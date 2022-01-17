using System;
using System.Drawing;
using System.Windows.Forms;

namespace VoidSharp.SpecialForms
{
    public partial class AccountManager : Form
    {
        Point mousedownpoint = Point.Empty;
        public AccountManager()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void darkLabel5_MouseEnter(object sender, EventArgs e)
        {
            darkLabel5.BackColor = Color.FromArgb(156, 11, 11);
        }

        private void darkLabel5_MouseLeave(object sender, EventArgs e)
        {
            darkLabel5.BackColor = Color.Firebrick;
        }

        private void darkLabel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountManager_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void AccountManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void AccountManager_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
    }
}
