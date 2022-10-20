using System;
using System.Windows.Forms;
using DiscordRPC;
using VoidSharp.Cheat;
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
                hodnoty.AutoAcceptWorking = true;
                AutoAcceptlbl.Text = "Disable AutoAccept";
                VoidSharp.AutoAccpt.Enabled = true;
                VoidSharp.AutoAccpt.Start();
            }
            else
            {
                hodnoty.AutoAcceptWorking = false;
                AutoAcceptlbl.Text = "Enable AutoAccept";
                VoidSharp.AutoAccpt.Enabled = false;
                VoidSharp.AutoAccpt.Stop();
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
                Details = "Connected: " + hodnoty.CurentUsername,
                State = "Playing: " + hodnoty.SelectedChamp,
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "discordlogo",
                    LargeImageText = "VoidSharp"
                }
            });
            discordInitalized = true;
        }

        private void Afkscriptcb_CheckedChanged(object sender, EventArgs e)
        {
            if (Afkscriptcb.Checked)
            {
                hodnoty.AFKisActivated = true;
                afkscriptlbl.Text = "Disable AFK Script";
                VoidSharp.AfkScript.Enabled = true;
                VoidSharp.AfkScript.Start();
                Keyboard.SendKeyDown(Keyboard.ScanCodeShort.SPACE);
            }
            else
            {
                hodnoty.AFKisActivated = false;
                afkscriptlbl.Text = "Enable AFK Script";
                VoidSharp.AfkScript.Enabled = false;
                VoidSharp.AfkScript.Stop();
                Keyboard.SendKeyUp(Keyboard.ScanCodeShort.SPACE);
            }
        }

        private void acceptoptionpb_Click(object sender, EventArgs e)
        {
            hodnoty.selectcolorchamp = false;
            SpecialForms.ColorPicker cp = new SpecialForms.ColorPicker();
            cp.Show();
        }
    }
}
