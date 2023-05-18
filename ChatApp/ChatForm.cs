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

            listPanelRight.Add(ProfilePanel);
            listPanelRight.Add(ContactsPanel);
            listPanelRight.Add(ConversationPanel);
            listPanelRight.Add(SettingsPanel);

            listPanelMid.Add(ProfileSidePanel);
            listPanelMid.Add(ContactsSidePanel);
            listPanelMid.Add(ConversationsSidePanel);
            listPanelMid.Add(SettingsSidePanel);

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

        private void LoadAvatarButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                AvatarPictureBox.Image = new Bitmap(open.FileName);

            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
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
            listPanelRight[0].Visible = false;
            listPanelRight[1].Visible = false;
            listPanelRight[2].Visible = false;
            listPanelRight[3].Visible = true;

            listPanelMid[0].Visible = false;
            listPanelMid[1].Visible = false;
            listPanelMid[2].Visible = false;
            listPanelMid[3].Visible = true;
        }
    }
}
