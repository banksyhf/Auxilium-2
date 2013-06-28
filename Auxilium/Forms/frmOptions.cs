using System;
using System.Windows.Forms;

namespace Auxilium.Forms
{
    public partial class frmOptions : Form
    {
        internal Options Options { get; set; }

        internal frmOptions(Options options)
        {
            InitializeComponent();

            this.Options = options;
            SetOptions(options);
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            Options = new Options()
            {
                Timestamps = cbTimestamps.Checked,
                ChatNotifications = cbNotifications.Checked,
                MinimizeToTray = cbMinimizeToTray.Checked,
                AudioNotification = cbNotificationSound.Checked,
                SpaceMessages = cbSpaceMessages.Checked,
                JoinLeaveEvents = cbUserEvents.Checked,
                WriteMessages = cbWriteMessages.Checked,
                RememberFormSize = cbRememberFormSize.Checked,
                RememberFont = cbRememberFont.Checked
            };

            Options.Save();
        }

        private void SetOptions(Options options)
        {
            cbTimestamps.Checked = options.Timestamps;
            cbNotifications.Checked = options.ChatNotifications;
            cbMinimizeToTray.Checked = options.MinimizeToTray;
            cbNotificationSound.Checked = options.AudioNotification;
            cbSpaceMessages.Checked = options.SpaceMessages;
            cbUserEvents.Checked = options.JoinLeaveEvents;
            cbWriteMessages.Checked = options.WriteMessages;
            cbRememberFormSize.Checked = options.RememberFormSize;
            cbRememberFont.Checked = options.RememberFont;
        }
    }
}