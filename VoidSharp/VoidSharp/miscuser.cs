using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VoidSharp
{
    public partial class miscuser : UserControl
    {
        public miscuser()
        {
            InitializeComponent();
            championcmb.Visible = false;
            championlbl.Visible = false;
            championcmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Autologinpb_Click(object sender, EventArgs e)
        {
            
        }

        private void accountsbtn_Click(object sender, EventArgs e)
        {
            SpecialForms.AccountManager am = new SpecialForms.AccountManager();
            am.Show();
            am.BringToFront();
        }

        private void Autologincb_CheckedChanged(object sender, EventArgs e)
        {
            if (Autologincb.Checked)
            {
                AutoLoginlbl.Text = "Disable AutoLogin";
            }
            else
            {
                AutoLoginlbl.Text = "Enable AutoLogin";
            }
        }

        private void AutoAcceptcb_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoAcceptcb.Checked)
            {
                AutoAcceptlbl.Text = "Disable AutoAccept";
            }
            else
            {
                AutoAcceptlbl.Text = "Enable AutoAccept";
            }
        }

        private void AutoChampselectcb_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoChampselectcb.Checked)
            {
                autochampselectlbl.Text = "Disable Auto ChampSelect";
                championcmb.Visible = true;
                championlbl.Visible = true;
            }
            else
            {
                autochampselectlbl.Text = "Enable Auto ChampSelect";
                championcmb.Visible = false;
                championlbl.Visible = false;
            }
        }

        private void dcrpccb_CheckedChanged(object sender, EventArgs e)
        {
            if (dcrpccb.Checked)
            {
                dcrpclbl.Text = "Disable DiscordRPC";
            }
            else
            {
                dcrpclbl.Text = "Enable DiscordRPC";
            }
        }
    }
}
