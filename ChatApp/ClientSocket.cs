using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Communications;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace ChatApp
{
    /// <summary>
    /// Represents a client socket for a chat application.
    /// </summary>
    class ClientSocket
    {
        private string IPAddress = "127.0.0.1"; // IP address to connect to 146.190.44.233
        private static ClientSocket instance = null;
        private Socket sender;
        private ClearComms _clearProxy;
        private EncComms _encProxy;

        /// <summary>
        /// Private constructor to enforce singleton pattern and initialize the client socket.
        /// </summary>
        private ClientSocket()
        {
            StartClient();
        }

        /// <summary>
        /// Singleton instance property for the client socket.
        /// </summary>
        public static ClientSocket Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientSocket();
                }
                return instance;
            }
        }

        /// <summary>
        /// Closes the socket and resets the singleton instance.
        /// </summary>
        public void CloseSocket()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            instance = null;
        }

        /// <summary>
        /// Starts the client socket connection and initializes communication proxies.
        /// </summary>
        private void StartClient()
        {
            // Parse the IP address
            IPAddress remoteIPAddress = System.Net.IPAddress.Parse(IPAddress);

            // Create an endpoint with the IP address and port number
            IPEndPoint remoteEP = new IPEndPoint(remoteIPAddress, 1234);

            // Create a socket for TCP communication
            sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // Connect to the remote endpoint
                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                // Create communication proxies
                _clearProxy = new ClearComms(sender);
                _encProxy = new EncComms(sender);

                // Generate RSA key pair
                RsaEncryption rsa = new RsaEncryption();

                // Send the RSA public key to the server
                _clearProxy.Send(Encoding.UTF8.GetBytes(rsa.ExportPublicKey()));

                // Receive and decrypt the AES key from the server
                byte[] aesKey = rsa.RSADecrypt(_clearProxy.Recv(128), false);
                _encProxy.setKey(aesKey);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Exception: {0}", e.ToString());
            }
        }

        /// <summary>
        /// Sends a message by serializing and encrypting it.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(IPacket message)
        {
            _encProxy.Send(message.Serialize());
        }

        /// <summary>
        /// Receives a message by decrypting and deserializing it.
        /// </summary>
        /// <returns>The received message.</returns>
        public IPacket ReceiveMessage()
        {
            // Receive the message size
            byte[] size_arr = _clearProxy.Recv(3);
            int size = (int)size_arr[0] + ((int)(size_arr[1]) << 8) + ((int)(size_arr[2]) << 16);

            // Receive the encrypted message data
            byte[] data = _encProxy.Recv(size);

            IPacket packet;

            // Determine the packet type and create the appropriate packet object
            switch ((PacketType)data[0])
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
                    throw new Exception("Unknown packet type received.");
            }
            packet.Deserialize(data);
            return packet;
        }
    }
}
