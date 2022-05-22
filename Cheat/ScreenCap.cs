using VoidSharp.Other;
using System.Drawing;
using System.Drawing.Imaging;
using Hazdryx.Drawing;
using System.Windows.Forms;

namespace VoidSharp.Cheat
{
    internal class ScreenCap
    {
        public static Point GetEnemyPosition(double ClientRange)
        {
            if (ClientRange >= 500 && ClientRange <= 550)
            {
                Rectangle rect = new Rectangle(450, 70, 910, 750);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            if (ClientRange >= 550 && ClientRange <= 600)
            {
                Rectangle rect = new Rectangle(462, 70, 913, 782);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            if (ClientRange >= 600 && ClientRange <= 650)
            {
                Rectangle rect = new Rectangle(403, 71, 964, 809);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            if (ClientRange >= 650 && ClientRange <= 725)
            {
                Rectangle rect = new Rectangle(362, 35, 1100, 875);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            if (ClientRange >= 725 && ClientRange <= 850)
            {
                Rectangle rect = new Rectangle(287, 0, 1225, 890);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            if (ClientRange > 850)
            {
                Rectangle rect = new Rectangle(200, 0, 1380, 900);
                return new Point((Size)PixelSearchEnemy(rect, hodnoty.EnemyPix));
            }
            return new Point(0,0);
        }
        public static Point PixelSearchEnemy(Rectangle rect, Color PixelColor)
        {
            int offsetX = 60;
            int offsetY = 140;
            
            // Adjust rectangle if screen is not 16:9 1080p
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
            }
            
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
                            if (InCircle(x, y, rect))
                            {
                                return new Point(x + rect.X + offsetX, y + rect.Y + offsetY);
                            }
                        }
                    }
                }
            }
            return new Point(0, 0);
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
    }
}
