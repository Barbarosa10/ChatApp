import struct
from rsa import PublicKey
from Crypto.Cipher import AES
from Crypto.Random import get_random_bytes

msg_type = {
    0: "LOGIN",
    1: "LOGIN_ACK",
    2: "REGISTER",
    3: "REGISTER_ACK",
    4: "SEND_MESSAGE",
    5: "SEND_ACK",
    6: "RETRIEVE_CONTACT",
    7: "RETRIEVE_CONTACT_ACK",
    8: "UPLOAD_PROFILE_PHOTO",
    9: "UPLOAD_PROFILE_ACK",
    10: "GET_MESSAGES",
    11: "GET_MESSAGES_ACK",
    12: "ERROR"
}

class Message:
    def __init__(self, type: str = ""):
        if type != "":
            self.type = list(msg_type.keys())[list(msg_type.values()).index(type)]
            self.raw = bytes([self.type])
    
    def login(self, username:str, password: str):
        self.raw += username.encode("utf-8")
        self.raw += b"\x00"
        self.raw += password.encode("utf-8")

    def set_ack_msg(self, ack:str):
        self.raw += ack.encode("utf-8")
    
    def set_error_msg(self, error:str):
        self.raw += error.encode("utf-8")

    def set_public_key(self, pub_key:PublicKey):
        pub = pub_key.save_pkcs1()
        self.raw += pub

    def set_message(self, sender_id, dest_id, msg):
        self.raw += sender_id + b"\x00" + dest_id + b"\x00" + msg

    def set_username_and_picture(self, username: bytes, pict:bytes):
        self.raw += username + b"\x00" + pict

    def get_username_and_picture(self):
        splitter = self.raw[1:].find(b"\x00")
        username = self.raw[1:][:splitter]
        picture =  self.raw[1:][splitter+1:]
        return username, picture
    
    def from_bytes(self, raw_message):
        self.raw = raw_message
        self.type = msg_type[raw_message[0]]
        return self
    
    def get_msg_type(self) -> str:
        return self.type
    
    def get_user_and_pass(self) -> (bytes, bytes):
        user, password = self.raw[1:].split(b"\x00")       
        return user.decode("utf-8"), password.decode("utf-8")
    
    def get_username(self) -> str:
        return self.raw[1:]

    def get_message(self) -> (bytes, bytes, bytes):
        print(self.raw.hex())
        sender_id, dest_id, msg = self.raw[1:].split(b"\x00")
        return sender_id, dest_id, msg
    
    def get_public_key(self) -> bytes:
        return PublicKey.load_pkcs1(self.raw[1:])

    def get_conv_parts(self) -> (bytes, bytes):
        return self.raw[1:].split(b"\x00")
    
    def get_raw(self):
        return self.raw

def encrypt_and_serialize(msg:Message, key:bytes) -> bytes:
    nonce = get_random_bytes(12)
    cipher = AES.new(key, AES.MODE_GCM, nonce=nonce)

    ciphertext, tag = cipher.encrypt_and_digest(msg.get_raw())
    enc_data = cipher.nonce+ciphertext+tag
    tmp = len(enc_data)
    size = bytes([tmp&0xff]) + bytes([(tmp>>8)&0xff]) + bytes([(tmp>>16)&0xff])
    packet = size + enc_data 
    print(f"TAG: {tag.hex()}\nIV: {cipher.nonce.hex()}\nCipher: {ciphertext.hex()}")
    return packet

def decrypt(msg:bytes, key:bytes) -> Message:
    nonce = msg[:12]
    cipher = AES.new(key, AES.MODE_GCM, nonce=nonce)
    dec = cipher.decrypt_and_verify(msg[12:-16], msg[-16:])
    return Message().from_bytes(dec)
    