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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearChat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrivateMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNews = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSendSuggestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSource = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsersPlaceHolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.rankList = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenMain = new Auxilium.Controls.HiddenTab();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.splitContainerUserList = new System.Windows.Forms.SplitContainer();
            this.splitContainerChat = new System.Windows.Forms.SplitContainer();
            this.rtbChat = new Auxilium.Controls.ExRichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.treeUsers = new Auxilium.Controls.TreeView();
            this.tabReconnect = new System.Windows.Forms.TabPage();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.cmsNotifyIcon.SuspendLayout();
            this.hiddenMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.splitContainerUserList.Panel1.SuspendLayout();
            this.splitContainerUserList.Panel2.SuspendLayout();
            this.splitContainerUserList.SuspendLayout();
            this.splitContainerChat.Panel1.SuspendLayout();
            this.splitContainerChat.Panel2.SuspendLayout();
            this.splitContainerChat.SuspendLayout();
            this.tabReconnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.Enabled = false;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmPrivateMessages,
            this.tsmHelp,
            this.tsmSource});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.msMenu.Size = new System.Drawing.Size(594, 24);
            this.msMenu.TabIndex = 14;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOptions,
            this.tsmChangeFont,
            this.tsmClearChat,
            this.toolStripSeparator1,
            this.tsmCheckForUpdates,
            this.toolStripSeparator3,
            this.tsmEditProfile,
            this.tsmSignOut});
            this.tsmMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmMenu.Image")));
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(65, 22);
            this.tsmMenu.Text = "Menu";
            // 
            // tsmOptions
            // 
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Size = new System.Drawing.Size(171, 22);
            this.tsmOptions.Text = "Options";
            this.tsmOptions.Click += new System.EventHandler(this.tsmOptions_Click);
            // 
            // tsmChangeFont
            // 
            this.tsmChangeFont.Name = "tsmChangeFont";
            this.tsmChangeFont.Size = new System.Drawing.Size(171, 22);
            this.tsmChangeFont.Text = "Change Font";
            this.tsmChangeFont.Click += new System.EventHandler(this.tsmChangeFont_Click);
            // 
            // tsmClearChat
            // 
            this.tsmClearChat.Name = "tsmClearChat";
            this.tsmClearChat.Size = new System.Drawing.Size(171, 22);
            this.tsmClearChat.Text = "Clear Chat";
            this.tsmClearChat.Click += new System.EventHandler(this.tsmClearChat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // tsmCheckForUpdates
            // 
            this.tsmCheckForUpdates.Name = "tsmCheckForUpdates";
            this.tsmCheckForUpdates.Size = new System.Drawing.Size(171, 22);
            this.tsmCheckForUpdates.Text = "Check For Updates";
            this.tsmCheckForUpdates.Click += new System.EventHandler(this.tsmCheckForUpdates_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // tsmEditProfile
            // 
            this.tsmEditProfile.Enabled = false;
            this.tsmEditProfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditProfile.Image")));
            this.tsmEditProfile.Name = "tsmEditProfile";
            this.tsmEditProfile.Size = new System.Drawing.Size(171, 22);
            this.tsmEditProfile.Text = "Edit Profile";
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmSignOut.Image")));
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(171, 22);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // tsmPrivateMessages
            // 
            this.tsmPrivateMessages.Image = ((System.Drawing.Image)(resources.GetObject("tsmPrivateMessages.Image")));
            this.tsmPrivateMessages.Name = "tsmPrivateMessages";
            this.tsmPrivateMessages.Size = new System.Drawing.Size(56, 22);
            this.tsmPrivateMessages.Text = "PMs";
            this.tsmPrivateMessages.Click += new System.EventHandler(this.tsmPrivateMessages_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNews,
            this.toolStripSeparator4,
            this.tsmSendSuggestion,
            this.toolStripSeparator2,
            this.tsmVersion,
            this.tsmPing});
            this.tsmHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmHelp.Image")));
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(59, 22);
            this.tsmHelp.Text = "Help";
            // 
            // tsmNews
            // 
            this.tsmNews.Image = ((System.Drawing.Image)(resources.GetObject("tsmNews.Image")));
            this.tsmNews.Name = "tsmNews";
            this.tsmNews.Size = new System.Drawing.Size(162, 22);
            this.tsmNews.Text = "News";
            this.tsmNews.Click += new System.EventHandler(this.tsmNews_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmSendSuggestion
            // 
            this.tsmSendSuggestion.Name = "tsmSendSuggestion";
            this.tsmSendSuggestion.Size = new System.Drawing.Size(162, 22);
            this.tsmSendSuggestion.Text = "Send Suggestion";
            this.tsmSendSuggestion.Click += new System.EventHandler(this.tsmSendSuggestion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmVersion
            // 
            this.tsmVersion.Name = "tsmVersion";
            this.tsmVersion.Size = new System.Drawing.Size(162, 22);
            this.tsmVersion.Text = "Version: ";
            // 
            // tsmPing
            // 
            this.tsmPing.Name = "tsmPing";
            this.tsmPing.Size = new System.Drawing.Size(162, 22);
            this.tsmPing.Text = "Ping: ";
            // 
            // tsmSource
            // 
            this.tsmSource.Image = ((System.Drawing.Image)(resources.GetObject("tsmSource.Image")));
            this.tsmSource.Name = "tsmSource";
            this.tsmSource.Size = new System.Drawing.Size(70, 22);
            this.tsmSource.Text = "Source";
            this.tsmSource.Click += new System.EventHandler(this.tsmSource_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 149;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.tslSpacer,
            this.lblUsersPlaceHolder});
            this.statusMain.Location = new System.Drawing.Point(0, 337);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(594, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 15;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(164, 17);
            this.lblStatus.Text = "Status: Connecting to server...";
            // 
            // tslSpacer
            // 
            this.tslSpacer.Name = "tslSpacer";
            this.tslSpacer.Size = new System.Drawing.Size(330, 17);
            this.tslSpacer.Spring = true;
            // 
            // lblUsersPlaceHolder
            // 
            this.lblUsersPlaceHolder.Name = "lblUsersPlaceHolder";
            this.lblUsersPlaceHolder.Size = new System.Drawing.Size(85, 17);
            this.lblUsersPlaceHolder.Text = "Users Online: 0";
            // 
            // rankList
            // 
            this.rankList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.rankList.ImageSize = new System.Drawing.Size(16, 16);
            this.rankList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auxilium";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(93, 26);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(92, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // hiddenMain
            // 
            this.hiddenMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenMain.Controls.Add(this.tabLogin);
            this.hiddenMain.Controls.Add(this.tabRegister);
            this.hiddenMain.Controls.Add(this.tabChat);
            this.hiddenMain.Controls.Add(this.tabReconnect);
            this.hiddenMain.DesignerIndex = 2;
            this.hiddenMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenMain.Location = new System.Drawing.Point(12, 34);
            this.hiddenMain.Name = "hiddenMain";
            this.hiddenMain.SelectedIndex = 0;
            this.hiddenMain.Size = new System.Drawing.Size(570, 291);
            this.hiddenMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabLogin.Controls.Add(this.cbAuto);
            this.tabLogin.Controls.Add(this.cbRemember);
            this.tabLogin.Controls.Add(this.btnCreate);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Controls.Add(this.lbUser);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.lbPass);
            this.tabLogin.Location = new System.Drawing.Point(0, 0);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(570, 291);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "tabPage1";
            // 
            // cbAuto
            // 
            this.cbAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAuto.AutoSize = true;
            this.cbAuto.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuto.Location = new System.Drawing.Point(237, 141);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(147, 16);
            this.cbAuto.TabIndex = 29;
            this.cbAuto.Text = "Sign me in automatically";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // cbRemember
            // 
            this.cbRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.Location = new System.Drawing.Point(237, 119);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(95, 16);
            this.cbRemember.TabIndex = 28;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(237, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 27);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create new account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(237, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 27);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "Sign into account";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(237, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 21);
            this.txtUsername.TabIndex = 22;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(175, 71);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(56, 12);
            this.lbUser.TabIndex = 24;
            this.lbUser.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(237, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(159, 21);
            this.txtPassword.TabIndex = 23;
            // 
            // lbPass
            // 
            this.lbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(175, 97);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 12);
            this.lbPass.TabIndex = 25;
            this.lbPass.Text = "Password";
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.SystemColors.Control;
            this.tabRegister.Controls.Add(this.regEmail);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Controls.Add(this.btnReturn);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.regPassword);
            this.tabRegister.Controls.Add(this.lblRegPassword);
            this.tabRegister.Controls.Add(this.lblRegUsername);
            this.tabRegister.Controls.Add(this.regUsername);
            this.tabRegister.Location = new System.Drawing.Point(0, 0);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(570, 291);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "tabPage2";
            // 
            // regEmail
            // 
            this.regEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.Location = new System.Drawing.Point(236, 118);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(160, 22);
            this.regEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(236, 174);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(77, 27);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(319, 174);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 27);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // regPassword
            // 
            this.regPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(236, 146);
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '•';
            this.regPassword.Size = new System.Drawing.Size(160, 22);
            this.regPassword.TabIndex = 14;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.Location = new System.Drawing.Point(174, 149);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(56, 13);
            this.lblRegPassword.TabIndex = 13;
            this.lblRegPassword.Text = "Password";
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUsername.Location = new System.Drawing.Point(174, 94);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(58, 13);
            this.lblRegUsername.TabIndex = 9;
            this.lblRegUsername.Text = "Username";
            // 
            // regUsername
            // 
            this.regUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(236, 90);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(160, 22);
            this.regUsername.TabIndex = 10;
            // 
            // tabChat
            // 
            this.tabChat.BackColor = System.Drawing.SystemColors.Control;
            this.tabChat.Controls.Add(this.splitContainerUserList);
            this.tabChat.Location = new System.Drawing.Point(0, 0);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(570, 291);
            this.tabChat.TabIndex = 2;
            this.tabChat.Text = "tabPage3";
            // 
            // splitContainerUserList
            // 
            this.splitContainerUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUserList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerUserList.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUserList.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerUserList.Name = "splitContainerUserList";
            // 
            // splitContainerUserList.Panel1
            // 
            this.splitContainerUserList.Panel1.Controls.Add(this.splitContainerChat);
            // 
            // splitContainerUserList.Panel2
            // 
            this.splitContainerUserList.Panel2.Controls.Add(this.treeUsers);
            this.splitContainerUserList.Panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerUserList.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splitContainerUserList.Size = new System.Drawing.Size(570, 291);
            this.splitContainerUserList.SplitterDistance = 413;
            this.splitContainerUserList.TabIndex = 22;
            // 
            // splitContainerChat
            // 
            this.splitContainerChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChat.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerChat.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChat.Name = "splitContainerChat";
            this.splitContainerChat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChat.Panel1
            // 
            this.splitContainerChat.Panel1.Controls.Add(this.rtbChat);
            this.splitContainerChat.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainerChat.Panel2
            // 
            this.splitContainerChat.Panel2.Controls.Add(this.rtbMessage);
            this.splitContainerChat.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splitContainerChat.Panel2MinSize = 20;
            this.splitContainerChat.Size = new System.Drawing.Size(413, 291);
            this.splitContainerChat.SplitterDistance = 230;
            this.splitContainerChat.TabIndex = 20;
            // 
            // rtbChat
            // 
            this.rtbChat.AutoWordSelection = true;
            this.rtbChat.BackColor = System.Drawing.SystemColors.Window;
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChat.Location = new System.Drawing.Point(1, 1);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbChat.Size = new System.Drawing.Size(411, 228);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            this.rtbChat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbChat_LinkClicked);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.HideSelection = false;
            this.rtbMessage.Location = new System.Drawing.Point(1, 1);
            this.rtbMessage.MaxLength = 1024;
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(411, 55);
            this.rtbMessage.TabIndex = 12;
            this.rtbMessage.Text = "";
            this.rtbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMessage_KeyDown);
            // 
            // treeUsers
            // 
            this.treeUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeUsers.ImageIndex = 0;
            this.treeUsers.ImageList = this.rankList;
            this.treeUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.treeUsers.Location = new System.Drawing.Point(1, 1);
            this.treeUsers.Name = "treeUsers";
            this.treeUsers.SelectedImageIndex = 0;
            this.treeUsers.ShowLines = false;
            this.treeUsers.Size = new System.Drawing.Size(151, 289);
            this.treeUsers.TabIndex = 20;
            this.treeUsers.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeUsers_NodeMouseDoubleClick);
            // 
            // tabReconnect
            // 
            this.tabReconnect.BackColor = System.Drawing.SystemColors.Control;
            this.tabReconnect.Controls.Add(this.btnReconnect);
            this.tabReconnect.Location = new System.Drawing.Point(0, 0);
            this.tabReconnect.Name = "tabReconnect";
            this.tabReconnect.Size = new System.Drawing.Size(570, 291);
            this.tabReconnect.TabIndex = 3;
            // 
            // btnReconnect
            // 
            this.btnReconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReconnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconnect.Location = new System.Drawing.Point(206, 132);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(159, 27);
            this.btnReconnect.TabIndex = 13;
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 359);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.hiddenMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(484, 300);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auxilium";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.cmsNotifyIcon.ResumeLayout(false);
            this.hiddenMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.splitContainerUserList.Panel1.ResumeLayout(false);
            this.splitContainerUserList.Panel2.ResumeLayout(false);
            this.splitContainerUserList.ResumeLayout(false);
            this.splitContainerChat.Panel1.ResumeLayout(false);
            this.splitContainerChat.Panel2.ResumeLayout(false);
            this.splitContainerChat.ResumeLayout(false);
            this.tabReconnect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.HiddenTab hiddenMain;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.SplitContainer splitContainerUserList;
        private System.Windows.Forms.SplitContainer splitContainerChat;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmEditProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem tsmPrivateMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmNews;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmPing;
        private System.Windows.Forms.ToolStripMenuItem tsmSource;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Controls.TreeView treeUsers;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ImageList rankList;
        private Controls.ExRichTextBox rtbChat;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeFont;
        private System.Windows.Forms.ToolStripMenuItem tsmClearChat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabReconnect;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslSpacer;
        private System.Windows.Forms.ToolStripStatusLabel lblUsersPlaceHolder;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCheckForUpdates;
        internal System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmSendSuggestion;
    }
}

