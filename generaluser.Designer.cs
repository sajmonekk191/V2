namespace VoidSharp
{
    partial class generaluser
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.champcb = new ClassicDarkTheme.Dark.DarkCombobox();
            this.darkLabel1 = new ClassicDarkTheme.Dark.DarkLabel();
            this.darkLabel2 = new ClassicDarkTheme.Dark.DarkLabel();
            this.darkButton1 = new ClassicDarkTheme.Dark.DarkButton();
            this.enablebutton = new ClassicDarkTheme.Dark.DarkButton();
            this.ingamelbl = new ClassicDarkTheme.Dark.DarkLabel();
            this.champpb = new ClassicDarkTheme.Dark.DarkPicturebox();
            this.statuspb = new ClassicDarkTheme.Dark.DarkPicturebox();
            this.statuslbl = new ClassicDarkTheme.Dark.DarkLabel();
            this.darkLabel3 = new ClassicDarkTheme.Dark.DarkLabel();
            this.Statuslbl2 = new ClassicDarkTheme.Dark.DarkLabel();
            this.wlbl = new ClassicDarkTheme.Dark.DarkLabel();
            this.bwlbl = new ClassicDarkTheme.Dark.DarkLabel();
            this.darkPicturebox1 = new ClassicDarkTheme.Dark.DarkPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.champpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // champcb
            // 
            this.champcb.Aligment = System.Drawing.StringAlignment.Near;
            this.champcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.champcb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.champcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.champcb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.champcb.ForeColor = System.Drawing.Color.White;
            this.champcb.FormattingEnabled = true;
            this.champcb.Items.AddRange(new object[] {
            "Aphelios",
            "Ashe",
            "Caitlyn",
            "Corki",
            "Draven",
            "Ezreal",
            "Jinx",
            "Kaisa",
            "Kalista",
            "Kayle",
            "Kindred",
            "Kogmaw",
            "Lucian",
            "Miss Fortune",
            "Quinn",
            "Samira",
            "Sivir",
            "Tristana",
            "Twitch",
            "Varus",
            "Vayne",
            "Xayah"});
            this.champcb.Location = new System.Drawing.Point(271, 82);
            this.champcb.Name = "champcb";
            this.champcb.Size = new System.Drawing.Size(124, 24);
            this.champcb.TabIndex = 0;
            this.champcb.SelectedIndexChanged += new System.EventHandler(this.champcb_SelectedIndexChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel1.ForeColor = System.Drawing.Color.White;
            this.darkLabel1.IsLink = false;
            this.darkLabel1.Link = "";
            this.darkLabel1.Location = new System.Drawing.Point(275, 27);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(108, 15);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Champion Settings";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel2.ForeColor = System.Drawing.Color.White;
            this.darkLabel2.IsLink = false;
            this.darkLabel2.Link = "";
            this.darkLabel2.Location = new System.Drawing.Point(65, 27);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(52, 15);
            this.darkLabel2.TabIndex = 3;
            this.darkLabel2.Text = "Connect";
            // 
            // darkButton1
            // 
            this.darkButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.darkButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkButton1.FlatAppearance.BorderSize = 0;
            this.darkButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkButton1.ForeColor = System.Drawing.Color.White;
            this.darkButton1.Location = new System.Drawing.Point(29, 46);
            this.darkButton1.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.darkButton1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.darkButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.darkButton1.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.darkButton1.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Size = new System.Drawing.Size(124, 34);
            this.darkButton1.TabIndex = 4;
            this.darkButton1.Text = "Connect to League";
            this.darkButton1.UseVisualStyleBackColor = false;
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // enablebutton
            // 
            this.enablebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.enablebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enablebutton.FlatAppearance.BorderSize = 0;
            this.enablebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enablebutton.ForeColor = System.Drawing.Color.White;
            this.enablebutton.Location = new System.Drawing.Point(29, 143);
            this.enablebutton.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.enablebutton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.enablebutton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.enablebutton.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.enablebutton.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.enablebutton.Name = "enablebutton";
            this.enablebutton.Size = new System.Drawing.Size(124, 34);
            this.enablebutton.TabIndex = 5;
            this.enablebutton.Text = "Enable Void";
            this.enablebutton.UseVisualStyleBackColor = false;
            this.enablebutton.Click += new System.EventHandler(this.enablebutton_Click);
            // 
            // ingamelbl
            // 
            this.ingamelbl.AutoSize = true;
            this.ingamelbl.BackColor = System.Drawing.Color.Transparent;
            this.ingamelbl.ForeColor = System.Drawing.Color.White;
            this.ingamelbl.IsLink = false;
            this.ingamelbl.Link = "";
            this.ingamelbl.Location = new System.Drawing.Point(47, 119);
            this.ingamelbl.Name = "ingamelbl";
            this.ingamelbl.Size = new System.Drawing.Size(92, 15);
            this.ingamelbl.TabIndex = 6;
            this.ingamelbl.Text = "Ingame Settings";
            // 
            // champpb
            // 
            this.champpb.Location = new System.Drawing.Point(271, 117);
            this.champpb.Name = "champpb";
            this.champpb.Size = new System.Drawing.Size(120, 120);
            this.champpb.TabIndex = 7;
            this.champpb.TabStop = false;
            // 
            // statuspb
            // 
            this.statuspb.Location = new System.Drawing.Point(76, 184);
            this.statuspb.Name = "statuspb";
            this.statuspb.Size = new System.Drawing.Size(32, 32);
            this.statuspb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statuspb.TabIndex = 8;
            this.statuspb.TabStop = false;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.BackColor = System.Drawing.Color.Transparent;
            this.statuslbl.ForeColor = System.Drawing.Color.White;
            this.statuslbl.IsLink = false;
            this.statuslbl.Link = "";
            this.statuslbl.Location = new System.Drawing.Point(27, 193);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(42, 15);
            this.statuslbl.TabIndex = 9;
            this.statuslbl.Text = "Status:";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel3.ForeColor = System.Drawing.Color.White;
            this.darkLabel3.IsLink = false;
            this.darkLabel3.Link = "";
            this.darkLabel3.Location = new System.Drawing.Point(293, 61);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(63, 15);
            this.darkLabel3.TabIndex = 10;
            this.darkLabel3.Text = "Champion";
            // 
            // Statuslbl2
            // 
            this.Statuslbl2.AutoSize = true;
            this.Statuslbl2.BackColor = System.Drawing.Color.Transparent;
            this.Statuslbl2.ForeColor = System.Drawing.Color.White;
            this.Statuslbl2.IsLink = false;
            this.Statuslbl2.Link = "";
            this.Statuslbl2.Location = new System.Drawing.Point(119, 191);
            this.Statuslbl2.Name = "Statuslbl2";
            this.Statuslbl2.Size = new System.Drawing.Size(39, 15);
            this.Statuslbl2.TabIndex = 11;
            this.Statuslbl2.Text = "Status";
            // 
            // wlbl
            // 
            this.wlbl.AutoSize = true;
            this.wlbl.BackColor = System.Drawing.Color.Transparent;
            this.wlbl.ForeColor = System.Drawing.Color.White;
            this.wlbl.IsLink = false;
            this.wlbl.Link = "";
            this.wlbl.Location = new System.Drawing.Point(271, 240);
            this.wlbl.Name = "wlbl";
            this.wlbl.Size = new System.Drawing.Size(55, 15);
            this.wlbl.TabIndex = 12;
            this.wlbl.Text = "Windup: ";
            this.wlbl.Visible = false;
            // 
            // bwlbl
            // 
            this.bwlbl.AutoSize = true;
            this.bwlbl.BackColor = System.Drawing.Color.Transparent;
            this.bwlbl.ForeColor = System.Drawing.Color.White;
            this.bwlbl.IsLink = false;
            this.bwlbl.Link = "";
            this.bwlbl.Location = new System.Drawing.Point(271, 255);
            this.bwlbl.Name = "bwlbl";
            this.bwlbl.Size = new System.Drawing.Size(82, 15);
            this.bwlbl.TabIndex = 13;
            this.bwlbl.Text = "Base Windup: ";
            // 
            // darkPicturebox1
            // 
            this.darkPicturebox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkPicturebox1.Image = global::VoidSharp.Properties.Resources.settings;
            this.darkPicturebox1.Location = new System.Drawing.Point(158, 50);
            this.darkPicturebox1.Name = "darkPicturebox1";
            this.darkPicturebox1.Size = new System.Drawing.Size(24, 24);
            this.darkPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.darkPicturebox1.TabIndex = 14;
            this.darkPicturebox1.TabStop = false;
            // 
            // generaluser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.darkPicturebox1);
            this.Controls.Add(this.bwlbl);
            this.Controls.Add(this.wlbl);
            this.Controls.Add(this.Statuslbl2);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.statuspb);
            this.Controls.Add(this.champpb);
            this.Controls.Add(this.ingamelbl);
            this.Controls.Add(this.enablebutton);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.champcb);
            this.Name = "generaluser";
            this.Size = new System.Drawing.Size(431, 282);
            ((System.ComponentModel.ISupportInitialize)(this.champpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassicDarkTheme.Dark.DarkCombobox champcb;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel1;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel2;
        private ClassicDarkTheme.Dark.DarkButton darkButton1;
        private ClassicDarkTheme.Dark.DarkButton enablebutton;
        private ClassicDarkTheme.Dark.DarkLabel ingamelbl;
        private ClassicDarkTheme.Dark.DarkPicturebox champpb;
        private ClassicDarkTheme.Dark.DarkPicturebox statuspb;
        private ClassicDarkTheme.Dark.DarkLabel statuslbl;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel3;
        private ClassicDarkTheme.Dark.DarkLabel Statuslbl2;
        private ClassicDarkTheme.Dark.DarkLabel wlbl;
        private ClassicDarkTheme.Dark.DarkLabel bwlbl;
        private ClassicDarkTheme.Dark.DarkPicturebox darkPicturebox1;
    }
}
