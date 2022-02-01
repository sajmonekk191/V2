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
    [DefaultEvent("CheckedChanged")]
    class DarkCheckbox : Control
    {
        private Dark.MouseEvent Mouse = new Dark.MouseEvent();
        [Category("Dark")]
        public int BorderThickness { get; set; } = 3;
        [Category("Dark")]
        public bool Checked { get; set; } = false;
        [Category("Dark")]
        public Types Type { get; set; } = Types.Standart;
        [Category("Dark")]
        public Color CheckboxBorderColor { get; set; } = Dark.DefaultButtonBorderColor;
        [Category("Dark")]
        public Color CheckboxBackColor { get; set; } = Dark.DefaultTextboxBackColor ;
        [Category("Dark")]
        public Color CheckboxDownColor { get; set; } = Dark.DefaultButtonDown;
        [Category("Dark")]
        public Color CheckboxUpColor { get; set; } = Dark.DefaultButtonHover;
        [Category("Dark")]
        public Color CheckboxHoverColor { get; set; } = Dark.DefaultButtonHover;
        [Category("Dark")]
        public Color CheckboxLeaveColor { get; set; } = Dark.DefaultButtonBackColor;

        public event EventHandler CheckedChanged;
        private static bool tempChecked = false;

        new protected virtual void InvokeCheckedChanged(EventArgs e)
        {
            EventHandler result = CheckedChanged;
            if (Checked != tempChecked)
            {
                tempChecked = Checked;
                result(this, e);
            }
        }

        public DarkCheckbox()
        {
            this.Size = new System.Drawing.Size(24, 24) ;
            this.Cursor = Cursors.Hand;
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12.25f);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
        }

        private bool clickEvent = false;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            clickEvent = true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Parent = this.Parent;
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            Checked = !Checked;
            Mouse = Dark.MouseEvent.Down;
            if (CheckedChanged != null) { CheckedChanged(this, new EventArgs()); }
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

        public enum Types
        {
            Standart,
            Circle
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;

            Color currentColor = CheckboxBackColor;
            if (Mouse == Dark.MouseEvent.Down && clickEvent)
            {
                currentColor = CheckboxDownColor;
            }
            else if (Mouse == Dark.MouseEvent.Up)
            {
                currentColor = CheckboxUpColor;
            }
            else if (Mouse == Dark.MouseEvent.Hover)
            {
                currentColor = CheckboxHoverColor;
            }
            else if (Mouse == Dark.MouseEvent.Leave)
            {
                currentColor = CheckboxBackColor;
            }

            g.FillEllipse(new SolidBrush(currentColor), this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            g.FillEllipse(new SolidBrush(CheckboxBorderColor), this.ClientRectangle.X + BorderThickness, this.ClientRectangle.Y + BorderThickness, this.ClientRectangle.Width - 1 - BorderThickness * 2, this.ClientRectangle.Height - 1 - BorderThickness * 2);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            if(Checked && Type == Types.Standart)
            {
                TextRenderer.DrawText(g, "", Font, new Point(Width + 3, Height / 2), ForeColor, flags);
            }
            else if (Checked && Type == Types.Circle)
            {
                g.FillEllipse(new SolidBrush(ForeColor), this.ClientRectangle.X + BorderThickness * 2, this.ClientRectangle.Y + BorderThickness * 2, this.ClientRectangle.Width - 1 - BorderThickness * 4, this.ClientRectangle.Height - 1 - BorderThickness * 4);
            }
        }
    }
}
