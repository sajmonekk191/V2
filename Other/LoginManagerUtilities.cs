using System.Windows.Forms;
namespace VoidSharp.Other
{
    class LoginManagerUtilities
    {
        public static bool AccountExists(int accID)
        {
            switch (accID)
            {
                case 1:
                    if (Properties.Settings.Default.Username1 != string.Empty && Properties.Settings.Default.Password1 != string.Empty)
                        return true;
                    break;
                case 2:
                    if (Properties.Settings.Default.Username2 != string.Empty && Properties.Settings.Default.Password2 != string.Empty)
                        return true;
                    break;
                case 3:
                    if (Properties.Settings.Default.Username3 != string.Empty && Properties.Settings.Default.Password3 != string.Empty)
                        return true;
                    break;
                case 4:
                    if (Properties.Settings.Default.Username4 != string.Empty && Properties.Settings.Default.Password4 != string.Empty)
                        return true;
                    break;
                case 5:
                    if (Properties.Settings.Default.Username5 != string.Empty && Properties.Settings.Default.Password5 != string.Empty)
                        return true;
                    break;
                case 6:
                    if (Properties.Settings.Default.Username6 != string.Empty && Properties.Settings.Default.Password6 != string.Empty)
                        return true;
                    break;
                case 7:
                    if (Properties.Settings.Default.Username7 != string.Empty && Properties.Settings.Default.Password7 != string.Empty)
                        return true;
                    break;
                case 8:
                    if (Properties.Settings.Default.Username8 != string.Empty && Properties.Settings.Default.Password8 != string.Empty)
                        return true;
                    break;
            }
            return false;
        }
        public static void DelAcc(SpecialForms.AccountManager am, int accID)
        {
            switch (accID)
            {
                case 1:
                    Properties.Settings.Default.Username1 = string.Empty;
                    Properties.Settings.Default.Password1 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername1.Text = "";
                    am.LBLpassword1.Text = "";
                    am.lbl1.Visible = false;
                    am.LBLusername1.Visible = false;
                    am.LBLpassword1.Visible = false;
                    am.selectedCB1.Visible = false;
                    am.showpassPB1.Visible = false;
                    am.selectedCB1.Checked = false;
                    break;
                case 2:
                    Properties.Settings.Default.Username2 = string.Empty;
                    Properties.Settings.Default.Password2 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername2.Text = "";
                    am.LBLpassword2.Text = "";
                    am.lbl2.Visible = false;
                    am.LBLusername2.Visible = false;
                    am.LBLpassword2.Visible = false;
                    am.selectedCB2.Visible = false;
                    am.showpassPB2.Visible = false;
                    am.selectedCB2.Checked = false;
                    break;
                case 3:
                    Properties.Settings.Default.Username3 = string.Empty;
                    Properties.Settings.Default.Password3 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername3.Text = "";
                    am.LBLpassword3.Text = "";
                    am.lbl3.Visible = false;
                    am.LBLusername3.Visible = false;
                    am.LBLpassword3.Visible = false;
                    am.selectedCB3.Visible = false;
                    am.showpassPB3.Visible = false;
                    am.selectedCB3.Checked = false;
                    break;
                case 4:
                    Properties.Settings.Default.Username4 = string.Empty;
                    Properties.Settings.Default.Password4 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername4.Text = "";
                    am.LBLpassword4.Text = "";
                    am.lbl4.Visible = false;
                    am.LBLusername4.Visible = false;
                    am.LBLpassword4.Visible = false;
                    am.selectedCB4.Visible = false;
                    am.showpassPB4.Visible = false;
                    am.selectedCB4.Checked = false;
                    break;
                case 5:
                    Properties.Settings.Default.Username5 = string.Empty;
                    Properties.Settings.Default.Password5 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername5.Text = "";
                    am.LBLpassword5.Text = "";
                    am.lbl5.Visible = false;
                    am.LBLusername5.Visible = false;
                    am.LBLpassword5.Visible = false;
                    am.selectedCB5.Visible = false;
                    am.showpassPB5.Visible = false;
                    am.selectedCB5.Checked = false;
                    break;
                case 6:
                    Properties.Settings.Default.Username6 = string.Empty;
                    Properties.Settings.Default.Password6 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername6.Text = "";
                    am.LBLpassword6.Text = "";
                    am.lbl6.Visible = false;
                    am.LBLusername6.Visible = false;
                    am.LBLpassword6.Visible = false;
                    am.selectedCB6.Visible = false;
                    am.showpassPB6.Visible = false;
                    am.selectedCB6.Checked = false;
                    break;
                case 7:
                    Properties.Settings.Default.Username7 = string.Empty;
                    Properties.Settings.Default.Password7 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername7.Text = "";
                    am.LBLpassword7.Text = "";
                    am.lbl7.Visible = false;
                    am.LBLusername7.Visible = false;
                    am.LBLpassword7.Visible = false;
                    am.selectedCB7.Visible = false;
                    am.showpassPB7.Visible = false;
                    am.selectedCB7.Checked = false;
                    break;
                case 8:
                    Properties.Settings.Default.Username8 = string.Empty;
                    Properties.Settings.Default.Password8 = string.Empty;
                    Properties.Settings.Default.Save();
                    am.LBLusername8.Text = "";
                    am.LBLpassword8.Text = "";
                    am.lbl8.Visible = false;
                    am.LBLusername8.Visible = false;
                    am.LBLpassword8.Visible = false;
                    am.selectedCB8.Visible = false;
                    am.showpassPB8.Visible = false;
                    am.selectedCB7.Checked = false;
                    break;
            }
        }
        public static void AccountLoader(SpecialForms.AccountManager am)
        {
            if (AccountExists(1))
            {
                am.lbl1.Visible = true;
                am.LBLusername1.Visible = true;
                am.LBLpassword1.Visible = true;
                am.selectedCB1.Visible = true;
                am.showpassPB1.Visible = true;
                am.LBLusername1.Text = Properties.Settings.Default.Username1;
                string tempname = Properties.Settings.Default.Password1;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword1.Text = temp;
            }
            if (AccountExists(2))
            {
                am.lbl2.Visible = true;
                am.LBLusername2.Visible = true;
                am.LBLpassword2.Visible = true;
                am.selectedCB2.Visible = true;
                am.showpassPB2.Visible = true;
                am.LBLusername2.Text = Properties.Settings.Default.Username2;
                string tempname = Properties.Settings.Default.Password2;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword2.Text = temp;
            }
            if (AccountExists(3))
            {
                am.lbl3.Visible = true;
                am.LBLusername3.Visible = true;
                am.LBLpassword3.Visible = true;
                am.selectedCB3.Visible = true;
                am.showpassPB3.Visible = true;
                am.LBLusername3.Text = Properties.Settings.Default.Username3;
                string tempname = Properties.Settings.Default.Password3;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword3.Text = temp;
            }
            if (AccountExists(4))
            {
                am.lbl4.Visible = true;
                am.LBLusername4.Visible = true;
                am.LBLpassword4.Visible = true;
                am.selectedCB4.Visible = true;
                am.showpassPB4.Visible = true;
                am.LBLusername4.Text = Properties.Settings.Default.Username4;
                string tempname = Properties.Settings.Default.Password4;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword4.Text = temp;
            }
            if (AccountExists(5))
            {
                am.lbl5.Visible = true;
                am.LBLusername5.Visible = true;
                am.LBLpassword5.Visible = true;
                am.selectedCB5.Visible = true;
                am.showpassPB5.Visible = true;
                am.LBLusername5.Text = Properties.Settings.Default.Username5;
                string tempname = Properties.Settings.Default.Password5;
                foreach (char ch in tempname)
                {
                    am.LBLpassword5.Text += "*";
                }
            }
            if (AccountExists(6))
            {
                am.lbl6.Visible = true;
                am.LBLusername6.Visible = true;
                am.LBLpassword6.Visible = true;
                am.selectedCB6.Visible = true;
                am.showpassPB6.Visible = true;
                am.LBLusername6.Text = Properties.Settings.Default.Username6;
                string tempname = Properties.Settings.Default.Password6;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword6.Text = temp;
            }
            if (AccountExists(7))
            {
                am.lbl7.Visible = true;
                am.LBLusername7.Visible = true;
                am.LBLpassword7.Visible = true;
                am.selectedCB7.Visible = true;
                am.showpassPB7.Visible = true;
                am.LBLusername7.Text = Properties.Settings.Default.Username7;
                string tempname = Properties.Settings.Default.Password7;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword7.Text = temp;
            }
            if (AccountExists(8))
            {
                am.lbl8.Visible = true;
                am.LBLusername8.Visible = true;
                am.LBLpassword8.Visible = true;
                am.selectedCB8.Visible = true;
                am.showpassPB8.Visible = true;
                am.LBLusername8.Text = Properties.Settings.Default.Username8;
                string tempname = Properties.Settings.Default.Password8;
                string temp = "";
                foreach (char ch in tempname)
                {
                    temp += "*";
                }
                am.LBLpassword8.Text = temp;
            }
        }
        public static void AddACC(SpecialForms.AccountManager am)
        {
            if (!AccountExists(1))
            {
                am.lbl1.Visible = true;
                am.LBLusername1.Visible = true;
                am.LBLpassword1.Visible = true;
                am.selectedCB1.Visible = true;
                am.showpassPB1.Visible = true;
                am.LBLusername1.Text = am.usernameTB.Text;
                am.LBLpassword1.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username1 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password1 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername1.Text = Properties.Settings.Default.Username1;
                string tempass = Properties.Settings.Default.Password1;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword1.Text = pass;
                return;
            }
            if (!AccountExists(2))
            {
                am.lbl2.Visible = true;
                am.LBLusername2.Visible = true;
                am.LBLpassword2.Visible = true;
                am.selectedCB2.Visible = true;
                am.showpassPB2.Visible = true;
                am.LBLusername2.Text = am.usernameTB.Text;
                am.LBLpassword2.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username2 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password2 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername2.Text = Properties.Settings.Default.Username2;
                string tempass = Properties.Settings.Default.Password2;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword2.Text = pass;
                return;
            }
            if (!AccountExists(3))
            {
                am.lbl3.Visible = true;
                am.LBLusername3.Visible = true;
                am.LBLpassword3.Visible = true;
                am.selectedCB3.Visible = true;
                am.showpassPB3.Visible = true;
                am.LBLusername3.Text = am.usernameTB.Text;
                am.LBLpassword3.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username3 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password3 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername3.Text = Properties.Settings.Default.Username3;
                string tempass = Properties.Settings.Default.Password3;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword3.Text = pass;
                return;
            }
            if (!AccountExists(4))
            {
                am.lbl4.Visible = true;
                am.LBLusername4.Visible = true;
                am.LBLpassword4.Visible = true;
                am.selectedCB4.Visible = true;
                am.showpassPB4.Visible = true;
                am.LBLusername4.Text = am.usernameTB.Text;
                am.LBLpassword4.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username4 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password4 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername4.Text = Properties.Settings.Default.Username4;
                string tempass = Properties.Settings.Default.Password4;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword4.Text = pass;
                return;
            }
            if (!AccountExists(5))
            {
                am.lbl5.Visible = true;
                am.LBLusername5.Visible = true;
                am.LBLpassword5.Visible = true;
                am.selectedCB5.Visible = true;
                am.showpassPB5.Visible = true;
                am.LBLusername5.Text = am.usernameTB.Text;
                am.LBLpassword5.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username5 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password5 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername5.Text = Properties.Settings.Default.Username5;
                string tempass = Properties.Settings.Default.Password5;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword5.Text = pass;
                return;
            }
            if (!AccountExists(6))
            {
                am.lbl6.Visible = true;
                am.LBLusername6.Visible = true;
                am.LBLpassword6.Visible = true;
                am.selectedCB6.Visible = true;
                am.showpassPB6.Visible = true;
                am.LBLusername6.Text = am.usernameTB.Text;
                am.LBLpassword6.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username6 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password6 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername6.Text = Properties.Settings.Default.Username6;
                string tempass = Properties.Settings.Default.Password6;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword6.Text = pass;
                return;
            }
            if (!AccountExists(7))
            {
                am.lbl7.Visible = true;
                am.LBLusername7.Visible = true;
                am.LBLpassword7.Visible = true;
                am.selectedCB7.Visible = true;
                am.showpassPB7.Visible = true;
                am.LBLusername7.Text = am.usernameTB.Text;
                am.LBLpassword7.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username7 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password7 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername7.Text = Properties.Settings.Default.Username7;
                string tempass = Properties.Settings.Default.Password7;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword7.Text = pass;
                return;
            }
            if (!AccountExists(8))
            {
                am.lbl8.Visible = true;
                am.LBLusername8.Visible = true;
                am.LBLpassword8.Visible = true;
                am.selectedCB8.Visible = true;
                am.showpassPB8.Visible = true;
                am.LBLusername8.Text = am.usernameTB.Text;
                am.LBLpassword8.Text = am.passwordTB.Text;
                Properties.Settings.Default.Username8 = am.usernameTB.Text.ToString();
                Properties.Settings.Default.Password8 = am.passwordTB.Text.ToString();
                Properties.Settings.Default.Save();
                am.LBLusername8.Text = Properties.Settings.Default.Username8;
                string tempass = Properties.Settings.Default.Password8;
                string pass = "";
                for (int i = 0; i < tempass.Length; i++)
                {
                    pass += "*";
                }
                am.LBLpassword8.Text = pass;
                return;
            }
        }
        public static void LoadAcc(SpecialForms.AccountManager am)
        {
            if (am.selectedCB1.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username1;
                hodnoty.CurentPassword = Properties.Settings.Default.Password1;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB2.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username2;
                hodnoty.CurentPassword = Properties.Settings.Default.Password2;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB3.Checked == true && SelectedSingleAcc(am))
            {
                
                hodnoty.CurentUsername = Properties.Settings.Default.Username3;
                hodnoty.CurentPassword = Properties.Settings.Default.Password3;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB4.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username4;
                hodnoty.CurentPassword = Properties.Settings.Default.Password4;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB5.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username5;
                hodnoty.CurentPassword = Properties.Settings.Default.Password5;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB6.Checked == true && SelectedSingleAcc(am))
            {
                
                hodnoty.CurentUsername = Properties.Settings.Default.Username6;
                hodnoty.CurentPassword = Properties.Settings.Default.Password6;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB7.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username7;
                hodnoty.CurentPassword = Properties.Settings.Default.Password7;
                hodnoty.success = true;
                return;
            }
            if (am.selectedCB8.Checked == true && SelectedSingleAcc(am))
            {
                hodnoty.CurentUsername = Properties.Settings.Default.Username8;
                hodnoty.CurentPassword = Properties.Settings.Default.Password8;
                hodnoty.success = true;
                return;
            }
            else
            {
                hodnoty.success = false;
                return;
            }
        }
        public static bool SelectedSingleAcc(SpecialForms.AccountManager am)
        {
            int count = 0;
            if (am.selectedCB1.Checked) count++;
            if (am.selectedCB2.Checked) count++;
            if (am.selectedCB3.Checked) count++;
            if (am.selectedCB4.Checked) count++; 
            if (am.selectedCB5.Checked) count++;
            if (am.selectedCB6.Checked) count++;
            if (am.selectedCB7.Checked) count++;
            if (am.selectedCB8.Checked) count++;

            if(count == 1) return true;
            return false;
        }
    }
}
