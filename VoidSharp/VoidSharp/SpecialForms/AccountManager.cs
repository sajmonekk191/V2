using System;
using System.Drawing;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.SpecialForms
{
    public partial class AccountManager : Form
    {
        Point mousedownpoint = Point.Empty;
        public AccountManager()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            lbl1.Visible = false;
            LBLusername1.Visible = false;
            LBLpassword1.Visible = false;
            selectedCB1.Visible = false;
            showpassPB1.Visible = false;

            lbl2.Visible = false;
            LBLusername2.Visible = false;
            LBLpassword2.Visible = false;
            selectedCB2.Visible = false;
            showpassPB2.Visible = false;

            lbl3.Visible = false;
            LBLusername3.Visible = false;
            LBLpassword3.Visible = false;
            selectedCB3.Visible = false;
            showpassPB3.Visible = false;

            lbl4.Visible = false;
            LBLusername4.Visible = false;
            LBLpassword4.Visible = false;
            selectedCB4.Visible = false;
            showpassPB4.Visible = false;

            lbl5.Visible = false;
            LBLusername5.Visible = false;
            LBLpassword5.Visible = false;
            selectedCB5.Visible = false;
            showpassPB5.Visible = false;

            lbl6.Visible = false;
            LBLusername6.Visible = false;
            LBLpassword6.Visible = false;
            selectedCB6.Visible = false;
            showpassPB6.Visible = false;

            lbl7.Visible = false;
            LBLusername7.Visible = false;
            LBLpassword7.Visible = false;
            selectedCB7.Visible = false;
            showpassPB7.Visible = false;

            lbl8.Visible = false;
            LBLusername8.Visible = false;
            LBLpassword8.Visible = false;
            selectedCB8.Visible = false;
            showpassPB8.Visible = false;
        }

        private void darkLabel5_MouseEnter(object sender, EventArgs e)
        {
            ExitLBL.BackColor = Color.FromArgb(156, 11, 11);
        }

        private void darkLabel5_MouseLeave(object sender, EventArgs e)
        {
            ExitLBL.BackColor = Color.Firebrick;
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

        private void AccountManager_Load(object sender, EventArgs e)
        {
            
        }
        private void AddAccount()
        {
            if (hodnoty.AccountUsed1 == false)
            {
                lbl1.Visible = true;
                LBLusername1.Visible = true;
                LBLpassword1.Visible = true;
                selectedCB1.Visible = true;
                showpassPB1.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername1.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword1.Text += "*";
                }

            }
            else if (hodnoty.AccountUsed2 == false)
            {
                lbl2.Visible = true;
                LBLusername2.Visible = true;
                LBLpassword2.Visible = true;
                selectedCB2.Visible = true;
                showpassPB2.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername2.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword2.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed3 == false)
            {
                lbl3.Visible = true;
                LBLusername3.Visible = true;
                LBLpassword3.Visible = true;
                selectedCB3.Visible = true;
                showpassPB3.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername3.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword3.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed4 == false)
            {
                lbl4.Visible = true;
                LBLusername4.Visible = true;
                LBLpassword4.Visible = true;
                selectedCB4.Visible = true;
                showpassPB4.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername4.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword4.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed5 == false)
            {
                lbl5.Visible = true;
                LBLusername5.Visible = true;
                LBLpassword5.Visible = true;
                selectedCB5.Visible = true;
                showpassPB5.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername5.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword5.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed6 == false)
            {
                lbl6.Visible = true;
                LBLusername6.Visible = true;
                LBLpassword6.Visible = true;
                selectedCB6.Visible = true;
                showpassPB6.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername6.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword6.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed7 == false)
            {
                lbl7.Visible = true;
                LBLusername7.Visible = true;
                LBLpassword7.Visible = true;
                selectedCB7.Visible = true;
                showpassPB7.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername7.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword7.Text += "*";
                }
            }
            else if (hodnoty.AccountUsed8 == false)
            {
                lbl8.Visible = true;
                LBLusername8.Visible = true;
                LBLpassword8.Visible = true;
                selectedCB8.Visible = true;
                showpassPB8.Visible = true;
                string user = usernameTB.Text;
                string pass = passwordTB.Text;
                LBLusername8.Text = user;
                foreach (char ch in pass)
                {
                    LBLpassword8.Text += "*";
                }
            }
        }

        private void AddAccountBTN_Click(object sender, EventArgs e)
        {
            AddAccount();
        }
    }
}
