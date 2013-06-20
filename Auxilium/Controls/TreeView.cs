using System;
using System.Runtime.InteropServices;

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
    }
}