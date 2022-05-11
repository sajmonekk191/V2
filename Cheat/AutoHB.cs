using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    internal class AutoHB
    {
        public static void Healer()
        {
            if (hodnoty.HBActivated && hodnoty.Health >= GetPlayerInfo.GetPlayerHealth() && GetPlayerInfo.GetPlayerHealth() != 0)
            {
                if(hodnoty.selectedD && isDready())
                {
                    Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_D);
                    Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_D);
                }
                else if (hodnoty.selectedF && isFready())
                {
                    Keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_F);
                    Keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_F);
                }
            }
        }
        private static bool isDready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDslotD, hodnoty.CDcolor)) return true;
            else return false;
        }
        private static bool isFready()
        {
            if (ScreenCap.PixelSearchCD(hodnoty.CDslotF, hodnoty.CDcolor)) return true;
            else return false;
        }
    }
}
