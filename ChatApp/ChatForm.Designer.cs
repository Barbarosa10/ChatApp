using System;
namespace ChatApp
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.ChatMainPanel = new System.Windows.Forms.Panel();
            this.ProfileSidePanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.SettingsSidePanel = new System.Windows.Forms.Panel();
            this.LoadAvatarButton = new System.Windows.Forms.Button();
            this.AvatarPictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConversationsSidePanel = new System.Windows.Forms.Panel();
            this.ContactsSidePanel = new System.Windows.Forms.Panel();
            this.ConversationPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.MessageToBeSentBox = new System.Windows.Forms.TextBox();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.ConversationButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.ChatMainPanel.SuspendLayout();
            this.ProfileSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).BeginInit();
            this.SettingsSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxSettings)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ConversationsSidePanel.SuspendLayout();
            this.ContactsSidePanel.SuspendLayout();
            this.ConversationPanel.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatMainPanel
            // 
            this.ChatMainPanel.BackColor = System.Drawing.Color.Black;
            this.ChatMainPanel.Controls.Add(this.ContactsSidePanel);
            this.ChatMainPanel.Controls.Add(this.ConversationsSidePanel);
            this.ChatMainPanel.Controls.Add(this.ConversationPanel);
            this.ChatMainPanel.Controls.Add(this.ProfileSidePanel);
            this.ChatMainPanel.Controls.Add(this.SettingsSidePanel);
            this.ChatMainPanel.Controls.Add(this.SettingsPanel);
            this.ChatMainPanel.Controls.Add(this.ProfilePanel);
            this.ChatMainPanel.Controls.Add(this.ContactsPanel);
            this.ChatMainPanel.Controls.Add(this.LeftSidePanel);
            this.ChatMainPanel.Location = new System.Drawing.Point(0, -1);
            this.ChatMainPanel.Name = "ChatMainPanel";
            this.ChatMainPanel.Size = new System.Drawing.Size(989, 510);
            this.ChatMainPanel.TabIndex = 0;
            // 
            // ProfileSidePanel
            // 
            this.ProfileSidePanel.BackColor = System.Drawing.Color.Gray;
            this.ProfileSidePanel.Controls.Add(this.EmailTextLabel);
            this.ProfileSidePanel.Controls.Add(this.UsernameLabel);
            this.ProfileSidePanel.Controls.Add(this.AvatarPictureBoxProfile);
            this.ProfileSidePanel.Location = new System.Drawing.Point(109, 1);
            this.ProfileSidePanel.Name = "ProfileSidePanel";
            this.ProfileSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ProfileSidePanel.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(27, 116);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(91, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // AvatarPictureBoxProfile
            // 
            this.AvatarPictureBoxProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AvatarPictureBoxProfile.Location = new System.Drawing.Point(24, 12);
            this.AvatarPictureBoxProfile.Name = "AvatarPictureBoxProfile";
            this.AvatarPictureBoxProfile.Size = new System.Drawing.Size(100, 100);
            this.AvatarPictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBoxProfile.TabIndex = 0;
            this.AvatarPictureBoxProfile.TabStop = false;
            // 
            // SettingsSidePanel
            // 
            this.SettingsSidePanel.BackColor = System.Drawing.Color.Gray;
            this.SettingsSidePanel.Controls.Add(this.LoadAvatarButton);
            this.SettingsSidePanel.Controls.Add(this.AvatarPictureBoxSettings);
            this.SettingsSidePanel.Location = new System.Drawing.Point(109, 1);
            this.SettingsSidePanel.Name = "SettingsSidePanel";
            this.SettingsSidePanel.Size = new System.Drawing.Size(153, 509);
            this.SettingsSidePanel.TabIndex = 7;
            // 
            // LoadAvatarButton
            // 
            this.LoadAvatarButton.BackColor = System.Drawing.Color.Black;
            this.LoadAvatarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadAvatarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadAvatarButton.ForeColor = System.Drawing.Color.Silver;
            this.LoadAvatarButton.Location = new System.Drawing.Point(19, 118);
            this.LoadAvatarButton.Name = "LoadAvatarButton";
            this.LoadAvatarButton.Size = new System.Drawing.Size(111, 28);
            this.LoadAvatarButton.TabIndex = 3;
            this.LoadAvatarButton.Text = " Încarcă";
            this.LoadAvatarButton.UseVisualStyleBackColor = false;
            this.LoadAvatarButton.Click += new System.EventHandler(this.LoadAvatarButton_Click_1);
            // 
            // AvatarPictureBoxSettings
            // 
            this.AvatarPictureBoxSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AvatarPictureBoxSettings.Location = new System.Drawing.Point(24, 12);
            this.AvatarPictureBoxSettings.Name = "AvatarPictureBoxSettings";
            this.AvatarPictureBoxSettings.Size = new System.Drawing.Size(100, 100);
            this.AvatarPictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBoxSettings.TabIndex = 2;
            this.AvatarPictureBoxSettings.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Black;
            this.SettingsPanel.Controls.Add(this.pictureBox3);
            this.SettingsPanel.Location = new System.Drawing.Point(267, 1);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(722, 508);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsPanel_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(203, 118);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.Black;
            this.ProfilePanel.Controls.Add(this.pictureBox1);
            this.ProfilePanel.Location = new System.Drawing.Point(265, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(722, 508);
            this.ProfilePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ConversationsSidePanel
            // 
            this.ConversationsSidePanel.BackColor = System.Drawing.Color.Gray;
            this.ConversationsSidePanel.Controls.Add(this.vScrollBar2);
            this.ConversationsSidePanel.Location = new System.Drawing.Point(109, 2);
            this.ConversationsSidePanel.Name = "ConversationsSidePanel";
            this.ConversationsSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ConversationsSidePanel.TabIndex = 6;
            // 
            // ContactsSidePanel
            // 
            this.ContactsSidePanel.BackColor = System.Drawing.Color.Gray;
            this.ContactsSidePanel.Controls.Add(this.vScrollBar1);
            this.ContactsSidePanel.Location = new System.Drawing.Point(109, 0);
            this.ContactsSidePanel.Name = "ContactsSidePanel";
            this.ContactsSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ContactsSidePanel.TabIndex = 5;
            // 
            // ConversationPanel
            // 
            this.ConversationPanel.BackColor = System.Drawing.Color.Black;
            this.ConversationPanel.Controls.Add(this.MessageToBeSentBox);
            this.ConversationPanel.Controls.Add(this.sendButton);
            this.ConversationPanel.Location = new System.Drawing.Point(266, 0);
            this.ConversationPanel.Name = "ConversationPanel";
            this.ConversationPanel.Size = new System.Drawing.Size(722, 508);
            this.ConversationPanel.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Black;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.Silver;
            this.sendButton.Location = new System.Drawing.Point(644, 466);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(79, 43);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // MessageToBeSentBox
            // 
            this.MessageToBeSentBox.BackColor = System.Drawing.Color.White;
            this.MessageToBeSentBox.Location = new System.Drawing.Point(-2, 467);
            this.MessageToBeSentBox.Multiline = true;
            this.MessageToBeSentBox.Name = "MessageToBeSentBox";
            this.MessageToBeSentBox.Size = new System.Drawing.Size(647, 41);
            this.MessageToBeSentBox.TabIndex = 0;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.BackColor = System.Drawing.Color.Black;
            this.ContactsPanel.Location = new System.Drawing.Point(266, 0);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(722, 508);
            this.ContactsPanel.TabIndex = 3;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftSidePanel.Controls.Add(this.pictureBox2);
            this.LeftSidePanel.Controls.Add(this.LogoutButton);
            this.LeftSidePanel.Controls.Add(this.SettingsButton);
            this.LeftSidePanel.Controls.Add(this.ContactsButton);
            this.LeftSidePanel.Controls.Add(this.ConversationButton);
            this.LeftSidePanel.Controls.Add(this.ProfileButton);
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 1);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(110, 507);
            this.LeftSidePanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Black;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Silver;
            this.LogoutButton.Location = new System.Drawing.Point(0, 467);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(111, 28);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);

            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Black;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Silver;
            this.SettingsButton.Location = new System.Drawing.Point(-1, 433);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(111, 28);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Setări";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ContactsButton
            // 
            this.ContactsButton.BackColor = System.Drawing.Color.Black;
            this.ContactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsButton.ForeColor = System.Drawing.Color.Silver;
            this.ContactsButton.Location = new System.Drawing.Point(-1, 46);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(111, 28);
            this.ContactsButton.TabIndex = 2;
            this.ContactsButton.Text = "Contacte";
            this.ContactsButton.UseVisualStyleBackColor = false;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // ConversationButton
            // 
            this.ConversationButton.BackColor = System.Drawing.Color.Black;
            this.ConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConversationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationButton.ForeColor = System.Drawing.Color.Silver;
            this.ConversationButton.Location = new System.Drawing.Point(0, 80);
            this.ConversationButton.Name = "ConversationButton";
            this.ConversationButton.Size = new System.Drawing.Size(111, 28);
            this.ConversationButton.TabIndex = 1;
            this.ConversationButton.Text = "Conversații";
            this.ConversationButton.UseVisualStyleBackColor = false;
            this.ConversationButton.Click += new System.EventHandler(this.ConversationButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Black;
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.Silver;
            this.ProfileButton.Location = new System.Drawing.Point(0, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(111, 28);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profil";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextLabel.Location = new System.Drawing.Point(1, 136);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailTextLabel.Size = new System.Drawing.Size(151, 20);
            this.EmailTextLabel.TabIndex = 2;
            this.EmailTextLabel.Text = "danut.duciuc";
            this.EmailTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(135, 2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 506);
            this.vScrollBar1.TabIndex = 0;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(135, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 506);
            this.vScrollBar2.TabIndex = 1;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 508);
            this.Controls.Add(this.ChatMainPanel);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ChatMainPanel.ResumeLayout(false);
            this.ProfileSidePanel.ResumeLayout(false);
            this.ProfileSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).EndInit();
            this.SettingsSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxSettings)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ConversationsSidePanel.ResumeLayout(false);
            this.ContactsSidePanel.ResumeLayout(false);
            this.ConversationPanel.ResumeLayout(false);
            this.ConversationPanel.PerformLayout();
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChatMainPanel;
        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.Button ConversationButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel ConversationPanel;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox MessageToBeSentBox;
        private System.Windows.Forms.Panel ProfileSidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox AvatarPictureBoxProfile;
        private System.Windows.Forms.Panel ConversationsSidePanel;
        private System.Windows.Forms.Panel SettingsSidePanel;
        private System.Windows.Forms.Panel ContactsSidePanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadAvatarButton;
        private System.Windows.Forms.PictureBox AvatarPictureBoxSettings;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}