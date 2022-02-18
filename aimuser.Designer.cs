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
            this.components = new System.ComponentModel.Container();
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
            this.labeltimer = new System.Windows.Forms.Timer(this.components);
            this.keybindQ = new AmongUsExternal.DarkTextbox();
            this.keybindW = new AmongUsExternal.DarkTextbox();
            this.keybindE = new AmongUsExternal.DarkTextbox();
            this.keybindR = new AmongUsExternal.DarkTextbox();
            this.spellslbl = new System.Windows.Forms.Label();
            this.keybindslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // champslbl
            // 
            this.champslbl.AutoSize = true;
            this.champslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.champslbl.Location = new System.Drawing.Point(15, 16);
            this.champslbl.Name = "champslbl";
            this.champslbl.Size = new System.Drawing.Size(116, 15);
            this.champslbl.TabIndex = 0;
            this.champslbl.Text = "Selected Champion: ";
            // 
            // championnamelbl
            // 
            this.championnamelbl.AutoSize = true;
            this.championnamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.championnamelbl.Location = new System.Drawing.Point(128, 17);
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
            this.cbQ.Location = new System.Drawing.Point(38, 88);
            this.cbQ.Name = "cbQ";
            this.cbQ.Size = new System.Drawing.Size(24, 24);
            this.cbQ.TabIndex = 2;
            this.cbQ.Text = "darkCheckbox1";
            this.cbQ.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            // 
            // Qlbl
            // 
            this.Qlbl.AutoSize = true;
            this.Qlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Qlbl.Location = new System.Drawing.Point(70, 93);
            this.Qlbl.Name = "Qlbl";
            this.Qlbl.Size = new System.Drawing.Size(16, 15);
            this.Qlbl.TabIndex = 3;
            this.Qlbl.Text = "Q";
            // 
            // Wlbl
            // 
            this.Wlbl.AutoSize = true;
            this.Wlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Wlbl.Location = new System.Drawing.Point(70, 128);
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
            this.cbW.Location = new System.Drawing.Point(38, 123);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(24, 24);
            this.cbW.TabIndex = 4;
            this.cbW.Text = "darkCheckbox2";
            this.cbW.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            // 
            // Elbl
            // 
            this.Elbl.AutoSize = true;
            this.Elbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Elbl.Location = new System.Drawing.Point(70, 163);
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
            this.cbE.Location = new System.Drawing.Point(38, 158);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(24, 24);
            this.cbE.TabIndex = 6;
            this.cbE.Text = "darkCheckbox3";
            this.cbE.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            // 
            // Rlbl
            // 
            this.Rlbl.AutoSize = true;
            this.Rlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Rlbl.Location = new System.Drawing.Point(70, 196);
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
            this.cbR.Location = new System.Drawing.Point(38, 191);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(24, 24);
            this.cbR.TabIndex = 8;
            this.cbR.Text = "darkCheckbox4";
            this.cbR.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            // 
            // labeltimer
            // 
            this.labeltimer.Enabled = true;
            this.labeltimer.Interval = 1000;
            this.labeltimer.Tick += new System.EventHandler(this.labeltimer_Tick);
            // 
            // keybindQ
            // 
            this.keybindQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.keybindQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.keybindQ.ForeColor = System.Drawing.Color.White;
            this.keybindQ.Location = new System.Drawing.Point(284, 92);
            this.keybindQ.MaxLength = 32767;
            this.keybindQ.Name = "keybindQ";
            this.keybindQ.OnlyNumbers = false;
            this.keybindQ.Size = new System.Drawing.Size(34, 20);
            this.keybindQ.TabIndex = 10;
            this.keybindQ.Text = "null";
            this.keybindQ.TextStr = "";
            // 
            // keybindW
            // 
            this.keybindW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.keybindW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.keybindW.ForeColor = System.Drawing.Color.White;
            this.keybindW.Location = new System.Drawing.Point(284, 127);
            this.keybindW.MaxLength = 32767;
            this.keybindW.Name = "keybindW";
            this.keybindW.OnlyNumbers = false;
            this.keybindW.Size = new System.Drawing.Size(34, 20);
            this.keybindW.TabIndex = 11;
            this.keybindW.Text = "null";
            this.keybindW.TextStr = "";
            // 
            // keybindE
            // 
            this.keybindE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.keybindE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.keybindE.ForeColor = System.Drawing.Color.White;
            this.keybindE.Location = new System.Drawing.Point(284, 162);
            this.keybindE.MaxLength = 32767;
            this.keybindE.Name = "keybindE";
            this.keybindE.OnlyNumbers = false;
            this.keybindE.Size = new System.Drawing.Size(34, 20);
            this.keybindE.TabIndex = 12;
            this.keybindE.Text = "null";
            this.keybindE.TextStr = "";
            // 
            // keybindR
            // 
            this.keybindR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.keybindR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.keybindR.ForeColor = System.Drawing.Color.White;
            this.keybindR.Location = new System.Drawing.Point(284, 195);
            this.keybindR.MaxLength = 32767;
            this.keybindR.Name = "keybindR";
            this.keybindR.OnlyNumbers = false;
            this.keybindR.Size = new System.Drawing.Size(34, 20);
            this.keybindR.TabIndex = 13;
            this.keybindR.Text = "null";
            this.keybindR.TextStr = "";
            // 
            // spellslbl
            // 
            this.spellslbl.AutoSize = true;
            this.spellslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.spellslbl.Location = new System.Drawing.Point(43, 60);
            this.spellslbl.Name = "spellslbl";
            this.spellslbl.Size = new System.Drawing.Size(37, 15);
            this.spellslbl.TabIndex = 14;
            this.spellslbl.Text = "Spells";
            // 
            // keybindslbl
            // 
            this.keybindslbl.AutoSize = true;
            this.keybindslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.keybindslbl.Location = new System.Drawing.Point(275, 60);
            this.keybindslbl.Name = "keybindslbl";
            this.keybindslbl.Size = new System.Drawing.Size(55, 15);
            this.keybindslbl.TabIndex = 15;
            this.keybindslbl.Text = "Keybinds";
            // 
            // aimuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.keybindslbl);
            this.Controls.Add(this.spellslbl);
            this.Controls.Add(this.keybindR);
            this.Controls.Add(this.keybindE);
            this.Controls.Add(this.keybindW);
            this.Controls.Add(this.keybindQ);
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
            this.Size = new System.Drawing.Size(358, 255);
            this.Load += new System.EventHandler(this.aimuser_Load);
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
        private System.Windows.Forms.Timer labeltimer;
        private AmongUsExternal.DarkTextbox keybindQ;
        private AmongUsExternal.DarkTextbox keybindW;
        private AmongUsExternal.DarkTextbox keybindE;
        private AmongUsExternal.DarkTextbox keybindR;
        private System.Windows.Forms.Label spellslbl;
        private System.Windows.Forms.Label keybindslbl;
    }
}
