using System;
using System.Drawing;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.SpecialForms
{
    public partial class DrawGUI : Form
    {
        Point mousedownpoint = Point.Empty;
        public DrawGUI()
        {
            InitializeComponent();
        }

        private void DrawGUI_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BackColor = Color.FromArgb(31, 28, 28);
            this.TransparencyKey = Color.FromArgb(31, 28, 28);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(20, 20);
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
        private void label1_Click(object sender, EventArgs e)
        {
            if(aimuser1.Visible == true) aimuser1.Visible = false;
            else aimuser1.Visible = true;
        }
    }
}
