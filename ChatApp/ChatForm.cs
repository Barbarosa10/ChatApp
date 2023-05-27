using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class ChatForm : Form
    {
        List<Panel> listPanelMid = new List<Panel>();
        List<Panel> listPanelRight = new List<Panel>();
        Chat chat;
        Contact logged_user;
        MessageHandler handler = new MessageHandler();
        LocalDatabase _localDatabase;
        public ChatForm(Contact user, LocalDatabase localDatabase)
        {

            InitializeComponent();
            this.CenterToScreen();
            _localDatabase = localDatabase;
            logged_user = user;
            chat = new Chat(_localDatabase, this, logged_user);

            handler.Start(chat);


            UserLabel.Text = user.Name;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;



            AvatarPictureBoxProfile.Image = logged_user.Image;
            AvatarPictureBoxSettings.Image = logged_user.Image;

            listPanelRight.Add(ProfilePanel);
            listPanelRight.Add(ContactsPanel);
            listPanelRight.Add(ConversationPanel);
            listPanelRight.Add(SettingsPanel);
            listPanelRight.Add(AddContactsPanel);
            listPanelRight.Add(ContactPanel);
            listPanelRight.Add(AddConversationPanel);
            listPanelRight.Add(ConversationMainPanel);

            listPanelMid.Add(ProfileSidePanel);
            listPanelMid.Add(ContactsSidePanel);
            listPanelMid.Add(ConversationsSidePanel);
            listPanelMid.Add(SettingsSidePanel);

            ProfileButton.BackColor = Color.DarkGray;
            ProfileButton.ForeColor = Color.Black;

            EnableDisableRightPanel(true, false, false, false, false, false, false, false);
            EnableDisableLeftPanel(true, false, false, false);

            ContactsListView.OwnerDraw = true;
            ContactsListView.DrawItem += ContactListView_DrawItem;
            ContactsListView.MouseMove += ContactListView_MouseMove;
            ContactsListView.MouseClick += ContactListView_MouseClick;
            chat.LoadContacts(user);

            ConversationsListView.OwnerDraw = true;
            ConversationsListView.DrawItem += ConversationListView_DrawItem;
            ConversationsListView.MouseMove += ConversationListView_MouseMove;
            ConversationsListView.MouseClick += ConversationListView_MouseClick;
            chat.LoadConversations();

            ConversationWithMessagesListView.View = View.Details;
            ConversationWithMessagesListView.OwnerDraw = true;
            ConversationWithMessagesListView.DrawItem += ConversationWithMessagesListView_DrawItem;
            //ConversationWithMessagesListView.MouseMove += ConversationWithMessagesListView_MouseMove;
            //ConversationWithMessagesListView.MouseClick += ConversationListView_MouseClick;
        }


        private void ConversationListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ConversationsListView.GetItemAt(e.X, e.Y);

            EnableDisableRightPanel(false, false, true, false, false, false, false, false);

            Contact contact = chat.Contact(item.Text);
            if (contact != null)
            {
                ConversationTopAvatarPictureBox.Image = contact.Image;
                ConversationTopLabel.Text = contact.Name;
            }

            GetNMessagesPacket packet = new GetNMessagesPacket();
            packet.User1 = logged_user.Name;
            packet.User2 = contact.Name;

            ClientSocket.Instance.SendMessage(packet);

            AddMessagesToListView(contact.Name);

        }
        private void ConversationListView_MouseMove(object sender, MouseEventArgs e)
        {
            // Obține elementul de sub cursor
            ListViewItem item = ConversationsListView.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                // Setează cursorul personalizat pentru elementul curent
                ConversationsListView.Cursor = Cursors.Hand; // înlocuiește Cursors.Hand cu cursorul dorit
            }
            else
            {
                // Setează cursorul implicit în cazul în care mouse-ul nu se află deasupra unui element
                ConversationsListView.Cursor = Cursors.Default;
            }
        }
        private void ConversationListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color color = Color.Black;

            if ((e.State & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
                color = Color.Gray;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
            }

            // Desenează textul elementului
            if (e.Item.ImageIndex >= 0)
            {
                Image image = ConversationsListView.SmallImageList.Images[e.Item.ImageIndex];
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top);
            }

            Rectangle textBounds = new Rectangle(e.Bounds.Left + ConversationsListView.SmallImageList.ImageSize.Width, e.Bounds.Top + ConversationsListView.SmallImageList.ImageSize.Height / 3, e.Bounds.Width - ConversationsListView.SmallImageList.ImageSize.Width, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, ConversationsListView.Font, textBounds, color, TextFormatFlags.Left);
        }

        private void ContactListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ContactsListView.GetItemAt(e.X, e.Y);


            EnableDisableRightPanel(false, false, false, false, false, true, false, false);

            Contact contact = chat.Contact(item.Text);
            if (contact != null)
            {
                ContactAvatarPictureBox.Image = contact.Image;
                ContactLabel.Text = contact.Name;
            }




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
            Color color = Color.Black;

            if ((e.State & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
                color = Color.Gray;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
            }

            // Desenează textul elementului
            if (e.Item.ImageIndex >= 0)
            {
                Image image = ContactsListView.SmallImageList.Images[e.Item.ImageIndex];
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top);
            }

            Rectangle textBounds = new Rectangle(e.Bounds.Left + ContactsListView.SmallImageList.ImageSize.Width, e.Bounds.Top + ContactsListView.SmallImageList.ImageSize.Height / 3, e.Bounds.Width - ContactsListView.SmallImageList.ImageSize.Width, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, ContactsListView.Font, textBounds, color, TextFormatFlags.Left);
        }

        private void ConversationWithMessagesListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds);
            // Desenează textul elementului
            if (e.Item.ImageIndex >= 0)
            {
                Image image = ConversationWithMessagesListView.SmallImageList.Images[e.Item.ImageIndex];
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top);
            }
            String dateString = e.Item.Text.Split('|')[0];
            String message = e.Item.Text.Replace(dateString + "|", "  ");

            Rectangle textBounds = new Rectangle(e.Bounds.Left + ConversationWithMessagesListView.SmallImageList.ImageSize.Width, e.Bounds.Top + ConversationWithMessagesListView.SmallImageList.ImageSize.Height / 4, 92, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, dateString + " : ", ConversationWithMessagesListView.Font, textBounds, Color.Gray, TextFormatFlags.Left);

            textBounds = new Rectangle(e.Bounds.Left + ConversationWithMessagesListView.SmallImageList.ImageSize.Width + 95, e.Bounds.Top + ConversationWithMessagesListView.SmallImageList.ImageSize.Height / 4, e.Bounds.Width - ConversationWithMessagesListView.SmallImageList.ImageSize.Width, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, message, ConversationWithMessagesListView.Font, textBounds, Color.White, TextFormatFlags.Left);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            handler.Stop();
            ClientSocket.Instance.CloseSocket();
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
            //RsaEncryption rsa = new RsaEncryption();
            //ClientSocket.Instance.SendMessage(rsa.ExportPublicKey());
            SendMessagePacket packet = new SendMessagePacket
            {
                DestID = ConversationTopLabel.Text,
                SenderID = logged_user.Name,
                Message = MessageToBeSentBox.Text
            };
            Console.WriteLine("Sendind message to " + packet.SenderID + " : " + packet.Message);
            ClientSocket.Instance.SendMessage(packet);

        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            AvatarPictureBoxProfile.Image = logged_user.Image;

            ProfileButton.BackColor = Color.DarkGray;
            ProfileButton.ForeColor = Color.Black;
            ContactsButton.BackColor = Color.Black;
            ContactsButton.ForeColor = Color.Silver;
            ConversationButton.BackColor = Color.Black;
            ConversationButton.ForeColor = Color.Silver;
            SettingsButton.BackColor = Color.Black;
            SettingsButton.ForeColor = Color.Silver;

            EnableDisableRightPanel(true, false, false, false, false, false, false, false);
            EnableDisableLeftPanel(true, false, false, false);

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

            EnableDisableRightPanel(false, true, false, false, false, false, false, false);
            EnableDisableLeftPanel(false, true, false, false);

            ContactsListView.View = View.Details;

            ContactsListView.ForeColor = Color.White;

            AddContactToListView();
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

            EnableDisableRightPanel(false, false, false, false, false, false, false, true);
            EnableDisableLeftPanel(false, false, true, false);

            ConversationsListView.View = View.Details;

            ConversationsListView.ForeColor = Color.White;

            AddConversationsToListView();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //AvatarPictureBoxSettings.Image = logged_user.Image;

            ProfileButton.BackColor = Color.Black;
            ProfileButton.ForeColor = Color.Silver;
            ContactsButton.BackColor = Color.Black;
            ContactsButton.ForeColor = Color.Silver;
            ConversationButton.BackColor = Color.Black;
            ConversationButton.ForeColor = Color.Silver;
            SettingsButton.BackColor = Color.DarkGray;
            SettingsButton.ForeColor = Color.Black;

            EnableDisableRightPanel(false, false, false, true, false, false, false, false);
            EnableDisableLeftPanel(false, false, false, true);

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
                Bitmap image = new Bitmap(open.FileName);

                AvatarPictureBoxProfile.Image = image;
                AvatarPictureBoxSettings.Image = image;
                logged_user.Image = image;

                _localDatabase.UploadAvatarPhoto(image, logged_user.Name);
            }

            byte[] img;
            using (MemoryStream stream = new MemoryStream())
            {
                logged_user.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                img = stream.ToArray();
            }
            ClientSocket.Instance.SendMessage(new UploadPhotoPacket(logged_user.Name, img));
        }

        private void AddContactsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            EnableDisableRightPanel(false, false, false, false, true, false, false, false);
        }

        private void InsertContactButton_Click(object sender, EventArgs e)
        {

            Console.WriteLine("contact: /" + ContactToAddTextBox.Text + "/");
            ClientSocket.Instance.SendMessage(new RetrieveContactPacket(ContactToAddTextBox.Text));

        }

        private void AddConversationButton_Click(object sender, EventArgs e)
        {
            EnableDisableRightPanel(false, false, false, false, false, false, true, false);
        }
        private void EnableDisableRightPanel(bool profilePanel, bool contactsPanel, bool conversationPanel, bool settingsPanel, bool addContactsPanel, bool contactPanel, bool addConversationPanel, bool conversationMainPanel)
        {

            listPanelRight[0].Visible = profilePanel;
            listPanelRight[1].Visible = contactsPanel;
            listPanelRight[2].Visible = conversationPanel;
            listPanelRight[3].Visible = settingsPanel;
            listPanelRight[4].Visible = addContactsPanel;
            listPanelRight[5].Visible = contactPanel;
            listPanelRight[6].Visible = addConversationPanel;
            listPanelRight[7].Visible = conversationMainPanel;

        }
        private void EnableDisableLeftPanel(bool profilePanel, bool contactsPanel, bool conversationsPanel, bool settingsPanel)
        {
            listPanelMid[0].Visible = profilePanel;
            listPanelMid[1].Visible = contactsPanel;
            listPanelMid[2].Visible = conversationsPanel;
            listPanelMid[3].Visible = settingsPanel;
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            chat.RemoveContact(ContactLabel.Text);
            AddContactToListView();
        }

        public void AddContactToListView()
        {
            ContactsListView.Clear();

            ContactsListView.Columns.Add("Contacts", 132);
            ImageList image = new ImageList();
            image.ImageSize = new Size(40, 40);

            for (int i = 0; i < chat.Contacts.Count; i++)
            {
                image.Images.Add(chat.Contacts[i].Image);
                ContactsListView.Items.Add(chat.Contacts[i].Name, i);

            }

            ContactsListView.SmallImageList = image;
        }
        public void AddConversationsToListView()
        {
            ConversationsListView.Clear();

            ConversationsListView.Columns.Add("Conversations", 132);
            ImageList image = new ImageList();
            image.ImageSize = new Size(40, 40);

            for (int i = 0; i < chat.Conversations.Count; i++)
            {
                image.Images.Add(chat.Conversations[i].Contact.Image);
                ConversationsListView.Items.Add(chat.Conversations[i].Contact.Name, i);
            }

            ConversationsListView.SmallImageList = image;
        }

        private void InsertConversationButton_Click(object sender, EventArgs e)
        {
            chat.AddConversation(ConversationToAddTextBox.Text);
            AddConversationsToListView();
        }

        private void DeleteConversationButton_Click(object sender, EventArgs e)
        {
            chat.RemoveConversation(ConversationTopLabel.Text);
            AddConversationsToListView();
        }

        public void AddMessagesToListView(String username)
        {

            ConversationWithMessagesListView.Clear();

            ConversationWithMessagesListView.Columns.Add("TimestampMessage", 132);
            //ConversationWithMessagesListView.Columns.Add("Message", 300);
            ImageList image = new ImageList();
            image.ImageSize = new Size(40, 40);

            Conversation conversation = chat.GetConversation(username);

            if (conversation.getMessage() != null)
            {
                int i = 0;
                foreach (String timestamp in conversation.getMessage().Keys)
                {
                    if(conversation.getMessage()[timestamp].username == logged_user.Name)
                        image.Images.Add(logged_user.Image);
                    else
                        image.Images.Add(conversation.Contact.Image);

                    // Convertiți timestamp-ul într-un obiect DateTime
                    DateTime dateTime = new DateTime(1970, 1, 1).AddSeconds(Convert.ToDouble(timestamp)); // Sau AddMilliseconds() pentru milisecunde

                    // Formatați data și ora într-un șir de caractere utilizând metoda ToString()
                    string dateString = dateTime.ToString("dd-MM-yyyy HH:mm"); // Schimbați formatul după necesități

                    ConversationWithMessagesListView.Items.Add(dateString + "|" + conversation.getMessage()[timestamp].message, i++);

                    //ListViewItem item = new ListViewItem(timestamp);
                    //item.SubItems.Add(conversation.getMessage()[timestamp].message);
                    //ConversationWithMessagesListView.Items.Add(item);
                }


                ConversationWithMessagesListView.SmallImageList = image;
            }


        }
        private void ConversationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}