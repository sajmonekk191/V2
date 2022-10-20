using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace VoidSharp.Other
{
    internal class SpecialFunc
    {
        static Random random = new Random();
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        public static string RandomString(int length)
        {
            const string chars = "ABCdefGHIJKLmnoPQRSTUVwxYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rectangle IpRect);
        public static void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
        public static bool IsLeagueFocused()
        {
            var Application = GetForegroundWindow();
            IntPtr handle = SpecialFunc.FindWindow(null, "League of Legends (TM) Client");
            if (Application == handle) return true;
            else return false;
        }
    }
}
