using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ChatApp
{
    /// <summary>
    /// Represents a chat instance of the chat application.
    /// </summary>
    class Chat
    {
        private List<Conversation> _conversations = new List<Conversation>();
        private List<Contact> _contacts = new List<Contact>();
        private LocalDatabase _localDatabase;
        private ChatForm _chatForm;
        private Contact _loggedUser;

        public ChatForm getChatForm()
        {
            return _chatForm;
        }

        /// <summary>
        /// Gets or sets the chat form associated with the chat instance.
        /// </summary>
        public ChatForm ChatForm
        {
            get { return _chatForm; }
            set { _chatForm = value; }
        }

        /// <summary>
        /// Gets or sets the local database associated with the chat instance.
        /// </summary>
        public LocalDatabase LocalDatabase
        {
            get { return _localDatabase; }
            set { _localDatabase = value; }
        }

        /// <summary>
        /// Retrieves a conversation with the given username.
        /// </summary>
        /// <param name="username">The username of the contact.</param>
        /// <returns>The conversation with the given username, or null if not found.</returns>
        public Conversation GetConversation(String username)
        {
            foreach (Conversation conversation in _conversations)
            {
                if (conversation.Contact.Name == username)
                    return conversation;
            }
            return null;
        }

        /// <summary>
        /// Initializes a new instance of the Chat class.
        /// </summary>
        /// <param name="localDatabase">The local database for storing chat data.</param>
        /// <param name="chatForm">The chat form associated with the chat instance.</param>
        /// <param name="loggedUser">The logged-in user's contact information.</param>
        public Chat(LocalDatabase localDatabase, ChatForm chatForm, Contact loggedUser)
        {
            this._chatForm = chatForm;
            this._localDatabase = localDatabase;
            this._loggedUser = loggedUser;

        }

        /// <summary>
        /// Retrieves the contact information of the logged-in user.
        /// </summary>
        /// <returns>The contact information of the logged-in user.</returns>
        public Contact GetLoggedUser()
        {
            return this._loggedUser;
        }

        /// <summary>
        /// Gets the list of conversations in the chat.
        /// </summary>
        public List<Conversation> Conversations
        {
            get { return _conversations; }
        }

        /// <summary>
        /// Gets the list of contacts in the chat.
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }
        }

        /// <summary>
        /// Retrieves the contact with the given name.
        /// </summary>
        /// <param name="name">The name of the contact.</param>
        /// <returns>The contact with the given name, or null if not found.</returns>
        public Contact Contact(String name)
        {
            foreach (Contact contact in _contacts)
            {
                if (contact.Name.Equals(name))
                {
                    return contact;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a new contact to the chat.
        /// </summary>
        /// <param name="username">The username of the new contact.</param>
        public void AddContact(String username)
        {
            foreach (Contact contact in _contacts)
            {
                if (contact.Name.Equals(username))
                {
                    return;
                }
            }
            _contacts.Add(new Contact(username));
            _localDatabase.AddContact(username);
        }

        /// <summary>
        /// Removes a contact from the chat.
        /// </summary>
        /// <param name="username">The username of the contact to remove.</param>
        public void RemoveContact(String username)
        {
            bool check = false;
            foreach (Contact contact in _contacts)
            {
                if (contact.Name.Equals(username))
                {
                    _contacts.Remove(contact);
                    check = true;
                    break;
                }
            }

            if (check)
            {
                _localDatabase.RemoveContact(username);
                RemoveConversation(username);
            }
        }

        /// <summary>
        /// Adds a new conversation to the chat.
        /// </summary>
        /// <param name="username">The username of the contact to start a conversation with.</param>
        public void AddConversation(String username)
        {
            foreach (Contact contact in _contacts)
            {
                if (contact.Name.Equals(username))
                {
                    foreach (Conversation conversation in _conversations)
                    {
                        if (conversation.Contact.Name.Equals(username))
                        {
                            return;
                        }
                    }

                    Contact contact1 = new Contact(username);
                    Conversation conversation1 = new Conversation();
                    conversation1.Contact = contact1;
                    _conversations.Add(conversation1);
                    _localDatabase.AddConversation(username);

                    break;
                }
            }
        }

        /// <summary>
        /// Removes a conversation from the chat.
        /// </summary>
        /// <param name="username">The username of the contact associated with the conversation.</param>
        public void RemoveConversation(String username)
        {
            bool check = false;

            foreach (Conversation conversation in _conversations)
            {
                if (conversation.Contact.Name.Equals(username))
                {
                    _conversations.Remove(conversation);
                    check = true;
                    break;
                }
            }

            if (check)
            {
                _localDatabase.RemoveConversation(username);
            }
        }

        /// <summary>
        /// Loads the contacts from the local database.
        /// </summary>
        /// <param name="user">The logged-in user's contact information.</param>
        public void LoadContacts(Contact user)
        {
            String content = File.ReadAllText("./../../Resources/Contacts/Usernames.txt");
            if (content != "")
            {
                String[] usernames = content.Split('/');
                try
                {
                    foreach (String username in usernames)
                    {
                        _contacts.Add(new Contact(username));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        /// <summary>
        /// Loads the conversations from the local database.
        /// </summary>
        public void LoadConversations()
        {
            String content = File.ReadAllText("./../../Resources/Contacts/Conversations.txt");
            if (content != "")
            {
                String[] usernames = content.Split('/');
                try
                {
                    foreach (String username in usernames)
                    {
                        Contact contact = new Contact(username);
                        Conversation conversation = new Conversation();
                        conversation.Contact = contact;
                        _conversations.Add(conversation);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        /// <summary>
        /// Loads the messages of a conversation from the local database.
        /// </summary>
        /// <param name="username">The username of the contact associated with the conversation.</param>
        /// <param name="timestamp">The timestamp of the message.</param>
        /// <param name="message">The content of the message.</param>
        public void LoadMessages(String username, String timestamp, String message)
        {
            Conversation conversation = GetConversation(username);

            if (conversation != null)
            {
                conversation.addMessage(timestamp, username, message);
            }
        }
    }
}
