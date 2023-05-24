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

        public List<Conversation> Conversations
        {
            get { return _conversations; }
        }
        public List<Contact> Contacts
        {
            get { return _contacts; }
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
            _contacts.Add(new Contact(username));
        }
        public void AddContact(String username, Bitmap image)
        {
            _contacts.Add(new Contact(username, image));
        }
        public void RemoveContact(String username)
        {
            foreach (Contact contact in _contacts)
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
        public void LoadContacts(Contact user)
        {

            String content = File.ReadAllText("./../../Resources/Contacts/Usernames.txt");
            String[] usernames = content.Split('/');

            String[] paths = Directory.GetFiles("./../../Resources/Contacts/ProfileImages");
            Console.WriteLine(paths);


            try
            {
                foreach (String username in usernames)
                {
                    if (username != user.Name) { }
                    bool check = false;
                    foreach (String path in paths)
                    {
                        Console.WriteLine(path + "   \\" + username + ".jpeg");
                        if (path.EndsWith("\\" + username + ".jpeg"))
                        {
                            _contacts.Add(new Contact(username, new Bitmap(path)));
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                    {
                        _contacts.Add(new Contact(username, new Bitmap("./../../Resources/Contacts/ProfileImages/noimage.jpeg")));
                    }
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
