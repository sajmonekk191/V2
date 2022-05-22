namespace VoidSharp
{
    partial class VoidSharp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidSharp));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadinglabel = new System.Windows.Forms.Label();
            this.DiscordPic = new System.Windows.Forms.PictureBox();
            this.PayPalPic = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ConnectButton = new ClassicDarkTheme.Dark.DarkButton();
            this.OrbwalkerButton = new ClassicDarkTheme.Dark.DarkButton();
            this.AutoAimButton = new ClassicDarkTheme.Dark.DarkButton();
            this.MiscButton = new ClassicDarkTheme.Dark.DarkButton();
            this.HealBarrierButton = new ClassicDarkTheme.Dark.DarkButton();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.generaluser1 = new global::VoidSharp.generaluser();
            this.miscuser1 = new global::VoidSharp.miscuser();
            this.darkLabel1 = new ClassicDarkTheme.Dark.DarkLabel();
            this.aimuser1 = new global::VoidSharp.aimuser();
            this.Orbtimer = new System.Windows.Forms.Timer(this.components);
            this.orbuser1 = new global::VoidSharp.orbuser();
            this.healbarrieruser1 = new global::VoidSharp.healbarrieruser();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayPalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 10);
            this.progressBar1.TabIndex = 0;
            // 
            // loadinglabel
            // 
            this.loadinglabel.AutoSize = true;
            this.loadinglabel.BackColor = System.Drawing.Color.Transparent;
            this.loadinglabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadinglabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loadinglabel.Location = new System.Drawing.Point(10, 5);
            this.loadinglabel.Name = "loadinglabel";
            this.loadinglabel.Size = new System.Drawing.Size(86, 19);
            this.loadinglabel.TabIndex = 1;
            this.loadinglabel.Text = "Loading Text";
            // 
            // DiscordPic
            // 
            this.DiscordPic.BackColor = System.Drawing.Color.Transparent;
            this.DiscordPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordPic.Image = ((System.Drawing.Image)(resources.GetObject("DiscordPic.Image")));
            this.DiscordPic.Location = new System.Drawing.Point(39, 321);
            this.DiscordPic.Name = "DiscordPic";
            this.DiscordPic.Size = new System.Drawing.Size(32, 32);
            this.DiscordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiscordPic.TabIndex = 8;
            this.DiscordPic.TabStop = false;
            this.DiscordPic.Click += new System.EventHandler(this.DiscordPic_Click);
            // 
            // PayPalPic
            // 
            this.PayPalPic.BackColor = System.Drawing.Color.Transparent;
            this.PayPalPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayPalPic.Image = ((System.Drawing.Image)(resources.GetObject("PayPalPic.Image")));
            this.PayPalPic.Location = new System.Drawing.Point(93, 321);
            this.PayPalPic.Name = "PayPalPic";
            this.PayPalPic.Size = new System.Drawing.Size(32, 32);
            this.PayPalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PayPalPic.TabIndex = 9;
            this.PayPalPic.TabStop = false;
            this.PayPalPic.Click += new System.EventHandler(this.PayPalPic_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(571, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(49, 19);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "    X    ";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Location = new System.Drawing.Point(532, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(39, 19);
            this.MinimizeButton.TabIndex = 11;
            this.MinimizeButton.Text = "   -   ";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(21, 82);
            this.ConnectButton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ConnectButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.ConnectButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ConnectButton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ConnectButton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(140, 40);
            this.ConnectButton.TabIndex = 12;
            this.ConnectButton.Text = "General";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // OrbwalkerButton
            // 
            this.OrbwalkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.OrbwalkerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrbwalkerButton.FlatAppearance.BorderSize = 0;
            this.OrbwalkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrbwalkerButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrbwalkerButton.ForeColor = System.Drawing.Color.White;
            this.OrbwalkerButton.Location = new System.Drawing.Point(21, 128);
            this.OrbwalkerButton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.OrbwalkerButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.OrbwalkerButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.OrbwalkerButton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.OrbwalkerButton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.OrbwalkerButton.Name = "OrbwalkerButton";
            this.OrbwalkerButton.Size = new System.Drawing.Size(140, 40);
            this.OrbwalkerButton.TabIndex = 13;
            this.OrbwalkerButton.Text = "Orbwalker";
            this.OrbwalkerButton.UseVisualStyleBackColor = false;
            this.OrbwalkerButton.Click += new System.EventHandler(this.OrbwalkerButton_Click);
            // 
            // AutoAimButton
            // 
            this.AutoAimButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.AutoAimButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoAimButton.FlatAppearance.BorderSize = 0;
            this.AutoAimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoAimButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoAimButton.ForeColor = System.Drawing.Color.White;
            this.AutoAimButton.Location = new System.Drawing.Point(21, 174);
            this.AutoAimButton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.AutoAimButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.AutoAimButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AutoAimButton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.AutoAimButton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AutoAimButton.Name = "AutoAimButton";
            this.AutoAimButton.Size = new System.Drawing.Size(140, 40);
            this.AutoAimButton.TabIndex = 14;
            this.AutoAimButton.Text = "AutoAim";
            this.AutoAimButton.UseVisualStyleBackColor = false;
            this.AutoAimButton.Click += new System.EventHandler(this.AutoAimButton_Click);
            // 
            // MiscButton
            // 
            this.MiscButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.MiscButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiscButton.FlatAppearance.BorderSize = 0;
            this.MiscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiscButton.ForeColor = System.Drawing.Color.White;
            this.MiscButton.Location = new System.Drawing.Point(21, 266);
            this.MiscButton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.MiscButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.MiscButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.MiscButton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.MiscButton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.MiscButton.Name = "MiscButton";
            this.MiscButton.Size = new System.Drawing.Size(140, 40);
            this.MiscButton.TabIndex = 15;
            this.MiscButton.Text = "Misc";
            this.MiscButton.UseVisualStyleBackColor = false;
            this.MiscButton.Click += new System.EventHandler(this.MiscButton_Click);
            // 
            // HealBarrierButton
            // 
            this.HealBarrierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.HealBarrierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HealBarrierButton.FlatAppearance.BorderSize = 0;
            this.HealBarrierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealBarrierButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HealBarrierButton.ForeColor = System.Drawing.Color.White;
            this.HealBarrierButton.Location = new System.Drawing.Point(21, 220);
            this.HealBarrierButton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.HealBarrierButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.HealBarrierButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.HealBarrierButton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.HealBarrierButton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.HealBarrierButton.Name = "HealBarrierButton";
            this.HealBarrierButton.Size = new System.Drawing.Size(140, 40);
            this.HealBarrierButton.TabIndex = 16;
            this.HealBarrierButton.Text = "Auto Heal/Barrier";
            this.HealBarrierButton.UseVisualStyleBackColor = false;
            this.HealBarrierButton.Click += new System.EventHandler(this.HealBarrierButton_Click_1);
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = global::VoidSharp.Properties.Resources.logo1;
            this.LogoPic.Location = new System.Drawing.Point(13, 11);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(100, 50);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 17;
            this.LogoPic.TabStop = false;
            // 
            // generaluser1
            // 
            this.generaluser1.BackColor = System.Drawing.Color.Transparent;
            this.generaluser1.Location = new System.Drawing.Point(189, 77);
            this.generaluser1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.generaluser1.Name = "generaluser1";
            this.generaluser1.Size = new System.Drawing.Size(417, 276);
            this.generaluser1.TabIndex = 18;
            // 
            // miscuser1
            // 
            this.miscuser1.BackColor = System.Drawing.Color.Transparent;
            this.miscuser1.Location = new System.Drawing.Point(189, 77);
            this.miscuser1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.miscuser1.Name = "miscuser1";
            this.miscuser1.Size = new System.Drawing.Size(416, 282);
            this.miscuser1.TabIndex = 19;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.darkLabel1.IsLink = false;
            this.darkLabel1.Link = "";
            this.darkLabel1.Location = new System.Drawing.Point(562, 349);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(48, 15);
            this.darkLabel1.TabIndex = 20;
            this.darkLabel1.Text = "Void 1.0";
            // 
            // aimuser1
            // 
            this.aimuser1.BackColor = System.Drawing.Color.Transparent;
            this.aimuser1.Location = new System.Drawing.Point(189, 77);
            this.aimuser1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.aimuser1.Name = "aimuser1";
            this.aimuser1.Size = new System.Drawing.Size(416, 282);
            this.aimuser1.TabIndex = 21;
            // 
            // Orbtimer
            // 
            this.Orbtimer.Enabled = true;
            this.Orbtimer.Interval = 10;
            this.Orbtimer.Tick += new System.EventHandler(this.Orbtimer_Tick);
            // 
            // orbuser1
            // 
            this.orbuser1.BackColor = System.Drawing.Color.Transparent;
            this.orbuser1.Location = new System.Drawing.Point(189, 77);
            this.orbuser1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.orbuser1.Name = "orbuser1";
            this.orbuser1.Size = new System.Drawing.Size(416, 282);
            this.orbuser1.TabIndex = 22;
            // 
            // healbarrieruser1
            // 
            this.healbarrieruser1.BackColor = System.Drawing.Color.Transparent;
            this.healbarrieruser1.Location = new System.Drawing.Point(189, 77);
            this.healbarrieruser1.Name = "healbarrieruser1";
            this.healbarrieruser1.Size = new System.Drawing.Size(416, 282);
            this.healbarrieruser1.TabIndex = 23;
            this.healbarrieruser1.Visible = false;
            // 
            // VoidSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 370);
            this.Controls.Add(this.healbarrieruser1);
            this.Controls.Add(this.orbuser1);
            this.Controls.Add(this.aimuser1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.miscuser1);
            this.Controls.Add(this.generaluser1);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.HealBarrierButton);
            this.Controls.Add(this.MiscButton);
            this.Controls.Add(this.AutoAimButton);
            this.Controls.Add(this.OrbwalkerButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PayPalPic);
            this.Controls.Add(this.DiscordPic);
            this.Controls.Add(this.loadinglabel);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoidSharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoidSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayPalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label loadinglabel;
        private System.Windows.Forms.PictureBox DiscordPic;
        private System.Windows.Forms.PictureBox PayPalPic;
        public System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private ClassicDarkTheme.Dark.DarkButton ConnectButton;
        private ClassicDarkTheme.Dark.DarkButton OrbwalkerButton;
        private ClassicDarkTheme.Dark.DarkButton AutoAimButton;
        private ClassicDarkTheme.Dark.DarkButton MiscButton;
        private ClassicDarkTheme.Dark.DarkButton HealBarrierButton;
        private System.Windows.Forms.PictureBox LogoPic;
        private global::VoidSharp.generaluser generaluser1;
        private global::VoidSharp.miscuser miscuser1;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel1;
        private global::VoidSharp.aimuser aimuser1;
        private System.Windows.Forms.Timer Orbtimer;
        private global::VoidSharp.orbuser orbuser1;
        private global::VoidSharp.healbarrieruser healbarrieruser1;
    }
}
