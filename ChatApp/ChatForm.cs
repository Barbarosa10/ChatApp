using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class ChatForm : Form
    {
        List<Panel> listPanelMid = new List<Panel>();
        List<Panel> listPanelRight = new List<Panel>();
        Chat chat = new Chat();
        public ChatForm(Contact user)
        {
            InitializeComponent();
            this.CenterToScreen();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            AvatarPictureBoxProfile.Image = user.Image;
            AvatarPictureBoxSettings.Image = user.Image;

            listPanelRight.Add(ProfilePanel);
            listPanelRight.Add(ContactsPanel);
            listPanelRight.Add(ConversationPanel);
            listPanelRight.Add(SettingsPanel);
            listPanelRight.Add(AddContactsPanel);
            listPanelRight.Add(ContactPanel);

            listPanelMid.Add(ProfileSidePanel);
            listPanelMid.Add(ContactsSidePanel);
            listPanelMid.Add(ConversationsSidePanel);
            listPanelMid.Add(SettingsSidePanel);

            ProfileButton.BackColor = Color.DarkGray;
            ProfileButton.ForeColor = Color.Black;

            listPanelRight[0].Visible = true;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = false;

            listPanelMid[0].Visible = true;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = false;

            ContactsListView.OwnerDraw = true;
            ContactsListView.DrawItem += ContactListView_DrawItem;
            ContactsListView.MouseMove += ContactListView_MouseMove;
            ContactsListView.MouseClick += ContactListView_MouseClick;


            chat.LoadContacts(user);
        }
        
        private void ContactListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ContactsListView.GetItemAt(e.X, e.Y);
            int index = item.Index;

            for (int i = 0; i < ContactsListView.Items.Count; i++)
            {
                //if(i == index)
                ContactsListView.Items[i].BackColor = Color.Black;

                //else
                //    ContactsListView.Items[i].BackColor = Color.Gray;
            }

            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = true;

            Contact contact = chat.Contact(item.Text);
            if(contact != null)
            {
                ContactAvatarPictureBox.Image = contact.Image;
                ContactLabel.Text = contact.Name;
            }
            //ContactAvatarPictureBox.Image = ContactsListView.SmallImageList.Images[item.Index];
            //ContactLabel.Text = item.Text;

        }
        private void ContactListView_MouseMove(object sender, MouseEventArgs e)
        {
            // Obține elementul de sub cursor
            ListViewItem item = ContactsListView.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                // Setează cursorul personalizat pentru elementul curent
                ContactsListView.Cursor = Cursors.Hand; // înlocuiește Cursors.Hand cu cursorul dorit
            }
            else
            {
                // Setează cursorul implicit în cazul în care mouse-ul nu se află deasupra unui element
                ContactsListView.Cursor = Cursors.Default;
            }
        }
        private void ContactListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color color = Color.White;

            //if ((e.State & ListViewItemStates.Selected) != 0)
            //{
            //    e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            //    color = Color.Gray;
            //}
            //else
            //{
            //    e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
            //}

            // Desenează textul elementului
            if (e.Item.ImageIndex >= 0)
            {
                Image image = ContactsListView.SmallImageList.Images[e.Item.ImageIndex];
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top);
            }

            Rectangle textBounds = new Rectangle(e.Bounds.Left + ContactsListView.SmallImageList.ImageSize.Width, e.Bounds.Top + ContactsListView.SmallImageList.ImageSize.Height/3, e.Bounds.Width - ContactsListView.SmallImageList.ImageSize.Width, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, ContactsListView.Font, textBounds, color, TextFormatFlags.Left);


        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            RsaEncryption rsa = new RsaEncryption();
            ClientSocket.Instance.SendMessage(rsa.GetPublicPEM());
 
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileButton.BackColor = Color.DarkGray;
            ProfileButton.ForeColor = Color.Black;
            ContactsButton.BackColor = Color.Black;
            ContactsButton.ForeColor = Color.Silver;
            ConversationButton.BackColor = Color.Black;
            ConversationButton.ForeColor = Color.Silver;
            SettingsButton.BackColor = Color.Black;
            SettingsButton.ForeColor = Color.Silver;

            listPanelRight[0].Visible = true;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = false;

            listPanelMid[0].Visible = true;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = false;
        }




        private void ContactsButton_Click(object sender, EventArgs e)
        {
            ProfileButton.BackColor = Color.Black;
            ProfileButton.ForeColor = Color.Silver;
            ContactsButton.BackColor = Color.DarkGray;
            ContactsButton.ForeColor = Color.Black;
            ConversationButton.BackColor = Color.Black;
            ConversationButton.ForeColor = Color.Silver;
            SettingsButton.BackColor = Color.Black;
            SettingsButton.ForeColor = Color.Silver;

            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = true;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = false;

            listPanelMid[0].Visible = false;
            listPanelMid[1].Visible = true;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = false;

            ContactsListView.View = View.Details;

            ContactsListView.ForeColor = Color.White;
           

            ContactsListView.Clear();
           
            ContactsListView.Columns.Add("Contacts", 132);
            ImageList image = new ImageList();
            image.ImageSize = new Size(40, 40);
            
            for(int i = 0; i < chat.Contacts.Count; i++)
            {
                image.Images.Add(chat.Contacts[i].Image);
                ContactsListView.Items.Add(chat.Contacts[i].Name, i);

            }

            ContactsListView.SmallImageList = image;
        }

        private void ConversationButton_Click(object sender, EventArgs e)
        {
            ProfileButton.BackColor = Color.Black;
            ProfileButton.ForeColor = Color.Silver;
            ContactsButton.BackColor = Color.Black;
            ContactsButton.ForeColor = Color.Silver;
            ConversationButton.BackColor = Color.DarkGray;
            ConversationButton.ForeColor = Color.Black;
            SettingsButton.BackColor = Color.Black;
            SettingsButton.ForeColor = Color.Silver;

            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = true;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = false;

            listPanelMid[0].Visible = false;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = true;
            listPanelMid[3].Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ProfileButton.BackColor = Color.Black;
            ProfileButton.ForeColor = Color.Silver;
            ContactsButton.BackColor = Color.Black;
            ContactsButton.ForeColor = Color.Silver;
            ConversationButton.BackColor = Color.Black;
            ConversationButton.ForeColor = Color.Silver;
            SettingsButton.BackColor = Color.DarkGray;
            SettingsButton.ForeColor = Color.Black;

            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = true;
            listPanelRight[4].Visible = false;
            listPanelRight[5].Visible = false;

            listPanelMid[0].Visible = false;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = true;
        }

        private void LoadAvatarButton_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                AvatarPictureBoxProfile.Image = new Bitmap(open.FileName);
                AvatarPictureBoxSettings.Image = new Bitmap(open.FileName);
            }
        }

        private void AddContactsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = false;
            listPanelRight[4].Visible = true;
            listPanelRight[5].Visible = false;
        }
    }
}
