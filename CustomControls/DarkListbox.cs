using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace ClassicDarkTheme.Dark
{
    class DarkListbox : ListBox
    {
        [Category("Dark")]
        public float BorderThickness { get; set; } = 2f;
        [Category("Dark")]
        public Color BorderColor { get; set; } = Dark.DefaultBorderColor;

        public DarkListbox()
        {
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Dark.DefaultButtonBackColor;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            Graphics g = Graphics.FromHwnd(m.HWnd);
            g.DrawRectangle(new Pen(BorderColor, BorderThickness), 0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        }
    }
}
