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
        byte[] Recv(int size=1024);
    }

    class ClearComms : IComms
    {
        private Socket s;
        public ClearComms(Socket socket)
        {
            s = socket;
        }
        public byte[] Recv(int size=1024)
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
            byte[] ciphertext = new byte[1024];
            byte[] iv = new byte[12];
            s.Receive(ciphertext);
            Array.Copy(ciphertext, 0, iv, 0, 12);
            GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
            AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv);
            cipher.Init(false, parameters);

            byte[] decryptedData = new byte[cipher.GetOutputSize(ciphertext.Length - iv.Length)];
            int len = cipher.ProcessBytes(ciphertext, iv.Length, ciphertext.Length - iv.Length, decryptedData, 0);
            cipher.DoFinal(decryptedData, len);
            return decryptedData;
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

            byte[] encData = new byte[iv.Length + ciphertext.Length + 2];
            encData[0] = (byte)encData.Length;
            encData[1] = (byte)(encData.Length >> 8);

            Buffer.BlockCopy(iv, 0, encData, 2, iv.Length);
            Buffer.BlockCopy(ciphertext, 0, encData, iv.Length + 2, ciphertext.Length);

            
            s.Send(encData);
        }
    }

}
