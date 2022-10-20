using System;
using System.Windows.Forms;
using NAudio.Wave;
using VoidSharp.Other;

namespace VoidSharp
{
    partial class Banger : UserControl
    {
        public static MediaFoundationReader stream = new MediaFoundationReader(Playlist.songs[0]);
        public static WasapiOut wo = new WasapiOut();
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int play = 1;  
        public Banger()
        {
            InitializeComponent();
        }
        private void playbtn_Click(object sender, EventArgs e)
        {
            if (play == 1)
            {
                play = 0;
                playbtn.Image = Properties.Resources.pause;
                wo.Play();
            }
            else
            {
                play = 1;
                playbtn.Image = Properties.Resources.play;
                wo.Pause();
            }
        }

        private void Banger_Load(object sender, EventArgs e)
        {
            Playlist.LoadBangers(this);
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += new EventHandler(TimerTickEvent);
        }

        private void playlist_DoubleClick(object sender, EventArgs e)
        {
            Playlist.ChangeBanger(this);
        }
        public void TimerTickEvent(object sender, EventArgs e)
        {
            autoplay();
        }

        private void volumetb_ValueChanged(object sender, EventArgs e)
        {
            volumetb.Scroll += (s, a) => wo.Volume = volumetb.Value / 100f;
        }
        private void autoplay()
        {
            Playlist.AutoPlayer(this);
        }
    }
}
