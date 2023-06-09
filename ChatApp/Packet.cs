﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
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
        GET_CONVERSATION,
        GET_CONVERSATION_ACK,
        ERROR
    }

    // Folosim sablonul de proiectare Command
    interface IPacket
    {
        byte[] Serialize();
        void Deserialize(byte[] data);
        void Execute(Chat chat);
    }

    class LoginPacket : IPacket
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginPacket(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public LoginPacket() { }

        public void Deserialize(byte[] data)
        {
            int username_len = Array.IndexOf(data, (byte)0);
            byte[] username = new byte[username_len - 1];
            Array.Copy(data, 1, username, 0, username_len);

            byte[] password = new byte[data.Length - username_len + 1];
            Array.Copy(data, 1 + username_len, password, 0, data.Length - username_len + 1);

            Username = Encoding.UTF8.GetString(username);
            Password = Encoding.UTF8.GetString(password);
        }

        public byte[] Serialize()
        {
            byte[] packet = new byte[Username.Length + Password.Length + 2];
            packet[0] = (byte)PacketType.LOGIN;
            Encoding.UTF8.GetBytes(Username).CopyTo(packet, 1);
            packet[Username.Length + 1] = 0;
            Encoding.UTF8.GetBytes(Password).CopyTo(packet, 1 + Username.Length + 1);
            return packet;
        }

        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] Serialize()
        {
            byte[] data = new byte[Message.Length + 1];
            data[0] = (byte)PacketType.LOGIN_ACK;
            Encoding.UTF8.GetBytes(Message).CopyTo(data, 1);
            return data;
        }
        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {

            int username_len = Array.IndexOf(data, (byte)0);
            byte[] username = new byte[username_len - 1];
            Array.Copy(data, 1, username, 0, username_len);

            byte[] password = new byte[data.Length - username_len + 1];
            Array.Copy(data, 1 + username_len, password, 0, data.Length - username_len + 1);

            Username = Encoding.UTF8.GetString(username);
            Password = Encoding.UTF8.GetString(password);
        }

        public byte[] Serialize()
        {
            byte[] packet = new byte[Username.Length + Password.Length + 2];
            packet[0] = (byte)PacketType.REGISTER;
            Encoding.UTF8.GetBytes(Username).CopyTo(packet, 1);
            packet[Username.Length + 1] = 0;
            Encoding.UTF8.GetBytes(Password).CopyTo(packet, 1 + Username.Length + 1);
            return packet;
        }

        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] Serialize()
        {
            byte[] data = new byte[Message.Length + 1];
            data[0] = (byte)PacketType.REGISTER_ACK;
            Encoding.UTF8.GetBytes(Message).CopyTo(data, 1);
            return data;
        }
        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {
            int username_len = Array.IndexOf(data, (byte)0);
            if (username_len == -1)
            {
                Username = null;
                Picture = null;
            }
            else
            {
                data = data.Skip(1).ToArray();
                Username = Encoding.UTF8.GetString(data.Take(username_len - 1).ToArray());
                Picture = new byte[data.Length - username_len];
                Array.Copy(data, username_len, Picture, 0, data.Length - username_len);
            }
        }

        public byte[] Serialize()
        {
            throw new Exception("Nu ai nevoie de asta");
        }
        public void Execute(Chat chat)
        {
            MemoryStream ms = new MemoryStream(Picture);
            Image bitmap = Image.FromStream(ms);
            Bitmap image = (Bitmap)bitmap;
            chat.LocalDatabase.UploadAvatarPhoto(image, Username);
            ChatForm.localDatabaseReloaded = 1;
            //chat.AddContact(Username);


            Console.WriteLine("Primit pachet cu poza");
            //throw new NotImplementedException();
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

        public void Deserialize(byte[] data)
        {
            Username = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] Serialize()
        {
            Console.WriteLine("CONTACT: " + Username);
            byte[] data = new byte[Username.Length + 1];
            data[0] = (byte)PacketType.RETRIEVE_CONTACT;
            Encoding.UTF8.GetBytes(Username).CopyTo(data, 1);
            return data;
        }
        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {
            data = data.Skip(1).ToArray();
            int username_len = Array.IndexOf(data, (byte)0);
            Username = Encoding.UTF8.GetString(data.Take(username_len).ToArray());
            Picture = new byte[data.Length - username_len - 1];
            Array.Copy(data, username_len + 1, Picture, 0, data.Length - username_len - 1);
        }

        public byte[] Serialize()
        {
            byte[] data = new byte[Username.Length + 2 + Picture.Length];
            data[0] = (byte)PacketType.UPLOAD_PHOTO;
            Encoding.UTF8.GetBytes(Username).CopyTo(data, 1);
            Array.Copy(Picture, 0, data, 1 + 1 + Username.Length, Picture.Length);
            return data;
        }
        public void Execute(Chat chat)
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

        public void Deserialize(byte[] data)
        {
            Message = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public byte[] Serialize()
        {
            throw new Exception("Nu ai nevoie");
        }
        public void Execute(Chat chat)
        {
            return;
            //throw new NotImplementedException();
        }
    }

    class SendMessagePacket : IPacket
    {
        public string SenderID { get; set; }
        public string DestID_or_Timestamp { get; set; }
        public string Message { get; set; }
        public void Deserialize(byte[] data)
        {
            data = data.Skip(1).ToArray();
            int sender_len = Array.IndexOf(data, (byte)0);
            SenderID = Encoding.UTF8.GetString(data.Take(sender_len).ToArray());
            int dest_len = Array.IndexOf(data, (byte)0, sender_len + 1) - sender_len;
            DestID_or_Timestamp = Encoding.UTF8.GetString(data.Skip(sender_len + 1).Take(dest_len - 1).ToArray());
            Message = Encoding.UTF8.GetString(data.Skip(sender_len + dest_len + 1).ToArray());
        }

        public void Execute(Chat chat)
        {
            Console.WriteLine("Mesaj primit: " + Message);

            Conversation conversation = chat.GetConversation(SenderID);

            if (conversation != null)
                conversation.addMessage(DestID_or_Timestamp, SenderID, Message);
            else
            {
                Contact sender = chat.Contact(SenderID);
                if (sender == null)
                {
                    ClientSocket.Instance.SendMessage(new RetrieveContactPacket(SenderID));

                }
                Thread.Sleep(5000);
                chat.AddContact(SenderID);
                chat.AddConversation(SenderID);
            }

            //throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            byte[] data = new byte[1 + 2 + SenderID.Length + DestID_or_Timestamp.Length + Message.Length];
            data[0] = (byte)PacketType.SEND_MESSAGE;
            Encoding.UTF8.GetBytes(SenderID).CopyTo(data, 1);
            data[SenderID.Length + 1] = 0;
            Array.Copy(Encoding.UTF8.GetBytes(DestID_or_Timestamp), 0, data, SenderID.Length + 2, SenderID.Length);
            data[SenderID.Length + DestID_or_Timestamp.Length + 2] = 0;
            Array.Copy(Encoding.UTF8.GetBytes(Message), 0, data, SenderID.Length + DestID_or_Timestamp.Length + 3, Message.Length);
            return data;
        }
    }

    class SendMessageAckPacket : IPacket
    {
        /// <summary>
        /// DestID if returned correctly, Error if not
        /// </summary>
        public string DestID_Or_Error { get; set; }
        public void Deserialize(byte[] data)
        {
            DestID_Or_Error = Encoding.UTF8.GetString(data.Skip(1).ToArray());
        }

        public void Execute(Chat chat)
        {

        }

        public byte[] Serialize()
        {
            throw new Exception("Nu ai nevoie");
        }
    }

    class GetNMessagesPacket : IPacket
    {
        public string User1 { get; set; }
        public string User2 { get; set; }
        public void Deserialize(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void Execute(Chat chat)
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            byte[] data = new byte[User1.Length + User2.Length + 2];
            data[0] = (byte)PacketType.GET_CONVERSATION;
            Array.Copy(Encoding.UTF8.GetBytes(User1), 0, data, 1, User1.Length);
            data[User1.Length + 1] = 0;
            Array.Copy(Encoding.UTF8.GetBytes(User2), 0, data, 2 + User1.Length, User2.Length);
            return data;
        }
    }

    class GetNMessagesAckPacket : IPacket
    {
        public List<ServerMessage> Messages { get; set; }
        public class ServerMessage
        {
            public string sender_id { get; set; }
            public string content { get; set; }
            public string timestamp { get; set; }
        }
        public void Deserialize(byte[] data)
        {
            data = data.Skip(1).ToArray();
            Messages = JsonConvert.DeserializeObject<List<ServerMessage>>(Encoding.UTF8.GetString(data));
        }

        public void Execute(Chat chat)
        {
            Conversation conversation = chat.GetConversation(ChatForm.conversationUsername);
            Console.WriteLine("NR MESSAGES: " + Messages.Count);
            foreach (ServerMessage message in Messages)
            {
                Console.WriteLine("SENDER: " + message.sender_id);

                if (conversation != null)
                    conversation.addMessage(message.timestamp, message.sender_id, message.content);
            }
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }

}
   
