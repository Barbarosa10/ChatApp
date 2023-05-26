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
        RETRIEVE_CONTACT,
        RETRIEVE_ACK,
        UPLOAD_PHOTO,
        UPLOAD_PHOTO_ACK,
        ERROR
    }

    // Folosim sablonul de proiectare Command
    interface IPacket
    {
        byte[] serialize();
        void deserialize(byte[] data);
        void execute(Chat chatForm);
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

        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class LoginAckPacket : IPacket
    {
        public string Message { get; set; }
        public LoginAckPacket(string message)
        {
            Message = message;
        }

        public LoginAckPacket() { }

        public void deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] serialize()
        {
            byte[] data = new byte[Message.Length + 1];
            data[0] = (byte)PacketType.LOGIN_ACK;
            Encoding.UTF8.GetBytes(Message).CopyTo(data, 1);
            return data;
        }
        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
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

        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class RegisterAckPacket : IPacket
    {
        public string Message { get; set; }
        public RegisterAckPacket(string message)
        {
            Message = message;
        }

        public RegisterAckPacket() { }

        public void deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] serialize()
        {
            byte[] data = new byte[Message.Length + 1];
            data[0] = (byte)PacketType.REGISTER_ACK;
            Encoding.UTF8.GetBytes(Message).CopyTo(data, 1);
            return data;
        }
        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class RetrieveContactAckPacket : IPacket
    {
        
        /// <summary>
        /// The username for the picture if it exists, null if it doesn't
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The picture if it exsists, null if it doesn't
        /// </summary>
        public byte[] Picture { get; set; }
        public RetrieveContactAckPacket(string username, byte[] pict)
        {
            Picture = (byte[])pict.Clone();
            Username = username;
        }

        public RetrieveContactAckPacket() { }

        public void deserialize(byte[] data)
        {
            int username_len = Array.IndexOf(data, 0);
            if (username_len == -1)
            {
                Username = null;
                Picture = null;
            }
            else
            {
                data = data.Skip(1).ToArray();
                Username = Encoding.UTF8.GetString(data.Take(username_len).ToArray());
                Picture = new byte[data.Length - username_len - 1];
                Array.Copy(data, username_len + 1, Picture, 0, data.Length - username_len - 1);
            }
        }

        public byte[] serialize()
        {
            throw new Exception("Nu ai nevoie de asta");
        }
        public void execute(Chat chatForm)
        {
            Console.WriteLine("Primit pachet cu poza");
            throw new NotImplementedException();
        }
    }

    class RetrieveContactPacket : IPacket
    {
        public string Username { get; set; }
        public RetrieveContactPacket(string username)
        {
            Username = username;
        }

        public RetrieveContactPacket() { }

        public void deserialize(byte[] data)
        {
            Username = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] serialize()
        {
            byte[] data = new byte[Username.Length + 1];
            data[0] = (byte)PacketType.RETRIEVE_CONTACT;
            Encoding.UTF8.GetBytes(Username).CopyTo(data, 1);
            return data;
        }
        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class UploadPhotoPacket : IPacket
    {
        public string Username { get; set; }
        public byte[] Picture { get; set; }
        public UploadPhotoPacket(string username, byte[] pict)
        {
            Picture = (byte[])pict.Clone();
            Username = username;
        }

        public UploadPhotoPacket() { }

        public void deserialize(byte[] data)
        {
            data = data.Skip(1).ToArray();
            int username_len = Array.IndexOf(data, (byte)0);
            Username = Encoding.UTF8.GetString(data.Take(username_len).ToArray());
            Picture = new byte[data.Length - username_len - 1];
            Array.Copy(data, username_len + 1, Picture, 0, data.Length - username_len - 1);
        }

        public byte[] serialize()
        {
            byte[] data = new byte[Username.Length + 2 + Picture.Length];
            data[0] = (byte)PacketType.UPLOAD_PHOTO;
            Encoding.UTF8.GetBytes(Username).CopyTo(data, 1);
            Array.Copy(Picture, 0, data, 1 + 1 + Username.Length, Picture.Length);
            return data;
        }
        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class UploadPhotoAckPacket : IPacket
    {
        public string Message { get; set; }
        public UploadPhotoAckPacket(string message)
        {
            Message = message;
        }

        public UploadPhotoAckPacket() { }

        public void deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] serialize()
        {
            throw new Exception("Nu ai nevoie");
        }
        public void execute(Chat chatForm)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class SendMessagePacket : IPacket
    {
        public string SenderID { get; set; }
        public string DestID { get; set; }
        public string Message { get; set; }
        public void deserialize(byte[] data)
        {
            data = data.Skip(1).ToArray();
            int sender_len = Array.IndexOf(data, (byte)0);
            SenderID = Encoding.UTF8.GetString(data.Take(sender_len).ToArray());
            int dest_len = Array.IndexOf(data, (byte)0, sender_len);
            Message = Encoding.UTF8.GetString(data.Skip(sender_len + dest_len + 2).ToArray());
        }

        public void execute(Chat chatForm)
        {
            Console.WriteLine("Mesaj primit: " + Message);
            //throw new NotImplementedException();
        }

        public byte[] serialize()
        {
            byte[] data = new byte[1 + 2 + SenderID.Length + DestID.Length + Message.Length];
            data[0] = (byte)PacketType.SEND_MESSAGE;
            Encoding.UTF8.GetBytes(SenderID).CopyTo(data, 1);
            data[SenderID.Length + 1] = 0;
            Array.Copy(Encoding.UTF8.GetBytes(SenderID), 0, data, SenderID.Length + 2, SenderID.Length);
            data[SenderID.Length + DestID.Length + 2] = 0;
            Array.Copy(Encoding.UTF8.GetBytes(Message), 0, data, SenderID.Length + DestID.Length + 3, Message.Length);
            return data;
        }
    }

    class SendMessageAckPacket : IPacket
    {

        /// <summary>
        /// Daca a fost primit corect, returneaza ID-ul destinatiei. Daca nu, un mesaj de eroare
        /// </summary>
        public string DestID_Or_Error { get; set; }
        public void deserialize(byte[] data)
        {
            DestID_Or_Error = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public void execute(Chat chatForm)
        {
            throw new NotImplementedException();
        }

        public byte[] serialize()
        {
            throw new Exception("Nu ai nevoie");
        }
    }


    static class Packet
    {
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
