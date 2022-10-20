namespace VoidSharp
{
    partial class Banger
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
            this.playbtn = new System.Windows.Forms.PictureBox();
            this.prevbtn = new System.Windows.Forms.PictureBox();
            this.nextbtn = new System.Windows.Forms.PictureBox();
            this.playlist = new System.Windows.Forms.ListBox();
            this.volumetb = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.playbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumetb)).BeginInit();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.Color.Transparent;
            this.playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbtn.Image = global::VoidSharp.Properties.Resources.play;
            this.playbtn.Location = new System.Drawing.Point(198, 218);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(32, 32);
            this.playbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playbtn.TabIndex = 0;
            this.playbtn.TabStop = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.BackColor = System.Drawing.Color.Transparent;
            this.prevbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevbtn.Image = global::VoidSharp.Properties.Resources.prev;
            this.prevbtn.Location = new System.Drawing.Point(134, 218);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(32, 32);
            this.prevbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevbtn.TabIndex = 1;
            this.prevbtn.TabStop = false;
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.Transparent;
            this.nextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbtn.Image = global::VoidSharp.Properties.Resources.next;
            this.nextbtn.Location = new System.Drawing.Point(259, 218);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(32, 32);
            this.nextbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextbtn.TabIndex = 2;
            this.nextbtn.TabStop = false;
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playlist.ForeColor = System.Drawing.SystemColors.Control;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 17;
            this.playlist.Location = new System.Drawing.Point(113, 21);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(197, 170);
            this.playlist.TabIndex = 3;
            this.playlist.DoubleClick += new System.EventHandler(this.playlist_DoubleClick);
            // 
            // volumetb
            // 
            this.volumetb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.volumetb.Location = new System.Drawing.Point(359, 157);
            this.volumetb.Maximum = 20;
            this.volumetb.Name = "volumetb";
            this.volumetb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumetb.Size = new System.Drawing.Size(45, 104);
            this.volumetb.TabIndex = 4;
            this.volumetb.Value = 20;
            this.volumetb.ValueChanged += new System.EventHandler(this.volumetb_ValueChanged);
            // 
            // Banger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.volumetb);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.prevbtn);
            this.Controls.Add(this.playbtn);
            this.Name = "Banger";
            this.Size = new System.Drawing.Size(431, 282);
            this.Load += new System.EventHandler(this.Banger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumetb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playbtn;
        private System.Windows.Forms.PictureBox prevbtn;
        private System.Windows.Forms.PictureBox nextbtn;
        public System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.TrackBar volumetb;
    }
}
