using System;
using System.Drawing;
using System.Windows.Forms;
using VoidSharp.Other;
using GameOverlay;

namespace VoidSharp.SpecialForms
{
    public partial class DrawGUI : Form
    {
        Graphics g;
        Timer timer = new Timer();
        Point mousedownpoint = Point.Empty;
        public DrawGUI()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 2;
            timer.Tick += new EventHandler(TimerCallback);
        }

        private void DrawGUI_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BackColor = Color.FromArgb(31, 28, 28);
            this.TransparencyKey = Color.FromArgb(31, 28, 28);
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Location = new Point(0, 0);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80000 | 0x20;
                return cp;
            }
        }
        private void DrawGUI_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void DrawGUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            DrawGUI f = sender as DrawGUI;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void DrawGUI_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
        private void TimerCallback(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            Point mp = Cursor.Position;
            Pen p = new Pen(Color.Blue, 2);
            g.DrawEllipse(p, mp.X - 90, mp.Y - 90, 200, 200);
        }
    }
}
