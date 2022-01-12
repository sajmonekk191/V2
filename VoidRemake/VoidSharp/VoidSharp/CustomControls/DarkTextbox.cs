using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassicDarkTheme.Dark;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace AmongUsExternal
{
    public partial class DarkTextbox : Control
    {
        private Color _MainColor = Dark.DefaultButtonBackColor, _BorderColor = Dark.DefaultBorderColor, _ForeColor = Color.White;
        private string _Text = String.Empty;
        private bool _OnlyNumbers = false;
        TextBox tb = new TextBox();

        public DarkTextbox()
        {
            //InitializeComponent();
            tb.ForeColor = _ForeColor;
            tb.BackColor = _MainColor;
            tb.Font = Font;
            tb.Text = TextStr;

            ForeColor = _ForeColor;
            BackColor = _MainColor;

            Width = 100;
            Height = 20;
            tb.TextChanged += new EventHandler(hsTextChanged);
            tb.KeyPress += new KeyPressEventHandler(hsKeyPress);
            tb.Multiline = true;
            tb.ForeColor = _ForeColor;
            tb.BackColor = _MainColor;
            tb.Font = Font;
            tb.BorderStyle = BorderStyle.None;
            tb.Location = new Point(3, 3);
            tb.Size = new Size(this.Width - 6, this.Height - 6);
            this.Controls.Add(tb);
        }

        public string TextStr
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
            }
        }

        public bool OnlyNumbers
        {
            get
            {
                return _OnlyNumbers;
            }
            set
            {
                _OnlyNumbers = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return tb.MaxLength;
            }
            set
            {
                tb.MaxLength = value;
            }
        }

        public Color BorderColor
        {
            get
            {
                return _BorderColor;
            }
            set
            {
                _BorderColor = value;
            }
        }

        public event EventHandler TextHasBeenChanged;
        private static string tempText = string.Empty;

        new protected virtual void aTextChanged(EventArgs e)
        {
            EventHandler result = TextHasBeenChanged;
            if (tb.Text != tempText)
            {
                tempText = tb.Text;
                result(this, e);
            }
        }

        private void ExternalTextbox_Load(object sender, EventArgs e)
        {
            tb.Text = TextStr;
            tb.ForeColor = _ForeColor;
            tb.BackColor = _MainColor;
            tb.Font = Font;
            tb.Text = TextStr;

            ForeColor = _ForeColor;
            BackColor = _MainColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            tb.Size = new Size(this.Width - 6, this.Height - 6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            tb.Text = TextStr;
            tb.Multiline = true;
            tb.ForeColor = _ForeColor;
            tb.BackColor = _MainColor;
            tb.Font = Font;
            tb.BorderStyle = BorderStyle.None;
            tb.MaxLength = MaxLength;
            tb.Location = new Point(3, 3);
            tb.Size = new Size(this.Width - 6, this.Height - 6);

            e.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(new Pen(BorderColor), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void hsTextChanged(object sender, EventArgs e)
        {
            TextStr = tb.Text;
            if (TextHasBeenChanged != null)
            {
                TextHasBeenChanged(this, e);
            }
        }

        private void hsKeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnlyNumbers)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
