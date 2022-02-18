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
        public static void DoThing(string call, Rectangle rect)
        {
            Point enemypos;
            switch (call)
            {
                case "AttackEnemy":
                    rect = ScreenCap.GetRangeValue(Other.hodnoty.rangevalue);
                    enemypos = ScreenCap.PixelSearch(rect, Other.hodnoty.EnemyPix);
                    if (enemypos == null)
                        break;
                    else
                    {
                        Point lastcursorpos = new Point(Cursor.Position.X, Cursor.Position.Y);
                        Cursor.Position = enemypos;
                    }
                    break;
                case "FindEnemy":
                    enemypos = ScreenCap.PixelSearch(rect, Other.hodnoty.EnemyPix);
                    if (enemypos.X == 0 && enemypos.Y == 0) 
                        break;
                    else Cursor.Position = enemypos;
                    break;
            }
        }
    }
}
