import socket
from hashlib import sha256
from pymongo.mongo_client import MongoClient
from pymongo.server_api import ServerApi
from pymongo.errors import DuplicateKeyError
from comm import *
from multiprocessing.pool import ThreadPool
import sys
import rsa
import logging
from time import time
import traceback


logging.basicConfig(format='%(asctime)s %(message)s', level=logging.INFO)
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
        size = self.con.recv(2)
        while len(size) == 0:
            size = self.con.recv(2)
        size = struct.unpack("<H", size)[0]
        enc = self.con.recv(size)
        return decrypt(enc, self.key)

    def get_con(self) -> socket.socket:
        return self.con

    def init(self):
        print("MADE IT")
        data = self.con.recv(1024)
        print(data)
        pub_key = rsa.PublicKey.load_pkcs1_openssl_pem(data)
        print(pub_key)
        self.key = get_random_bytes(16)
        logging.info(f"AES KEY: {self.key.hex()}")
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
        if(users.insert_one({"username":user, "password":hashed_password}).inserted_id):
            return user
    except DuplicateKeyError:
        return ""

def get_conv_id(user1: str, user2:str) -> str:
    conv_id = db.conversations.find_one({"participants": {"$all": [user1, user2]}}).get("_id")
    if conv_id == None:
        conv_id = db.conversations.insert_one({"participants":[user1, user2]}).get("_id")
    return conv_id

def add_message(sender_id: bytes, dest_id: bytes, msg:bytes) -> str:
    sender_id = sender_id.decode("utf-8")
    dest_id = dest_id.decode("utf-8")
    msg = msg.decode("utf-8")
    conv_id = get_conv_id(sender_id, dest_id)
    logging.info(f"CONVERSATION: {conv_id}")
    db.messages.insert_one({"conversation_id":conv_id, "sender_id":sender_id, "content":msg, "timestamp":str(int(time()))})

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
                if(login(user, password)):
                    client.login(user)
                    to_send = Message("LOGIN_ACK")
                    to_send.set_ack_msg("OK")
                else:
                    logging.warning(f"{user} didn't get the right password")
                    to_send = Message("ERROR")
                    to_send.set_error_msg("Wrong username/password");

            elif msg.get_msg_type() == "REGISTER":
                user, password = msg.get_user_and_pass()
                if(register(user, password) == user):
                    logging.info(f"{user} registered.")
                    to_send = Message("REGISTER_ACK")
                    to_send.set_ack_msg("OK")
                else:
                    logging.warning(f"{user} tried to register again.")
                    to_send = Message("ERROR")
                    to_send.set_error_msg("User already exists.");
            
            elif msg.get_msg_type() == "SEND_MESSAGE":
                sender_id, dest_id, mess = msg.get_message()
                #TODO adding messsage to DB
                add_message(sender_id, dest_id, mess)
                if(dest_id in users_list):
                    logging.info(f"Sending message from {sender_id} to {dest_id}")
                    users_list[dest_id].send(msg)
                else:
                    logging.info(f"Cannot send message to unlogged user {dest_id}")


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