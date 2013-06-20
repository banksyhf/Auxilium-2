namespace Auxilium.Updating
{
    partial class frmUpdater
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNotNow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbChangeLog = new System.Windows.Forms.RichTextBox();
            this.lblUpdateVersion = new Auxilium.Controls.SmoothLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(133, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNotNow
            // 
            this.btnNotNow.Location = new System.Drawing.Point(225, 220);
            this.btnNotNow.Name = "btnNotNow";
            this.btnNotNow.Size = new System.Drawing.Size(86, 25);
            this.btnNotNow.TabIndex = 7;
            this.btnNotNow.Text = "Not Now";
            this.btnNotNow.UseVisualStyleBackColor = true;
            this.btnNotNow.Click += new System.EventHandler(this.btnNotNow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbChangeLog);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(299, 159);
            this.panel1.TabIndex = 9;
            // 
            // rtbChangeLog
            // 
            this.rtbChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChangeLog.Location = new System.Drawing.Point(1, 1);
            this.rtbChangeLog.Name = "rtbChangeLog";
            this.rtbChangeLog.Size = new System.Drawing.Size(297, 157);
            this.rtbChangeLog.TabIndex = 0;
            this.rtbChangeLog.Text = "";
            // 
            // lblUpdateVersion
            // 
            this.lblUpdateVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.lblUpdateVersion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.lblUpdateVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.lblUpdateVersion.Location = new System.Drawing.Point(12, 12);
            this.lblUpdateVersion.Name = "lblUpdateVersion";
            this.lblUpdateVersion.Size = new System.Drawing.Size(299, 37);
            this.lblUpdateVersion.TabIndex = 0;
            // 
            // frmUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNotNow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdater";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update";
            this.Shown += new System.EventHandler(this.frmUpdating_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SmoothLabel lblUpdateVersion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNotNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbChangeLog;
    }
}