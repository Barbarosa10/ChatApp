using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Communications
{
    public interface IComms
    {
        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="msg">The message to send.</param>
        void Send(byte[] msg);

        /// <summary>
        /// Receives a message.
        /// </summary>
        /// <param name="size">The size of the message to receive.</param>
        /// <returns>The received message.</returns>
        byte[] Recv(int size = 1024);
    }

    /// <summary>
    /// Represents a clear communication channel for sending and receiving messages without encryption.
    /// </summary>
    public class ClearComms : IComms
    {
        private Socket s;

        /// <summary>
        /// Initializes a new instance of the ClearComms class with the specified socket.
        /// </summary>
        /// <param name="socket">The socket for communication.</param>
        public ClearComms(Socket socket)
        {
            s = socket;
        }

        public byte[] Recv(int size = 1024)
        {
            byte[] data = new byte[size];
            s.Receive(data, size, SocketFlags.None);
            return data;
        }

        public void Send(byte[] msg)
        {
            s.Send(msg);
        }
    }

    /// <summary>
    /// Represents an encrypted communication channel for sending and receiving messages with encryption.
    /// </summary>
    public class EncComms : IComms
    {
        private Socket s;
        private byte[] key;
        int nonceLength = 12;
        int tagLength = 16;

        /// <summary>
        /// Initializes a new instance of the EncComms class with the specified socket.
        /// </summary>
        /// <param name="socket">The socket for communication.</param>
        public EncComms(Socket socket)
        {
            s = socket;
        }

        /// <summary>
        /// Sets the encryption key for the communication channel.
        /// </summary>
        /// <param name="key">The encryption key.</param>
        public void setKey(byte[] key)
        {
            this.key = (byte[])key.Clone();
        }

        public byte[] Recv(int size = 1024)
        {
            byte[] encryptedMessage = new byte[size];
            int recv_len = s.Receive(encryptedMessage, size, SocketFlags.None);
            while (recv_len < size)
            {
                recv_len += s.Receive(encryptedMessage, recv_len, size - recv_len, SocketFlags.None);
            }

            byte[] nonce = new byte[nonceLength];
            Array.Copy(encryptedMessage, 0, nonce, 0, nonceLength);

            byte[] ciphertext = new byte[encryptedMessage.Length - nonceLength - tagLength];
            Array.Copy(encryptedMessage, nonceLength, ciphertext, 0, ciphertext.Length);

            byte[] tag = new byte[tagLength];
            Array.Copy(encryptedMessage, nonceLength + ciphertext.Length, tag, 0, tagLength);

            // Create GCM cipher with AES engine
            var cipher = new GcmBlockCipher(new AesEngine());

            // Set the parameters for decryption
            var parameters = new AeadParameters(new KeyParameter(key), tagLength * 8, nonce);
            cipher.Init(false, parameters);

            // Combine ciphertext and tag
            ciphertext = ciphertext.Concat(tag).ToArray();

            // Decrypt the ciphertext and obtain the plaintext
            byte[] plaintext = new byte[cipher.GetOutputSize(ciphertext.Length)];
            int len = cipher.ProcessBytes(ciphertext, 0, ciphertext.Length, plaintext, 0);
            cipher.DoFinal(plaintext, len);

            return plaintext;
        }

        public void Send(byte[] msg)
        {
            // Generate a random initialization vector (IV)
            byte[] iv = new byte[12];
            SecureRandom random = new SecureRandom();
            random.NextBytes(iv);

            // Create GCM cipher with AES engine
            GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());

            // Set the parameters for encryption
            KeyParameter keyParam = new KeyParameter(key);
            AeadParameters parameters = new AeadParameters(keyParam, 128, iv);
            cipher.Init(true, parameters);

            // Encrypt the message
            byte[] ciphertext = new byte[cipher.GetOutputSize(msg.Length)];
            int len = cipher.ProcessBytes(msg, 0, msg.Length, ciphertext, 0);
            cipher.DoFinal(ciphertext, len);

            // Prepare the encrypted data for sending
            byte[] encData = new byte[iv.Length + ciphertext.Length + 3];
            encData[0] = (byte)encData.Length;
            encData[1] = (byte)(encData.Length >> 8);
            encData[2] = (byte)(encData.Length >> 16);

            Buffer.BlockCopy(iv, 0, encData, 3, iv.Length);
            Buffer.BlockCopy(ciphertext, 0, encData, iv.Length + 3, ciphertext.Length);

            // Send the encrypted data
            s.Send(encData);
        }
    }
}
