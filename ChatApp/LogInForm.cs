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
    public partial class LogInForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public LogInForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listPanel.Add(LoginPanel);
            listPanel.Add(RegistrationPanel);

            listPanel[0].Visible = true;
            listPanel[1].Visible = false;
            ClientSocket clientSocket = ClientSocket.Instance;
        }



        private void SignInButton_Click(object sender, EventArgs e)
        {
            ClientSocket.Instance.SendMessage(new LoginPacket(UserTextBox.Text,PasswordTextBox.Text));
            LoginAckPacket p = (LoginAckPacket)ClientSocket.Instance.ReceiveMessage();
            if (!p.Message.Equals("OK"))
            {
                MessageBox.Show(p.Message);
            }
            else { 
                ChatForm chatForm = new ChatForm(new Contact(UserTextBox.Text));
                this.Hide();
                chatForm.ShowDialog();
                this.Close();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            listPanel[1].Visible = true;
            listPanel[0].Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = true;
            listPanel[1].Visible = false;
            ClientSocket.Instance.SendMessage(new RegisterPacket(RegisterUsername.Text, RegisterPassword.Text));
            RegisterAckPacket p = (RegisterAckPacket)ClientSocket.Instance.ReceiveMessage();


            if (!p.Message.Equals("OK"))
            {
                MessageBox.Show(p.Message);
            }
        }

    }
}
