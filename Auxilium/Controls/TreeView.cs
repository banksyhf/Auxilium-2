using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Auxilium.Controls
{
    public sealed class TreeView : System.Windows.Forms.TreeView
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        protected override void CreateHandle()
        {
            base.CreateHandle();
            SetWindowTheme(this.Handle, "explorer", null);
        }

        public TreeView()
        {
            this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}