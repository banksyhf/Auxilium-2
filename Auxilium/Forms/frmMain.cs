using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Auxilium.Core;

namespace Auxilium.Forms
{
    public partial class frmMain : Form
    {
        public Client Client { get; set; }

        public frmMain(Client client)
        {
            Client = client;
            InitializeComponent();
        }
    }
}
