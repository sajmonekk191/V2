using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    internal class calls
    {
        public static void DoThing(string call, Point enemypos)
        {
            switch (call)
            {
                case "AttackEnemy":
                    if(enemypos.X == 0 && enemypos.Y == 0)
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                        break;
                    }
                    Mouse.SetCursorPosition(enemypos.X, enemypos.Y);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;
                case "StopPlayer":
                    Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_S);
                    Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_S);
                    break;
                case "MouseMove":
                    Mouse.SetCursorPosition(enemypos.X, enemypos.Y);
                    break;
                case "RightClick":
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;
            }
        }
        public static bool isQready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposQ, hodnoty.CDcolor)) return true;
            else return false;
        }
        public static bool isWready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposW, hodnoty.CDcolor)) return true;
            else return false;
        }
        public static bool isEready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposE, hodnoty.CDcolor)) return true;
            else return false;
        }
        public static bool isRready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposR, hodnoty.CDcolor)) return true;
            else return false;
        }
        public static bool IsKeyDown(Keys key)
        {
            short value = SpecialFunc.GetAsyncKeyState(key);
            return ((value >> 15) & 0x0001) == 0x0001; ;
        }
    }
}
