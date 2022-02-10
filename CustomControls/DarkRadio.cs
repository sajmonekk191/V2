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
    class DarkRadio : DarkCheckbox
    {
        public DarkRadio()
        {
            this.Type = Types.Circle;
            this.CheckedChanged += new EventHandler(DarkRadio_CheckedChanged);

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Parent = this.Parent;
            this.BackColor = Color.Transparent;
        }

        private void DarkRadio_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Parent.Controls)
            {
                if (control.GetType() == typeof(DarkRadio))
                {
                    DarkRadio radio = (DarkRadio)control;
                    if (!this.Checked && !radio.Checked)
                    {
                        this.Checked = true;
                        this.Invalidate();
                    }
                    if (radio != this)
                    {
                        if(this.Checked)
                        {
                            radio.Checked = false;
                        }
                        radio.Invalidate();
                    }
                }
            }
        }
    }
}
