using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace VoidSharp.Cheat
{
    internal class calls
    {
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
        public static void DoThing(string call, Point enemypos)
        {
            switch (call)
            {
                case "AttackEnemy":
                    if(enemypos.X == 0 && enemypos.Y == 0)
                    {
                        Mouse.SetCursorPosition(Cursor.Position.X, Cursor.Position.Y);
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
    }
}
