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
    class Chat
    {
        private List<Conversation> _conversations = new List<Conversation>();
        private List<Contact> _contacts = new List<Contact>();
        private ChatForm _chatForm;

        public List<Conversation> Conversations
        {
            get { return _conversations; }
        }
        public List<Contact> Contacts
        {
            get { return _contacts; }
        }
        public Chat(ChatForm chatForm)
        {
            _chatForm = chatForm;
        }
        public Contact Contact(String name)
        {
            foreach(Contact contact in _contacts)
            {
                if (contact.Name.Equals(name))
                {
                    return contact;
                }
            }
            return null;
        }
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

            String content = File.ReadAllText("./../../Resources/Contacts/Usernames.txt");

            if (content.Equals(""))
                content += username;
            else
                content += "/" + username;

            File.WriteAllText("./../../Resources/Contacts/Usernames.txt", content);
        }
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
                String content = File.ReadAllText("./../../Resources/Contacts/Usernames.txt");
                Console.WriteLine(content);
                Console.WriteLine(username);
                if (content.Contains("/" + username + "/"))
                {
                    content = content.Replace("/" + username, "");
                }
                else if (content.Contains(username + "/"))
                {
                    content = content.Replace(username + "/", "");
                }
                else if (content.Contains("/" + username))
                {
                    content = content.Replace("/" + username, "");
                }
                else if (content.Equals(username))
                    content = "";
                Console.WriteLine(content);
                File.WriteAllText("./../../Resources/Contacts/Usernames.txt", content);

                RemoveConversation(username);
            }
        }
        public void AddConversation(String username)
        {

            foreach(Contact contact in _contacts)
            {
                if (contact.Name.Equals(username))
                {
                    foreach(Conversation conversation in _conversations)
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

                    String content = File.ReadAllText("./../../Resources/Contacts/Conversations.txt");

                    if (content.Equals(""))
                        content += username;
                    else
                        content += "/" + username;

                    File.WriteAllText("./../../Resources/Contacts/Conversations.txt", content);

                    break;
                }
            }
        }
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
                String content = File.ReadAllText("./../../Resources/Contacts/Conversations.txt");

                if (content.Contains("/" + username + "/"))
                {
                    content = content.Replace("/" + username, "");
                }
                else if (content.Contains(username + "/"))
                {
                    content = content.Replace(username + "/", "");
                }
                else if (content.Contains("/" + username))
                {
                    content = content.Replace("/" + username, "");
                }
                else if (content.Equals(username))
                    content = "";

                File.WriteAllText("./../../Resources/Contacts/Conversations.txt", content);
            }
        }

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
    }
}
