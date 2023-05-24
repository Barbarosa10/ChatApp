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
            this.ContactsSidePanel = new System.Windows.Forms.Panel();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactsListView = new System.Windows.Forms.ListView();
            this.ConversationsSidePanel = new System.Windows.Forms.Panel();
            this.ConversationPanel = new System.Windows.Forms.Panel();
            this.MessageToBeSentBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ProfileSidePanel = new System.Windows.Forms.Panel();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.AddContactsPanel = new System.Windows.Forms.Panel();
            this.InsertContactButton = new System.Windows.Forms.Button();
            this.ContactToAddTextBox = new System.Windows.Forms.TextBox();
            this.UsernameToAddLabel = new System.Windows.Forms.Label();
            this.SettingsSidePanel = new System.Windows.Forms.Panel();
            this.LoadAvatarButton = new System.Windows.Forms.Button();
            this.AvatarPictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.ConversationButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ConversationsListView = new System.Windows.Forms.ListView();
            this.ConversationsLabel = new System.Windows.Forms.Label();
            this.AddConversationButton = new System.Windows.Forms.Button();
            this.ChatMainPanel.SuspendLayout();
            this.ContactsSidePanel.SuspendLayout();
            this.ConversationsSidePanel.SuspendLayout();
            this.ConversationPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactAvatarPictureBox)).BeginInit();
            this.ContactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ProfileSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).BeginInit();
            this.AddContactsPanel.SuspendLayout();
            this.SettingsSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxSettings)).BeginInit();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatMainPanel
            // 
            this.ChatMainPanel.BackColor = System.Drawing.Color.Black;
            this.ChatMainPanel.Controls.Add(this.ConversationsSidePanel);
            this.ChatMainPanel.Controls.Add(this.ContactsSidePanel);
            this.ChatMainPanel.Controls.Add(this.AddContactsPanel);
            this.ChatMainPanel.Controls.Add(this.ContactPanel);
            this.ChatMainPanel.Controls.Add(this.ConversationPanel);
            this.ChatMainPanel.Controls.Add(this.ProfilePanel);
            this.ChatMainPanel.Controls.Add(this.ContactsPanel);
            this.ChatMainPanel.Controls.Add(this.SettingsPanel);
            this.ChatMainPanel.Controls.Add(this.ProfileSidePanel);
            this.ChatMainPanel.Controls.Add(this.SettingsSidePanel);
            this.ChatMainPanel.Controls.Add(this.LeftSidePanel);
            this.ChatMainPanel.Location = new System.Drawing.Point(0, -1);
            this.ChatMainPanel.Name = "ChatMainPanel";
            this.ChatMainPanel.Size = new System.Drawing.Size(989, 510);
            this.ChatMainPanel.TabIndex = 0;
            // 
            // ContactsSidePanel
            // 
            this.ContactsSidePanel.BackColor = System.Drawing.Color.Black;
            this.ContactsSidePanel.Controls.Add(this.ContactsLabel);
            this.ContactsSidePanel.Controls.Add(this.AddContactButton);
            this.ContactsSidePanel.Controls.Add(this.ContactsListView);
            this.ContactsSidePanel.Location = new System.Drawing.Point(109, 0);
            this.ContactsSidePanel.Name = "ContactsSidePanel";
            this.ContactsSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ContactsSidePanel.TabIndex = 5;
            // 
            // ContactsLabel
            // 
            this.ContactsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsLabel.ForeColor = System.Drawing.Color.Gray;
            this.ContactsLabel.Location = new System.Drawing.Point(1, 2);
            this.ContactsLabel.Name = "ContactsLabel";
            this.ContactsLabel.Size = new System.Drawing.Size(152, 31);
            this.ContactsLabel.TabIndex = 2;
            this.ContactsLabel.Text = "Contacts";
            this.ContactsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackColor = System.Drawing.Color.Transparent;
            this.AddContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddContactButton.Image = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Image")));
            this.AddContactButton.Location = new System.Drawing.Point(0, 34);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(153, 58);
            this.AddContactButton.TabIndex = 1;
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactsListView
            // 
            this.ContactsListView.BackColor = System.Drawing.Color.Gray;
            this.ContactsListView.CausesValidation = false;
            this.ContactsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContactsListView.FullRowSelect = true;
            this.ContactsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ContactsListView.HideSelection = false;
            this.ContactsListView.Location = new System.Drawing.Point(-1, 94);
            this.ContactsListView.Name = "ContactsListView";
            this.ContactsListView.Size = new System.Drawing.Size(154, 416);
            this.ContactsListView.TabIndex = 0;
            this.ContactsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ConversationsSidePanel
            // 
            this.ConversationsSidePanel.BackColor = System.Drawing.Color.Black;
            this.ConversationsSidePanel.Controls.Add(this.ConversationsLabel);
            this.ConversationsSidePanel.Controls.Add(this.AddConversationButton);
            this.ConversationsSidePanel.Controls.Add(this.ConversationsListView);
            this.ConversationsSidePanel.Location = new System.Drawing.Point(109, 2);
            this.ConversationsSidePanel.Name = "ConversationsSidePanel";
            this.ConversationsSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ConversationsSidePanel.TabIndex = 6;
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
            // MessageToBeSentBox
            // 
            this.MessageToBeSentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageToBeSentBox.BackColor = System.Drawing.Color.White;
            this.MessageToBeSentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageToBeSentBox.Location = new System.Drawing.Point(-2, 467);
            this.MessageToBeSentBox.Multiline = true;
            this.MessageToBeSentBox.Name = "MessageToBeSentBox";
            this.MessageToBeSentBox.Size = new System.Drawing.Size(647, 41);
            this.MessageToBeSentBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Black;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.Silver;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sendButton.Location = new System.Drawing.Point(643, 467);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(79, 43);
            this.sendButton.TabIndex = 1;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
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
            // ContactPanel
            // 
            this.ContactPanel.BackColor = System.Drawing.Color.Black;
            this.ContactPanel.Controls.Add(this.ContactLabel);
            this.ContactPanel.Controls.Add(this.ContactAvatarPictureBox);
            this.ContactPanel.Location = new System.Drawing.Point(264, 1);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Size = new System.Drawing.Size(722, 508);
            this.ContactPanel.TabIndex = 16;
            // 
            // ContactLabel
            // 
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.ForeColor = System.Drawing.Color.White;
            this.ContactLabel.Location = new System.Drawing.Point(270, 136);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactLabel.Size = new System.Drawing.Size(151, 20);
            this.ContactLabel.TabIndex = 3;
            this.ContactLabel.Text = "danut.duciuc";
            this.ContactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactAvatarPictureBox
            // 
            this.ContactAvatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactAvatarPictureBox.Location = new System.Drawing.Point(298, 30);
            this.ContactAvatarPictureBox.Name = "ContactAvatarPictureBox";
            this.ContactAvatarPictureBox.Size = new System.Drawing.Size(100, 100);
            this.ContactAvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContactAvatarPictureBox.TabIndex = 1;
            this.ContactAvatarPictureBox.TabStop = false;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.BackColor = System.Drawing.Color.Black;
            this.ContactsPanel.Controls.Add(this.pictureBox4);
            this.ContactsPanel.Location = new System.Drawing.Point(266, 0);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(722, 508);
            this.ContactsPanel.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(204, 119);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(322, 260);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
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
            // AddContactsPanel
            // 
            this.AddContactsPanel.BackColor = System.Drawing.Color.Black;
            this.AddContactsPanel.Controls.Add(this.InsertContactButton);
            this.AddContactsPanel.Controls.Add(this.ContactToAddTextBox);
            this.AddContactsPanel.Controls.Add(this.UsernameToAddLabel);
            this.AddContactsPanel.Location = new System.Drawing.Point(265, 2);
            this.AddContactsPanel.Name = "AddContactsPanel";
            this.AddContactsPanel.Size = new System.Drawing.Size(722, 508);
            this.AddContactsPanel.TabIndex = 15;
            this.AddContactsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddContactsPanel_Paint);
            // 
            // InsertContactButton
            // 
            this.InsertContactButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.InsertContactButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertContactButton.FlatAppearance.BorderSize = 2;
            this.InsertContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertContactButton.Location = new System.Drawing.Point(289, 88);
            this.InsertContactButton.Name = "InsertContactButton";
            this.InsertContactButton.Size = new System.Drawing.Size(108, 41);
            this.InsertContactButton.TabIndex = 2;
            this.InsertContactButton.Text = "ADD";
            this.InsertContactButton.UseVisualStyleBackColor = false;
            this.InsertContactButton.Click += new System.EventHandler(this.InsertContactButton_Click);
            // 
            // ContactToAddTextBox
            // 
            this.ContactToAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactToAddTextBox.Location = new System.Drawing.Point(327, 43);
            this.ContactToAddTextBox.Name = "ContactToAddTextBox";
            this.ContactToAddTextBox.Size = new System.Drawing.Size(184, 26);
            this.ContactToAddTextBox.TabIndex = 1;
            // 
            // UsernameToAddLabel
            // 
            this.UsernameToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameToAddLabel.ForeColor = System.Drawing.Color.Gray;
            this.UsernameToAddLabel.Location = new System.Drawing.Point(202, 36);
            this.UsernameToAddLabel.Name = "UsernameToAddLabel";
            this.UsernameToAddLabel.Size = new System.Drawing.Size(112, 39);
            this.UsernameToAddLabel.TabIndex = 0;
            this.UsernameToAddLabel.Text = "Username:";
            this.UsernameToAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.Black;
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
            this.pictureBox2.Location = new System.Drawing.Point(-8, 231);
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
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Silver;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.Location = new System.Drawing.Point(0, 444);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(111, 51);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Black;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Silver;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(0, 374);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(111, 54);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ContactsButton
            // 
            this.ContactsButton.BackColor = System.Drawing.Color.Black;
            this.ContactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactsButton.FlatAppearance.BorderSize = 0;
            this.ContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsButton.ForeColor = System.Drawing.Color.Silver;
            this.ContactsButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactsButton.Image")));
            this.ContactsButton.Location = new System.Drawing.Point(-1, 80);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(111, 50);
            this.ContactsButton.TabIndex = 2;
            this.ContactsButton.UseVisualStyleBackColor = false;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // ConversationButton
            // 
            this.ConversationButton.BackColor = System.Drawing.Color.Black;
            this.ConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConversationButton.FlatAppearance.BorderSize = 0;
            this.ConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConversationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationButton.ForeColor = System.Drawing.Color.Silver;
            this.ConversationButton.Image = ((System.Drawing.Image)(resources.GetObject("ConversationButton.Image")));
            this.ConversationButton.Location = new System.Drawing.Point(-1, 145);
            this.ConversationButton.Name = "ConversationButton";
            this.ConversationButton.Size = new System.Drawing.Size(111, 51);
            this.ConversationButton.TabIndex = 1;
            this.ConversationButton.UseVisualStyleBackColor = false;
            this.ConversationButton.Click += new System.EventHandler(this.ConversationButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Black;
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.Silver;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(-1, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(112, 53);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // ConversationsListView
            // 
            this.ConversationsListView.BackColor = System.Drawing.Color.Gray;
            this.ConversationsListView.CausesValidation = false;
            this.ConversationsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConversationsListView.FullRowSelect = true;
            this.ConversationsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ConversationsListView.HideSelection = false;
            this.ConversationsListView.Location = new System.Drawing.Point(-1, 92);
            this.ConversationsListView.Name = "ConversationsListView";
            this.ConversationsListView.Size = new System.Drawing.Size(154, 416);
            this.ConversationsListView.TabIndex = 1;
            this.ConversationsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ConversationsLabel
            // 
            this.ConversationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConversationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationsLabel.ForeColor = System.Drawing.Color.Gray;
            this.ConversationsLabel.Location = new System.Drawing.Point(1, 0);
            this.ConversationsLabel.Name = "ConversationsLabel";
            this.ConversationsLabel.Size = new System.Drawing.Size(152, 31);
            this.ConversationsLabel.TabIndex = 4;
            this.ConversationsLabel.Text = "Conversations";
            this.ConversationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddConversationButton
            // 
            this.AddConversationButton.BackColor = System.Drawing.Color.Transparent;
            this.AddConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddConversationButton.FlatAppearance.BorderSize = 0;
            this.AddConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConversationButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddConversationButton.Image = ((System.Drawing.Image)(resources.GetObject("AddConversationButton.Image")));
            this.AddConversationButton.Location = new System.Drawing.Point(0, 33);
            this.AddConversationButton.Name = "AddConversationButton";
            this.AddConversationButton.Size = new System.Drawing.Size(153, 58);
            this.AddConversationButton.TabIndex = 3;
            this.AddConversationButton.UseVisualStyleBackColor = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 509);
            this.Controls.Add(this.ChatMainPanel);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ChatMainPanel.ResumeLayout(false);
            this.ContactsSidePanel.ResumeLayout(false);
            this.ConversationsSidePanel.ResumeLayout(false);
            this.ConversationPanel.ResumeLayout(false);
            this.ConversationPanel.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContactPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactAvatarPictureBox)).EndInit();
            this.ContactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ProfileSidePanel.ResumeLayout(false);
            this.ProfileSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).EndInit();
            this.AddContactsPanel.ResumeLayout(false);
            this.AddContactsPanel.PerformLayout();
            this.SettingsSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxSettings)).EndInit();
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
        private System.Windows.Forms.ListView ContactsListView;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Label ContactsLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel AddContactsPanel;
        private System.Windows.Forms.TextBox ContactToAddTextBox;
        private System.Windows.Forms.Label UsernameToAddLabel;
        private System.Windows.Forms.Button InsertContactButton;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.PictureBox ContactAvatarPictureBox;
        private System.Windows.Forms.Label ConversationsLabel;
        private System.Windows.Forms.Button AddConversationButton;
        private System.Windows.Forms.ListView ConversationsListView;
    }
}