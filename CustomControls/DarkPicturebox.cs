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
    public class DarkPicturebox : PictureBox
    {
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

        public DarkPicturebox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
        }
    }
}
