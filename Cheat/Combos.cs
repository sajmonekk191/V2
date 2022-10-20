using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    class Combos
    {
        private static Point EnemyPos;
        private static Point LastMousePos;
        public static bool CheckComboReady()
        {
            if (hodnoty.CombosActivated)
            {
                switch (hodnoty.SelectedChamp)
                {
                    case "Ashe":
                        if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) return true;
                        break;
                    case "Kogmaw":
                        if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) return true;
                        else if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) return true;
                        else if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) return true;
                        else if(calls.isRready() && hodnoty.REnabled && CalculateMana(hodnoty.RManaValue)) return true;
                        break;
                    case "Vayne":
                        if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) return true;
                        break;
                    case "Lucian":
                        if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) return true;
                        else if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) return true;
                        else if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) return true;
                        break;
                    case "Kayle":
                        if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) return true;
                        else if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) return true;
                        break;
                    case "Tristana":
                        if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) return true;
                        else if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) return true;
                        break;

                }
            }
            return false;
        }
        public static void MakeCombo()
        {
            switch (hodnoty.SelectedChamp)
            {
                case "Ashe":
                    if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) WaitThenCombo(Keyboard.ScanCodeShort.KEY_Q, 0);
                    break;
                case "Kogmaw":
                    if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) ClickCombo(Keyboard.ScanCodeShort.KEY_Q, 10);
                    if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) Buffme(Keyboard.ScanCodeShort.KEY_W);
                    if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) ClickCombo(Keyboard.ScanCodeShort.KEY_E, 20);
                    if (calls.isRready() && hodnoty.REnabled && CalculateMana(hodnoty.RManaValue)) ClickCombo(Keyboard.ScanCodeShort.KEY_R, 10);
                    break;
                case "Vayne":
                    if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) WaitThenCombo(Keyboard.ScanCodeShort.KEY_Q, 50);
                    break;
                case "Lucian":
                    if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) CancleAuto(Keyboard.ScanCodeShort.KEY_Q);
                    if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) CancleAuto(Keyboard.ScanCodeShort.KEY_W);
                    if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) WaitThenCombo(Keyboard.ScanCodeShort.KEY_E, 60);
                    break;
                case "Kayle":
                    if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) WaitThenCombo(Keyboard.ScanCodeShort.KEY_E, 0);
                    if (calls.isWready() && hodnoty.WEnabled && CalculateMana(hodnoty.WManaValue)) Buffme(Keyboard.ScanCodeShort.KEY_W);
                    //if (calls.isRready() && hodnoty.REnabled && CalculateMana(hodnoty.RManaValue)) Buffme(Keyboard.ScanCodeShort.KEY_R);
                    break;
                case "Tristana":
                    if (calls.isEready() && hodnoty.EEnabled && CalculateMana(hodnoty.EManaValue)) ClickCombo(Keyboard.ScanCodeShort.KEY_E, 10);
                    if (calls.isQready() && hodnoty.QEnabled && CalculateMana(hodnoty.QManaValue)) Buffme(Keyboard.ScanCodeShort.KEY_Q);
                    break;
            }
            return;
        }
        private static void ClickCombo(Keyboard.ScanCodeShort key, int sleep)
        {
            LastMousePos = Cursor.Position;
            EnemyPos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
            if (EnemyPos != new Point(0, 0))
            {
                calls.DoThing("MouseMove", EnemyPos);
                Keyboard.SendKeyDown(key);
                Keyboard.SendKeyUp(key);
                Thread.Sleep(sleep);
                calls.DoThing("MouseMove", LastMousePos);
            }
            return;
        }
        private static void WaitThenCombo(Keyboard.ScanCodeShort key, int sleep)
        {
            LastMousePos = Cursor.Position;
            Keyboard.SendKeyDown(key);
            Keyboard.SendKeyUp(key);
            Thread.Sleep(sleep);
            EnemyPos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
            if (EnemyPos != new Point(0, 0))
            {
                calls.DoThing("AttackEnemy", EnemyPos);
                calls.DoThing("MouseMove", LastMousePos);
            }
            return;
        }
        private static void CancleAuto(Keyboard.ScanCodeShort key)
        {
            LastMousePos = Cursor.Position;
            EnemyPos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
            if (EnemyPos != new Point(0, 0))
            {
                calls.DoThing("MouseMove", EnemyPos);
                Keyboard.SendKeyDown(key);
                Keyboard.SendKeyUp(key);
                Thread.Sleep(12);
                calls.DoThing("MouseMove", LastMousePos);
                EnemyPos = ScreenCap.GetEnemyPosition(GetPlayerInfo.GetAttackRange());
                if (EnemyPos != new Point(0, 0))
                {
                    calls.DoThing("AttackEnemy", EnemyPos);
                    calls.DoThing("MouseMove", LastMousePos);
                }
            }
            return;
        }
        private static void Buffme(Keyboard.ScanCodeShort key)
        {
            Keyboard.SendKeyDown(Keyboard.ScanCodeShort.LMENU);
            Keyboard.SendKeyDown(key);
            Keyboard.SendKeyUp(Keyboard.ScanCodeShort.LMENU);
            Keyboard.SendKeyUp(key);
        }
        private static bool CalculateMana(int value)
        {
            if ((GetPlayerInfo.GetPlayerMana() / GetPlayerInfo.GetPlayerMaxMana()) * 100 >= (int)Math.Round((double)value) * 10) return true;
            else return false;
        }
    }
}
