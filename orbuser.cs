using System;
using System.Windows.Forms;
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
                hodnoty.AvPing = Convert.ToInt32(pingtb.Text);
                hodnoty.HumanizerTime = Convert.ToInt32(Humanizertb.Text);
            }
            catch { };
            aslabel.Text = "AttackSpeed: " + Cheat.GetPlayerInfo.GetAttackSpeed().ToString();
            arlabel.Text = "AttackRange: " + Cheat.GetPlayerInfo.GetAttackRange().ToString();
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
    }
}
