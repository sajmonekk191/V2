using System;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class combos : UserControl
    {
        public combos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                hodnoty.CombosActivated = true;
            else
                hodnoty.CombosActivated = false;

        }

        private void Qcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Qcheckbox.Checked)
            {
                hodnoty.QEnabled = true;
                manaQcb.Enabled = true;
            }
            else
            {
                hodnoty.QEnabled = false;
                manaQcb.Enabled = false;
            }
        }

        private void Wcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Wcheckbox.Checked)
            {
                hodnoty.WEnabled = true;
                manaWcb.Enabled = true;
            }
            else
            {
                hodnoty.WEnabled = false;
                manaWcb.Enabled = false;
            }
        }

        private void Echeckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Echeckbox.Checked)
            {
                hodnoty.EEnabled = true;
                manaEcb.Enabled = true;
            }
            else
            {
                hodnoty.EEnabled = false;
                manaEcb.Enabled = false;
            }
        }

        private void Rcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Rcheckbox.Checked)
            {
                hodnoty.REnabled = true;
                manaRcb.Enabled = true;
            }
            else
            {
                hodnoty.REnabled = false;
                manaRcb.Enabled = false;
            }
        }

        private void Qtb_ValueChanged(object sender, EventArgs e)
        {
            if (manaQcb.Checked)hodnoty.QManaValue = Qtb.Value;
        }

        private void Wtb_ValueChanged(object sender, EventArgs e)
        {
            if (manaWcb.Checked) hodnoty.WManaValue = Wtb.Value;
        }

        private void Etb_ValueChanged(object sender, EventArgs e)
        {
            if (manaEcb.Checked) hodnoty.EManaValue = Etb.Value;
        }

        private void Rtb_ValueChanged(object sender, EventArgs e)
        {
            if (manaRcb.Checked) hodnoty.RManaValue = Rtb.Value;
        }

        private void manaQcb_CheckedChanged(object sender, EventArgs e)
        {
            if (manaQcb.Checked) Qtb.Enabled = true;
            else Qtb.Enabled = false;
        }

        private void manaWcb_CheckedChanged(object sender, EventArgs e)
        {
            if (manaWcb.Checked) Wtb.Enabled = true;
            else Wtb.Enabled = false;
        }

        private void manaEcb_CheckedChanged(object sender, EventArgs e)
        {
            if (manaEcb.Checked) Etb.Enabled = true;
            else Etb.Enabled = false;
        }

        private void manaRcb_CheckedChanged(object sender, EventArgs e)
        {
            if (manaRcb.Checked) Rtb.Enabled = true;
            else Rtb.Enabled = false;
        }
    }
}
