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
        private  void StartClient()
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
            //_encProxy.Send(message.serialize());
            //byte[] msg = Encoding.ASCII.GetBytes(message);
            //int bytesSent = sender.Send(msg);
        }
        public String ReceiveMessage()
        {
            byte[] bytes = new byte[1024];

            int bytesRec = sender.Receive(bytes);

            return Encoding.ASCII.GetString(bytes, 0, bytesRec);
        }
    }
}
