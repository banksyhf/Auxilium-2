namespace Auxilium.Forms
{
    partial class frmPrivate
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Received Messages", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Sent Messages", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvwPrivateMessages = new Auxilium.Controls.ListView();
            this.columnSubject = new System.Windows.Forms.ColumnHeader();
            this.columnSender = new System.Windows.Forms.ColumnHeader();
            this.columnRecipient = new System.Windows.Forms.ColumnHeader();
            this.columnTimeSent = new System.Windows.Forms.ColumnHeader();
            this.hiddenMessaging = new Auxilium.Controls.HiddenTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnToReply = new System.Windows.Forms.Button();
            this.panelReadMessage = new System.Windows.Forms.Panel();
            this.rtbMessage = new Auxilium.Controls.ExRichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.hiddenMessaging.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelReadMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPrivateMessages
            // 
            this.lvwPrivateMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPrivateMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnSender,
            this.columnRecipient,
            this.columnTimeSent});
            this.lvwPrivateMessages.FullRowSelect = true;
            listViewGroup1.Header = "Received Messages";
            listViewGroup1.Name = "lvgReceivedMessages";
            listViewGroup2.Header = "Sent Messages";
            listViewGroup2.Name = "lvgSentMessages";
            this.lvwPrivateMessages.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvwPrivateMessages.Location = new System.Drawing.Point(12, 12);
            this.lvwPrivateMessages.Name = "lvwPrivateMessages";
            this.lvwPrivateMessages.Size = new System.Drawing.Size(590, 313);
            this.lvwPrivateMessages.TabIndex = 3;
            this.lvwPrivateMessages.UseCompatibleStateImageBehavior = false;
            this.lvwPrivateMessages.View = System.Windows.Forms.View.Details;
            this.lvwPrivateMessages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwPrivateMessages_MouseDoubleClick);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Message Subject";
            this.columnSubject.Width = 106;
            // 
            // columnSender
            // 
            this.columnSender.Text = "Sender";
            this.columnSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSender.Width = 136;
            // 
            // columnRecipient
            // 
            this.columnRecipient.Text = "Recipient";
            this.columnRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRecipient.Width = 141;
            // 
            // columnTimeSent
            // 
            this.columnTimeSent.Text = "Time Sent";
            this.columnTimeSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTimeSent.Width = 182;
            // 
            // hiddenMessaging
            // 
            this.hiddenMessaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenMessaging.Controls.Add(this.tabPage3);
            this.hiddenMessaging.Controls.Add(this.tabPage4);
            this.hiddenMessaging.DesignerIndex = 0;
            this.hiddenMessaging.Location = new System.Drawing.Point(12, 346);
            this.hiddenMessaging.Name = "hiddenMessaging";
            this.hiddenMessaging.SelectedIndex = 0;
            this.hiddenMessaging.Size = new System.Drawing.Size(590, 167);
            this.hiddenMessaging.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnToReply);
            this.tabPage3.Controls.Add(this.panelReadMessage);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(590, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnToReply
            // 
            this.btnToReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToReply.Location = new System.Drawing.Point(498, 138);
            this.btnToReply.Name = "btnToReply";
            this.btnToReply.Size = new System.Drawing.Size(86, 23);
            this.btnToReply.TabIndex = 0;
            this.btnToReply.Text = "Reply >>";
            this.btnToReply.UseVisualStyleBackColor = true;
            // 
            // panelReadMessage
            // 
            this.panelReadMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReadMessage.Controls.Add(this.rtbMessage);
            this.panelReadMessage.Location = new System.Drawing.Point(6, 6);
            this.panelReadMessage.Name = "panelReadMessage";
            this.panelReadMessage.Padding = new System.Windows.Forms.Padding(1);
            this.panelReadMessage.Size = new System.Drawing.Size(578, 126);
            this.panelReadMessage.TabIndex = 2;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Location = new System.Drawing.Point(1, 1);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(576, 124);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(590, 167);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmPrivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 337);
            this.Controls.Add(this.lvwPrivateMessages);
            this.Controls.Add(this.hiddenMessaging);
            this.Name = "frmPrivate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Private Messages";
            this.Shown += new System.EventHandler(this.frmPrivate_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrivate_FormClosed);
            this.hiddenMessaging.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelReadMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Auxilium.Controls.ExRichTextBox rtbMessage;
        private Auxilium.Controls.HiddenTab hiddenMessaging;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnToReply;
        private System.Windows.Forms.Panel panelReadMessage;
        private Auxilium.Controls.ListView lvwPrivateMessages;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnSender;
        private System.Windows.Forms.ColumnHeader columnRecipient;
        private System.Windows.Forms.ColumnHeader columnTimeSent;

    }
}