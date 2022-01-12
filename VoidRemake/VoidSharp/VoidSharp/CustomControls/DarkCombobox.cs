using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace ClassicDarkTheme.Dark
{
    class DarkCombobox : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Dark.DefaultBorderColor;

        public StringAlignment Aligment { get; set; } = StringAlignment.Near;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public DarkCombobox()
        {
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Popup;
            this.BackColor = Dark.DefaultButtonBackColor;
            this.DrawMode = DrawMode.OwnerDrawFixed;
            //this.DropDownStyle = ComboBoxStyle.DropDownList;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
     ControlStyles.OptimizedDoubleBuffer |
     ControlStyles.ResizeRedraw, true);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                        var d = FlatStyle == FlatStyle.Popup ? 1 : 0;
                        g.DrawLine(p, Width - buttonWidth - d,
                            0, Width - buttonWidth - d, Height);
                    }
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = new SolidBrush(this.ForeColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = Aligment;
            stringFormat.LineAlignment = Aligment;
            e.DrawBackground();
            e.Graphics.DrawString(this.Items[index].ToString(), e.Font, brush, e.Bounds, stringFormat);
            e.DrawFocusRectangle();
        }
    }
}
