using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ChatForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            ProfileButton.FlatStyle = FlatStyle.Flat;
            ProfileButton.FlatAppearance.BorderSize = 0;

            ContactsButton.FlatStyle = FlatStyle.Flat;
            ContactsButton.FlatAppearance.BorderSize = 0;

            ConversationButton.FlatStyle = FlatStyle.Flat;
            ConversationButton.FlatAppearance.BorderSize = 0;

            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.FlatAppearance.BorderSize = 0;

            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            LoadAvatarButton.FlatStyle = FlatStyle.Flat;
            LoadAvatarButton.FlatAppearance.BorderSize = 0;

            listPanelRight.Add(ProfilePanel);
            listPanelRight.Add(ContactsPanel);
            listPanelRight.Add(ConversationPanel);
            listPanelRight.Add(SettingsPanel);

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

            listPanelMid[0].Visible = true;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = false;
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

            listPanelMid[0].Visible = false;
            listPanelMid[1].Visible = true;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = false;

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

    }
}
