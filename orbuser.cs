using System;
using System.Windows.Forms;
using VoidSharp.Cheat;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class orbuser : UserControl
    {
        public orbuser()
        {
            InitializeComponent();
        }

        private void orbuser_Load(object sender, EventArgs e)
        {
           
        }

        private void UpdateValue_Tick(object sender, EventArgs e)
        {
            try
            {
                if (hodnoty.AutoHumanize)
                {
                    float aspeed = GetPlayerInfo.GetAttackSpeed();
                    if (aspeed < 0.6)
                    {
                        Humanizertb.Text = "150";
                    }
                    else if (aspeed > 0.6 && aspeed < 0.9)
                    {
                        Humanizertb.Text = "120";
                    }
                    else if (aspeed > 0.9 && aspeed < 1.3)
                    {
                        Humanizertb.Text = "90";
                    }
                    else if (aspeed > 1.3 && aspeed < 1.6)
                    {
                        Humanizertb.Text = "50";
                    }
                    else if (aspeed > 1.6)
                    {
                        Humanizertb.Text = "0";
                    }
                }
            }
            catch { };
            if (hodnoty.VoidActivated)
            {
                aslabel.Text = "AttackSpeed: " + GetPlayerInfo.GetAttackSpeed().ToString();
                arlabel.Text = "AttackRange: " + GetPlayerInfo.GetAttackRange().ToString();
            }
            else
            {
                aslabel.Text = "AttackSpeed: " + "null";
                arlabel.Text = "AttackRange: " + "null";
            }
        }

        private void AttackChampcb_CheckedChanged(object sender, EventArgs e)
        {
            if (AttackChampcb.Checked == true)
                hodnoty.AttackChamponly = true;
            else
                hodnoty.AttackChamponly = false;
        }

        private void AttackEverythingcb_CheckedChanged(object sender, EventArgs e)
        {
            if (AttackEverythingcb.Checked == true)
                hodnoty.AttackEverything = true;
            else
                hodnoty.AttackEverything = false;
        }

        private void showrangecb_CheckedChanged(object sender, EventArgs e)
        {
            if (showrangecb.Checked == true)
                hodnoty.ShowRange = true;
            else
                hodnoty.ShowRange = false;
        }

        private void tooglechampcb_CheckedChanged(object sender, EventArgs e)
        {
            if (tooglechampcb.Checked == true)
                hodnoty.tooglechamponly = true;
            else
                hodnoty.tooglechamponly = false;
        }

        private void Activatecb_CheckedChanged(object sender, EventArgs e)
        {
            if(Activatecb.Checked)
                hodnoty.OrbActivated = true;
            else
                hodnoty.OrbActivated= false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Space":
                    hodnoty.OrbwalkerKey = Keys.Space;
                    break;
                case "V":
                    hodnoty.OrbwalkerKey = Keys.V;
                    break;
                case "C":
                    hodnoty.OrbwalkerKey = Keys.C;
                    break;
                case "X":
                    hodnoty.OrbwalkerKey = Keys.X;
                    break;
            }
        }

        private void autohuma_CheckedChanged(object sender, EventArgs e)
        {
            if (autohuma.Checked == true) hodnoty.AutoHumanize = true;
            else hodnoty.AutoHumanize = false;
        }
    }
}
