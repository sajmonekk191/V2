namespace VoidSharp
{
    partial class orbuser
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
            this.darkLabel1 = new ClassicDarkTheme.Dark.DarkLabel();
            this.darkLabel2 = new ClassicDarkTheme.Dark.DarkLabel();
            this.aslabel = new System.Windows.Forms.Label();
            this.arlabel = new System.Windows.Forms.Label();
            this.UpdateValue = new System.Windows.Forms.Timer(this.components);
            this.humanizerlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttackChampcb = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.AttackEverythingcb = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.showrangecb = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.tooglechampcb = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.pingtb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkLabel3 = new ClassicDarkTheme.Dark.DarkLabel();
            this.Activatecb = new System.Windows.Forms.CheckBox();
            this.keybindlbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Humanizertb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.autohuma = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel1.ForeColor = System.Drawing.Color.White;
            this.darkLabel1.IsLink = false;
            this.darkLabel1.Link = "";
            this.darkLabel1.Location = new System.Drawing.Point(265, 50);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(106, 15);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Orbwalker Settings";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel2.ForeColor = System.Drawing.Color.White;
            this.darkLabel2.IsLink = false;
            this.darkLabel2.Link = "";
            this.darkLabel2.Location = new System.Drawing.Point(50, 50);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(95, 15);
            this.darkLabel2.TabIndex = 1;
            this.darkLabel2.Text = "Orbwalker Mode";
            // 
            // aslabel
            // 
            this.aslabel.AutoSize = true;
            this.aslabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aslabel.Location = new System.Drawing.Point(51, 223);
            this.aslabel.Name = "aslabel";
            this.aslabel.Size = new System.Drawing.Size(79, 15);
            this.aslabel.TabIndex = 2;
            this.aslabel.Text = "AttackSpeed: ";
            // 
            // arlabel
            // 
            this.arlabel.AutoSize = true;
            this.arlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.arlabel.Location = new System.Drawing.Point(51, 248);
            this.arlabel.Name = "arlabel";
            this.arlabel.Size = new System.Drawing.Size(83, 15);
            this.arlabel.TabIndex = 3;
            this.arlabel.Text = "AttackRange:  ";
            // 
            // UpdateValue
            // 
            this.UpdateValue.Enabled = true;
            this.UpdateValue.Interval = 1000;
            this.UpdateValue.Tick += new System.EventHandler(this.UpdateValue_Tick);
            // 
            // humanizerlbl
            // 
            this.humanizerlbl.AutoSize = true;
            this.humanizerlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.humanizerlbl.Location = new System.Drawing.Point(299, 78);
            this.humanizerlbl.Name = "humanizerlbl";
            this.humanizerlbl.Size = new System.Drawing.Size(31, 15);
            this.humanizerlbl.TabIndex = 7;
            this.humanizerlbl.Text = "Ping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "AttackChamp Only";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Attack Everything";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(79, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Show Attack Range";
            // 
            // AttackChampcb
            // 
            this.AttackChampcb.BackColor = System.Drawing.Color.Transparent;
            this.AttackChampcb.BorderThickness = 3;
            this.AttackChampcb.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.AttackChampcb.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.AttackChampcb.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.AttackChampcb.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AttackChampcb.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.AttackChampcb.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AttackChampcb.Checked = false;
            this.AttackChampcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackChampcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackChampcb.ForeColor = System.Drawing.Color.White;
            this.AttackChampcb.Location = new System.Drawing.Point(51, 78);
            this.AttackChampcb.Name = "AttackChampcb";
            this.AttackChampcb.Size = new System.Drawing.Size(24, 24);
            this.AttackChampcb.TabIndex = 11;
            this.AttackChampcb.Text = "darkCheckbox1";
            this.AttackChampcb.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.AttackChampcb.CheckedChanged += new System.EventHandler(this.AttackChampcb_CheckedChanged);
            // 
            // AttackEverythingcb
            // 
            this.AttackEverythingcb.BackColor = System.Drawing.Color.Transparent;
            this.AttackEverythingcb.BorderThickness = 3;
            this.AttackEverythingcb.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.AttackEverythingcb.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.AttackEverythingcb.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.AttackEverythingcb.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AttackEverythingcb.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.AttackEverythingcb.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.AttackEverythingcb.Checked = false;
            this.AttackEverythingcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackEverythingcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackEverythingcb.ForeColor = System.Drawing.Color.White;
            this.AttackEverythingcb.Location = new System.Drawing.Point(51, 110);
            this.AttackEverythingcb.Name = "AttackEverythingcb";
            this.AttackEverythingcb.Size = new System.Drawing.Size(24, 24);
            this.AttackEverythingcb.TabIndex = 12;
            this.AttackEverythingcb.Text = "darkCheckbox2";
            this.AttackEverythingcb.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.AttackEverythingcb.CheckedChanged += new System.EventHandler(this.AttackEverythingcb_CheckedChanged);
            // 
            // showrangecb
            // 
            this.showrangecb.BackColor = System.Drawing.Color.Transparent;
            this.showrangecb.BorderThickness = 3;
            this.showrangecb.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.showrangecb.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.showrangecb.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.showrangecb.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.showrangecb.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.showrangecb.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.showrangecb.Checked = false;
            this.showrangecb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showrangecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showrangecb.ForeColor = System.Drawing.Color.White;
            this.showrangecb.Location = new System.Drawing.Point(50, 143);
            this.showrangecb.Name = "showrangecb";
            this.showrangecb.Size = new System.Drawing.Size(24, 24);
            this.showrangecb.TabIndex = 13;
            this.showrangecb.Text = "darkCheckbox3";
            this.showrangecb.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.showrangecb.CheckedChanged += new System.EventHandler(this.showrangecb_CheckedChanged);
            // 
            // tooglechampcb
            // 
            this.tooglechampcb.BackColor = System.Drawing.Color.Transparent;
            this.tooglechampcb.BorderThickness = 3;
            this.tooglechampcb.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.tooglechampcb.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.tooglechampcb.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.tooglechampcb.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.tooglechampcb.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.tooglechampcb.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.tooglechampcb.Checked = false;
            this.tooglechampcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tooglechampcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tooglechampcb.ForeColor = System.Drawing.Color.White;
            this.tooglechampcb.Location = new System.Drawing.Point(51, 177);
            this.tooglechampcb.Name = "tooglechampcb";
            this.tooglechampcb.Size = new System.Drawing.Size(24, 24);
            this.tooglechampcb.TabIndex = 15;
            this.tooglechampcb.Text = "darkCheckbox3";
            this.tooglechampcb.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Standart;
            this.tooglechampcb.CheckedChanged += new System.EventHandler(this.tooglechampcb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(80, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Toogle Champ Only";
            // 
            // pingtb
            // 
            this.pingtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.pingtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pingtb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pingtb.ForeColor = System.Drawing.SystemColors.Control;
            this.pingtb.Location = new System.Drawing.Point(292, 96);
            this.pingtb.Name = "pingtb";
            this.pingtb.Size = new System.Drawing.Size(45, 20);
            this.pingtb.TabIndex = 18;
            this.pingtb.Text = "0";
            this.pingtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VoidSharp.Properties.Resources.champonly;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
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
            this.darkLabel3.Size = new System.Drawing.Size(77, 20);
            this.darkLabel3.TabIndex = 20;
            this.darkLabel3.Text = "Orbwalker";
            // 
            // Activatecb
            // 
            this.Activatecb.AutoSize = true;
            this.Activatecb.Location = new System.Drawing.Point(123, 21);
            this.Activatecb.Name = "Activatecb";
            this.Activatecb.Size = new System.Drawing.Size(15, 14);
            this.Activatecb.TabIndex = 21;
            this.Activatecb.UseVisualStyleBackColor = true;
            this.Activatecb.CheckedChanged += new System.EventHandler(this.Activatecb_CheckedChanged);
            // 
            // keybindlbl
            // 
            this.keybindlbl.AutoSize = true;
            this.keybindlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.keybindlbl.Location = new System.Drawing.Point(291, 186);
            this.keybindlbl.Name = "keybindlbl";
            this.keybindlbl.Size = new System.Drawing.Size(50, 15);
            this.keybindlbl.TabIndex = 23;
            this.keybindlbl.Text = "Keybind";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Space",
            "V",
            "C",
            "X"});
            this.comboBox1.Location = new System.Drawing.Point(284, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Humanizertb
            // 
            this.Humanizertb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.Humanizertb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Humanizertb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Humanizertb.ForeColor = System.Drawing.SystemColors.Control;
            this.Humanizertb.Location = new System.Drawing.Point(292, 144);
            this.Humanizertb.Name = "Humanizertb";
            this.Humanizertb.Size = new System.Drawing.Size(45, 20);
            this.Humanizertb.TabIndex = 25;
            this.Humanizertb.Text = "0";
            this.Humanizertb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(284, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Humanizer";
            // 
            // autohuma
            // 
            this.autohuma.AutoSize = true;
            this.autohuma.ForeColor = System.Drawing.SystemColors.Control;
            this.autohuma.Location = new System.Drawing.Point(345, 146);
            this.autohuma.Name = "autohuma";
            this.autohuma.Size = new System.Drawing.Size(52, 19);
            this.autohuma.TabIndex = 27;
            this.autohuma.Text = "Auto";
            this.autohuma.UseVisualStyleBackColor = true;
            this.autohuma.CheckedChanged += new System.EventHandler(this.autohuma_CheckedChanged);
            // 
            // orbuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.autohuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Humanizertb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.keybindlbl);
            this.Controls.Add(this.Activatecb);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pingtb);
            this.Controls.Add(this.tooglechampcb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showrangecb);
            this.Controls.Add(this.AttackEverythingcb);
            this.Controls.Add(this.AttackChampcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humanizerlbl);
            this.Controls.Add(this.arlabel);
            this.Controls.Add(this.aslabel);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Name = "orbuser";
            this.Size = new System.Drawing.Size(431, 282);
            this.Load += new System.EventHandler(this.orbuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassicDarkTheme.Dark.DarkLabel darkLabel1;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel2;
        private System.Windows.Forms.Label aslabel;
        private System.Windows.Forms.Label arlabel;
        private System.Windows.Forms.Timer UpdateValue;
        private System.Windows.Forms.Label humanizerlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ClassicDarkTheme.Dark.DarkCheckbox AttackChampcb;
        private ClassicDarkTheme.Dark.DarkCheckbox AttackEverythingcb;
        private ClassicDarkTheme.Dark.DarkCheckbox showrangecb;
        private ClassicDarkTheme.Dark.DarkCheckbox tooglechampcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pingtb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ClassicDarkTheme.Dark.DarkLabel darkLabel3;
        private System.Windows.Forms.CheckBox Activatecb;
        private System.Windows.Forms.Label keybindlbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Humanizertb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox autohuma;
    }
}
