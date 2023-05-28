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
        private int state = 0;
        private int size = 0;
        private Contact _contact;
        private Dictionary<String, SimpleMessage> _fullMessage = new Dictionary<String, SimpleMessage>();

        public Contact Contact { get; set; }

        public Dictionary<String, SimpleMessage> getMessage()
        {
            return _fullMessage;
        }
        public int State {
            get { return state; }
            set { state = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Dictionary<String, SimpleMessage> Message { get; set; }
        public Conversation()
        {
        }

        public void addMessage(String timestamp, String username, String message)
        {
            if(!_fullMessage.ContainsKey(timestamp))
                _fullMessage.Add(timestamp, new SimpleMessage() {username = username, message = message });
        }
    }
}
