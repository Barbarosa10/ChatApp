using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class Conversation
    {
        public struct SimpleMessage
        {
            public String username;
            public String message;
        }
        private Contact _contact;
        private Dictionary<String, SimpleMessage> _fullMessage = new Dictionary<String, SimpleMessage>();

        public Contact Contact { get; set; }
        public Dictionary<String, SimpleMessage> Message { get; set; }
        public Conversation()
        {
        }

        public void addMessage(String timestamp, String username, String message)
        {
            _fullMessage.Add(timestamp, new SimpleMessage() {username = username, message = message });
        }
    }
}
