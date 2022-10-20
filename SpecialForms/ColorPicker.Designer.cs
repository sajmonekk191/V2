namespace VoidSharp.SpecialForms
{
    partial class ColorPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.ExitButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.darkButton1 = new ClassicDarkTheme.Dark.DarkButton();
            this.Picker = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Gtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rtb1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gtb1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btb1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(330, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(49, 19);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "    X    ";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 141);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Rtb
            // 
            this.Rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Rtb.ForeColor = System.Drawing.SystemColors.Control;
            this.Rtb.Location = new System.Drawing.Point(201, 91);
            this.Rtb.Name = "Rtb";
            this.Rtb.Size = new System.Drawing.Size(66, 23);
            this.Rtb.TabIndex = 13;
            this.Rtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(226, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(246, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Color";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // darkButton1
            // 
            this.darkButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkButton1.FlatAppearance.BorderSize = 0;
            this.darkButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkButton1.ForeColor = System.Drawing.Color.White;
            this.darkButton1.Location = new System.Drawing.Point(157, 206);
            this.darkButton1.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.darkButton1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.darkButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.darkButton1.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.darkButton1.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 18;
            this.darkButton1.Text = "OK";
            this.darkButton1.UseVisualStyleBackColor = true;
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // Picker
            // 
            this.Picker.Tick += new System.EventHandler(this.Picker_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(226, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "B";
            // 
            // Gtb
            // 
            this.Gtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Gtb.ForeColor = System.Drawing.SystemColors.Control;
            this.Gtb.Location = new System.Drawing.Point(201, 134);
            this.Gtb.Name = "Gtb";
            this.Gtb.Size = new System.Drawing.Size(66, 23);
            this.Gtb.TabIndex = 19;
            this.Gtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(226, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "G";
            // 
            // Btb
            // 
            this.Btb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Btb.ForeColor = System.Drawing.SystemColors.Control;
            this.Btb.Location = new System.Drawing.Point(201, 177);
            this.Btb.Name = "Btb";
            this.Btb.Size = new System.Drawing.Size(66, 23);
            this.Btb.TabIndex = 21;
            this.Btb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(308, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "G2";
            // 
            // Rtb1
            // 
            this.Rtb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Rtb1.ForeColor = System.Drawing.SystemColors.Control;
            this.Rtb1.Location = new System.Drawing.Point(283, 90);
            this.Rtb1.Name = "Rtb1";
            this.Rtb1.Size = new System.Drawing.Size(66, 23);
            this.Rtb1.TabIndex = 27;
            this.Rtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(308, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "B2";
            // 
            // Gtb1
            // 
            this.Gtb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Gtb1.ForeColor = System.Drawing.SystemColors.Control;
            this.Gtb1.Location = new System.Drawing.Point(283, 134);
            this.Gtb1.Name = "Gtb1";
            this.Gtb1.Size = new System.Drawing.Size(66, 23);
            this.Gtb1.TabIndex = 25;
            this.Gtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(308, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "R2";
            // 
            // Btb1
            // 
            this.Btb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.Btb1.ForeColor = System.Drawing.SystemColors.Control;
            this.Btb1.Location = new System.Drawing.Point(283, 177);
            this.Btb1.Name = "Btb1";
            this.Btb1.Size = new System.Drawing.Size(66, 23);
            this.Btb1.TabIndex = 23;
            this.Btb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(379, 238);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rtb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gtb1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gtb);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorPicker";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Rtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ClassicDarkTheme.Dark.DarkButton darkButton1;
        private System.Windows.Forms.Timer Picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Gtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Btb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rtb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Gtb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Btb1;
    }
}