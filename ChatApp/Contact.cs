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
    public class Contact
    {
        private String _name;
        private Bitmap _image;

        public Contact(String name, Bitmap image)
        {
            _name = name;
            _image = image;
        }
        public Contact(String name)
        {
            _name = name;


            String path = "./../../Resources/Contacts/ProfileImages/" + name + ".jpeg";
            try
            {
                bool check = false;

                Console.WriteLine(path + "   \\" + name + ".jpeg");

                _image = new Bitmap(path);
            }
            catch (Exception exc)
            {
                _image = new Bitmap("./../../Resources/Contacts/ProfileImages/noimage.jpeg");
            }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
