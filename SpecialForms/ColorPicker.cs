using System;
using VoidSharp.Other;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Hazdryx.Drawing;
using System.Runtime.InteropServices;

namespace VoidSharp.SpecialForms
{
    public partial class ColorPicker : Form
    {
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        bool startPicking = false;
        Point mousedownpoint = Point.Empty;
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            Color EnemyColor = new Color();
            try { EnemyColor = Color.FromArgb(Convert.ToByte(textBox1.Text), Convert.ToByte(textBox3.Text), Convert.ToByte(textBox2.Text)); }
            catch { }
            if (!hodnoty.selectcolorchamp)
            {
                hodnoty.AutoAcceptColor = EnemyColor;
                Properties.Settings.Default.AcceptColor = hodnoty.AutoAcceptColor;
            }
            else
            {
                hodnoty.EnemyPix = EnemyColor;
                hodnoty.selectcolorchamp = false;
                Properties.Settings.Default.ChampColor = hodnoty.EnemyPix;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ColorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void ColorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void ColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!startPicking)
            {
                startPicking = true;
                Picker.Start();
            }
        }

        private void Picker_Tick(object sender, EventArgs e)
        {
            Point undermous = Cursor.Position;
            Color picked = GetColorAt(undermous);
            textBox1.Text = picked.R.ToString();
            textBox3.Text = picked.G.ToString();
            textBox2.Text = picked.B.ToString();
            hodnoty.EnemyPix = picked;
        }
        private Color GetColorAt(Point point)
        {
            Bitmap bitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(bitmap))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, point.X, point.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return bitmap.GetPixel(0, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (startPicking)
            {
                startPicking = false;
                Picker.Stop();
            }
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(143, 37, 37);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(127, 37, 37);
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            if(hodnoty.selectcolorchamp) pictureBox1.Image = Properties.Resources.pixelimg;
            else pictureBox1.Image = Properties.Resources.Acceptimg;
        }
    }
}
