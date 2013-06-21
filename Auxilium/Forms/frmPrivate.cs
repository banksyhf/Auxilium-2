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

        public frmPrivate(Client client, string username)
        {
            this.Username = username.ToLower();
            this.Client = client;

            InitializeComponent();

            new PrivateMessagesRequest().Execute(client);

            Color color = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;

            panelReadMessage.BackColor = color;
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

            AnimateResize();
        }

        private void AnimateResize()
        {

            new Thread(() =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    lvwPrivateMessages.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                }));

                while (hiddenMessaging.Location.Y + hiddenMessaging.Height + 50 > this.Height)
                {
                    Invoke(new MethodInvoker(() => this.Height += 1));

                    Thread.Sleep(2);
                }

                Invoke(new MethodInvoker(() =>
                {
                    lvwPrivateMessages.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    hiddenMessaging.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
                }));
            }) { IsBackground = true }.Start();

        }

        private void frmPrivate_Shown(object sender, EventArgs e)
        {

        }
    }
}
