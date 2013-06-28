namespace Auxilium.Forms
{
    partial class frmOptions
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
            this.cbTimestamps = new System.Windows.Forms.CheckBox();
            this.cbNotifications = new System.Windows.Forms.CheckBox();
            this.cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.cbNotificationSound = new System.Windows.Forms.CheckBox();
            this.cbSpaceMessages = new System.Windows.Forms.CheckBox();
            this.cbUserEvents = new System.Windows.Forms.CheckBox();
            this.cbWriteMessages = new System.Windows.Forms.CheckBox();
            this.cbRememberFormSize = new System.Windows.Forms.CheckBox();
            this.cbRememberFont = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbTimestamps
            // 
            this.cbTimestamps.AutoSize = true;
            this.cbTimestamps.Checked = true;
            this.cbTimestamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTimestamps.Location = new System.Drawing.Point(12, 12);
            this.cbTimestamps.Name = "cbTimestamps";
            this.cbTimestamps.Size = new System.Drawing.Size(112, 17);
            this.cbTimestamps.TabIndex = 0;
            this.cbTimestamps.Text = "Show Timestamps";
            this.cbTimestamps.UseVisualStyleBackColor = true;
            this.cbTimestamps.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbNotifications
            // 
            this.cbNotifications.AutoSize = true;
            this.cbNotifications.Checked = true;
            this.cbNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotifications.Location = new System.Drawing.Point(12, 35);
            this.cbNotifications.Name = "cbNotifications";
            this.cbNotifications.Size = new System.Drawing.Size(139, 17);
            this.cbNotifications.TabIndex = 1;
            this.cbNotifications.Text = "Show Chat Notifications";
            this.cbNotifications.UseVisualStyleBackColor = true;
            this.cbNotifications.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.AutoSize = true;
            this.cbMinimizeToTray.Location = new System.Drawing.Point(12, 58);
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Size = new System.Drawing.Size(102, 17);
            this.cbMinimizeToTray.TabIndex = 2;
            this.cbMinimizeToTray.Text = "Minimize to Tray";
            this.cbMinimizeToTray.UseVisualStyleBackColor = true;
            this.cbMinimizeToTray.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbNotificationSound
            // 
            this.cbNotificationSound.AutoSize = true;
            this.cbNotificationSound.Location = new System.Drawing.Point(12, 81);
            this.cbNotificationSound.Name = "cbNotificationSound";
            this.cbNotificationSound.Size = new System.Drawing.Size(136, 17);
            this.cbNotificationSound.TabIndex = 3;
            this.cbNotificationSound.Text = "Play Notification Sound";
            this.cbNotificationSound.UseVisualStyleBackColor = true;
            this.cbNotificationSound.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbSpaceMessages
            // 
            this.cbSpaceMessages.AutoSize = true;
            this.cbSpaceMessages.Checked = true;
            this.cbSpaceMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpaceMessages.Location = new System.Drawing.Point(12, 104);
            this.cbSpaceMessages.Name = "cbSpaceMessages";
            this.cbSpaceMessages.Size = new System.Drawing.Size(128, 17);
            this.cbSpaceMessages.TabIndex = 4;
            this.cbSpaceMessages.Text = "Space Out Messages";
            this.cbSpaceMessages.UseVisualStyleBackColor = true;
            this.cbSpaceMessages.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbUserEvents
            // 
            this.cbUserEvents.AutoSize = true;
            this.cbUserEvents.Enabled = false;
            this.cbUserEvents.Location = new System.Drawing.Point(12, 127);
            this.cbUserEvents.Name = "cbUserEvents";
            this.cbUserEvents.Size = new System.Drawing.Size(171, 17);
            this.cbUserEvents.TabIndex = 5;
            this.cbUserEvents.Text = "Show User Join/Leave Events";
            this.cbUserEvents.UseVisualStyleBackColor = true;
            this.cbUserEvents.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbWriteMessages
            // 
            this.cbWriteMessages.AutoSize = true;
            this.cbWriteMessages.Enabled = false;
            this.cbWriteMessages.Location = new System.Drawing.Point(12, 150);
            this.cbWriteMessages.Name = "cbWriteMessages";
            this.cbWriteMessages.Size = new System.Drawing.Size(133, 17);
            this.cbWriteMessages.TabIndex = 6;
            this.cbWriteMessages.Text = "Write Messages to File";
            this.cbWriteMessages.UseVisualStyleBackColor = true;
            this.cbWriteMessages.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbRememberFormSize
            // 
            this.cbRememberFormSize.AutoSize = true;
            this.cbRememberFormSize.Location = new System.Drawing.Point(12, 173);
            this.cbRememberFormSize.Name = "cbRememberFormSize";
            this.cbRememberFormSize.Size = new System.Drawing.Size(126, 17);
            this.cbRememberFormSize.TabIndex = 7;
            this.cbRememberFormSize.Text = "Remember Form Size";
            this.cbRememberFormSize.UseVisualStyleBackColor = true;
            this.cbRememberFormSize.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cbRememberFont
            // 
            this.cbRememberFont.AutoSize = true;
            this.cbRememberFont.Location = new System.Drawing.Point(12, 196);
            this.cbRememberFont.Name = "cbRememberFont";
            this.cbRememberFont.Size = new System.Drawing.Size(101, 17);
            this.cbRememberFont.TabIndex = 8;
            this.cbRememberFont.Text = "Remember Font";
            this.cbRememberFont.UseVisualStyleBackColor = true;
            this.cbRememberFont.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 250);
            this.Controls.Add(this.cbRememberFont);
            this.Controls.Add(this.cbRememberFormSize);
            this.Controls.Add(this.cbWriteMessages);
            this.Controls.Add(this.cbUserEvents);
            this.Controls.Add(this.cbSpaceMessages);
            this.Controls.Add(this.cbNotificationSound);
            this.Controls.Add(this.cbMinimizeToTray);
            this.Controls.Add(this.cbNotifications);
            this.Controls.Add(this.cbTimestamps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTimestamps;
        private System.Windows.Forms.CheckBox cbNotifications;
        private System.Windows.Forms.CheckBox cbMinimizeToTray;
        private System.Windows.Forms.CheckBox cbNotificationSound;
        private System.Windows.Forms.CheckBox cbSpaceMessages;
        private System.Windows.Forms.CheckBox cbUserEvents;
        private System.Windows.Forms.CheckBox cbWriteMessages;
        private System.Windows.Forms.CheckBox cbRememberFormSize;
        private System.Windows.Forms.CheckBox cbRememberFont;
    }
}