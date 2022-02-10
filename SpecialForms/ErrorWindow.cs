using System;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp.SpecialForms
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void ErrorWindow_Load(object sender, EventArgs e)
        {
            if (hodnoty.success)
            {
                this.Text = "Info";
                label1.Visible = true;
                label2.Text = hodnoty.CurentUsername;
            }
            else
            {
                this.Text = "Error";
                label1.Visible = false;
                label2.Location = new System.Drawing.Point(label2.Location.X - 62, label2.Location.Y);
                label2.Text = "You can select only 1 account !";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
