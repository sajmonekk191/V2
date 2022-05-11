using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    internal class Orbwalker
    {
        private static int AAtick;
        private static int MoveCT;
        private static Point LastMousePos = Point.Empty;
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private static int GetAttackWindup()
        {
            float windup = hodnoty.getWindup();

            int finalWindUP = (int)((1 / Cheat.GetPlayerInfo.GetAttackSpeed() * 1000) * windup);
            return finalWindUP;
        }
        private static int GetAttackDelay()
        {
            return (int)(1000.0f / Cheat.GetPlayerInfo.GetAttackSpeed());
        }
        private static bool CanAttack()
        {
            return AAtick + GetAttackDelay() + hodnoty.AvPing / 2 < Environment.TickCount;
        }
        private static bool CanMove(float extraWU)
        {
            if(hodnoty.SelectedChamp == "Kalista")
            {
                return true;
            }
            else
            {
                return MoveCT <= Environment.TickCount + extraWU;
            }
        }
        public static void OrbwalkEnemy()
        {
            short key = GetAsyncKeyState(0x20);
            bool keyIsPressed = ((key >> 15) & 0x0001) == 0x0001;

            if(hodnoty.VoidActivated && hodnoty.OrbActivated)
            {
                if (keyIsPressed && AAtick < Environment.TickCount)
                {
                    if (hodnoty.ShowRange)
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_C);

                    if (hodnoty.tooglechamponly)
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.NUMPAD9);

                    Point pos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
                    if (CanAttack() && pos != Point.Empty)
                    {
                        LastMousePos = Cursor.Position;

                        if (hodnoty.AttackChamponly)
                            calls.DoThing("AttackEnemy", pos);
                        if (hodnoty.AttackEverything)
                        {
                            Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_A);
                            Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_A);
                        }

                        AAtick = Environment.TickCount;
                        MoveCT = Environment.TickCount + GetAttackWindup();

                        calls.DoThing("MouseMove", LastMousePos);
                    }
                    else if (CanMove(10) && MoveCT <= Environment.TickCount)
                    {
                        calls.DoThing("RightClick", new Point(0, 0));

                        LastMousePos = Cursor.Position;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(hodnoty.HumanizerTime);
                        if (pos == Point.Empty)
                        {
                            LastMousePos = Cursor.Position;
                        }
                        calls.DoThing("RightClick", new Point(0, 0));
                    }
                }
                else
                {
                    if (hodnoty.ShowRange)
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_C);

                    if (hodnoty.tooglechamponly)
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.NUMPAD9);
                }
            }
        }
    }
}
