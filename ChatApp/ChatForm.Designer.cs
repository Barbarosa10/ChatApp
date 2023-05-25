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
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.ConversationMainPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ProfileSidePanel = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConversationPanel = new System.Windows.Forms.Panel();
            this.ConversationWithMessagesPanel = new System.Windows.Forms.Panel();
            this.TopConversationPanel = new System.Windows.Forms.Panel();
            this.ConversationTopLabel = new System.Windows.Forms.Label();
            this.ConversationTopAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteConversationButton = new System.Windows.Forms.Button();
            this.MessageToBeSentBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ConversationsSidePanel = new System.Windows.Forms.Panel();
            this.ConversationsLabel = new System.Windows.Forms.Label();
            this.AddConversationButton = new System.Windows.Forms.Button();
            this.ConversationsListView = new System.Windows.Forms.ListView();
            this.AddConversationPanel = new System.Windows.Forms.Panel();
            this.InsertConversationButton = new System.Windows.Forms.Button();
            this.ConversationToAddTextBox = new System.Windows.Forms.TextBox();
            this.ConversationToAddLabel = new System.Windows.Forms.Label();
            this.AddContactsPanel = new System.Windows.Forms.Panel();
            this.InsertContactButton = new System.Windows.Forms.Button();
            this.ContactToAddTextBox = new System.Windows.Forms.TextBox();
            this.UsernameToAddLabel = new System.Windows.Forms.Label();
            this.ContactsSidePanel = new System.Windows.Forms.Panel();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactsListView = new System.Windows.Forms.ListView();
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
            this.ChatMainPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactAvatarPictureBox)).BeginInit();
            this.ConversationMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.ProfileSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ConversationPanel.SuspendLayout();
            this.TopConversationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConversationTopAvatarPictureBox)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ConversationsSidePanel.SuspendLayout();
            this.AddConversationPanel.SuspendLayout();
            this.AddContactsPanel.SuspendLayout();
            this.ContactsSidePanel.SuspendLayout();
            this.SettingsSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxSettings)).BeginInit();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatMainPanel
            // 
            this.ChatMainPanel.BackColor = System.Drawing.Color.Black;
            this.ChatMainPanel.Controls.Add(this.AddContactsPanel);
            this.ChatMainPanel.Controls.Add(this.ContactsPanel);
            this.ChatMainPanel.Controls.Add(this.ContactPanel);
            this.ChatMainPanel.Controls.Add(this.ConversationMainPanel);
            this.ChatMainPanel.Controls.Add(this.ProfileSidePanel);
            this.ChatMainPanel.Controls.Add(this.ProfilePanel);
            this.ChatMainPanel.Controls.Add(this.ConversationPanel);
            this.ChatMainPanel.Controls.Add(this.SettingsPanel);
            this.ChatMainPanel.Controls.Add(this.ConversationsSidePanel);
            this.ChatMainPanel.Controls.Add(this.AddConversationPanel);
            this.ChatMainPanel.Controls.Add(this.ContactsSidePanel);
            this.ChatMainPanel.Controls.Add(this.SettingsSidePanel);
            this.ChatMainPanel.Controls.Add(this.LeftSidePanel);
            this.ChatMainPanel.Location = new System.Drawing.Point(0, -1);
            this.ChatMainPanel.Name = "ChatMainPanel";
            this.ChatMainPanel.Size = new System.Drawing.Size(989, 510);
            this.ChatMainPanel.TabIndex = 0;
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
            // ContactPanel
            // 
            this.ContactPanel.BackColor = System.Drawing.Color.Black;
            this.ContactPanel.Controls.Add(this.DeleteContactButton);
            this.ContactPanel.Controls.Add(this.ContactLabel);
            this.ContactPanel.Controls.Add(this.ContactAvatarPictureBox);
            this.ContactPanel.Location = new System.Drawing.Point(264, 1);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Size = new System.Drawing.Size(722, 508);
            this.ContactPanel.TabIndex = 16;
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteContactButton.FlatAppearance.BorderSize = 0;
            this.DeleteContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteContactButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteContactButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteContactButton.Image")));
            this.DeleteContactButton.Location = new System.Drawing.Point(648, 1);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(77, 47);
            this.DeleteContactButton.TabIndex = 13;
            this.DeleteContactButton.UseVisualStyleBackColor = false;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
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
            // ConversationMainPanel
            // 
            this.ConversationMainPanel.BackColor = System.Drawing.Color.Black;
            this.ConversationMainPanel.Controls.Add(this.pictureBox5);
            this.ConversationMainPanel.Location = new System.Drawing.Point(265, 0);
            this.ConversationMainPanel.Name = "ConversationMainPanel";
            this.ConversationMainPanel.Size = new System.Drawing.Size(722, 508);
            this.ConversationMainPanel.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(203, 118);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(322, 260);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // ProfileSidePanel
            // 
            this.ProfileSidePanel.BackColor = System.Drawing.Color.Gray;
            this.ProfileSidePanel.Controls.Add(this.UserLabel);
            this.ProfileSidePanel.Controls.Add(this.UsernameLabel);
            this.ProfileSidePanel.Controls.Add(this.AvatarPictureBoxProfile);
            this.ProfileSidePanel.Location = new System.Drawing.Point(109, 1);
            this.ProfileSidePanel.Name = "ProfileSidePanel";
            this.ProfileSidePanel.Size = new System.Drawing.Size(153, 509);
            this.ProfileSidePanel.TabIndex = 4;
            // 
            // UserLabel
            // 
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(1, 136);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserLabel.Size = new System.Drawing.Size(151, 20);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ConversationPanel
            // 
            this.ConversationPanel.BackColor = System.Drawing.Color.Black;
            this.ConversationPanel.Controls.Add(this.ConversationWithMessagesPanel);
            this.ConversationPanel.Controls.Add(this.TopConversationPanel);
            this.ConversationPanel.Controls.Add(this.MessageToBeSentBox);
            this.ConversationPanel.Controls.Add(this.sendButton);
            this.ConversationPanel.Location = new System.Drawing.Point(266, 0);
            this.ConversationPanel.Name = "ConversationPanel";
            this.ConversationPanel.Size = new System.Drawing.Size(722, 508);
            this.ConversationPanel.TabIndex = 2;
            // 
            // ConversationWithMessagesPanel
            // 
            this.ConversationWithMessagesPanel.BackColor = System.Drawing.Color.Black;
            this.ConversationWithMessagesPanel.Location = new System.Drawing.Point(-2, 48);
            this.ConversationWithMessagesPanel.Name = "ConversationWithMessagesPanel";
            this.ConversationWithMessagesPanel.Size = new System.Drawing.Size(724, 423);
            this.ConversationWithMessagesPanel.TabIndex = 3;
            // 
            // TopConversationPanel
            // 
            this.TopConversationPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.TopConversationPanel.Controls.Add(this.ConversationTopLabel);
            this.TopConversationPanel.Controls.Add(this.ConversationTopAvatarPictureBox);
            this.TopConversationPanel.Controls.Add(this.DeleteConversationButton);
            this.TopConversationPanel.Location = new System.Drawing.Point(-2, 1);
            this.TopConversationPanel.Name = "TopConversationPanel";
            this.TopConversationPanel.Size = new System.Drawing.Size(725, 48);
            this.TopConversationPanel.TabIndex = 2;
            // 
            // ConversationTopLabel
            // 
            this.ConversationTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConversationTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationTopLabel.ForeColor = System.Drawing.Color.Gray;
            this.ConversationTopLabel.Location = new System.Drawing.Point(59, 14);
            this.ConversationTopLabel.Name = "ConversationTopLabel";
            this.ConversationTopLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConversationTopLabel.Size = new System.Drawing.Size(112, 20);
            this.ConversationTopLabel.TabIndex = 3;
            this.ConversationTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConversationTopAvatarPictureBox
            // 
            this.ConversationTopAvatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConversationTopAvatarPictureBox.Location = new System.Drawing.Point(0, 1);
            this.ConversationTopAvatarPictureBox.Name = "ConversationTopAvatarPictureBox";
            this.ConversationTopAvatarPictureBox.Size = new System.Drawing.Size(57, 47);
            this.ConversationTopAvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConversationTopAvatarPictureBox.TabIndex = 3;
            this.ConversationTopAvatarPictureBox.TabStop = false;
            // 
            // DeleteConversationButton
            // 
            this.DeleteConversationButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteConversationButton.FlatAppearance.BorderSize = 0;
            this.DeleteConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteConversationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteConversationButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteConversationButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteConversationButton.Image")));
            this.DeleteConversationButton.Location = new System.Drawing.Point(647, 1);
            this.DeleteConversationButton.Name = "DeleteConversationButton";
            this.DeleteConversationButton.Size = new System.Drawing.Size(77, 47);
            this.DeleteConversationButton.TabIndex = 12;
            this.DeleteConversationButton.UseVisualStyleBackColor = false;
            this.DeleteConversationButton.Click += new System.EventHandler(this.DeleteConversationButton_Click);
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
            this.AddConversationButton.Location = new System.Drawing.Point(0, 32);
            this.AddConversationButton.Name = "AddConversationButton";
            this.AddConversationButton.Size = new System.Drawing.Size(153, 58);
            this.AddConversationButton.TabIndex = 3;
            this.AddConversationButton.UseVisualStyleBackColor = false;
            this.AddConversationButton.Click += new System.EventHandler(this.AddConversationButton_Click);
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
            // AddConversationPanel
            // 
            this.AddConversationPanel.BackColor = System.Drawing.Color.Black;
            this.AddConversationPanel.Controls.Add(this.InsertConversationButton);
            this.AddConversationPanel.Controls.Add(this.ConversationToAddTextBox);
            this.AddConversationPanel.Controls.Add(this.ConversationToAddLabel);
            this.AddConversationPanel.Location = new System.Drawing.Point(265, 3);
            this.AddConversationPanel.Name = "AddConversationPanel";
            this.AddConversationPanel.Size = new System.Drawing.Size(722, 508);
            this.AddConversationPanel.TabIndex = 16;
            // 
            // InsertConversationButton
            // 
            this.InsertConversationButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.InsertConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertConversationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertConversationButton.FlatAppearance.BorderSize = 2;
            this.InsertConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertConversationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertConversationButton.Location = new System.Drawing.Point(289, 88);
            this.InsertConversationButton.Name = "InsertConversationButton";
            this.InsertConversationButton.Size = new System.Drawing.Size(108, 41);
            this.InsertConversationButton.TabIndex = 2;
            this.InsertConversationButton.Text = "ADD";
            this.InsertConversationButton.UseVisualStyleBackColor = false;
            this.InsertConversationButton.Click += new System.EventHandler(this.InsertConversationButton_Click);
            // 
            // ConversationToAddTextBox
            // 
            this.ConversationToAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationToAddTextBox.Location = new System.Drawing.Point(327, 43);
            this.ConversationToAddTextBox.Name = "ConversationToAddTextBox";
            this.ConversationToAddTextBox.Size = new System.Drawing.Size(184, 26);
            this.ConversationToAddTextBox.TabIndex = 1;
            // 
            // ConversationToAddLabel
            // 
            this.ConversationToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationToAddLabel.ForeColor = System.Drawing.Color.Gray;
            this.ConversationToAddLabel.Location = new System.Drawing.Point(202, 36);
            this.ConversationToAddLabel.Name = "ConversationToAddLabel";
            this.ConversationToAddLabel.Size = new System.Drawing.Size(112, 39);
            this.ConversationToAddLabel.TabIndex = 0;
            this.ConversationToAddLabel.Text = "Username:";
            this.ConversationToAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.InsertContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.ContactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ContactPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactAvatarPictureBox)).EndInit();
            this.ConversationMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ProfileSidePanel.ResumeLayout(false);
            this.ProfileSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBoxProfile)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ConversationPanel.ResumeLayout(false);
            this.ConversationPanel.PerformLayout();
            this.TopConversationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConversationTopAvatarPictureBox)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ConversationsSidePanel.ResumeLayout(false);
            this.AddConversationPanel.ResumeLayout(false);
            this.AddConversationPanel.PerformLayout();
            this.AddContactsPanel.ResumeLayout(false);
            this.AddContactsPanel.PerformLayout();
            this.ContactsSidePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label UserLabel;
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
        private System.Windows.Forms.Panel AddConversationPanel;
        private System.Windows.Forms.Button InsertConversationButton;
        private System.Windows.Forms.TextBox ConversationToAddTextBox;
        private System.Windows.Forms.Label ConversationToAddLabel;
        private System.Windows.Forms.Panel ConversationWithMessagesPanel;
        private System.Windows.Forms.Panel TopConversationPanel;
        private System.Windows.Forms.Label ConversationTopLabel;
        private System.Windows.Forms.PictureBox ConversationTopAvatarPictureBox;
        private System.Windows.Forms.Button DeleteConversationButton;
        private System.Windows.Forms.Button DeleteContactButton;
        private System.Windows.Forms.Panel ConversationMainPanel;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}