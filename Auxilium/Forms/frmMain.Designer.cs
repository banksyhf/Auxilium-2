namespace Auxilium.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.hiddenTab1 = new Auxilium.Controls.HiddenTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.lvUsers = new Auxilium.Controls.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimestamps = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChatNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTray = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAudibleNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpaceMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserJoinEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWriteMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClearChat = new System.Windows.Forms.ToolStripMenuItem();
            this.pMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDonations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPing = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGetSource = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hiddenTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenTab1
            // 
            this.hiddenTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenTab1.Controls.Add(this.tabPage1);
            this.hiddenTab1.Controls.Add(this.tabPage2);
            this.hiddenTab1.DesignerIndex = 0;
            this.hiddenTab1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenTab1.Location = new System.Drawing.Point(12, 27);
            this.hiddenTab1.Name = "hiddenTab1";
            this.hiddenTab1.SelectedIndex = 0;
            this.hiddenTab1.Size = new System.Drawing.Size(694, 367);
            this.hiddenTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvUsers);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Size = new System.Drawing.Size(688, 361);
            this.splitContainer2.SplitterDistance = 531;
            this.splitContainer2.TabIndex = 22;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbChat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbMessage);
            this.splitContainer1.Panel2MinSize = 20;
            this.splitContainer1.Size = new System.Drawing.Size(531, 361);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 20;
            // 
            // rtbChat
            // 
            this.rtbChat.AcceptsTab = true;
            this.rtbChat.BackColor = System.Drawing.Color.White;
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChat.HideSelection = false;
            this.rtbChat.Location = new System.Drawing.Point(0, 0);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbChat.Size = new System.Drawing.Size(531, 316);
            this.rtbChat.TabIndex = 8;
            this.rtbChat.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.HideSelection = false;
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.MaxLength = 1024;
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(531, 41);
            this.rtbMessage.TabIndex = 12;
            this.rtbMessage.Text = "";
            // 
            // lvUsers
            // 
            this.lvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUsers.AutoArrange = false;
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvUsers.Location = new System.Drawing.Point(0, 0);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(153, 334);
            this.lvUsers.TabIndex = 20;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 149;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Channels";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tsmOptions,
            this.pMsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.pauseChatToolStripMenuItem,
            this.tsmGetSource});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.msMenu.Size = new System.Drawing.Size(718, 24);
            this.msMenu.TabIndex = 14;
            this.msMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditProfile,
            this.tsmSignOut});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmEditProfile
            // 
            this.tsmEditProfile.Enabled = false;
            this.tsmEditProfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditProfile.Image")));
            this.tsmEditProfile.Name = "tsmEditProfile";
            this.tsmEditProfile.Size = new System.Drawing.Size(130, 22);
            this.tsmEditProfile.Text = "Edit Profile";
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Enabled = false;
            this.tsmSignOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmSignOut.Image")));
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(130, 22);
            this.tsmSignOut.Text = "Sign Out";
            // 
            // tsmOptions
            // 
            this.tsmOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTimestamps,
            this.tsmChatNotifications,
            this.tsmTray,
            this.tsmAudibleNotification,
            this.tsmSpaceMessages,
            this.tsmUserJoinEvents,
            this.tsmWriteMessages,
            this.toolStripSeparator1,
            this.changeFontToolStripMenuItem,
            this.toolStripSeparator3,
            this.tsmClearChat});
            this.tsmOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsmOptions.Image")));
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Size = new System.Drawing.Size(77, 22);
            this.tsmOptions.Text = "Options";
            // 
            // tsmTimestamps
            // 
            this.tsmTimestamps.Checked = true;
            this.tsmTimestamps.CheckOnClick = true;
            this.tsmTimestamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmTimestamps.Name = "tsmTimestamps";
            this.tsmTimestamps.Size = new System.Drawing.Size(221, 22);
            this.tsmTimestamps.Text = "Show Timestamps";
            // 
            // tsmChatNotifications
            // 
            this.tsmChatNotifications.Checked = true;
            this.tsmChatNotifications.CheckOnClick = true;
            this.tsmChatNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmChatNotifications.Name = "tsmChatNotifications";
            this.tsmChatNotifications.Size = new System.Drawing.Size(221, 22);
            this.tsmChatNotifications.Text = "Show Chat Notifications";
            // 
            // tsmTray
            // 
            this.tsmTray.CheckOnClick = true;
            this.tsmTray.Name = "tsmTray";
            this.tsmTray.Size = new System.Drawing.Size(221, 22);
            this.tsmTray.Text = "Minimize To Tray";
            // 
            // tsmAudibleNotification
            // 
            this.tsmAudibleNotification.CheckOnClick = true;
            this.tsmAudibleNotification.Name = "tsmAudibleNotification";
            this.tsmAudibleNotification.Size = new System.Drawing.Size(221, 22);
            this.tsmAudibleNotification.Text = "Play Notification Sound";
            // 
            // tsmSpaceMessages
            // 
            this.tsmSpaceMessages.Checked = true;
            this.tsmSpaceMessages.CheckOnClick = true;
            this.tsmSpaceMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmSpaceMessages.Name = "tsmSpaceMessages";
            this.tsmSpaceMessages.Size = new System.Drawing.Size(221, 22);
            this.tsmSpaceMessages.Text = "Space Out Messages";
            // 
            // tsmUserJoinEvents
            // 
            this.tsmUserJoinEvents.CheckOnClick = true;
            this.tsmUserJoinEvents.Name = "tsmUserJoinEvents";
            this.tsmUserJoinEvents.Size = new System.Drawing.Size(221, 22);
            this.tsmUserJoinEvents.Text = "Show User Join/Leave Events";
            // 
            // tsmWriteMessages
            // 
            this.tsmWriteMessages.CheckOnClick = true;
            this.tsmWriteMessages.Name = "tsmWriteMessages";
            this.tsmWriteMessages.Size = new System.Drawing.Size(221, 22);
            this.tsmWriteMessages.Text = "Write Messages To File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font..";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // tsmClearChat
            // 
            this.tsmClearChat.Name = "tsmClearChat";
            this.tsmClearChat.Size = new System.Drawing.Size(221, 22);
            this.tsmClearChat.Text = "Clear Chat";
            // 
            // pMsToolStripMenuItem
            // 
            this.pMsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pMsToolStripMenuItem.Image")));
            this.pMsToolStripMenuItem.Name = "pMsToolStripMenuItem";
            this.pMsToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.pMsToolStripMenuItem.Text = "PMs";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNews,
            this.tsmDonations,
            this.toolStripSeparator2,
            this.tsmVersion,
            this.tsmPing});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmNews
            // 
            this.tsmNews.Image = ((System.Drawing.Image)(resources.GetObject("tsmNews.Image")));
            this.tsmNews.Name = "tsmNews";
            this.tsmNews.Size = new System.Drawing.Size(183, 22);
            this.tsmNews.Text = "News";
            // 
            // tsmDonations
            // 
            this.tsmDonations.Image = ((System.Drawing.Image)(resources.GetObject("tsmDonations.Image")));
            this.tsmDonations.Name = "tsmDonations";
            this.tsmDonations.Size = new System.Drawing.Size(183, 22);
            this.tsmDonations.Text = "Donate (Server Costs)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // tsmVersion
            // 
            this.tsmVersion.Name = "tsmVersion";
            this.tsmVersion.Size = new System.Drawing.Size(183, 22);
            this.tsmVersion.Text = "Version: ";
            // 
            // tsmPing
            // 
            this.tsmPing.Name = "tsmPing";
            this.tsmPing.Size = new System.Drawing.Size(183, 22);
            this.tsmPing.Text = "Ping: ";
            // 
            // pauseChatToolStripMenuItem
            // 
            this.pauseChatToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pauseChatToolStripMenuItem.CheckOnClick = true;
            this.pauseChatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseChatToolStripMenuItem.Image")));
            this.pauseChatToolStripMenuItem.Name = "pauseChatToolStripMenuItem";
            this.pauseChatToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.pauseChatToolStripMenuItem.Text = "Pause Chat";
            // 
            // tsmGetSource
            // 
            this.tsmGetSource.Image = ((System.Drawing.Image)(resources.GetObject("tsmGetSource.Image")));
            this.tsmGetSource.Name = "tsmGetSource";
            this.tsmGetSource.Size = new System.Drawing.Size(70, 22);
            this.tsmGetSource.Text = "Source";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 149;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 406);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.hiddenTab1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.hiddenTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.HiddenTab hiddenTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEditProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmTimestamps;
        private System.Windows.Forms.ToolStripMenuItem tsmChatNotifications;
        private System.Windows.Forms.ToolStripMenuItem tsmTray;
        private System.Windows.Forms.ToolStripMenuItem tsmAudibleNotification;
        private System.Windows.Forms.ToolStripMenuItem tsmSpaceMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmUserJoinEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmWriteMessages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmClearChat;
        private System.Windows.Forms.ToolStripMenuItem pMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNews;
        private System.Windows.Forms.ToolStripMenuItem tsmDonations;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmPing;
        private System.Windows.Forms.ToolStripMenuItem pauseChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmGetSource;
        private Controls.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

