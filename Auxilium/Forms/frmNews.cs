using System;
using System.Windows.Forms;

namespace Auxilium.Forms
{
    public partial class frmNews : Form
    {
        public frmNews(string news)
        {
            InitializeComponent();

            txtNews.Text = news.Replace(@"\n", Environment.NewLine);
            btnOK.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}