using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
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
        static UInt16 _size;
        static byte[] _payload;
        
        static byte[] serialize()
        {
            byte[] packet = new byte[3 + _payload.Length];
            packet[0] = _type;
            packet[1] = (byte)_size;
            packet[2] = (byte)(_size >> 8);
            _payload.CopyTo(packet, 3);
            return packet;

        }
        static public byte[] getLoginPacket(string user, string password)
        {
            _type = (byte)PacketType.LOGIN;
            _size = (ushort)(3 + _payload.Length);
            _payload = new byte[1 + user.Length + password.Length];
            Encoding.UTF8.GetBytes(user).CopyTo(_payload, 0);
            _payload[user.Length] = 0;
            Encoding.UTF8.GetBytes(password).CopyTo(_payload, user.Length + 1);
            return serialize();
        }

        static public byte[] getRegisterPacket(string user, string password)
        {
            _type = (byte)PacketType.REGISTER;
            _size = (ushort)(3 + _payload.Length);
            _payload = new byte[1 + user.Length + password.Length];
            Encoding.UTF8.GetBytes(user).CopyTo(_payload, 0);
            _payload[user.Length] = 0;
            Encoding.UTF8.GetBytes(password).CopyTo(_payload, user.Length + 1);
            return serialize();
        }

    }
}
