﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
        Random random = new Random();
        Point mousedownpoint = Point.Empty;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer AfkScript = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer AutoAccpt = new System.Windows.Forms.Timer();
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
            this.Name = "Void";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            progressBar1.Value = 3;
            loadinglabel.Location = new Point(loadinglabel.Left - 20, loadinglabel.Top);
            loadinglabel.Text = "Checking for Update..";
            calls.Wait(1500);
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/fMU8eZAv").Contains("Update 1.0")) //Github udaje 
                {
                    if (MessageBox.Show("An update is available", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        try
                        {
                            lop:
                            if (MessageBox.Show("Server isn´t responding (DDOSed or offline)", "Error 2", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                            {
                                goto lop;
                            }
                            else Environment.Exit(0);
                            Process.Start(new ProcessStartInfo("http://99.99.99.99/download/Void.zip") { UseShellExecute = true });
                            string pnv = Process.GetCurrentProcess().MainModule.FileName;
                            Process.Start(new ProcessStartInfo(pnv) { UseShellExecute = true });
                            Environment.Exit(0);
                        }
                        catch { }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Try to restart Void", "Error 7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calls.Wait(1000);
                Environment.Exit(0);
            }
            progressBar1.Value = 64;
            loadinglabel.Text = "Loading..";
            loadinglabel.Location = new Point(loadinglabel.Left + 30, loadinglabel.Top);
            calls.Wait(500);
            progressBar1.Value = 100;
            calls.Wait(100);
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
            this.TopMost = false;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.ControlBox = true;
            // LoadColors //
            try
            {
                hodnoty.EnemyPix = Properties.Settings.Default.ChampColor;
                hodnoty.AutoAcceptColor = Properties.Settings.Default.AcceptColor;
            }
            catch
            {
                hodnoty.EnemyPix = Color.FromArgb(63, 5, 0);
                hodnoty.AutoAcceptColor = Color.FromArgb(21, 103, 101);
            }
            // LoadColors //
            timer.Interval = 50000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += new EventHandler(ChangeNameLoop);
            AfkScript.Interval = 5000;
            AfkScript.Tick += new EventHandler(AfkScriptTimer);
            AutoAccpt.Interval = 5000;
            AutoAccpt.Tick += new EventHandler(AutoAcceptTimer);
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
            MessageBox.Show("sajmonekk#1565", "Discord", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PayPalPic_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.paypal.com/donate/?hosted_button_id=PEG8NYGH636D8") { UseShellExecute = true });
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
            MessageBox.Show("Comming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*aimuser1.Visible = true;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
            orbuser1.Visible = false;
            healbarrieruser1.Visible = false;*/
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
            if (hodnoty.VoidActivated && hodnoty.OrbActivated) Orbwalker.OrbwalkEnemy();
        }
        /*private void Aimtimer_Tick(object sender, EventArgs e)
        {
            if (hodnoty.VoidActivated && hodnoty.AimActivated) AimCore.Aimer();
        }*/
        private void HBtimer_Tick(object sender, EventArgs e)
        {
            if (hodnoty.VoidActivated && hodnoty.HBActivated) AutoHB.Healer();
        }
        private void ChangeNameLoop(object sender, EventArgs e)
        {
            string VoidName = SpecialFunc.RandomString(random.Next(5, 13)) + ".exe";
            File.Move(hodnoty.ActualName, VoidName);
            hodnoty.ActualName = VoidName;
        }
        private void AfkScriptTimer(object sender, EventArgs e)
        {
            if (hodnoty.AFKisActivated && hodnoty.VoidActivated)
            {
                this.SendToBack();
                Process[] league = Process.GetProcessesByName("League of Legends");
                SpecialFunc.SetForegroundWindow(league[0].MainWindowHandle);
                Mouse.SetCursorPosition(Screen.PrimaryScreen.Bounds.Width / 2 + random.Next(-400, 400), Screen.PrimaryScreen.Bounds.Height / 2 + random.Next(-400, 400));
                Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
            }
        }
        private void AutoAcceptTimer(object sender, EventArgs e)
        {
            if(hodnoty.AutoAcceptWorking) AutoAccept.FindMatch();
        }
    }
}
