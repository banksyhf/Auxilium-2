using Auxilium.Core;
using System.Windows.Forms;

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