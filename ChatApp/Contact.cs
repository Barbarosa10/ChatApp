using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    /// <summary>
    /// Represents a contact in the chat application.
    /// </summary>
    public class Contact
    {
        private String _name;
        private Bitmap _image;

        /// <summary>
        /// Initializes a new instance of the Contact class with the specified name and image.
        /// </summary>
        /// <param name="name">The name of the contact.</param>
        /// <param name="image">The image associated with the contact.</param>
        public Contact(String name, Bitmap image)
        {
            _name = name;
            _image = image;
        }

        /// <summary>
        /// Initializes a new instance of the Contact class with the specified name and loads the associated image.
        /// </summary>
        /// <param name="name">The name of the contact.</param>
        public Contact(String name)
        {
            _name = name;

            String path = "./../../Resources/Contacts/ProfileImages/" + name + ".jpeg";
            try
            {
                bool check = false;

                Console.WriteLine(path + "   \\" + name + ".jpeg");

                var bytes = File.ReadAllBytes(path);
                MemoryStream ms = new MemoryStream(bytes);
                Image bitmap = System.Drawing.Image.FromStream(ms);

                _image = (Bitmap)bitmap;

            }
            catch (Exception exc)
            {

                var bytes = File.ReadAllBytes("./../../Resources/Contacts/ProfileImages/noimage.jpeg");
                MemoryStream ms = new MemoryStream(bytes);
                Image bitmap = System.Drawing.Image.FromStream(ms);

                _image = (Bitmap)bitmap;

            }
        }

        /// <summary>
        /// Gets or sets the name of the contact.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the image associated with the contact.
        /// </summary>
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
