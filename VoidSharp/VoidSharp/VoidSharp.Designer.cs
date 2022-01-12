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
            this.generaluser1 = new VoidSharp.generaluser();
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
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(570, 0);
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
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.Location = new System.Drawing.Point(531, 0);
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
            this.generaluser1.Location = new System.Drawing.Point(189, 82);
            this.generaluser1.Name = "generaluser1";
            this.generaluser1.Size = new System.Drawing.Size(417, 260);
            this.generaluser1.TabIndex = 18;
            // 
            // VoidSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 370);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoidSharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private ClassicDarkTheme.Dark.DarkButton ConnectButton;
        private ClassicDarkTheme.Dark.DarkButton OrbwalkerButton;
        private ClassicDarkTheme.Dark.DarkButton AutoAimButton;
        private ClassicDarkTheme.Dark.DarkButton MiscButton;
        private ClassicDarkTheme.Dark.DarkButton HealBarrierButton;
        private System.Windows.Forms.PictureBox LogoPic;
        private VoidSharp.generaluser generaluser1;
    }
}
