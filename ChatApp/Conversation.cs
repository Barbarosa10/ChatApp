using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    /// <summary>
    /// Represents a conversation in the chat application.
    /// </summary>
    public class Conversation
    {
        /// <summary>
        /// Represents a simple message structure with a username and message content.
        /// </summary>
        public struct SimpleMessage
        {
            public String username;
            public String message;
        }

        private int state = 0;
        private int size = 0;
        private Contact _contact;
        private Dictionary<String, SimpleMessage> _fullMessage = new Dictionary<String, SimpleMessage>();

        /// <summary>
        /// Gets or sets the contact associated with the conversation.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets the full message dictionary of the conversation.
        /// </summary>
        /// <returns>The dictionary of timestamped messages in the conversation.</returns>
        public Dictionary<String, SimpleMessage> getMessage()
        {
            return _fullMessage;
        }

        /// <summary>
        /// Gets or sets the state of the conversation.
        /// </summary>
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Gets or sets the size of the conversation.
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets or sets the message dictionary of the conversation.
        /// </summary>
        public Dictionary<String, SimpleMessage> Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the Conversation class.
        /// </summary>
        public Conversation()
        {
        }

        /// <summary>
        /// Adds a new message to the conversation with the specified timestamp, username, and message content.
        /// </summary>
        /// <param name="timestamp">The timestamp of the message.</param>
        /// <param name="username">The username associated with the message.</param>
        /// <param name="message">The content of the message.</param>
        public void addMessage(String timestamp, String username, String message)
        {
            if (!_fullMessage.ContainsKey(timestamp))
                _fullMessage.Add(timestamp, new SimpleMessage() { username = username, message = message });
        }
    }
}
