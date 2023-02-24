// Fix Sleep na combach - Medium       - Priority 3
// AutoQSS - VeryHard       - Priority 1
// Fix Crashing po hře - Hard       - Priority 3
// Udělat AutoLogin - Medium       - Priority 1
// Fix AutoAccept - Easy       - Priority 1
// Dodělat AutoChampSelect - Medium       - Priority 1
// fix combo rectangle + fix all rectangles - Hard     - Priority 10 
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DiscordRPC;
using VoidSharp.Cheat;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class VoidSharp : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        static extern int UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        const int WH_KEYBOARD_LL = 13;
        const int VK_SPACE = 0x20;
        const int WM_KEYDOWN = 0x0100;

        delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);
        static IntPtr hookHandle = IntPtr.Zero;
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
            banger1.Visible = false;
            LogoPic.Visible = false;
            ExitButton.Visible = false;
            MinimizeButton.Visible = false;
            ConnectButton.Visible = false;
            OrbwalkerButton.Visible = false;
            AutoAimButton.Visible = false;
            CombosButton.Visible = false;
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
            SpecialFunc.Wait(1500);
            /*WebClient webClient = new WebClient();
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
                SpecialFunc.Wait(1000);
                Environment.Exit(0);
            }*/
            progressBar1.Value = 64;
            loadinglabel.Text = "Loading..";
            loadinglabel.Location = new Point(loadinglabel.Left + 30, loadinglabel.Top);
            SpecialFunc.Wait(500);
            progressBar1.Value = 100;
            SpecialFunc.Wait(100);
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
            CombosButton.Visible = true;
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
                hodnoty.EnemyPix1 = Properties.Settings.Default.ChampColor1;
                hodnoty.AutoAcceptColor = Properties.Settings.Default.AcceptColor;
                hodnoty.CurentUsername = Properties.Settings.Default.CurentUsername;
                if(hodnoty.CurentUsername != String.Empty)Playerlbl.Text = hodnoty.CurentUsername;
            }
            catch { }
            // LoadColors //
            timer.Interval = 50000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += new EventHandler(ChangeNameLoop);
            AfkScript.Interval = 5000;
            AfkScript.Tick += new EventHandler(AfkScriptTimer);
            //AutoAccpt.Interval = 5000;
            //AutoAccpt.Tick += new EventHandler(AutoAcceptTimer);
            Process.GetCurrentProcess().PriorityBoostEnabled = true;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.AboveNormal;
            //Base.OnTick += Orbwalker.OrbwalkEnemy;
            hookHandle = SetHook(KeyboardProc);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            client = new DiscordRpcClient(hodnoty.DiscordRpcID);
            client.Dispose();
            UnhookWindowsHookEx(hookHandle);
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
            orbuser1.Visible = false;
            combos1.Visible = false;
            banger1.Visible = false;
        }
        private void MiscButton_Click(object sender, EventArgs e)
        {
            miscuser1.Visible = true;
            generaluser1.Visible = false;
            orbuser1.Visible = false;
            combos1.Visible = false;
            banger1.Visible = false;
        }
        private void AutoAimButton_Click(object sender, EventArgs e)
        {
            banger1.Visible = true;
            miscuser1.Visible = false;
            generaluser1.Visible = false;
            orbuser1.Visible = false;
            combos1.Visible = false;
        }
        private void OrbwalkerButton_Click(object sender, EventArgs e)
        {
            orbuser1.Visible = true;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
            combos1.Visible = false;
            banger1.Visible = false;
        }
        private void HealBarrierButton_Click_1(object sender, EventArgs e)
        {
            combos1.Visible = true;
            orbuser1.Visible = false;
            generaluser1.Visible = false;
            miscuser1.Visible = false;
            banger1.Visible = false;
        }
        private void ChangeNameLoop(object sender, EventArgs e)
        {
            /*string VoidName = SpecialFunc.RandomString(random.Next(5, 13)) + ".exe";
            File.Move(hodnoty.ActualName, VoidName);
            hodnoty.ActualName = VoidName;*/
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

        private void Updater_Tick(object sender, EventArgs e)
        {
            if(hodnoty.CurentUsername != string.Empty)Playerlbl.Text = hodnoty.CurentUsername;
        }
        static IntPtr SetHook(HookProc proc)
        {
            IntPtr hModule = GetModuleHandle(null);
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, hModule, 0);
        }
        static int KeyboardProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_SPACE)
                {
                    Orbwalker.OrbwalkEnemy();
                }
            }
            return CallNextHookEx(hookHandle, code, wParam, lParam);
        }
    }
}
