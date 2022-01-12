using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace ClassicDarkTheme.Dark
{
    class DarkGroupbox : DarkPanel
    {
        [Category("Dark")]
        public string Header { get; set; } = "Header";
        [Category("Dark")]
        public int Far { get; set; } = 3;
        [Category("Dark")]
        public Font HeaderFont { get; set; } = new Font("Microsoft Sans Serif", 10.25f);
        [Category("Dark")]
        public Color HeaderColor { get; set; } = Color.White;
        [Category("Dark")]
        public StringAlignment HeaderAligment { get; set; } = StringAlignment.Center;
        [Category("Dark")]
        public StringAlignment HeaderAligmentLine { get; set; } = StringAlignment.Near;
        public DarkGroupbox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = HeaderAligment;
            stringFormat.LineAlignment = HeaderAligmentLine;

            // Draw the text and the surrounding rectangle.
            g.DrawString(Header, HeaderFont, new SolidBrush(HeaderColor),new RectangleF(this.ClientRectangle.X, this.ClientRectangle.Y + Far, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1), stringFormat);
            int seperator = Convert.ToInt32(this.HeaderFont.Size * 3f);
            g.DrawLine(new Pen(HeaderColor, 2f), 10, this.ClientRectangle.Y + seperator, this.ClientRectangle.Width - 11, this.ClientRectangle.Y + seperator);
        }
    }
}
