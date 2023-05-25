using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;


namespace ChatApp
{
    interface IComms
    {
        void Send(byte[] msg);
        byte[] Recv(int size = 1024);
    }

    class ClearComms : IComms
    {
        private Socket s;
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

    class EncComms : IComms
    {
        private Socket s;
        private byte[] key;
        int nonceLength = 12;
        int tagLength = 16;
        byte[] adata = new byte[0];
        public EncComms(Socket socket)
        {
            s = socket;
        }
        public void setKey(byte[] key)
        {
            this.key = (byte[])key.Clone();
        }
        public byte[] Recv(int size = 1024)
        {
            byte[] encryptedMessage = new byte[size];
            s.Receive(encryptedMessage);

            byte[] nonce = new byte[nonceLength];
            Array.Copy(encryptedMessage, 0, nonce, 0, nonceLength);

            byte[] ciphertext = new byte[encryptedMessage.Length - nonceLength - tagLength];
            Array.Copy(encryptedMessage, nonceLength, ciphertext, 0, ciphertext.Length);

            byte[] tag = new byte[tagLength];
            Array.Copy(encryptedMessage, nonceLength + ciphertext.Length, tag, 0, tagLength);
            

            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(new KeyParameter(key), tagLength * 8, nonce);
            cipher.Init(false, parameters);

            ciphertext = ciphertext.Concat(tag).ToArray();

            byte[] plaintext = new byte[cipher.GetOutputSize(ciphertext.Length)];
            int len = cipher.ProcessBytes(ciphertext, 0, ciphertext.Length, plaintext, 0);
            //cipher.ProcessAadBytes(tag, 0, tag.Length); // Process the authentication tag
            cipher.DoFinal(plaintext, len);

            return plaintext;
        }

        public void Send(byte[] msg)
        {
            byte[] iv = new byte[12];
            SecureRandom random = new SecureRandom();
            random.NextBytes(iv);

            GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
            KeyParameter keyParam = new KeyParameter(key);
            AeadParameters parameters = new AeadParameters(keyParam, 128, iv);
            cipher.Init(true, parameters);

            byte[] ciphertext = new byte[cipher.GetOutputSize(msg.Length)];
            int len = cipher.ProcessBytes(msg, 0, msg.Length, ciphertext, 0);
            cipher.DoFinal(ciphertext, len);

            byte[] encData = new byte[iv.Length + ciphertext.Length + 3];
            encData[0] = (byte)encData.Length;
            encData[1] = (byte)(encData.Length >> 8);
            encData[2] = (byte)(encData.Length >> 16);

            Buffer.BlockCopy(iv, 0, encData, 3, iv.Length);
            Buffer.BlockCopy(ciphertext, 0, encData, iv.Length + 3, ciphertext.Length);

            
            s.Send(encData);
        }
    }

}
