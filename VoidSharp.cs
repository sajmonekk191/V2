using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using DiscordRPC;
using VoidSharp.Cheat;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class VoidSharp : Form
    {
        DiscordRpcClient client;
        Point mousedownpoint = Point.Empty;
        public VoidSharp()
        {
            InitializeComponent();
            this.Size = new Size(325, 160);
            this.BackgroundImage = Properties.Resources.splashscreen;
            loadinglabel.Location = new Point(117, 111);
            progressBar1.Location = new Point(12, 138);
            ExitButton.BackColor = Color.FromArgb(127, 37, 37);
            MinimizeButton.BackColor = Color.FromArgb(108, 116, 116);
            miscuser1.Visible = false;
            orbuser1.Visible = false;
            generaluser1.Visible = false;
            aimuser1.Visible = false;
            LogoPic.Visible = false;
            ExitButton.Visible = false;
            MinimizeButton.Visible = false;
            ConnectButton.Visible = false;
            OrbwalkerButton.Visible = false;
            AutoAimButton.Visible = false;
            HealBarrierButton.Visible = false;
            MiscButton.Visible = false;
            DiscordPic.Visible = false;
            PayPalPic.Visible = false; 
            this.TopMost = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Name = "VoidSharp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateVoid();
        }
        private void UpdateVoid()
        {
            this.Show();
            progressBar1.Value = 3;
            loadinglabel.Location = new Point(loadinglabel.Left - 20, loadinglabel.Top);
            loadinglabel.Text = "Checking for Update..";
            /*
            Wait(1500);
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/fMU8eZAv").Contains("Update 1.0")) //Github udaje 
                {
                    if (MessageBox.Show("An update is available", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Process.Start(new ProcessStartInfo("http://81.162.196.29/download/Void.zip") { UseShellExecute = true });
                        Environment.Exit(0);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Try to restart Void", "Error 7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Wait(1000);
                Environment.Exit(0);
            }
            */
            progressBar1.Value = 64;
            loadinglabel.Text = "Loading..";
            loadinglabel.Location = new Point(loadinglabel.Left + 30, loadinglabel.Top);
            Wait(500);
            progressBar1.Value = 100;
            Wait(100);
            this.Size = new Size(620, 370);
            this.Location = new Point(this.Location.X - 190, this.Location.Y - 150);
            progressBar1.Visible = false;
            loadinglabel.Visible = false;
            this.BackgroundImage = Properties.Resources.background;
            LogoPic.Visible = true;
            ExitButton.Visible = true;
            MinimizeButton.Visible = true;
            ConnectButton.Visible = true;
            OrbwalkerButton.Visible = true;
            AutoAimButton.Visible = true;
            HealBarrierButton.Visible = true;
            MiscButton.Visible = true;
            DiscordPic.Visible = true;
            PayPalPic.Visible = true;
            this.TopMost = true;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.ControlBox = true;
        }
        private void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            client = new DiscordRpcClient(hodnoty.DiscordRpcID);
            client.Dispose();
            Environment.Exit(0);
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(143, 37, 37);
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(127, 37, 37);
        }
        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.BackColor = Color.FromArgb(130, 134, 134);
        }
        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.BackColor = Color.FromArgb(108, 116, 116);
        }
        private void DiscordPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: sajmonekk#1565", "Discord", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PayPalPic_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.paypal.com/paypalme/sajmonekk") { UseShellExecute = true });
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            generaluser1.Visible = true;
            miscuser1.Visible = false;
            aimuser1.Visible = false;
            orbuser1.Visible = false;
            healbarrieruser1.Visible = false;
        }
        private void MiscButton_Click(object sender, EventArgs e)
        {
            miscuser1.Visible = true;
            generaluser1.Visible = false;
            aimuser1.Visible = false;
            orbuser1.Visible = false;
            healbarrieruser1.Visible = false;
        }
        private void AutoAimButton_Click(object sender, EventArgs e)
        {
            aimuser1.Visible = true;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
            orbuser1.Visible = false;
            healbarrieruser1.Visible = false;
        }
        private void OrbwalkerButton_Click(object sender, EventArgs e)
        {
            orbuser1.Visible = true;
            aimuser1.Visible = false;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
            healbarrieruser1.Visible = false;
        }
        private void HealBarrierButton_Click_1(object sender, EventArgs e)
        {
            healbarrieruser1.Visible = true;
            orbuser1.Visible = false;
            aimuser1.Visible = false;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
        }
        private void Orbtimer_Tick(object sender, EventArgs e)
        {
            if (hodnoty.VoidActivated)
            {
                Orbwalker.OrbwalkEnemy();
                AimCore.Aimer();
                AutoHB.Healer();
            }
        }
    }
}
