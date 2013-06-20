using System;
using System.Drawing;
using System.Windows.Forms;

namespace Auxilium.Updating
{
    public partial class frmUpdater : Form
    {
        private Updater _updater;

        internal frmUpdater(Updater updater)
        {
            this._updater = updater;
            InitializeComponent();
        }

        private void frmUpdating_Shown(object sender, EventArgs e)
        {
            lblUpdateVersion.Text = "Update available, version: " + this._updater.Version;
            rtbChangeLog.Text = this._updater.ChangeLog.Replace(@"\n", Environment.NewLine);

            Color borderColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;
            panel1.BackColor = borderColor;
        }

        private void btnNotNow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._updater.StartUpdate();
        }
    }
}