using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
