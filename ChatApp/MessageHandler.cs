using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    /// <summary>
    /// Handles incoming messages and executes the corresponding actions in the chat.
    /// </summary>
    class MessageHandler
    {
        private bool isRunning;
        private Chat chat;

        /// <summary>
        /// Starts the message handling process.
        /// </summary>
        /// <param name="chat">The chat instance to handle messages for.</param>
        public void Start(Chat chat)
        {
            this.chat = chat;
            isRunning = true;
            Task.Run(Handler);
        }

        /// <summary>
        /// Stops the message handling process.
        /// </summary>
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
                    try
                    {
                        IPacket packet = ClientSocket.Instance.ReceiveMessage();

                        packet.Execute(chat);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("EROARE: " + e.Message);
                    }
                });
            }
        }
    }
}
