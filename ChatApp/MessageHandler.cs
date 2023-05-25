using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class MessageHandler
    {
        private bool isRunning;
        private Chat chat;
        public void Start(Chat chat)
        {
            this.chat = chat;
            isRunning = true;
            Task.Run(Handler);
        }
        public void Stop()
        {
            // Stop the message handling task
            isRunning = false;
        }

        private async Task Handler()
        {
            while (isRunning)
            {
                // Receive and process incoming messages
                await Task.Run(() =>
                {
                    IPacket packet = ClientSocket.Instance.ReceiveMessage();
                    try
                    {
                        packet.execute(chat);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("EROARE: " + e.Message);
                    }
                });;
            }
        }
    }

}
