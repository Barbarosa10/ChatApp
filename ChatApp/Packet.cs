using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    enum PacketType
    {
        LOGIN,
        LOGIN_ACK,
        REGISTER,
        REGISTER_ACK,
        SEND_MESSAGE,
        SEND_ACK,
        ERROR
    }
    interface IPacket
    {
        byte[] serialize();
        void deserialize(byte[] data);
    }

    class LoginPacket: IPacket
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginPacket(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public LoginPacket() { }

        public void deserialize(byte[] data)
        {
            int username_len = Array.IndexOf(data, 0);
            byte[] username = new byte[username_len-1];
            Array.Copy(data, 1, username,0, username_len);

            byte[] password = new byte[data.Length - username_len + 1];
            Array.Copy(data, 1+username_len, password, 0, data.Length - username_len + 1);

            Username = Encoding.UTF8.GetString(username);
            Password = Encoding.UTF8.GetString(password);
        }

        public byte[] serialize()
        {
            byte[] packet = new byte[Username.Length + Password.Length + 2];
            packet[0] = (byte)PacketType.LOGIN;
            Encoding.UTF8.GetBytes(Username).CopyTo(packet, 1);
            packet[Username.Length + 1] = 0;
            Encoding.UTF8.GetBytes(Password).CopyTo(packet, 1 + Username.Length + 1);
            return packet;
        }
    }

  

    class RegisterPacket : IPacket
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RegisterPacket(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public RegisterPacket() { }

        public void deserialize(byte[] data)
        {
            int username_len = Array.IndexOf(data, 0);
            byte[] username = new byte[username_len - 1];
            Array.Copy(data, 1, username, 0, username_len);

            byte[] password = new byte[data.Length - username_len + 1];
            Array.Copy(data, 1 + username_len, password, 0, data.Length - username_len + 1);

            Username = Encoding.UTF8.GetString(username);
            Password = Encoding.UTF8.GetString(password);
        }

        public byte[] serialize()
        {
            byte[] packet = new byte[Username.Length + Password.Length + 2];
            packet[0] = (byte)PacketType.REGISTER;
            Encoding.UTF8.GetBytes(Username).CopyTo(packet, 1);
            packet[Username.Length + 1] = 0;
            Encoding.UTF8.GetBytes(Password).CopyTo(packet, 1 + Username.Length + 1);
            return packet;
        }
    }
    static class Packet
    {
        enum PacketType
        {
            LOGIN,
            REGISTER,
            SEND_MESSAGE,
            ERROR
        }
        static byte _type;
        static byte[] _payload;
        
        static byte[] serialize()
        {
            byte[] packet = new byte[1 + _payload.Length];
            packet[0] = _type;
            _payload.CopyTo(packet, 1);
            return packet;

        }
        static public byte[] getLoginPacket(string user, string password)
        {
            _type = (byte)PacketType.LOGIN;
            _payload = new byte[1 + user.Length + password.Length];
            Encoding.UTF8.GetBytes(user).CopyTo(_payload, 0);
            _payload[user.Length] = 0;
            Encoding.UTF8.GetBytes(password).CopyTo(_payload, user.Length + 1);
            return serialize();
        }

        static public byte[] getRegisterPacket(string user, string password)
        {
            _type = (byte)PacketType.REGISTER;
            _payload = new byte[1 + user.Length + password.Length];
            Encoding.UTF8.GetBytes(user).CopyTo(_payload, 0);
            _payload[user.Length] = 0;
            Encoding.UTF8.GetBytes(password).CopyTo(_payload, user.Length + 1);
            return serialize();
        }

        static public byte[] getSendMessagePacket(string source, string dest, string mes)
        {
            _type = (byte)PacketType.SEND_MESSAGE;
            _payload = new byte[2 + source.Length + dest.Length + mes.Length];
            Encoding.UTF8.GetBytes(source).CopyTo(_payload, 0);
            _payload[source.Length] = 0;
            Encoding.UTF8.GetBytes(dest).CopyTo(_payload, source.Length + 1);
            _payload[source.Length + dest.Length + 1] = 0;
            Encoding.UTF8.GetBytes(mes).CopyTo(_payload, source.Length + dest.Length + 1 + 1);
            return serialize();
        }

        static public byte[] getErrorMessagePacket(string error)
        {
            _type = (byte)PacketType.ERROR;
            _payload = new byte[error.Length];
            Encoding.UTF8.GetBytes(error).CopyTo(_payload, 0);
            return serialize();
        }
    }
}
