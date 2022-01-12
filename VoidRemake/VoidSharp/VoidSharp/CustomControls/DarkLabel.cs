using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    class DarkLabel : Label
    {
        [Category("Dark")]
        public bool IsLink { get; set; } = false;

        [Category("Dark")]
        public string Link { get; set; } = string.Empty;

        public DarkLabel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(27, 26, 27);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(IsLink)
            {
                Process.Start(Link);
            }
        }
    }
}
