using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auxilium.Controls
{
    public sealed class ListView : System.Windows.Forms.ListView
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        protected override void CreateHandle()
        {
            base.CreateHandle();
            SetWindowTheme(this.Handle, "explorer", null);
        }

        public ListView()
        {
            this.DoubleBuffered = true;
            this.View = System.Windows.Forms.View.Details;
            this.FullRowSelect = true;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x1000 + 145:
                    // LVM_INSERTGROUP = LVM_FIRST + 145;
                    // Add the collapsible feature id needed
                    LVGROUP lvgroup = (LVGROUP)Marshal.PtrToStructure(m.LParam, typeof(LVGROUP));
                    lvgroup.state = (int)GroupState.COLLAPSIBLE;
                    // LVGS_COLLAPSIBLE
                    lvgroup.mask = lvgroup.mask ^ 4;
                    // LVGF_STATE
                    Marshal.StructureToPtr(lvgroup, m.LParam, true);
                    base.WndProc(ref m);
                    break;
                case 0x202:
                    //WM_LBUTTONUP
                    base.DefWndProc(ref m);
                    base.WndProc(ref m);
                    break;
                case 0x83: // WM_NCCALCSIZE
                    int style = (int)GetWindowLong(this.Handle, GwlStyle);
                    if ((style & WsHscroll) == WsHscroll)
                        SetWindowLong(this.Handle, GwlStyle, style & ~WsHscroll);
                    base.WndProc(ref m);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LVGROUP
        {
            public int cbSize;
            public int mask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszHeader;
            public int cchHeader;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszFooter;
            public int cchFooter;
            public int iGroupId;
            public int stateMask;
            public int state;
            public int uAlign;
        }
        public enum GroupState
        {
            COLLAPSIBLE = 8,
            COLLAPSED = 1,
            EXPANDED = 0
        }
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr window, int message, int wParam, IntPtr lParam);

        private const int GwlStyle = -16;
        public const int WsHscroll = 0x00100000;

        public static int GetWindowLong(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 4)
                return (int)GetWindowLong32(hWnd, nIndex);
            else
                return (int)(long)GetWindowLongPtr64(hWnd, nIndex);
        }

        public static int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong)
        {
            if (IntPtr.Size == 4)
                return (int)SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
            else
                return (int)(long)SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, int dwNewLong);
    }
}