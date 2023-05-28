import socket
from hashlib import sha256
from pymongo.mongo_client import MongoClient
from pymongo.server_api import ServerApi
from pymongo.errors import DuplicateKeyError
from pymongo import DESCENDING
from comm import *
from multiprocessing.pool import ThreadPool
import sys
import rsa
import logging
from time import time
import traceback
from bson.binary import Binary
from bson.json_util import dumps


logging.basicConfig(format='%(asctime)s %(message)s', level=logging.DEBUG)
MONGO_USERNAME = "admin"
MONGO_PASSWORD = "admin"
MONGO_URI = f"mongodb+srv://{MONGO_USERNAME}:{MONGO_PASSWORD}@cluster.usyyx.mongodb.net/?retryWrites=true&w=majority"

SERVER_IP = "0.0.0.0"
SERVER_PORT = 1234

client_list = []
users_list = {}

mongoClient = MongoClient(MONGO_URI, server_api=ServerApi('1'))
db = mongoClient.Chat

PRIVATE_KEY : rsa.PrivateKey = None
PUBLIC_KEY : rsa.PublicKey = None

class Client:
    def __init__(self, con: socket.socket):
        self.is_logged = False
        self.con : socket.socket = con
        logging.info("User connected")

    def login(self, username):
        global users_list
        logging.info(f"{username} logged in")
        self.is_logged = True
        self.username = username
        users_list[self.username] = self
    
    def send(self, msg:Message) -> None:
        data = encrypt_and_serialize(msg, self.key)
        self.con.sendall(data)
    
    def recv(self) -> Message:
        size = self.con.recv(3)
        if len(size) == 0:
            self.con.close()
            del users_list[self.username]
            raise Exception("Connection closed unexpected")
        else:
            size = int(size[0]) + int(size[1]<<8) + int(size[2]<<16)
            enc = self.con.recv(size)
            return decrypt(enc, self.key)

    def get_con(self) -> socket.socket:
        return self.con

    def init(self):
        data = self.con.recv(1024)
        pub_key = rsa.PublicKey.load_pkcs1_openssl_pem(data)
        self.key = get_random_bytes(16)
        self.con.sendall(rsa.encrypt(self.key, pub_key))


def login(user:str, password:str) -> bool:
    users = db.users
    hashed_password = sha256(password.encode("utf-8")).hexdigest()
    logging.info(f"{user}:{hashed_password}")
    if(users.find_one({"username":user, "password":hashed_password})):
        return True
    return False

def register(user:str, password:str) -> str:
    users = db.users
    hashed_password = sha256(password.encode("utf-8")).hexdigest()
    try:
        if(users.insert_one({"username":user, "password":hashed_password, "profile_picture":Binary(b'')}).inserted_id):
            return user
    except DuplicateKeyError:
        return ""

def get_conv_id(user1: str, user2:str) -> str:
    conv_id = db.conversations.find_one({"participants": {"$all": [user1, user2]}})
    if conv_id == None:
        return db.conversations.insert_one({"participants":[user1, user2]}).inserted_id
    return conv_id.get("_id")

def add_message(sender_id: str, dest_id: str, msg:bytes) -> str:
    msg = msg.decode("utf-8")
    conv_id = get_conv_id(sender_id, dest_id)
    logging.info(f"CONVERSATION: {conv_id}")
    db.messages.insert_one({"conversation_id":conv_id, "sender_id":sender_id, "content":msg, "timestamp":str(int(time()))})

def get_contact_profile(username: str) -> bytes:
    user = db.users.find_one({"username":username})
    if user == None:
        raise Exception("No username")

    return user.get("profile_picture")

def get_n_messages(user1: str, user2: str, n:int) -> []:
    messages = db.messages
    conv_id = get_conv_id(user1, user2)
    return dumps(messages.find({"conversation_id":conv_id}, {"_id":0, "conversation_id":0}, sort=[('_id', DESCENDING)]))

def upload_photo_to_profile(username: bytes, photo:bytes):
    db.users.update_one({"username":username.decode("utf-8")}, {"$set": {"profile_picture":Binary(photo)}})

def client_handler(conn):
    client = Client(conn)
    client.init()
    while True:
        try:
            msg = client.recv()
            to_send : Message = None

            if msg.get_msg_type() == "LOGIN":
                user, password = msg.get_user_and_pass()
                logging.info(f"{user} is trying to log in...")
                to_send = Message("LOGIN_ACK")
                if(login(user, password)):
                    client.login(user)
                    to_send.set_ack_msg("OK")
                else:
                    logging.warning(f"{user} didn't get the right password")
                    to_send.set_error_msg("Wrong username/password");

            elif msg.get_msg_type() == "REGISTER":
                user, password = msg.get_user_and_pass()
                to_send = Message("REGISTER_ACK")
                if(register(user, password) == user):
                    logging.info(f"{user} registered.")
                    to_send.set_ack_msg("OK")
                else:
                    logging.warning(f"{user} tried to register again.")
                    to_send.set_error_msg("User already exists.");
            
            elif msg.get_msg_type() == "SEND_MESSAGE":
                sender_id, dest_id, mess = msg.get_message()
                sender_id = sender_id.decode()
                dest_id = dest_id.decode()
                to_send = Message("SEND_ACK")
                logging.debug(f"users_list: {users_list}")
                if(dest_id in users_list):
                    
                    if(sender_id != client.username):
                        logging.warning(f"{client.username} tried to spoof the message sender_id to {sender_id}")
                        to_send.set_error_msg("You tried to spoof the message")
                    
                    else:
                        add_message(sender_id, dest_id, mess)
                        logging.info(f"Sending message from {sender_id} to {dest_id}")
                        users_list[dest_id].send(msg)
                        to_send.set_ack_msg(dest_id)
                
                else:
                    to_send.set_error_msg("Server error")
                    logging.info(f"Cannot send message to unlogged user {dest_id}")

            elif msg.get_msg_type() == "RETRIEVE_CONTACT":
                username = msg.get_username()
                to_send = Message("RETRIEVE_CONTACT_ACK")
                try:
                    pict = get_contact_profile(username.decode())
                    to_send.set_username_and_picture(username, pict)
                except Exception as e:
                    logging.error(e)
                    to_send.set_error_msg("No user with that username")

            elif msg.get_msg_type() == "UPLOAD_PROFILE_PHOTO":
                username, pict = msg.get_username_and_picture()
                logging.info(f"User {client.username} is uploading picture")
                upload_photo_to_profile(username, pict)
                to_send = Message("UPLOAD_PROFILE_ACK")
                to_send.set_ack_msg("OK")

            elif msg.get_msg_type() == "GET_MESSAGES":
                user1, user2 = msg.get_conv_parts()
                user1 = user1.decode()
                user2 = user2.decode()
                to_send = Message("GET_MESSAGES_ACK")
                messages = get_n_messages(user1, user2, 10)
                to_send.set_ack_msg(messages)

            client.send(to_send)
        except Exception as e:
            traceback.print_exc()
            logging.error(e)
            break

def main():
    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    server.bind((SERVER_IP, SERVER_PORT))
    server.listen(5)

    thread_pool = ThreadPool(processes=4)

    while True:
        try:
            conn, addr = server.accept()
            client_list.append(conn)
            print(f"{addr[0]} is connected")
            thread_pool.apply_async(client_handler, (conn,))

        except KeyboardInterrupt:
            server.shutdown(socket.SHUT_RDWR)
            server.close()
            thread_pool.join()
            thread_pool.close()
            return

if __name__ == "__main__":
    main()