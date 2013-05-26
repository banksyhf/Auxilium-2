using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Auxilium.Core;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;

namespace Auxilium.Forms
{
    public partial class frmLogin : Form
    {
        private Client Client { get; set; }

        public frmLogin(Client client)
        {
            Client = client;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login(txtUsername.Text, txtPassword.Text).Execute(Client);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register(regUsername.Text, regPassword.Text, regEmail.Text).Execute(Client);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 1;
        }

        public void HandleLoginResponse(LoginResponse login)
        {
            Invoke(new MethodInvoker(() =>
            {
                if (login.Successful)
                {
                    new frmMain(Client).Show();
                    this.Close();
                }

                if (login.Message != null)
                    MessageBox.Show(login.Message);
            }));
        }

        public void HandleRegisterResponse(RegisterResponse register)
        {
            Invoke(new MethodInvoker(() =>
            {
                if (register.Successful)
                    tabMain.SelectedIndex = 0;

                MessageBox.Show(register.Message);
            }));

        }
    }
}
