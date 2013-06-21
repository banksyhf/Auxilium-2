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

namespace Auxilium.Forms
{
    public partial class frmSuggestion : Form
    {
        public Client Client { get; set; }

        private string _username;

        public frmSuggestion(string username, Client client)
        {
            this.Client = client;
            this._username = username;
            InitializeComponent();

            panelSuggestionBox.BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!rtbSuggestionBox.Text.IsNullOrWhiteSpace())
            {
                new Suggestion(this._username, rtbSuggestionBox.Text.Trim()).Execute(Client);
                this.Close();
            }
            else
                MessageBox.Show("Please type a suggestion.");
        }
    }
}
