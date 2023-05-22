using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class Chat
    {
        private List<Conversation> _conversations = new List<Conversation>();
        private List<Contact> _contacts = new List<Contact>();

        public List<Conversation> Conversations
        {
            get { return _conversations; }
        }
        public List<Contact> Contacts
        {
            get { return _contacts; }
        }
        public void AddContact(String username, Bitmap image )
        {
            _contacts.Add(new Contact(username, image));
        }
        public void RemoveContact(String username)
        {
            foreach(Contact contact in _contacts)
            {
                if (contact.Name.Equals(username))
                {
                    _contacts.Remove(contact);
                    break;
                }
            }
        }
        public void AddConversation(String timestamp, String username, String message)
        {

        }
        public void RemoveConversation()
        {

        }
    }
}
