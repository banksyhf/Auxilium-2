using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Auxilium.Controls;
using Auxilium.Core;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium.Updating;
using Microsoft.Win32;

namespace Auxilium.Forms
{
    public partial class frmMain : Form
    {
        public Client Client { get; set; }

        private string Username { get; set; }

        private Options Options { get; set; }

        private Dictionary<int, UserInfo> Users { get; set; }

        private SoundPlayer AudioPlayer { get; set; }

        private Updater Updater { get; set; }

        private bool _autoLogin;
        private bool _initialized;

        public bool Initialized
        {
            get
            {
                return _initialized;
            }
            set
            {
                _initialized = value;
                if (_autoLogin)
                    btnLogin.PerformClick();
            }
        }

        private int _currentChannel = 0;

        internal frmMain(Client client)
        {
            Updater = new Updater("https://s3-us-west-2.amazonaws.com/auxilium2/updater.xml", Application.ProductVersion);

            Options = Options.Load();

            Client = client;

            AudioPlayer = new SoundPlayer(Properties.Resources.Notify);

            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            new Thread(CheckForUpdates) { IsBackground = true }.Start();

            AeroRenderer renderer = new AeroRenderer(ToolbarTheme.Toolbar, true);

            msMenu.Renderer = renderer;
            cmsNotifyIcon.Renderer = renderer;

            tsmVersion.Text += Application.ProductVersion;

            AddResourceToImageList("Auxilium.Images.channel-icon.png");

            for (int i = 1; i <= 42; i++)
                AddResourceToImageList("Auxilium.Images.Ranks." + i + ".png");

            SendPing();
            System.Timers.Timer pingTimer = new System.Timers.Timer(30000);
            pingTimer.Elapsed += (x, i) => SendPing();
            pingTimer.Start();

            Color borderColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;

            splitContainerChat.Panel1.BackColor = borderColor;
            splitContainerChat.Panel2.BackColor = borderColor;
            splitContainerUserList.Panel2.BackColor = borderColor;

            CheckLoginRegistry();
        }

        private void CheckForUpdates()
        {
            while (true)
            {
                try
                {
                    if (Updater.UpdateAvailable())
                    {
                        this.Updater.UpdaterOpen = true;
                        Invoke(new MethodInvoker(() => new frmUpdater(this.Updater).ShowDialog()));
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.ToString());
                }
                Thread.Sleep(150000);
            }
        }

        #region " Packet Handlers "

