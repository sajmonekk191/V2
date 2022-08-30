using System;
using System.Diagnostics;
using System.Linq;
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
            statuspb.Image = Properties.Resources.fail;
            champpb.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void enablebutton_Click(object sender, EventArgs e)
        {
            Statuslbl2.Visible = true;
            if (!hodnoty.VoidActivated)
            {
                enablebutton.Text = "Disable Void";
                Statuslbl2.Text = "Enabled";
                hodnoty.VoidActivated = true;
                statuspb.Image = Properties.Resources.succ;
            }
            else
            {
                enablebutton.Text = "Enable Void";
                Statuslbl2.Text = "Disabled";
                hodnoty.VoidActivated = false;
                statuspb.Image = Properties.Resources.fail;
            }
        }
        private void champcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (champcb.SelectedItem.ToString().Trim())
            {
                case "Ashe":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.ashe;

                    wlbl.Text = ("Windup: " + hodnoty.ashewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.ashebwu.ToString());
                    hodnoty.Windup = hodnoty.ashewu;
                    hodnoty.BaseWindup = hodnoty.ashebwu;
                    hodnoty.SelectedChamp = "Ashe";
                    hodnoty.rectQ = SpellRange.AsheQ;
                    hodnoty.rectW = SpellRange.AsheW;
                    hodnoty.rectE = SpellRange.AsheE;
                    hodnoty.rectR = SpellRange.AsheR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Caitlyn":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.caitlyn;

                    wlbl.Text = ("Windup: " + hodnoty.caitlynwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.caitlynbwu.ToString());
                    hodnoty.Windup = hodnoty.caitlynwu;
                    hodnoty.BaseWindup = hodnoty.caitlynbwu;
                    hodnoty.SelectedChamp = "Caitlyn";
                    hodnoty.rectQ = SpellRange.CaitlynQ;
                    hodnoty.rectW = SpellRange.CaitlynW;
                    hodnoty.rectE = SpellRange.CaitlynE;
                    hodnoty.rectR = SpellRange.CaitlynR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Corki":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.corki;

                    wlbl.Text = ("Windup: " + hodnoty.corkiwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.corkibwu.ToString());
                    hodnoty.Windup = hodnoty.corkiwu;
                    hodnoty.BaseWindup = hodnoty.corkibwu;
                    hodnoty.SelectedChamp = "Corki";
                    hodnoty.rectQ = SpellRange.CorkiQ;
                    hodnoty.rectW = SpellRange.CorkiW;
                    hodnoty.rectE = SpellRange.CorkiE;
                    hodnoty.rectR = SpellRange.CorkiR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Draven":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.draven;

                    wlbl.Text = ("Windup: " + hodnoty.dravenwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.dravenbwu.ToString());
                    hodnoty.Windup = hodnoty.dravenwu;
                    hodnoty.BaseWindup = hodnoty.dravenbwu;
                    hodnoty.SelectedChamp = "Draven";
                    hodnoty.rectQ = SpellRange.DravenQ;
                    hodnoty.rectW = SpellRange.DravenW;
                    hodnoty.rectE = SpellRange.DravenE;
                    hodnoty.rectR = SpellRange.DravenR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Ezreal":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.ezreal;

                    wlbl.Text = ("Windup: " + hodnoty.ezrealwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.ezrealbwu.ToString());
                    hodnoty.Windup = hodnoty.ezrealwu;
                    hodnoty.BaseWindup = hodnoty.ezrealbwu;
                    hodnoty.SelectedChamp = "Ezreal";
                    hodnoty.rectQ = SpellRange.EzrealQ;
                    hodnoty.rectW = SpellRange.EzrealW;
                    hodnoty.rectE = SpellRange.EzrealE;
                    hodnoty.rectR = SpellRange.EzrealR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Jinx":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.jinx;

                    wlbl.Text = ("Windup: " + hodnoty.jinxwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.jinxbwu.ToString());
                    hodnoty.Windup = hodnoty.jinxwu;
                    hodnoty.BaseWindup = hodnoty.jinxbwu;
                    hodnoty.SelectedChamp = "Jinx";
                    hodnoty.rectQ = SpellRange.JinxQ;
                    hodnoty.rectW = SpellRange.JinxW;
                    hodnoty.rectE = SpellRange.JinxE;
                    hodnoty.rectR = SpellRange.JinxR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Kaisa":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kaisa;

                    wlbl.Text = ("Windup: " + hodnoty.kaisawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kaisabwu.ToString());
                    hodnoty.Windup = hodnoty.kaisawu;
                    hodnoty.BaseWindup = hodnoty.kaisabwu;
                    hodnoty.SelectedChamp = "Kaisa";
                    hodnoty.rectQ = SpellRange.KaisaQ;
                    hodnoty.rectW = SpellRange.KaisaW;
                    hodnoty.rectE = SpellRange.KaisaE;
                    hodnoty.rectR = SpellRange.KaisaR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Kalista":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kalista;

                    wlbl.Text = ("Windup: " + hodnoty.kalistawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kalistabwu.ToString());
                    hodnoty.Windup = hodnoty.kalistawu;
                    hodnoty.BaseWindup = hodnoty.kalistabwu;
                    hodnoty.SelectedChamp = "Kalista";
                    hodnoty.rectQ = SpellRange.KalistaQ;
                    hodnoty.rectW = SpellRange.KalistaW;
                    hodnoty.rectE = SpellRange.KalistaE;
                    hodnoty.rectR = SpellRange.KalistaR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Kayle":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kayle;

                    wlbl.Text = ("Windup: " + hodnoty.kaylewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kaylebwu.ToString());
                    hodnoty.Windup = hodnoty.kaylewu;
                    hodnoty.BaseWindup = hodnoty.kaylebwu;
                    hodnoty.SelectedChamp = "Kayle";
                    hodnoty.rectQ = SpellRange.KayleQ;
                    hodnoty.rectW = SpellRange.KayleW;
                    hodnoty.rectE = SpellRange.KayleE;
                    hodnoty.rectR = SpellRange.KayleR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Kindred":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kindred;

                    wlbl.Text = ("Windup: " + hodnoty.kindredwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kindredbwu.ToString());
                    hodnoty.Windup = hodnoty.kindredwu;
                    hodnoty.BaseWindup = hodnoty.kindredbwu;
                    hodnoty.SelectedChamp = "Kindred";
                    hodnoty.rectQ = SpellRange.KindredQ;
                    hodnoty.rectW = SpellRange.KindredW;
                    hodnoty.rectE = SpellRange.KindredE;
                    hodnoty.rectR = SpellRange.KindredR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Kogmaw":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.kogmaw;

                    wlbl.Text = ("Windup: " + hodnoty.kogmawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.kogmabwu.ToString());
                    hodnoty.Windup = hodnoty.kogmawu;
                    hodnoty.BaseWindup = hodnoty.kogmabwu;
                    hodnoty.SelectedChamp = "Kogmaw";
                    hodnoty.rectQ = SpellRange.KogmawQ;
                    hodnoty.rectW = SpellRange.KogmawW;
                    hodnoty.rectE = SpellRange.KogmawE;
                    hodnoty.rectR = SpellRange.KogmawR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Lucian":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.lucian;

                    wlbl.Text = ("Windup: " + hodnoty.lucianwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.lucianbwu.ToString());
                    hodnoty.Windup = hodnoty.lucianwu;
                    hodnoty.BaseWindup = hodnoty.lucianbwu;
                    hodnoty.SelectedChamp = "Lucian";
                    hodnoty.rectQ = SpellRange.LucianQ;
                    hodnoty.rectW = SpellRange.LucianW;
                    hodnoty.rectE = SpellRange.LucianE;
                    hodnoty.rectR = SpellRange.LucianR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Miss Fortune":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.missfortune;

                    wlbl.Text = ("Windup: " + hodnoty.mfwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.mfbwu.ToString());
                    hodnoty.Windup = hodnoty.mfwu;
                    hodnoty.BaseWindup = hodnoty.mfbwu;
                    hodnoty.SelectedChamp = "Miss Fortune";
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Quinn":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.quinn;

                    wlbl.Text = ("Windup: " + hodnoty.quinnwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.quinnbwu.ToString());
                    hodnoty.Windup = hodnoty.quinnwu;
                    hodnoty.BaseWindup = hodnoty.quinnbwu;
                    hodnoty.SelectedChamp = "Quinn";
                    hodnoty.rectQ = SpellRange.QuinnQ;
                    hodnoty.rectW = SpellRange.QuinnW;
                    hodnoty.rectE = SpellRange.QuinnE;
                    hodnoty.rectR = SpellRange.QuinnR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Samira":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.samira;

                    wlbl.Text = ("Windup: " + hodnoty.samirawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.samirabwu.ToString());
                    hodnoty.Windup = hodnoty.samirawu;
                    hodnoty.BaseWindup = hodnoty.samirabwu;
                    hodnoty.SelectedChamp = "Samira";
                    hodnoty.rectQ = SpellRange.SamiraQ;
                    hodnoty.rectW = SpellRange.SamiraW;
                    hodnoty.rectE = SpellRange.SamiraE;
                    hodnoty.rectR = SpellRange.SamiraR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Senna":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.senna;

                    wlbl.Text = ("Windup: " + hodnoty.sennawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.sennabwu.ToString());
                    hodnoty.Windup = hodnoty.sennawu;
                    hodnoty.BaseWindup = hodnoty.sennabwu;
                    hodnoty.SelectedChamp = "Senna";
                    //hodnoty.rectQ = SpellRange.SamiraQ;
                    //hodnoty.rectW = SpellRange.SamiraW;
                    //hodnoty.rectE = SpellRange.SamiraE;
                    //hodnoty.rectR = SpellRange.SamiraR;
                    //hodnoty.ChargeQ = false;
                    //hodnoty.ChargeW = false;
                    //hodnoty.ChargeE = false;
                    //hodnoty.ChargeR = false;
                    break;
                case "Sivir":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.sivir;

                    wlbl.Text = ("Windup: " + hodnoty.sivirwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.sivirbwu.ToString());
                    hodnoty.Windup = hodnoty.sivirwu;
                    hodnoty.BaseWindup = hodnoty.sivirbwu;
                    hodnoty.SelectedChamp = "Sivir";
                    hodnoty.rectQ = SpellRange.SivirQ;
                    hodnoty.rectW = SpellRange.SivirW;
                    hodnoty.rectE = SpellRange.SivirE;
                    hodnoty.rectR = SpellRange.SivirR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Tristana":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.tristana;

                    wlbl.Text = ("Windup: " + hodnoty.tristanawu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.tristanabwu.ToString());
                    hodnoty.Windup = hodnoty.tristanawu;
                    hodnoty.BaseWindup = hodnoty.tristanabwu;
                    hodnoty.SelectedChamp = "Tristana";
                    hodnoty.rectQ = SpellRange.TristanaQ;
                    hodnoty.rectW = SpellRange.TristanaW;
                    hodnoty.rectE = SpellRange.TristanaE;
                    hodnoty.rectR = SpellRange.TristanaR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Twitch":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.twitch;

                    wlbl.Text = ("Windup: " + hodnoty.twitchwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.twitchbwu.ToString());
                    hodnoty.Windup = hodnoty.twitchwu;
                    hodnoty.BaseWindup = hodnoty.twitchbwu;
                    hodnoty.SelectedChamp = "Twitch";
                    hodnoty.rectQ = SpellRange.TwitchQ;
                    hodnoty.rectW = SpellRange.TwitchW;
                    hodnoty.rectE = SpellRange.TwitchE;
                    hodnoty.rectR = SpellRange.TwitchR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Varus":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.varus;

                    wlbl.Text = ("Windup: " + hodnoty.varuswu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.varusbwu.ToString());
                    hodnoty.Windup = hodnoty.varuswu;
                    hodnoty.BaseWindup = hodnoty.varusbwu;
                    hodnoty.SelectedChamp = "Varus";
                    hodnoty.rectQ = SpellRange.VarusQ;
                    hodnoty.rectW = SpellRange.VarusW;
                    hodnoty.rectE = SpellRange.VarusE;
                    hodnoty.rectR = SpellRange.VarusR;
                    hodnoty.ChargeQ = true;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Vayne":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.vayne;

                    wlbl.Text = ("Windup: " + hodnoty.vaynewu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.vaynebwu.ToString());
                    hodnoty.Windup = hodnoty.vaynewu;
                    hodnoty.BaseWindup = hodnoty.vaynebwu;
                    hodnoty.SelectedChamp = "Vayne";
                    hodnoty.rectQ = SpellRange.VayneQ;
                    hodnoty.rectW = SpellRange.VayneW;
                    hodnoty.rectE = SpellRange.VayneE;
                    hodnoty.rectR = SpellRange.VayneR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Xayah":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.xayah;

                    wlbl.Text = ("Windup: " + hodnoty.xayahwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.xayahbwu.ToString());
                    hodnoty.Windup = hodnoty.xayahwu;
                    hodnoty.BaseWindup = hodnoty.xayahbwu;
                    hodnoty.SelectedChamp = "Xayah";
                    hodnoty.rectQ = SpellRange.XayahQ;
                    hodnoty.rectW = SpellRange.XayahW;
                    hodnoty.rectE = SpellRange.XayahE;
                    hodnoty.rectR = SpellRange.XayahR;
                    hodnoty.ChargeQ = false;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;
                case "Xerath":
                    wlbl.Visible = true;
                    bwlbl.Visible = true;
                    champpb.ImageLocation = Champions.xerath;

                    wlbl.Text = ("Windup: " + hodnoty.xerathwu.ToString());
                    bwlbl.Text = ("Base Windup: " + hodnoty.xerathbwu.ToString());
                    hodnoty.Windup = hodnoty.xerathwu;
                    hodnoty.BaseWindup = hodnoty.xerathbwu;
                    hodnoty.SelectedChamp = "Xerath";
                    hodnoty.rectQ = SpellRange.XerathQ;
                    hodnoty.rectW = SpellRange.XerathW;
                    hodnoty.rectE = SpellRange.XerathE;
                    hodnoty.rectR = SpellRange.XerathR;
                    hodnoty.ChargeQ = true;
                    hodnoty.ChargeW = false;
                    hodnoty.ChargeE = false;
                    hodnoty.ChargeR = false;
                    break;

            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            Process[] league = Process.GetProcessesByName("League of Legends");
            if (league != null)
            {
                if (league.Count() > 0) SpecialFunc.SetForegroundWindow(league[0].MainWindowHandle);

            }
            else
            {
                MessageBox.Show("League of Legends Process isn´t detected.");
            }
        }
        private void darkButton1_Click_1(object sender, EventArgs e)
        {
            hodnoty.selectcolorchamp = true;
            SpecialForms.ColorPicker cp = new SpecialForms.ColorPicker();
            cp.Show();
            cp.BringToFront();
        }
    }
}
