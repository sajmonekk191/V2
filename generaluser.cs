using System;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class generaluser : UserControl
    {
        public generaluser()
        {
            InitializeComponent();
            wlbl.Visible = false;
            bwlbl.Visible = false;
            Statuslbl2.Visible = true;
            hodnoty.VoidActivated = false;
            enablebutton.Text = "Enable Void";
            Statuslbl2.Text = "Disabled";
            champcb.DropDownStyle = ComboBoxStyle.DropDownList;
            champcb.Items.Insert(0, "Select Champion");
            champcb.SelectedIndex = 0;
            statuspb.Image = Properties.Resources.Fail;
        }

        private void enablebutton_Click(object sender, EventArgs e)
        {
            Statuslbl2.Visible = true;
            if (!hodnoty.VoidActivated)
            {
                enablebutton.Text = "Disable Void";
                Statuslbl2.Text = "Enabled";
                hodnoty.VoidActivated = true;
                statuspb.Image = Properties.Resources.Succesfull;
            }
            else
            {
                enablebutton.Text = "Enable Void";
                Statuslbl2.Text = "Disabled";
                hodnoty.VoidActivated = false;
                statuspb.Image = Properties.Resources.Fail;
            }
        }
        private void champcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (champcb.SelectedItem.ToString().Trim())
            {
                case "Aphelios":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.aphelios;

                    wlbl.Text = ("Windup: " + hodnoty.aphelioswu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.apheliosbwu.ToString());
                    hodnoty.finalWindup = hodnoty.aphelioswu;
                    hodnoty.finalBaseWindup = hodnoty.apheliosbwu;
                    hodnoty.SelectedChamp = "Aphelios";
                    break;
                case "Ashe":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.ashe;

                    wlbl.Text = ("Windup: " + hodnoty.ashewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.ashebwu.ToString());
                    hodnoty.finalWindup = hodnoty.ashewu;
                    hodnoty.finalBaseWindup = hodnoty.ashebwu;
                    hodnoty.SelectedChamp = "Ashe";
                    break;
                case "Caitlyn":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.caitlyn;

                    wlbl.Text = ("Windup: " + hodnoty.caitlynwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.caitlynbwu.ToString());
                    hodnoty.finalWindup = hodnoty.caitlynwu;
                    hodnoty.finalBaseWindup = hodnoty.caitlynbwu;
                    hodnoty.SelectedChamp = "Caitlyn";
                    break;
                case "Corki":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.corki;

                    wlbl.Text = ("Windup: " + hodnoty.corkiwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.corkibwu.ToString());
                    hodnoty.finalWindup = hodnoty.corkiwu;
                    hodnoty.finalBaseWindup = hodnoty.corkibwu;
                    hodnoty.SelectedChamp = "Corki";
                    break;
                case "Draven":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.draven;

                    wlbl.Text = ("Windup: " + hodnoty.dravenwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.dravenbwu.ToString());
                    hodnoty.finalWindup = hodnoty.dravenwu;
                    hodnoty.finalBaseWindup = hodnoty.dravenbwu;
                    hodnoty.SelectedChamp = "Draven";
                    break;
                case "Ezreal":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.ezreal;

                    wlbl.Text = ("Windup: " + hodnoty.ezrealwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.ezrealbwu.ToString());
                    hodnoty.finalWindup = hodnoty.ezrealwu;
                    hodnoty.finalBaseWindup = hodnoty.ezrealbwu;
                    hodnoty.SelectedChamp = "Ezreal";
                    break;
                case "Jinx":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.jinx;

                    wlbl.Text = ("Windup: " + hodnoty.jinxwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.jinxbwu.ToString());
                    hodnoty.finalWindup = hodnoty.jinxwu;
                    hodnoty.finalBaseWindup = hodnoty.jinxbwu;
                    hodnoty.SelectedChamp = "Jinx";
                    break;
                case "Kaisa":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kaisa;

                    wlbl.Text = ("Windup: " + hodnoty.kaisawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kaisabwu.ToString());
                    hodnoty.finalWindup = hodnoty.kaisawu;
                    hodnoty.finalBaseWindup = hodnoty.kaisabwu;
                    hodnoty.SelectedChamp = "Kaisa";
                    break;
                case "Kalista":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kalista;

                    wlbl.Text = ("Windup: " + hodnoty.kalistawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kalistabwu.ToString());
                    hodnoty.finalWindup = hodnoty.kalistawu;
                    hodnoty.finalBaseWindup = hodnoty.kalistabwu;
                    hodnoty.SelectedChamp = "Kalista";
                    break;
                case "Kayle":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kayle;

                    wlbl.Text = ("Windup: " + hodnoty.kaylewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kaylebwu.ToString());
                    hodnoty.finalWindup = hodnoty.kaylewu;
                    hodnoty.finalBaseWindup = hodnoty.kaylebwu;
                    hodnoty.SelectedChamp = "Kayle";
                    break;
                case "Kindred":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kindred;

                    wlbl.Text = ("Windup: " + hodnoty.kindredwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kindredbwu.ToString());
                    hodnoty.finalWindup = hodnoty.kindredwu;
                    hodnoty.finalBaseWindup = hodnoty.kindredbwu;
                    hodnoty.SelectedChamp = "Kindred";
                    break;
                case "Kogmaw":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kogmaw;

                    wlbl.Text = ("Windup: " + hodnoty.kogmawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kogmabwu.ToString());
                    hodnoty.finalWindup = hodnoty.kogmawu;
                    hodnoty.finalBaseWindup = hodnoty.kogmabwu;
                    hodnoty.SelectedChamp = "Kogmaw";
                    break;
                case "Lucian":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.lucian;

                    wlbl.Text = ("Windup: " + hodnoty.lucianwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.lucianbwu.ToString());
                    hodnoty.finalWindup = hodnoty.lucianwu;
                    hodnoty.finalBaseWindup = hodnoty.lucianbwu;
                    hodnoty.SelectedChamp = "Lucian";
                    break;
                case "Miss Fortune":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.missfortune;

                    wlbl.Text = ("Windup: " + hodnoty.mfwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.mfbwu.ToString());
                    hodnoty.finalWindup = hodnoty.mfwu;
                    hodnoty.finalBaseWindup = hodnoty.mfbwu;
                    hodnoty.SelectedChamp = "Miss Fortune";
                    break;
                case "Quinn":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.quinn;

                    wlbl.Text = ("Windup: " + hodnoty.quinnwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.quinnbwu.ToString());
                    hodnoty.finalWindup = hodnoty.quinnwu;
                    hodnoty.finalBaseWindup = hodnoty.quinnbwu;
                    hodnoty.SelectedChamp = "Quinn";
                    break;
                case "Samira":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.samira;

                    wlbl.Text = ("Windup: " + hodnoty.samirawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.samirabwu.ToString());
                    hodnoty.finalWindup = hodnoty.samirawu;
                    hodnoty.finalBaseWindup = hodnoty.samirabwu;
                    hodnoty.SelectedChamp = "Samira";
                    break;
                case "Sivir":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.sivir;

                    wlbl.Text = ("Windup: " + hodnoty.sivirwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.sivirbwu.ToString());
                    hodnoty.finalWindup = hodnoty.sivirwu;
                    hodnoty.finalBaseWindup = hodnoty.sivirbwu;
                    hodnoty.SelectedChamp = "Sivir";
                    break;
                case "Tristana":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.tristana;

                    wlbl.Text = ("Windup: " + hodnoty.tristanawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.tristanabwu.ToString());
                    hodnoty.finalWindup = hodnoty.tristanawu;
                    hodnoty.finalBaseWindup = hodnoty.tristanabwu;
                    hodnoty.SelectedChamp = "Tristana";
                    break;
                case "Twitch":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.twitch;

                    wlbl.Text = ("Windup: " + hodnoty.twitchwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.twitchbwu.ToString());
                    hodnoty.finalWindup = hodnoty.twitchwu;
                    hodnoty.finalBaseWindup = hodnoty.twitchbwu;
                    hodnoty.SelectedChamp = "Twitch";
                    break;
                case "Varus":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.varus;

                    wlbl.Text = ("Windup: " + hodnoty.varuswu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.varusbwu.ToString());
                    hodnoty.finalWindup = hodnoty.varuswu;
                    hodnoty.finalBaseWindup = hodnoty.varusbwu;
                    hodnoty.SelectedChamp = "Varus";
                    break;
                case "Vayne":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.vayne;

                    wlbl.Text = ("Windup: " + hodnoty.vaynewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.vaynebwu.ToString());
                    hodnoty.finalWindup = hodnoty.vaynewu;
                    hodnoty.finalBaseWindup = hodnoty.vaynebwu;
                    hodnoty.SelectedChamp = "Vayne";
                    break;
                case "Xayah":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.xayah;

                    wlbl.Text = ("Windup: " + hodnoty.xayahwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.xayahbwu.ToString());
                    hodnoty.finalWindup = hodnoty.xayahwu;
                    hodnoty.finalBaseWindup = hodnoty.xayahbwu;
                    hodnoty.SelectedChamp = "Xayah";
                    break;

            }
        }
    }
}
