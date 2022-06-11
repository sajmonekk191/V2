using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    class AimCore
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private static bool Qdown = false;
        private static bool Wdown = false;
        private static bool Edown = false;
        private static bool Rdown = false;
        public static void Aimer()
        {
            if (hodnoty.VoidActivated && hodnoty.AimActivated)
            {
                short keyQ = hodnoty.KeyQ;
                short keyW = hodnoty.KeyW;
                short keyE = hodnoty.KeyE;
                short keyR = hodnoty.KeyR;
                bool keyIsPressedQ = ((keyQ >> 15) & 0x0001) == 0x0001;
                bool keyIsPressedW = ((keyW >> 15) & 0x0001) == 0x0001;
                bool keyIsPressedE = ((keyE >> 15) & 0x0001) == 0x0001;
                bool keyIsPressedR = ((keyR >> 15) & 0x0001) == 0x0001;
                if (hodnoty.ChargeQ)
                {
                    if (keyIsPressedQ && hodnoty.QActivated)
                    {
                        Qdown = true;
                        SendKeys.Send("Q");
                        //Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_1);
                    }
                    else if (Qdown && !keyIsPressedQ && hodnoty.QActivated)
                    {
                        Qdown = false;
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectQ, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        SendKeys.Send("Q");
                        //Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_1);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                else
                {
                    if (keyIsPressedQ && Qisready() && hodnoty.QActivated)
                    {
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectQ, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        SendKeys.Send("Q");
                        //Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_1);
                        //Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_1);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                if (hodnoty.ChargeW)
                {
                    if (keyIsPressedW && hodnoty.WActivated)
                    {
                        Wdown = true;
                        SendKeys.Send("W");
                        //Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_2);
                    }
                    else if (Wdown && !keyIsPressedW && hodnoty.WActivated)
                    {
                        Wdown = false;
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectW, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        SendKeys.Send("W");
                        //Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_2);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                else
                {
                    if (keyIsPressedW && Wisready() && hodnoty.WActivated)
                    {
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectW, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        SendKeys.Send("W");
                        //Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_2);
                        //Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_2);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                if (hodnoty.ChargeE)
                {
                    if (keyIsPressedE && hodnoty.EActivated)
                    {
                        Edown = true;
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_3);
                    }
                    else if (Edown && !keyIsPressedE && hodnoty.EActivated)
                    {
                        Edown = false;
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectE, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_3);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                else
                {
                    if (keyIsPressedE && Eisready() && hodnoty.EActivated)
                    {
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectE, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_3);
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_3);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                if (hodnoty.ChargeR)
                {
                    if (keyIsPressedR && hodnoty.RActivated)
                    {
                        Rdown = true;
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_4);
                    }
                    else if (Rdown && !keyIsPressedR && hodnoty.RActivated)
                    {
                        Rdown = false;
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectR, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_4);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
                else
                {
                    if (keyIsPressedR && Risready() && hodnoty.RActivated)
                    {
                        Point LastMovePos = Cursor.Position;
                        Point pos = ScreenCap.PixelSearchEnemy(hodnoty.rectR, hodnoty.EnemyPix);
                        calls.DoThing("AttackEnemy", pos);
                        Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_4);
                        Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_4);
                        calls.Wait(8);
                        calls.DoThing("MouseMove", LastMovePos);
                    }
                }
            }
        }
        private static bool Qisready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposQ, hodnoty.CDcolor)) return true;
            else return false;
        }
        private static bool Wisready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposW, hodnoty.CDcolor)) return true;
            else return false;
        }
        private static bool Eisready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposE, hodnoty.CDcolor)) return true;
            else return false;
        }
        private static bool Risready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDposR, hodnoty.CDcolor)) return true;
            else return false;
        }
    }
}
