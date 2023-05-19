import struct
from rsa import PublicKey


msg_type = {
    0: "LOGIN",
    1: "REGISTER",
    2: "SEND_MESSAGE",
    3: "ERROR"
}

class Message:
    def __init__(self, type: str = ""):
        if type != "":
            self.type = list(msg_type.keys())[list(msg_type.values()).index(type)]
            self.raw = bytes([self.type])
    
    def login(self, username:str, password: str):
        self.raw += struct.pack(">H", len(username) + len(password) + 1 + 3)
        self.raw += username.encode("utf-8")
        self.raw += b"\x00"
        self.raw += password.encode("utf-8")

    def set_ack_msg(self, ack:str):
        self.raw += struct.pack(">H", len(ack) + 3)
        self.raw += ack.encode("utf-8")
    
    def set_error_msg(self, error:str):
        self.raw += struct.pack(">H", len(error) + 3)
        self.raw += error.encode("utf-8")

    def set_public_key(self, pub_key:PublicKey):
        pub = pub_key.save_pkcs1()
        self.raw += struct.pack(">H", len(pub) + 3)
        self.raw += pub

    def set_message(self, sender_id, dest_id, msg):
        self.raw += struct.pack(">H", 3 + len(sender_id) + len(dest_id) + len(msg) + 2)
        self.raw += sender_id + b"\x00" + dest_id + b"\x00" + msg
    
    def from_bytes(self, raw_message):
        self.raw = raw_message
        self.type = msg_type[raw_message[0]]
        self.size = struct.unpack(">H", raw_message[1:3])[0]
        return self
    
    def get_msg_type(self) -> str:
        return self.type
    
    def get_user_and_pass(self) -> (bytes, bytes):
        user, password = self.raw[3:self.size].split(b"\x00")       
        return user.decode("utf-8"), password.decode("utf-8")
    
    def get_message(self) -> (bytes, bytes, bytes):
        sender_id, dest_id, msg = self.raw[3:].split(b"\x00")
        return sender_id, dest_id, msg
    
    def get_public_key(self) -> bytes:
        return PublicKey.load_pkcs1(self.raw[3:self.size])
    
    def get_raw(self):
        return self.raw

    def get_size(self) -> int:
        return self.size