        internal void HandleChannelList(ChannelList list)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => HandleChannelList(list)));
                return;
            }
            treeUsers.BeginUpdate();
            treeUsers.Nodes.Clear();

            Users = new Dictionary<int, UserInfo>();

            foreach (ChannelInfo channel in list.Channels)
            {
                TreeNode node = new TreeNode(channel.Name) { Tag = channel };
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
                node.ForeColor = Color.FromArgb(0, 120, 220);
                treeUsers.Nodes.Add(node);

                if (channel.Users != null)
                {
                    foreach (UserInfo user in channel.Users)
                    {
                        if (user.Name.ToLower() == this.Username.ToLower())
                            this._currentChannel = node.Index;

                        TreeNode childNode = node.Nodes.Add(user.Name);

                        childNode.ImageIndex = user.Rank + 1;
                        childNode.SelectedImageIndex = user.Rank + 1;

                        Users.Add(user.ID, user);
                    }
                }
            }
            treeUsers.ExpandAll();
            treeUsers.EndUpdate();

            UpdateUserCount(Users.Count);

            UpdateStatus(string.Format("Status: Chatting in {0}", list.Channels.First(x => x.ID == list.CurrentChannel).Name));
        }

        internal void HandleLoginResponse(LoginResponse login)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => HandleLoginResponse(login)));
                return;
            }

            if (login.Successful)
            {
                ChangeTab(MainIndex.Chat);
                msMenu.Enabled = true;
                UpdateStatus("Username: " + Username);
            }
            else
            {
                UpdateStatus("Status: Failed to login.");
            }

            if (login.Message != null)
                MessageBox.Show(login.Message, "", MessageBoxButtons.OK, (MessageBoxIcon)login.ErrorCode);
        }

        internal void HandleRegisterResponse(RegisterResponse register)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => HandleRegisterResponse(register)));
                return;
            }

            if (register.Successful)
            {
                ChangeTab(MainIndex.Login);
                UpdateStatus("Status: Registered.");
            }
            else
                UpdateStatus("Status: Registration failed.");

            if (register.Message != null)
                MessageBox.Show(register.Message, "", MessageBoxButtons.OK, (MessageBoxIcon)register.ErrorCode);
        }

        internal void HandleBroadcastMessage(BroadcastMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => HandleBroadcastMessage(message)));
                return;
            }

            UserInfo user = Users[message.ID];

            AppendChat(GetRankColor(user.Rank), Color.Black, message.Username, message.Text, message.Time.ToLocalTime());

            if (Options.ChatNotifications && !IsForegroundWindow)
            {
                NativeMethods.FlashWindow(this.Handle, true);
                notifyIcon.ShowBalloonTip(100, user.Name, message.Text, ToolTipIcon.Info);

                if (Options.AudioNotification)
                    AudioPlayer.Play();
            }
        }

        #endregion " Packet Handlers "

        #region " Control Events "

        #region " Network Controls "

        private void treeUsers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
                return;
            if (e.Node.Index == this._currentChannel)
                return;

            ChannelInfo channelInfo = (ChannelInfo)e.Node.Tag;

            new ChangeChannel(channelInfo.ID).Execute(Client);

            rtbChat.Text = null;
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            new Register(regUsername.Text, regPassword.Text, regEmail.Text, Client.HashAlgorithm).Execute(Client);
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            ChangeTab(MainIndex.Login);
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            _autoLogin = false;

            RegistryKey rKey = Registry.CurrentUser.OpenSubKey("Software\\Auxilium2", true) ??
                                   Registry.CurrentUser.CreateSubKey("Software\\Auxilium2");

            if (cbRemember.Checked)
            {
                if (rKey != null)
                {
                    rKey.SetValue("Username", txtUsername.Text.Trim());
                    rKey.SetValue("Password", txtPassword.Text.Trim());
                    rKey.SetValue("AutoLogin", cbAuto.Checked);
                }
            }
            else
            {
                if (rKey != null)
                {
                    rKey.SetValue("Username", string.Empty);
                    rKey.SetValue("Password", string.Empty);
                    rKey.SetValue("AutoLogin", false);
                }
            }

            Username = txtUsername.Text.Trim();
            new Login(Username, txtPassword.Text.Trim(), Client.HashAlgorithm).Execute(Client);
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            ChangeTab(MainIndex.Register);
        }

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string message = rtbMessage.Text.Trim();

                if (!string.IsNullOrEmpty(message))
                {
                    //Send the chat message to the server.
                    //byte[] data = Packer.Serialize((byte)ClientPacket.ChatMessage, message);
                    //Connection.Send(data);
                    new ClientMessage(message).Execute(Client);

                    //Show message locally. May want to wait for verification from server.
                    AppendChat(Color.ForestGreen, Color.DimGray, Username, message, DateTime.Now);

                    rtbMessage.Clear();
                }
            }
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {
            Program.Connect();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            Program.Connect();
        }

        #endregion " Network Controls "

        private void tsmOptions_Click(object sender, EventArgs e)
        {
            using (frmOptions frm = new frmOptions(this.Options))
            {
                frm.ShowDialog();

                this.Options = frm.Options;
            }
        }

        private void tsmSource_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BanksyHF/Auxilium-2");
        }

        private void tsmChangeFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtbChat.Font;

            if (fd.ShowDialog() != DialogResult.OK)
                return;

            //We lose all our color coding so let's clear these.
            rtbChat.Clear();
            rtbMessage.Clear();

            rtbChat.Font = fd.Font;
            rtbMessage.Font = fd.Font;
        }

        private void tsmClearChat_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && Options.MinimizeToTray)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (hiddenMain.SelectedIndex == (int)MainIndex.Chat)
                rtbMessage.Select();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbChat_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void tsmNews_Click(object sender, EventArgs e)
        {
            new frmNews(this.Updater.ChangeLog).ShowDialog();
        }

        private void tsmCheckForUpdates_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                this.Updater.UpdaterOpen = false;
                if (this.Updater.UpdateAvailable())
                    new frmUpdater(this.Updater).ShowDialog();
                else
                    MessageBox.Show("No update available.", "No update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }) { IsBackground = true }.Start();
        }

        private void tsmSendSuggestion_Click(object sender, EventArgs e)
        {
            new frmSuggestion(this.Username, this.Client).ShowDialog();
        }

        #endregion " Control Events "

        #region " Chat Methods "

        private void AppendChat(Color nameColor, Color msgColor, string name, string message, DateTime time)
        {
            string sender = string.Format("{0}: ", name);

            if (Options.Timestamps)
                sender = string.Format("[{0}] {1}", time.ToShortTimeString(), sender);

            AppendText(nameColor, sender);
            AppendText(msgColor, message);
            AppendLine();

            if (Options.SpaceMessages)
                AppendLine();
        }

        private void AppendText(Color c, string text)
        {
            rtbChat.AppendText(c, text);
        }

        private void AppendLine()
        {
            rtbChat.AppendText(Color.Empty, Environment.NewLine);
        }

        #endregion " Chat Methods "

        #region " Other Methods "

        private void CheckLoginRegistry()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Auxilium2");

            if (rk != null)
            {
                string[] names = rk.GetValueNames();
                string username = string.Empty;
                string password = string.Empty;

                if (names.Contains("Username") && !(username = (string)rk.GetValue("Username")).IsNullOrWhiteSpace())
                {
                    txtUsername.Text = username;
                    cbRemember.Checked = true;
                }
                if (names.Contains("Password") && !(password = (string)rk.GetValue("Password")).IsNullOrWhiteSpace())
                {
                    txtPassword.Text = password;
                    cbRemember.Checked = true;
                }
                if (names.Contains("AutoLogin"))
                {
                    if (Convert.ToBoolean((string)rk.GetValue("AutoLogin")) && !string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        cbAuto.Checked = true;
                        _autoLogin = true;
                    }
                }
            }
        }

        internal void ChangeTab(MainIndex index)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => ChangeTab(index)));
                return;
            }
            hiddenMain.SelectedIndex = (int)index;

            if (index == MainIndex.Login)
            {
                this.AcceptButton = btnLogin;

                rtbChat.Clear();
                rtbMessage.Clear();

                regUsername.Clear();
                regPassword.Clear();
                regEmail.Clear();
            }
            else if (index == MainIndex.Register)
            {
                this.AcceptButton = btnRegister;
            }
            else
            {
                this.AcceptButton = null;
            }
        }

        private Color GetRankColor(byte rank)
        {
            switch (rank)
            {
                case (byte)SpecialRank.Admin:
                    return Color.Red;
                default:
                    return Color.Blue;
            }
        }

        private void AddResourceToImageList(string name)
        {
            Bitmap bmp = GetBitmapFromResource(name);
            rankList.Images.Add(bmp);
        }

        private Bitmap GetBitmapFromResource(string name)
        {
            return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
        }

        internal void UpdateStatus(string text)
        {
            lblStatus.Text = text;
        }

        internal void UpdateUserCount(int users)
        {
            lblUsersPlaceHolder.Text = "Users Online: " + users;
        }

        private void SendPing()
        {
            Ping ping = new Ping();
            ping.PingCompleted += (sender, e) =>
            {
                tsmPing.Text = "Ping: " +
                    (e.Reply.Status == IPStatus.Success ? e.Reply.RoundtripTime.ToString() + " ms"
                    : "N/A");
            };
            ping.SendAsync(Client.EndPoint.Address, null);
        }

        public bool IsForegroundWindow
        {
            get
            {
                return (this.Handle == NativeMethods.GetForegroundWindow());
            }
        }

        #endregion " Other Methods "

        private void tsmPrivateMessages_Click(object sender, EventArgs e)
        {
            new frmPrivate(Client, Username).ShowDialog();
        }


    }
}