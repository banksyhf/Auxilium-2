using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium.Core;
using System.Threading;

namespace Auxilium.Forms
{
    public partial class frmPrivate : Form
    {
        public string Username { get; set; }
        public Client Client { get; set; }
        private bool _isReplyOpen = false;

        private Thread[] _resizeThreads = new Thread[2];

        public frmPrivate(Client client, string username)
        {
            this.Username = username.ToLower();
            this.Client = client;

            InitializeComponent();

            new PrivateMessagesRequest().Execute(client);

            Color color = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;

            panelReadMessage.BackColor = color;
            panel1.BackColor = color;
        }

        public void AddPrivateMessage(PrivateMessage pm)
        {
            ListViewItem item = new ListViewItem(new[] { pm.Subject, pm.Sender, pm.Recipient, pm.TimeSent.ToLocalTime().ToString("f") });
            item.Group = lvwPrivateMessages.Groups[pm.Sender.ToLower() == this.Username.ToLower() ? 1 : 0];
            lvwPrivateMessages.Items.Add(item);
        }

        private void frmPrivate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void lvwPrivateMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwPrivateMessages.SelectedItems.Count == 0)
                return;

            if (!_isReplyOpen)
            {
                if (_resizeThreads[1] != null && _resizeThreads[1].IsAlive)
                    _resizeThreads[1].Abort();

                AnimateResize();
            }
        }

        private void AnimateResize()
        {

            Thread T = new Thread(() =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                }));
                while (hiddenMessaging.Location.Y + hiddenMessaging.Height + 50 > this.Height)
                {
                    Invoke(new MethodInvoker(() => this.Height += 1));
                    Thread.Sleep(2);
                }

                Invoke(new MethodInvoker(() =>
                {
                    panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
                }));
                _isReplyOpen = true;
            }) { IsBackground = true };

            T.Start();
            _resizeThreads[0] = T;

        }

        private void AnimateDefault()
        {
            Thread T = new Thread(() =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                }));

                while (this.Height > panel1.Location.Y + panel1.Height + 50)
                {
                    Invoke(new MethodInvoker(() => this.Height -= 1));
                    Thread.Sleep(2);
                }

                Invoke(new MethodInvoker(() =>
                {
                    panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
                }));
                _isReplyOpen = false;
            }) { IsBackground = true };

            T.Start();
            _resizeThreads[1] = T;
        }

        private void frmPrivate_Shown(object sender, EventArgs e)
        {

        }

        private void lvwPrivateMessages_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lvwPrivateMessages_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvwPrivateMessages.SelectedItems.Count == 0 && _isReplyOpen)
            {
                if (_resizeThreads[0] != null && _resizeThreads[0].IsAlive)
                    _resizeThreads[0].Abort();

                AnimateDefault();
            }
        }
    }
}
