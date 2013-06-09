namespace Auxilium.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tabMain = new Auxilium.Controls.HiddenTab();
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
            this.tabMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabLogin);
            this.tabMain.Controls.Add(this.tabRegister);
            this.tabMain.DesignerIndex = 1;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(385, 253);
            this.tabMain.TabIndex = 6;
            // 
            // tabLogin
            // 
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
            this.tabLogin.Size = new System.Drawing.Size(385, 253);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // cbAuto
            // 
            this.cbAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAuto.AutoSize = true;
            this.cbAuto.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuto.Location = new System.Drawing.Point(144, 122);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(147, 16);
            this.cbAuto.TabIndex = 21;
            this.cbAuto.Text = "Sign me in automatically";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // cbRemember
            // 
            this.cbRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.Location = new System.Drawing.Point(144, 100);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(95, 16);
            this.cbRemember.TabIndex = 20;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(144, 177);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 27);
            this.btnCreate.TabIndex = 19;
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
            this.btnLogin.Location = new System.Drawing.Point(144, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 27);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Sign into account";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(144, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 21);
            this.txtUsername.TabIndex = 14;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(82, 52);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(56, 12);
            this.lbUser.TabIndex = 16;
            this.lbUser.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(144, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(159, 21);
            this.txtPassword.TabIndex = 15;
            // 
            // lbPass
            // 
            this.lbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(82, 78);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 12);
            this.lbPass.TabIndex = 17;
            this.lbPass.Text = "Password";
            // 
            // tabRegister
            // 
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
            this.tabRegister.Size = new System.Drawing.Size(385, 253);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // regEmail
            // 
            this.regEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.Location = new System.Drawing.Point(144, 114);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(160, 22);
            this.regEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(144, 170);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(77, 27);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(227, 170);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 27);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // regPassword
            // 
            this.regPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(144, 142);
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '•';
            this.regPassword.Size = new System.Drawing.Size(160, 22);
            this.regPassword.TabIndex = 6;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.Location = new System.Drawing.Point(82, 145);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(56, 13);
            this.lblRegPassword.TabIndex = 5;
            this.lblRegPassword.Text = "Password";
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUsername.Location = new System.Drawing.Point(82, 90);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(58, 13);
            this.lblRegUsername.TabIndex = 1;
            this.lblRegUsername.Text = "Username";
            // 
            // regUsername
            // 
            this.regUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(144, 86);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(160, 22);
            this.regUsername.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.tabMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.HiddenTab tabMain;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.Label label1;
    }
}