using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatApp
{
    public class LocalDatabase
    {
        public LocalDatabase()
        {
            if (!Directory.Exists("./../../Resources"))
            {
                Directory.CreateDirectory("./../../Resources");
                Console.WriteLine("Folderul a fost creat cu succes.");
            }
            else
            {
                Console.WriteLine("Folderul există deja.");
            }

            if (!Directory.Exists("./../../Resources/Contacts"))
            {
                Directory.CreateDirectory("./../../Resources/Contacts");
                Console.WriteLine("Folderul a fost creat cu succes.");
            }
            else
            {
                Console.WriteLine("Folderul există deja.");
            }

            if (!Directory.Exists("./../../Resources/Contacts/ProfileImages"))
            {
                Directory.CreateDirectory("./Resources/Contacts/ProfileImages");
                Console.WriteLine("Folderul a fost creat cu succes.");
            }
            else
            {
                Console.WriteLine("Folderul există deja.");
            }

            // Verificăm dacă fișierul există
            if (File.Exists("./../../Resources/Contacts/Usernames.txt"))
            {
                Console.WriteLine("Fișierul Usernames.txt există deja.");
            }
            else
            {
                // Creăm fișierul
                File.Create("./../../Resources/Contacts/Usernames.txt").Close();
                Console.WriteLine("Fișierul Usernames.txt a fost creat.");
            }

            // Verificăm dacă fișierul există
            if (File.Exists("./../../Resources/Contacts/Conversations.txt"))
            {
                Console.WriteLine("Fișierul Conversations.txt există deja.");
            }
            else
            {
                // Creăm fișierul
                File.Create("./../Resources/Contacts/Conversations.txt").Close();
                Console.WriteLine("Fișierul Conversations.txt a fost creat.");
            }

            if (File.Exists("./../../Resources/Contacts/ProfileImages/noimage.jpeg"))
            {
                Console.WriteLine("Fișierul noimage.jpeg există deja.");
            }
            else
            {
                // Creăm fișierul
                int width = 200;
                int height = 200;

                Bitmap bitmap = new Bitmap(width, height);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.Black);
                }

                string outputPath = "./../../Resources/Contacts/ProfileImages/noimage.jpeg";
                bitmap.Save(outputPath);
                Console.WriteLine("Fișierul noimage.jpeg a fost creat.");
            }

        }
        public void UploadAvatarPhoto(Bitmap image, String username)
        {
            String path = "./../../Resources/Contacts/ProfileImages/" + username + ".jpeg";

            //existingImage.Save(path);
            if (File.Exists(path))
            {
                // Ștergem fișierul existent
                File.Delete(path);
            }

            image.Save(path);
        }
        public Bitmap GetAvatarImage(String name)
        {
            Bitmap image;
            String path = "./../../Resources/Contacts/ProfileImages/" + name + ".jpeg";

            try
            {
                bool check = false;

                Console.WriteLine(path + "   \\" + name + ".jpeg");

                var bytes = File.ReadAllBytes(path);
                MemoryStream ms = new MemoryStream(bytes);
                Image bitmap = Image.FromStream(ms);

                image = (Bitmap)bitmap;


            }
            catch (Exception exc)
            {
                var bytes = File.ReadAllBytes("./../../Resources/Contacts/ProfileImages/noimage.jpeg");
                MemoryStream ms = new MemoryStream(bytes);
                Image bitmap = Image.FromStream(ms);

                image = (Bitmap)bitmap;

            }

            return image;
        }
        public void AddContact(String username)
        {
            String content = File.ReadAllText("./../../Resources/Contacts/Usernames.txt");

            if (content.Equals(""))
                content += username;
            else
                content += "/" + username;

            File.WriteAllText("./../../Resources/Contacts/Usernames.txt", content);
        }

        public void ReloadLocalDatabase(Contact loggedUser)
        {

            String content = File.ReadAllText("./../../Resources/Contacts/LoggedUser.txt");

            if (!loggedUser.Name.Equals(content))
            {
                File.WriteAllText("./../../Resources/Contacts/LoggedUser.txt", loggedUser.Name);
                File.WriteAllText("./../../Resources/Contacts/Usernames.txt", "");
                File.WriteAllText("./../../Resources/Contacts/Conversations.txt", "");
                
                String path = "./../../Resources/Contacts/ProfileImages/";
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    if(!file.Contains("noimage.jpeg"))
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }

                }

                ClientSocket.Instance.SendMessage(new RetrieveContactPacket(loggedUser.Name));
            }
            else
            {
                ChatForm.localDatabaseReloaded = 1;
            }
        }
        public void RemoveContact(String username)
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
        }
        public void AddConversation(String username)
        {
            String content = File.ReadAllText("./../../Resources/Contacts/Conversations.txt");

            if (content.Equals(""))
                content += username;
            else
                content += "/" + username;

            File.WriteAllText("./../../Resources/Contacts/Conversations.txt", content);
        }
        public void RemoveConversation(String username)
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
}
