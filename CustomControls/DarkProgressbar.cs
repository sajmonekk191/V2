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
    class DarkProgressbar : ProgressBar
    {
        [Category("Dark")]
        public float BorderThickness{ get; set; } = 3f;
        [Category("Dark")]
        public Color BorderColor { get; set; } = Dark.DefaultButtonBorderColor;
        [Category("Dark")]
        public Color ProgressBarBackColor { get; set; } = Dark.DefaultButtonBackColor;
        [Category("Dark")]
        public Color ProgressBarRightProgressColor { get; set; } = Color.Yellow;

        [Category("Dark")]
        public Color ProgressBarLeftProgressColor { get; set; } = Color.Red;

        public DarkProgressbar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
        }

        #region Radius
        private int radius = 3;
        [Category("Dark")]
        [DefaultValue(3)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }
        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
        private void RecreateRegion()
        {
            var bounds = ClientRectangle;
            bounds.Width--; bounds.Height--;
            using (var path = GetRoundRectagle(bounds, this.Radius))
                this.Region = new Region(path);
            this.Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            g.FillRectangle(new SolidBrush(ProgressBarBackColor), this.ClientRectangle);
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, this.ProgressBarRightProgressColor,
            this.ProgressBarLeftProgressColor, 180);
            e.Graphics.FillRectangle(lgb, 2, 2, rec.Width, rec.Height);
            g.DrawRectangle(new Pen(BorderColor, BorderThickness), this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 2, this.ClientRectangle.Height - 2);
        }
    }
}
