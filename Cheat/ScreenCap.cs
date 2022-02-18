using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace VoidSharp.Cheat
{
    internal class ScreenCap
    {
        static Rectangle rect;
        public static int starty;
        public static int startx;
        public static Bitmap CaptureApplication(string procName)
        {
            var proc = Process.GetProcessesByName(procName)[0];
            Interop.BringWindowToFront(procName);
            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            graphics.Dispose();
            return bmp;
        }
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }
        public static Rectangle GetRangeValue(double ClientRange)
        {
            if (ClientRange > 500 && ClientRange < 550)
            {
                rect = new Rectangle(502, 125, 1288, 755);
                startx = 502;
                starty = 125;
                return rect;
            }
            if (ClientRange > 550 && ClientRange < 600)
            {
                rect = new Rectangle(462, 98, 1328, 782);
                startx = 462;
                starty = 98;
                return rect;
            }
            if (ClientRange > 600 && ClientRange < 650)
            {
                rect = new Rectangle(423, 71, 1367, 809);
                startx = 423;
                starty = 71;
                return rect;
            }
            if (ClientRange > 650 && ClientRange < 700)
            {
                rect = new Rectangle(344, 17, 1446, 863);
                startx = 344;
                starty = 17;
                return rect;
            }
            if (ClientRange > 700 && ClientRange < 750)
            {
                rect = new Rectangle(305, 0, 1485, 890);
                startx = 305;
                starty = 0;
                return rect;
            }
            if (ClientRange > 750 && ClientRange < 850)
            {
                rect = new Rectangle(226, 0, 1564, 944);
                startx = 226;
                starty = 0;
                return rect;
            }
            return rect;
        }
        public static Point PixelSearch(Rectangle rect, Color PixelColor)
        {
            int konecx = rect.Width - rect.X;
            int konecy = rect.Height - rect.Y;
            Bitmap RegionIn_Bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(RegionIn_Bitmap);
            graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, new Size(rect.Width, rect.Height), CopyPixelOperation.SourceCopy);
            BitmapData RegionIn_BitmapData = RegionIn_Bitmap.LockBits(new Rectangle(0, 0, RegionIn_Bitmap.Width, RegionIn_Bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int[] Formatted_Color = new int[3] { PixelColor.B, PixelColor.G, PixelColor.R }; //bgr

            unsafe
            {
                for (int y = rect.Y; y < konecy; y++)
                {
                    byte* row = (byte*)RegionIn_BitmapData.Scan0 + (y * RegionIn_BitmapData.Stride);

                    for (int x = rect.X; x < konecx; x++)
                    {
                        if (row[x * 3] == Formatted_Color[0]) //blue
                        {
                            if (row[(x * 3) + 1] == Formatted_Color[1]) //green
                            {
                                if (row[(x * 3) + 2] == Formatted_Color[2]) //red
                                {
                                    return new Point(x + rect.X + 65, y + rect.Y + 140);
                                }
                            }
                        }
                    }
                }
            }
            return new Point(0, 0);
        }
    }
}
