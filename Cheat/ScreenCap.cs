using VoidSharp.Other;
using System.Drawing;
using System.Drawing.Imaging;
using Hazdryx.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace VoidSharp.Cheat
{
    internal class ScreenCap
    {
        public static Point GetEnemyPosition(double? ClientRange)
        {
            if (hodnoty.OrbwalkerKey != Keys.Space)
            {
                if (ClientRange >= 500 && ClientRange < 650)
                {
                    Rectangle rect = new Rectangle(450 + 50, 70 + 145, 910 + 10, 750 + 60);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                else if (ClientRange >= 650 && ClientRange < 850)
                {
                    Rectangle rect = new Rectangle(385 + 50, 35 + 145, 1100 + 10, 875 + 60);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                else if (ClientRange >= 850)
                {
                    Rectangle rect = new Rectangle(200 + 50, 0 + 145, 1600 + 10, 900 + 60);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                return new Point(0, 0);
            }
            else
            {
                if (ClientRange >= 500 && ClientRange < 650)
                {
                    Rectangle rect = new Rectangle(450, 70, 910, 750);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                else if (ClientRange >= 650 && ClientRange < 850)
                {
                    Rectangle rect = new Rectangle(385, 35, 1100, 875);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                else if (ClientRange >= 850)
                {
                    Rectangle rect = new Rectangle(200, 0, 1600, 900);
                    return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix, hodnoty.EnemyPix1));
                }
                return new Point(0, 0);
            }
        }
        public static Point PixelSearchEnemy(Rectangle rect, Color PixelColor, Color PixelColor1)
        {
            Point PlayerPos = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            List<Point> Points = PixelSearchEnemies(rect, PixelColor, PixelColor1, PlayerPos);
            Point Pos = new Point(0, 0);

            foreach (Point p in Points)
            {
                if (Pos == new Point(0, 0))
                {
                    Pos = p;
                }
                int DY = PlayerPos.Y - p.Y;
                int DX = PlayerPos.X - p.X;
                int D = DX * DX + DY * DY;

                int DPY = PlayerPos.Y - Pos.Y;
                int DPX = PlayerPos.X - Pos.X;
                int DP = DPX * DPX + DPY * DPY;

                if (Math.Abs(D) < Math.Abs(DP))
                {
                    Pos = p;
                }
            }

            return Pos;
        }

        public static List<Point> PixelSearchEnemies(Rectangle rect, Color PixelColor, Color PixelColor1, Point PlayerPos)
        {
            int offsetX = 63;
            int offsetY = 95;

            if (Screen.PrimaryScreen.Bounds.Width != 1920 || Screen.PrimaryScreen.Bounds.Height != 1080)
            {
                double XRatio = Screen.PrimaryScreen.Bounds.Width / 1920;
                double YRatio = Screen.PrimaryScreen.Bounds.Height / 1080;
                rect.X = (int)(rect.X * XRatio);
                rect.Y = (int)(rect.Y * YRatio);
                rect.Width = (int)(rect.Width * XRatio);
                rect.Height = (int)(rect.Height * YRatio);
                offsetX = (int)(offsetX * XRatio);
                offsetY = (int)(offsetY * YRatio);
                if (hodnoty.OrbwalkerKey != Keys.Space)
                {
                    PlayerPos.X = (int)(PlayerPos.X * XRatio);
                    PlayerPos.Y = (int)(PlayerPos.Y * YRatio);
                }
            }
            if (hodnoty.OrbwalkerKey != Keys.Space)
            {
                rect.X += PlayerPos.X - (Screen.PrimaryScreen.Bounds.Width / 2);
                rect.Y += PlayerPos.Y - (Screen.PrimaryScreen.Bounds.Height / 2);
            }

            int searchvalue = PixelColor.ToArgb();
            int searchvalue1 = PixelColor1.ToArgb();

            List<Point> Points = new List<Point>();

            unsafe
            {
                Bitmap BMP = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
                Graphics GFX = Graphics.FromImage(BMP);
                GFX.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                using (FastBitmap bitmap = new FastBitmap(BMP))
                {
                    for (int i = 0; i < bitmap.Length; i++)
                    {
                        if (searchvalue == bitmap.GetI(i))
                        {
                            i += 1;
                            if (searchvalue1 == bitmap.GetI(i))
                            {
                                int x = i % bitmap.Width;
                                int y = i / bitmap.Width;
                                if (InCircle(x, y, rect))
                                {
                                    Points.Add(new Point(x + rect.X + offsetX, y + rect.Y + offsetY));
                                }
                            }
                        }
                    }
                }
            }

            return Points;
        }
        public static bool InCircle(int X, int Y, Rectangle rect)
        {
            double ratio = (double)rect.Width / rect.Height;
            double r = rect.Height / 2;
            double y = rect.Height / 2 - Y;
            double x = (rect.Width / 2 - X) / ratio;
            if (x * x + y * y <= r * r)
            {
                return true;
            }
            return false;
        }
        public static bool PixelSearchCD(Rectangle rect, Color PixelColor)
        {
            int searchvalue = PixelColor.ToArgb();
            unsafe
            {
                Bitmap BMP = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
                Graphics GFX = Graphics.FromImage(BMP);
                GFX.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                using (FastBitmap bitmap = new FastBitmap(BMP))
                {
                    for (int i = 0; i < bitmap.Length; i++)
                    {
                        if (searchvalue == bitmap.GetI(i))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static Point PixelSearch(Rectangle rect, Color PixelColor)
        {
            int searchvalue = PixelColor.ToArgb();
            unsafe
            {
                Bitmap BMP = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
                Graphics GFX = Graphics.FromImage(BMP);
                GFX.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                using (FastBitmap bitmap = new FastBitmap(BMP))
                {
                    for (int i = 0; i < bitmap.Length; i++)
                    {
                        if (searchvalue == bitmap.GetI(i))
                        {
                            int x = i % bitmap.Width;
                            int y = i / bitmap.Width;
                            return new Point(x, y);
                        }
                    }
                }
            }
            return new Point(0, 0);
        }
    }
}
