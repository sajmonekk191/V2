namespace VoidSharp.SpecialForms
{
    partial class DrawGUI
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
            this.aimuser1 = new global::VoidSharp.aimuser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aimuser1
            // 
            this.aimuser1.BackColor = System.Drawing.Color.Transparent;
            this.aimuser1.Location = new System.Drawing.Point(12, 12);
            this.aimuser1.Name = "aimuser1";
            this.aimuser1.Size = new System.Drawing.Size(350, 224);
            this.aimuser1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DrawGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aimuser1);
            this.Name = "DrawGUI";
            this.Text = "DrawGUI";
            this.Load += new System.EventHandler(this.DrawGUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawGUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawGUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawGUI_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::VoidSharp.aimuser aimuser1;
        private System.Windows.Forms.Label label1;
    }
}