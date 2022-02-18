using System;
using System.Runtime.InteropServices;

namespace VoidSharp.Other
{
    internal class SpecialFunc
    {
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
