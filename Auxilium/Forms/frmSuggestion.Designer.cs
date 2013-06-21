namespace Auxilium.Forms
{
    partial class frmSuggestion
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
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbSuggestionBox = new System.Windows.Forms.RichTextBox();
            this.panelSuggestionBox = new System.Windows.Forms.Panel();
            this.panelSuggestionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(239, 137);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Suggestion";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbSuggestionBox
            // 
            this.rtbSuggestionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSuggestionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSuggestionBox.Location = new System.Drawing.Point(1, 1);
            this.rtbSuggestionBox.Name = "rtbSuggestionBox";
            this.rtbSuggestionBox.Size = new System.Drawing.Size(326, 117);
            this.rtbSuggestionBox.TabIndex = 1;
            this.rtbSuggestionBox.Text = "";
            // 
            // panel1
            // 
            this.panelSuggestionBox.Controls.Add(this.rtbSuggestionBox);
            this.panelSuggestionBox.Location = new System.Drawing.Point(12, 12);
            this.panelSuggestionBox.Name = "panel1";
            this.panelSuggestionBox.Padding = new System.Windows.Forms.Padding(1);
            this.panelSuggestionBox.Size = new System.Drawing.Size(328, 119);
            this.panelSuggestionBox.TabIndex = 2;
            // 
            // frmSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 172);
            this.Controls.Add(this.panelSuggestionBox);
            this.Controls.Add(this.btnSend);
            this.Name = "frmSuggestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSuggestion";
            this.panelSuggestionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbSuggestionBox;
        private System.Windows.Forms.Panel panelSuggestionBox;
    }
}