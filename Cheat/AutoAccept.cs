using System;
using System.Drawing;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    class AutoAccept
    {
        public static IntPtr handle;
        public static string Process = "League Of Legends";

        public static void FindMatch()
        {
            if (hodnoty.AutoAcceptWorking)
            {
                try
                {
                    Rectangle rect;
                    handle = SpecialFunc.FindWindow(null, Process);
                    SpecialFunc.GetWindowRect(handle, out rect);
                    SpecialFunc.SetForegroundWindow(handle);
                    Point Position = ScreenCap.PixelSearch(rect, hodnoty.AutoAcceptColor);
                    if (Position != new Point(0, 0))
                    {
                        SpecialFunc.SetForegroundWindow(handle);
                        Mouse.SetCursorPosition(rect.X + Position.X, rect.Y + Position.Y);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.LeftDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.LeftUp);
                    }
                }
                catch { }
            }
        }
    }
}
