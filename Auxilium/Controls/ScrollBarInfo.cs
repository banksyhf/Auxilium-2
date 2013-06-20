using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Auxilium.Controls
{
    internal class ScrollBarInfo
    {
        public const uint ObjidVscroll = 0xFFFFFFFB;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetScrollBarInfo(IntPtr hWnd, uint idObject, ref ScrollBar psbi);

        internal static bool CheckBottom(Control ctrl)
        {
            ScrollBar info = new ScrollBar();
            info.CbSize = Marshal.SizeOf(info);

            int res = GetScrollBarInfo(ctrl.Handle,
                                       ObjidVscroll,
                                       ref info);

            bool isAtBottom = info.XyThumbBottom > (info.RcScrollBar.Bottom - info.RcScrollBar.Top - (int)Math.Round((decimal)info.DxyLineButton * (decimal)2));
            return isAtBottom;
        }
    }

    internal struct ScrollBar
    {
        public int CbSize;
        public Rect RcScrollBar;
        public int DxyLineButton;
        public int XyThumbTop;
        public int XyThumbBottom;
        public int Reserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public int[] Rgstate;
    }

    internal struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
}