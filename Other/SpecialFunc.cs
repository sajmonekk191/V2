using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace VoidSharp.Other
{
    internal class SpecialFunc
    {
        static Random random = new Random();
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static string RandomString(int length)
        {
            const string chars = "ABCdefGHIJKLmnoPQRSTUVwxYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
