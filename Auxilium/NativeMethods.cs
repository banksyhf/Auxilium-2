using System;
using System.Runtime.InteropServices;

namespace Auxilium
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint = "FlashWindow")]
        public static extern bool FlashWindow(IntPtr handle, bool invert);
    }
}