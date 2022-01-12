using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace ClassicDarkTheme.Dark
{
    class DarkButton :  Button
    {
        private Dark.MouseEvent Mouse = new Dark.MouseEvent();
        private Point lastLocation = new Point();
        //[Category("Dark")]
        //[DefaultValue(1)]
        //public int BorderThickness { get; set; }
        [Category("Dark")]
        public Color MouseBackColor { get; set; } = Dark.DefaultTextboxBackColor;
        [Category("Dark")]
        public Color MouseDownColor { get; set; } = Dark.DefaultButtonDown;
        [Category("Dark")]
        public Color MouseUpColor { get; set; } = Dark.DefaultButtonHover;
        [Category("Dark")]
        public Color MouseHoverColor { get; set; } = Dark.DefaultButtonHover;
        [Category("Dark")]
        public Color MouseLeaveColor { get; set; } = Dark.DefaultTextboxBackColor;
        //[Category("Dark")]
        //public Color MouseBorderColor { get; set; } = Dark.DefaultButtonBorderColor;   

        private bool clickEvent = false;
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
        public DarkButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.ForeColor = Color.White;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
            this.Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            clickEvent = true;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            Mouse = Dark.MouseEvent.Down;
            this.InvokeOnClick(this, EventArgs.Empty);
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            Mouse = Dark.MouseEvent.Up;
            this.Invalidate();
        }

        protected override void OnMouseHover(EventArgs e)
        {
            Mouse = Dark.MouseEvent.Hover;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Mouse = Dark.MouseEvent.Leave;
            this.Invalidate();
        }

        int counter = 0;
        int alpha = 0;
        bool circle = false;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            Color currentColor = MouseBackColor;
            if (Mouse == Dark.MouseEvent.Down && clickEvent)
            {
                currentColor = MouseDownColor;
            }
            else if (Mouse == Dark.MouseEvent.Up)
            {
                currentColor = MouseUpColor;
            }
            else if (Mouse == Dark.MouseEvent.Hover)
            {
                currentColor = MouseHoverColor;
            }
            else if (Mouse == Dark.MouseEvent.Leave)
            {
                currentColor = MouseBackColor;
            }

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.FillRectangle(new SolidBrush(currentColor), this.ClientRectangle);
            if (Mouse == Dark.MouseEvent.Down)
            {
                //counter++;
                //this.Refresh();
                //if (alpha != 255)
                //{
                //    alpha++;
                //    this.Refresh();
                //}
            }
            if(Mouse == Dark.MouseEvent.Hover || Mouse == Dark.MouseEvent.Up || Mouse == Dark.MouseEvent.Leave)
            {
               // //if(counter != 0)
               // //{
               // //    counter--;
               // //}
               // counter++;
               //if(alpha != 0)
               // {
               //     alpha--;
               //     this.Refresh();
               // }
               // else
               // {
               //     counter = 0;
               //     this.Refresh();
               // }
            }
            //Color newColor = Color.FromArgb(alpha, Color.Red);
            g.FillEllipse(new SolidBrush(currentColor), new RectangleF(lastLocation.X - counter / 2, lastLocation.Y - counter / 2, counter, counter));

                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}
