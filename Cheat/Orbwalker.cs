using System;
using System.Drawing;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    internal class Orbwalker
    {
        private static int Waiter;
        private static int AAtick;
        private static int MoveCT;
        private static Point LastMousePos = Point.Empty;
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
            short key = SpecialFunc.GetAsyncKeyState(hodnoty.OrbwalkerKey);
            bool keyIsPressed = ((key >> 15) & 0x0001) == 0x0001;

            if(hodnoty.VoidActivated && hodnoty.OrbActivated && SpecialFunc.IsLeagueFocused())
            {
                if (keyIsPressed)
                {
                    if(Waiter < 2)Waiter++;
                    if (hodnoty.ShowRange && !calls.IsKeyDown(Keys.C)) Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_C);
                    if (hodnoty.tooglechamponly && !calls.IsKeyDown(Keys.NumPad9)) Keyboard.SendKeyDown(Keyboard.ScanCodeShort.NUMPAD9);

                    if (AAtick < Environment.TickCount)
                    {
                        Point pos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
                        if (CanAttack() && hodnoty.AttackChamponly && pos != Point.Empty && Waiter >= 2)
                        {
                            LastMousePos = Cursor.Position;

                            if (hodnoty.AttackChamponly)
                            {
                                calls.DoThing("AttackEnemy", pos);
                                calls.DoThing("AttackEnemy", pos);
                            }

                            AAtick = Environment.TickCount;
                            MoveCT = Environment.TickCount + GetAttackWindup();

                            calls.DoThing("MouseMove", LastMousePos);
                        }
                        else if (CanAttack() && hodnoty.AttackEverything)
                        {
                            Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_A);
                            Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_A);
                            AAtick = Environment.TickCount;
                            MoveCT = Environment.TickCount + GetAttackWindup();
                        }
                        else if (CanMove(10) && MoveCT <= Environment.TickCount)
                        {
                            calls.DoThing("RightClick", new Point(0, 0));

                            LastMousePos = Cursor.Position;
                        }
                        //
                        else if (!CanAttack() && Combos.CheckComboReady() && !hodnoty.AttackEverything)
                        {
                            Combos.MakeCombo();
                            System.Threading.Thread.Sleep(hodnoty.HumanizerTime);
                            if (pos == Point.Empty)
                            {
                                LastMousePos = Cursor.Position;
                            }
                            calls.DoThing("RightClick", new Point(0, 0));
                        }
                        //
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
                }
                else
                {
                    if (hodnoty.ShowRange && calls.IsKeyDown(Keys.C)) Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_C);
                    if (hodnoty.tooglechamponly && calls.IsKeyDown(Keys.NumPad9)) Keyboard.SendKeyUp(Keyboard.ScanCodeShort.NUMPAD9);
                    Waiter = 0;
                }
            }
        }
    }
}
