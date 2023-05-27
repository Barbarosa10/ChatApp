using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ChatApp
{
    class ClientSocket
    {
        private string IPAddress = "127.0.0.1"; //146.190.44.233
        private static ClientSocket instance = null;
        private Socket sender;
        private ClearComms _clearProxy;
        private EncComms _encProxy;
        private ClientSocket()
        {
            StartClient();
        }
        public static ClientSocket Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ClientSocket();
                }
                return instance;
            }
        }
        private void StartClient()
        {

            IPAddress remoteIPAddress = System.Net.IPAddress.Parse(IPAddress);
            IPEndPoint remoteEP = new IPEndPoint(remoteIPAddress, 1234);

            sender = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}",
                    sender.RemoteEndPoint.ToString());
                _clearProxy = new ClearComms(sender);
                _encProxy = new EncComms(sender);
                RsaEncryption rsa = new RsaEncryption();
                _clearProxy.Send(Encoding.UTF8.GetBytes(rsa.ExportPublicKey()));
                byte[] aesKey = rsa.RSADecrypt(_clearProxy.Recv(128), false);
                _encProxy.setKey(aesKey);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException : {0}", e.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException : {0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Exception : {0}", e.ToString());
            }
        }

        public void SendMessage(IPacket message)
        {
            _encProxy.Send(message.serialize());
        }

        public IPacket ReceiveMessage()
        {
            byte[] size_arr = _clearProxy.Recv(3);
            int size = (int)size_arr[0] + ((int)(size_arr[1]) << 8) + ((int)(size_arr[2]) << 16);
            byte[] data = _encProxy.Recv(size);
            IPacket packet;
            switch((PacketType)data[0])
            {
                case PacketType.LOGIN_ACK:
                    packet = new LoginAckPacket();
                    break;
                case PacketType.REGISTER_ACK:
                    packet = new RegisterAckPacket();
                    break;
                case PacketType.RETRIEVE_ACK:
                    packet = new RetrieveContactAckPacket();
                    break;
                case PacketType.UPLOAD_PHOTO_ACK:
                    packet = new UploadPhotoAckPacket();
                    break;
                case PacketType.SEND_MESSAGE:
                    packet = new SendMessagePacket();
                    break;
                case PacketType.SEND_ACK:
                    packet = new SendMessageAckPacket();
                    break;
                case PacketType.GET_CONVERSATION_ACK:
                    packet = new GetNMessagesAckPacket();
                    break;

                default:
                    throw new Exception("Auleu ca nu stiu ce pachet ea asta");
            }
            packet.deserialize(data);
            return packet;
        }
    }
}
