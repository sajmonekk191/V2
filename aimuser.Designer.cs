namespace VoidSharp
{
    partial class aimuser
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
            this.champslbl = new System.Windows.Forms.Label();
            this.championnamelbl = new System.Windows.Forms.Label();
            this.cbQ = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.Qlbl = new System.Windows.Forms.Label();
            this.Wlbl = new System.Windows.Forms.Label();
            this.cbW = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.Elbl = new System.Windows.Forms.Label();
            this.cbE = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.Rlbl = new System.Windows.Forms.Label();
            this.cbR = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.spellslbl = new System.Windows.Forms.Label();
            this.keybindslbl = new System.Windows.Forms.Label();
            this.darkLabel3 = new ClassicDarkTheme.Dark.DarkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Activatedcb = new System.Windows.Forms.CheckBox();
            this.KeybindQ = new System.Windows.Forms.TextBox();
            this.KeybindW = new System.Windows.Forms.TextBox();
            this.KeybindE = new System.Windows.Forms.TextBox();
            this.KeybindR = new System.Windows.Forms.TextBox();
            this.helplbl = new System.Windows.Forms.Label();
            this.KeyOutR = new System.Windows.Forms.TextBox();
            this.KeyOutE = new System.Windows.Forms.TextBox();
            this.KeyOutW = new System.Windows.Forms.TextBox();
            this.KeyOutQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new ClassicDarkTheme.Dark.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // champslbl
            // 
            this.champslbl.AutoSize = true;
            this.champslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.champslbl.Location = new System.Drawing.Point(107, 50);
            this.champslbl.Name = "champslbl";
            this.champslbl.Size = new System.Drawing.Size(116, 15);
            this.champslbl.TabIndex = 0;
            this.champslbl.Text = "Selected Champion: ";
            // 
            // championnamelbl
            // 
            this.championnamelbl.AutoSize = true;
            this.championnamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.championnamelbl.Location = new System.Drawing.Point(215, 50);
            this.championnamelbl.Name = "championnamelbl";
            this.championnamelbl.Size = new System.Drawing.Size(95, 15);
            this.championnamelbl.TabIndex = 1;
            this.championnamelbl.Text = "ChampionName";
            // 
            // cbQ
            // 
            this.cbQ.BackColor = System.Drawing.Color.Transparent;
            this.cbQ.BorderThickness = 3;
            this.cbQ.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.cbQ.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.cbQ.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.cbQ.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbQ.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.cbQ.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbQ.Checked = false;
            this.cbQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbQ.ForeColor = System.Drawing.Color.White;
            this.cbQ.Location = new System.Drawing.Point(68, 115);
            this.cbQ.Name = "cbQ";
            this.cbQ.Size = new System.Drawing.Size(24, 24);
            this.cbQ.TabIndex = 2;
            this.cbQ.Text = "darkCheckbox1";
            this.cbQ.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.cbQ.CheckedChanged += new System.EventHandler(this.cbQ_CheckedChanged);
            // 
            // Qlbl
            // 
            this.Qlbl.AutoSize = true;
            this.Qlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Qlbl.Location = new System.Drawing.Point(100, 120);
            this.Qlbl.Name = "Qlbl";
            this.Qlbl.Size = new System.Drawing.Size(16, 15);
            this.Qlbl.TabIndex = 3;
            this.Qlbl.Text = "Q";
            // 
            // Wlbl
            // 
            this.Wlbl.AutoSize = true;
            this.Wlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Wlbl.Location = new System.Drawing.Point(100, 155);
            this.Wlbl.Name = "Wlbl";
            this.Wlbl.Size = new System.Drawing.Size(18, 15);
            this.Wlbl.TabIndex = 5;
            this.Wlbl.Text = "W";
            // 
            // cbW
            // 
            this.cbW.BackColor = System.Drawing.Color.Transparent;
            this.cbW.BorderThickness = 3;
            this.cbW.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.cbW.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.cbW.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.cbW.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbW.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.cbW.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbW.Checked = false;
            this.cbW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbW.ForeColor = System.Drawing.Color.White;
            this.cbW.Location = new System.Drawing.Point(68, 150);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(24, 24);
            this.cbW.TabIndex = 4;
            this.cbW.Text = "darkCheckbox2";
            this.cbW.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.cbW.CheckedChanged += new System.EventHandler(this.cbW_CheckedChanged);
            // 
            // Elbl
            // 
            this.Elbl.AutoSize = true;
            this.Elbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Elbl.Location = new System.Drawing.Point(100, 190);
            this.Elbl.Name = "Elbl";
            this.Elbl.Size = new System.Drawing.Size(13, 15);
            this.Elbl.TabIndex = 7;
            this.Elbl.Text = "E";
            // 
            // cbE
            // 
            this.cbE.BackColor = System.Drawing.Color.Transparent;
            this.cbE.BorderThickness = 3;
            this.cbE.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.cbE.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.cbE.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.cbE.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbE.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.cbE.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbE.Checked = false;
            this.cbE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbE.ForeColor = System.Drawing.Color.White;
            this.cbE.Location = new System.Drawing.Point(68, 185);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(24, 24);
            this.cbE.TabIndex = 6;
            this.cbE.Text = "darkCheckbox3";
            this.cbE.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.cbE.CheckedChanged += new System.EventHandler(this.cbE_CheckedChanged);
            // 
            // Rlbl
            // 
            this.Rlbl.AutoSize = true;
            this.Rlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Rlbl.Location = new System.Drawing.Point(100, 223);
            this.Rlbl.Name = "Rlbl";
            this.Rlbl.Size = new System.Drawing.Size(14, 15);
            this.Rlbl.TabIndex = 9;
            this.Rlbl.Text = "R";
            // 
            // cbR
            // 
            this.cbR.BackColor = System.Drawing.Color.Transparent;
            this.cbR.BorderThickness = 3;
            this.cbR.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.cbR.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.cbR.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.cbR.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbR.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.cbR.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbR.Checked = false;
            this.cbR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbR.ForeColor = System.Drawing.Color.White;
            this.cbR.Location = new System.Drawing.Point(68, 218);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(24, 24);
            this.cbR.TabIndex = 8;
            this.cbR.Text = "darkCheckbox4";
            this.cbR.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.cbR.CheckedChanged += new System.EventHandler(this.cbR_CheckedChanged);
            // 
            // spellslbl
            // 
            this.spellslbl.AutoSize = true;
            this.spellslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.spellslbl.Location = new System.Drawing.Point(73, 87);
            this.spellslbl.Name = "spellslbl";
            this.spellslbl.Size = new System.Drawing.Size(37, 15);
            this.spellslbl.TabIndex = 14;
            this.spellslbl.Text = "Spells";
            // 
            // keybindslbl
            // 
            this.keybindslbl.AutoSize = true;
            this.keybindslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.keybindslbl.Location = new System.Drawing.Point(197, 88);
            this.keybindslbl.Name = "keybindslbl";
            this.keybindslbl.Size = new System.Drawing.Size(70, 15);
            this.keybindslbl.TabIndex = 15;
            this.keybindslbl.Text = "Keybinds IN";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darkLabel3.ForeColor = System.Drawing.Color.White;
            this.darkLabel3.IsLink = false;
            this.darkLabel3.Link = "";
            this.darkLabel3.Location = new System.Drawing.Point(46, 16);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(68, 20);
            this.darkLabel3.TabIndex = 22;
            this.darkLabel3.Text = "AutoAim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VoidSharp.Properties.Resources.aim;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Activatedcb
            // 
            this.Activatedcb.AutoSize = true;
            this.Activatedcb.Location = new System.Drawing.Point(114, 21);
            this.Activatedcb.Name = "Activatedcb";
            this.Activatedcb.Size = new System.Drawing.Size(15, 14);
            this.Activatedcb.TabIndex = 23;
            this.Activatedcb.UseVisualStyleBackColor = true;
            this.Activatedcb.CheckedChanged += new System.EventHandler(this.Activatedcb_CheckedChanged);
            // 
            // KeybindQ
            // 
            this.KeybindQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeybindQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeybindQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeybindQ.ForeColor = System.Drawing.SystemColors.Control;
            this.KeybindQ.Location = new System.Drawing.Point(222, 112);
            this.KeybindQ.MaxLength = 1;
            this.KeybindQ.Name = "KeybindQ";
            this.KeybindQ.Size = new System.Drawing.Size(19, 23);
            this.KeybindQ.TabIndex = 24;
            this.KeybindQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeybindW
            // 
            this.KeybindW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeybindW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeybindW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeybindW.ForeColor = System.Drawing.SystemColors.Control;
            this.KeybindW.Location = new System.Drawing.Point(222, 147);
            this.KeybindW.MaxLength = 1;
            this.KeybindW.Name = "KeybindW";
            this.KeybindW.Size = new System.Drawing.Size(19, 23);
            this.KeybindW.TabIndex = 25;
            this.KeybindW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeybindE
            // 
            this.KeybindE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeybindE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeybindE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeybindE.ForeColor = System.Drawing.SystemColors.Control;
            this.KeybindE.Location = new System.Drawing.Point(222, 182);
            this.KeybindE.MaxLength = 1;
            this.KeybindE.Name = "KeybindE";
            this.KeybindE.Size = new System.Drawing.Size(19, 23);
            this.KeybindE.TabIndex = 26;
            this.KeybindE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeybindR
            // 
            this.KeybindR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeybindR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeybindR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeybindR.ForeColor = System.Drawing.SystemColors.Control;
            this.KeybindR.Location = new System.Drawing.Point(222, 215);
            this.KeybindR.MaxLength = 1;
            this.KeybindR.Name = "KeybindR";
            this.KeybindR.Size = new System.Drawing.Size(19, 23);
            this.KeybindR.TabIndex = 27;
            this.KeybindR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // helplbl
            // 
            this.helplbl.AutoSize = true;
            this.helplbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helplbl.ForeColor = System.Drawing.SystemColors.Control;
            this.helplbl.Location = new System.Drawing.Point(406, 256);
            this.helplbl.Name = "helplbl";
            this.helplbl.Size = new System.Drawing.Size(16, 20);
            this.helplbl.TabIndex = 28;
            this.helplbl.Text = "?";
            // 
            // KeyOutR
            // 
            this.KeyOutR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeyOutR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyOutR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOutR.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyOutR.Location = new System.Drawing.Point(315, 215);
            this.KeyOutR.MaxLength = 1;
            this.KeyOutR.Name = "KeyOutR";
            this.KeyOutR.Size = new System.Drawing.Size(19, 23);
            this.KeyOutR.TabIndex = 33;
            this.KeyOutR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyOutE
            // 
            this.KeyOutE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeyOutE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyOutE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOutE.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyOutE.Location = new System.Drawing.Point(315, 182);
            this.KeyOutE.MaxLength = 1;
            this.KeyOutE.Name = "KeyOutE";
            this.KeyOutE.Size = new System.Drawing.Size(19, 23);
            this.KeyOutE.TabIndex = 32;
            this.KeyOutE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyOutW
            // 
            this.KeyOutW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeyOutW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyOutW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOutW.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyOutW.Location = new System.Drawing.Point(315, 147);
            this.KeyOutW.MaxLength = 1;
            this.KeyOutW.Name = "KeyOutW";
            this.KeyOutW.Size = new System.Drawing.Size(19, 23);
            this.KeyOutW.TabIndex = 31;
            this.KeyOutW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyOutQ
            // 
            this.KeyOutQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeyOutQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyOutQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOutQ.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyOutQ.Location = new System.Drawing.Point(315, 112);
            this.KeyOutQ.MaxLength = 1;
            this.KeyOutQ.Name = "KeyOutQ";
            this.KeyOutQ.Size = new System.Drawing.Size(19, 23);
            this.KeyOutQ.TabIndex = 30;
            this.KeyOutQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(285, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Keybinds OUT";
            // 
            // savebtn
            // 
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(255, 247);
            this.savebtn.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.savebtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.savebtn.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.savebtn.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.savebtn.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(43, 23);
            this.savebtn.TabIndex = 34;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // aimuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.KeyOutR);
            this.Controls.Add(this.KeyOutE);
            this.Controls.Add(this.KeyOutW);
            this.Controls.Add(this.KeyOutQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helplbl);
            this.Controls.Add(this.KeybindR);
            this.Controls.Add(this.KeybindE);
            this.Controls.Add(this.KeybindW);
            this.Controls.Add(this.KeybindQ);
            this.Controls.Add(this.Activatedcb);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.keybindslbl);
            this.Controls.Add(this.spellslbl);
            this.Controls.Add(this.Rlbl);
            this.Controls.Add(this.cbR);
            this.Controls.Add(this.Elbl);
            this.Controls.Add(this.cbE);
            this.Controls.Add(this.Wlbl);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.Qlbl);
            this.Controls.Add(this.cbQ);
            this.Controls.Add(this.championnamelbl);
            this.Controls.Add(this.champslbl);
            this.Name = "aimuser";
            this.Size = new System.Drawing.Size(431, 282);
            this.Load += new System.EventHandler(this.aimuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label champslbl;
        public System.Windows.Forms.Label championnamelbl;
        private ClassicDarkTheme.Dark.DarkCheckbox cbQ;
        private System.Windows.Forms.Label Qlbl;
        private System.Windows.Forms.Label Wlbl;
        private ClassicDarkTheme.Dark.DarkCheckbox cbW;
        private System.Windows.Forms.Label Elbl;
        private ClassicDarkTheme.Dark.DarkCheckbox cbE;
        private System.Windows.Forms.Label Rlbl;
        private ClassicDarkTheme.Dark.DarkCheckbox cbR;
        private System.Windows.Forms.Label spellslbl;
        private System.Windows.Forms.Label keybindslbl;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Activatedcb;
        private System.Windows.Forms.TextBox KeybindQ;
        private System.Windows.Forms.TextBox KeybindW;
        private System.Windows.Forms.TextBox KeybindE;
        private System.Windows.Forms.TextBox KeybindR;
        private System.Windows.Forms.Label helplbl;
        private System.Windows.Forms.TextBox KeyOutR;
        private System.Windows.Forms.TextBox KeyOutE;
        private System.Windows.Forms.TextBox KeyOutW;
        private System.Windows.Forms.TextBox KeyOutQ;
        private System.Windows.Forms.Label label1;
        private ClassicDarkTheme.Dark.DarkButton savebtn;
    }
}
