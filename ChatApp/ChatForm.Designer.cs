
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
            this.ChatMainPanel = new System.Windows.Forms.Panel();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.ConversationButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.ConversationPanel = new System.Windows.Forms.Panel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChatMainPanel.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            this.ConversationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatMainPanel
            // 
            this.ChatMainPanel.BackColor = System.Drawing.Color.Black;
            this.ChatMainPanel.Controls.Add(this.panel1);
            this.ChatMainPanel.Controls.Add(this.ConversationPanel);
            this.ChatMainPanel.Controls.Add(this.SettingsPanel);
            this.ChatMainPanel.Controls.Add(this.ContactsPanel);
            this.ChatMainPanel.Controls.Add(this.ProfilePanel);
            this.ChatMainPanel.Controls.Add(this.LeftSidePanel);
            this.ChatMainPanel.Location = new System.Drawing.Point(0, -1);
            this.ChatMainPanel.Name = "ChatMainPanel";
            this.ChatMainPanel.Size = new System.Drawing.Size(989, 510);
            this.ChatMainPanel.TabIndex = 0;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.SettingsButton.Location = new System.Drawing.Point(0, 114);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(111, 28);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Setări";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ContactsButton
            // 
            this.ContactsButton.BackColor = System.Drawing.Color.Black;
            this.ContactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsButton.ForeColor = System.Drawing.Color.Silver;
            this.ContactsButton.Location = new System.Drawing.Point(0, 80);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(111, 28);
            this.ContactsButton.TabIndex = 2;
            this.ContactsButton.Text = "Contacte";
            this.ContactsButton.UseVisualStyleBackColor = false;
            // 
            // ConversationButton
            // 
            this.ConversationButton.BackColor = System.Drawing.Color.Black;
            this.ConversationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConversationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationButton.ForeColor = System.Drawing.Color.Silver;
            this.ConversationButton.Location = new System.Drawing.Point(0, 46);
            this.ConversationButton.Name = "ConversationButton";
            this.ConversationButton.Size = new System.Drawing.Size(111, 28);
            this.ConversationButton.TabIndex = 1;
            this.ConversationButton.Text = "Conversații";
            this.ConversationButton.UseVisualStyleBackColor = false;
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
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.Black;
            this.ProfilePanel.Location = new System.Drawing.Point(265, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(722, 508);
            this.ProfilePanel.TabIndex = 1;
            // 
            // ConversationPanel
            // 
            this.ConversationPanel.BackColor = System.Drawing.Color.Black;
            this.ConversationPanel.Controls.Add(this.sendButton);
            this.ConversationPanel.Controls.Add(this.textBox1);
            this.ConversationPanel.Location = new System.Drawing.Point(266, 0);
            this.ConversationPanel.Name = "ConversationPanel";
            this.ConversationPanel.Size = new System.Drawing.Size(722, 508);
            this.ConversationPanel.TabIndex = 2;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.BackColor = System.Drawing.Color.Black;
            this.ContactsPanel.Location = new System.Drawing.Point(266, 0);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(722, 508);
            this.ContactsPanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Black;
            this.SettingsPanel.Location = new System.Drawing.Point(267, 1);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(722, 508);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-1, 467);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 41);
            this.textBox1.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Black;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.Silver;
            this.sendButton.Location = new System.Drawing.Point(644, 467);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(76, 43);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(108, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 509);
            this.panel1.TabIndex = 4;
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
            this.LeftSidePanel.ResumeLayout(false);
            this.ConversationPanel.ResumeLayout(false);
            this.ConversationPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}