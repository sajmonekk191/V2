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
            passwordTB.UseSystemPasswordChar = true;
            usernameTB.BackColor = Color.FromArgb(32, 32, 32);
            passwordTB.BackColor = Color.FromArgb(32, 32, 32);
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
            LoginManagerUtilities.AccountLoader(this);
        }
        private void AddAccount()
        {
            LoginManagerUtilities.AddACC(this);
        }

        private void AddAccountBTN_Click(object sender, EventArgs e)
        {
            AddAccount();
            usernameTB.Clear();
            passwordTB.Clear();
        }
        private void LoadBTN_Click(object sender, EventArgs e)
        {
            LoginManagerUtilities.LoadAcc(this);
            ErrorWindow ew = new ErrorWindow();
            ew.Show();
            ew.BringToFront();
            Properties.Settings.Default.CurentUsername = hodnoty.CurentUsername;
            Properties.Settings.Default.Save();
        }
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (selectedCB1.Checked == true) LoginManagerUtilities.DelAcc(this, 1);
            if (selectedCB2.Checked == true) LoginManagerUtilities.DelAcc(this, 2);
            if (selectedCB3.Checked == true) LoginManagerUtilities.DelAcc(this, 3);
            if (selectedCB4.Checked == true) LoginManagerUtilities.DelAcc(this, 4);
            if (selectedCB5.Checked == true) LoginManagerUtilities.DelAcc(this, 5);
            if (selectedCB6.Checked == true) LoginManagerUtilities.DelAcc(this, 6);
            if (selectedCB7.Checked == true) LoginManagerUtilities.DelAcc(this, 7);
            if (selectedCB8.Checked == true) LoginManagerUtilities.DelAcc(this, 8);
        }
        private void showpassPB1_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword1, Properties.Settings.Default.Password1);
        }

        private void showpassPB2_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword2, Properties.Settings.Default.Password2);
        }

        private void showpassPB3_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword3, Properties.Settings.Default.Password3);
        }

        private void showpassPB4_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword4, Properties.Settings.Default.Password4);
        }

        private void showpassPB5_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword5, Properties.Settings.Default.Password5);
        }

        private void showpassPB6_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword6, Properties.Settings.Default.Password6);
        }

        private void showpassPB7_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword7, Properties.Settings.Default.Password7);
        }

        private void showpassPB8_Click(object sender, EventArgs e)
        {
            ShowPassword(LBLpassword8, Properties.Settings.Default.Password8);
        }
        private void ShowPassword(Label label, string password)
        {
            string passtext = label.Text;
            if (passtext.Contains("*"))
            {
                hodnoty.HashedPassword = label.Text;
                label.Text = password;
            }
            else
            {
                label.Text = hodnoty.HashedPassword;
            }
        }
    }
}
