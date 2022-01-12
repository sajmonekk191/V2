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
    class DarkCircle : Control
    {
        [Category("Dark")]
        public float BorderThickness { get; set; } = 3;

        [Category("Dark")]
        public float GradientValue { get; set; } = 90f;
        [Category("Dark")]
        public Color CircleBorderColor { get; set; } = Dark.DefaultButtonBorderColor;
        [Category("Dark")]
        public Color CircleTopColor { get; set; } = Dark.DefaultButtonBackColor;
        [Category("Dark")]
        public Color CircleBottomColor { get; set; } = Dark.DefaultButtonBackColor;

        public DarkCircle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            this.ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
            LinearGradientBrush lgb = new
LinearGradientBrush(this.ClientRectangle, this.CircleTopColor,
this.CircleBottomColor, this.GradientValue);

            g.DrawEllipse(new Pen(lgb, BorderThickness), 1, 1, this.ClientRectangle.Width - 3 , this.ClientRectangle.Height - 3);
        }
    }
}
