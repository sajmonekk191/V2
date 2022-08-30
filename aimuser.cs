using System;
using System.Windows.Forms;
using VoidSharp.Other;
using System.Runtime.InteropServices;

namespace VoidSharp
{
    public partial class aimuser : UserControl
    {
        public aimuser()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private void aimuser_Load(object sender, EventArgs e)
        {
            if (hodnoty.SelectedChamp != null)
            {
                championnamelbl.Text = hodnoty.SelectedChamp;
            }
            else
            {
                championnamelbl.Text = "Champion isn´t selected";
            }
        }

        private void cbQ_CheckedChanged(object sender, EventArgs e)
        {
            if(cbQ.Checked == true)
                hodnoty.QActivated = true;
            else
                hodnoty.QActivated = false;
        }

        private void cbW_CheckedChanged(object sender, EventArgs e)
        {
            if (cbW.Checked == true)
                hodnoty.WActivated = true;
            else
                hodnoty.WActivated = false;
        }

        private void cbE_CheckedChanged(object sender, EventArgs e)
        {
            if (cbE.Checked == true)
                hodnoty.EActivated = true;
            else
                hodnoty.EActivated = false;
        }

        private void cbR_CheckedChanged(object sender, EventArgs e)
        {
            if (cbR.Checked == true)
                hodnoty.RActivated = true;
            else
                hodnoty.RActivated = false;
        }

        private void Activatedcb_CheckedChanged(object sender, EventArgs e)
        {
            if (Activatedcb.Checked)
                hodnoty.AimActivated = true;
            else
                hodnoty.AimActivated = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            hodnoty.KeyQ = GetAsyncKeyState(Convert.ToInt16(KeybindQ.Text.ToUpper()));
            hodnoty.KeyW = GetAsyncKeyState(Convert.ToInt16(KeybindW.Text.ToUpper()));
            hodnoty.KeyE = GetAsyncKeyState(Convert.ToInt16(KeybindE.Text.ToUpper()));
            hodnoty.KeyR = GetAsyncKeyState(Convert.ToInt16(KeybindR.Text.ToUpper()));
        }
    }
}
