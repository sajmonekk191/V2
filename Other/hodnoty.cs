﻿using System.Drawing;
using System.Windows.Forms;

namespace VoidSharp.Other
{
    internal class hodnoty
    {
        // ColorPicker //
        public static bool selectcolorchamp = false;
        //ColorPicker //

        // ChangeName //
        public static string ActualName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        // ChangeName //

        // Player Info //
        public static string ActivePlayerEndpoint = @"https://127.0.0.1:2999/liveclientdata/activeplayer";
        // Player Info //

        // Main Hodnoty //
        public static bool VoidActivated = false;
        public static bool AutoHeal = false;
        public static float Windup;
        public static float BaseWindup;
        public static string SelectedChamp;
        // Main Hodnoty //

        // Champion Windup //
        public static float ashewu = 21.93f;
        public static float caitlynwu = 17.708f;
        public static float corkiwu = 10.00f;
        public static float dravenwu = 15.614f;
        public static float ezrealwu = 18.839f;
        public static float jinxwu = 16.875f;
        public static float kaisawu = 16.108f;
        public static float kalistawu = 36.000f;
        public static float kaylewu = 19.355f;
        public static float kindredwu = 17.544f;
        public static float kogmawu = 16.622f;
        public static float lucianwu = 15.00f;
        public static float mfwu = 14.801f;
        public static float quinnwu = 17.544f;
        public static float samirawu = 15.00f;
        public static float sennawu = 31.25f;
        public static float sivirwu = 12.00f;
        public static float tristanawu = 14.801f;
        public static float twitchwu = 20.192f;
        public static float varuswu = 17.544f;
        public static float vaynewu = 17.544f;
        public static float xayahwu = 17.687f;
        public static float xerathwu = 25.074f;
        // Champion Windup //

        // Champion Base Windup //
        public static float ashebwu = 0.658f;
        public static float caitlynbwu = 0.681f;
        public static float corkibwu = 0.638f;
        public static float dravenbwu = 0.679f;
        public static float ezrealbwu = 0.625f;
        public static float jinxbwu = 0.625f;
        public static float kaisabwu = 0.644f;
        public static float kalistabwu = 0.694f;
        public static float kaylebwu = 0.625f;
        public static float kindredbwu = 0.625f;
        public static float kogmabwu = 0.665f;
        public static float lucianbwu = 0.638f;
        public static float mfbwu = 0.656f;
        public static float quinnbwu = 0.668f;
        public static float samirabwu = 0.658f;
        public static float sennabwu = 0.658f;
        public static float sivirbwu = 0.625f;
        public static float tristanabwu = 0.656f;
        public static float twitchbwu = 0.679f;
        public static float varusbwu = 0.658f;
        public static float vaynebwu = 0.658f;
        public static float xayahbwu = 0.625f;
        public static float xerathbwu = 0.625f;
        // Champion Base Windup //

        // Champion Windup Modifier //
        public static float ashebwm = 1f;
        public static float caitlynbwm = 1f;
        public static float corkibwm = 1f;
        public static float dravenbwm = 1f;
        public static float ezrealbwm = 1f;
        public static float jinxbwm = 1f;
        public static float kaisabwm = 0.75f;
        public static float kalistabwm = 1f;
        public static float kaylebwm = 1f;
        public static float kindredbwm = 1f;
        public static float kogmabwm = 1f;
        public static float lucianbwm = 1f;
        public static float mfbwm = 1f;
        public static float quinnbwm = 1f;
        public static float samirabwm = 1f;
        public static float sennabwm = 1f;
        public static float sivirbwm = 1f;
        public static float tristanabwm = 1f;
        public static float twitchbwm = 1f;
        public static float varusbwm = 1f;
        public static float vaynebwm = 1f;
        public static float xayahbwm = 1f;
        public static float xerathbwm = 1f;
        // Champion Windup Modifier //

        // Account Manager //
        public static string CurentUsername = string.Empty;
        public static string CurentPassword = string.Empty;

        public static string HashedPassword = string.Empty;
        public static string success = string.Empty;
        // Account Manager //

        // Discord RPC //
        public static string DiscordRpcID = "941004535659376651";
        // Discord RPC //

        // Orbwalker components //
        public static Keys OrbwalkerKey;
        public static bool AutoHumanize = false;
        public static bool OrbActivated = false;
        public static bool AttackChamponly = false;
        public static bool AttackEverything = false;
        public static bool ShowRange = false;
        public static bool tooglechamponly = false;
        public static int AvPing = 50;
        public static int HumanizerTime = 50;
        public static Color EnemyPix = Color.FromArgb(255, 63, 5, 0);
        public static Color EnemyPix1 = Color.FromArgb(255, 63, 5, 0);
        public static Color PlayerColor = Color.FromArgb(255, 59, 49, 5);
        public static Point EnemyPosition = Point.Empty;
        public static double AttackRange = double.NaN;
        public static double AttackSpeed = double.NaN;
        public static double PlayerHealth = double.NaN;
        // Orbwalker components //

        // Aim components //
        public static bool AimActivated = false;
        public static bool QActivated = false;
        public static bool WActivated = false;
        public static bool EActivated = false;
        public static bool RActivated = false;
        public static Color CDcolor = Color.FromArgb(255, 231, 195, 123);
        public static Rectangle CDposQ = new Rectangle(806, 992, 30, 30);
        public static Rectangle CDposW = new Rectangle(851, 992, 30, 30);
        public static Rectangle CDposE = new Rectangle(895, 992, 30, 30);
        public static Rectangle CDposR = new Rectangle(939, 992, 30, 30);
        public static bool ChargeQ = false;
        public static bool ChargeW = false;
        public static bool ChargeE = false;
        public static bool ChargeR = false;
        public static Rectangle rectQ = Rectangle.Empty;
        public static Rectangle rectW = Rectangle.Empty;
        public static Rectangle rectE = Rectangle.Empty;
        public static Rectangle rectR = Rectangle.Empty;
        // Aim components //

        // Combos components //
        public static bool CombosActivated = false;
        public static bool QEnabled = false;
        public static bool WEnabled = false;
        public static bool EEnabled = false;
        public static bool REnabled = false;
        public static int QManaValue;
        public static int WManaValue;
        public static int EManaValue;
        public static int RManaValue;
        // Combos components //

        //KeyBinds//
        public static short KeyQ = 0;
        public static short KeyW = 0;
        public static short KeyE = 0;
        public static short KeyR = 0;
        //KeyBinds//

        // AFK script //
        public static bool AFKisActivated = false;
        // AFK script //

        // AutoAccept //
        public static bool AutoAcceptWorking = false;
        public static Color AutoAcceptColor = Color.FromArgb(255, 21, 103, 101);
        // AutoAccept //

        public static float getWindup()
        {
            return Windup;
        }
    }
}
