using System;
using System.Windows.Forms;
using DiscordRPC;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class miscuser : UserControl
    {
        DiscordRpcClient client;
        bool discordInitalized = false;
        public miscuser()
        {
            InitializeComponent();
            championcmb.Visible = false;
            championlbl.Visible = false;
            championcmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void accountsbtn_Click(object sender, EventArgs e)
        {
            SpecialForms.AccountManager am = new SpecialForms.AccountManager();
            am.Show();
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
            if (dcrpccb.Checked && !discordInitalized)
            {
                dcrpclbl.Text = "Disable DiscordRPC";
                client = new DiscordRpcClient(hodnoty.DiscordRpcID);
                client.Initialize();
                StartDiscordRPC();
            }
            else
            {
                dcrpclbl.Text = "Enable DiscordRPC";
                client.Dispose();
                discordInitalized = false;
            }
        }
        private void StartDiscordRPC()
        {
            client.SetPresence(new RichPresence()
            {
                Details = "TEST VOID2",
                State = "",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "discordlogo",
                    LargeImageText = "VoidSharp"
                }
            });
            discordInitalized = true;
        }
    }
}
