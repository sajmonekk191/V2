using System;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class aimuser : UserControl
    {
        public aimuser()
        {
            InitializeComponent();
        }

        private void aimuser_Load(object sender, EventArgs e)
        {
            if (hodnoty.SelectedChamp != null)
            {
                championnamelbl.Text = hodnoty.SelectedChamp;
            }
            else
            {
                championnamelbl.Text = "Champion isn´t selected";
            }
        }

        private void labeltimer_Tick(object sender, EventArgs e)
        {
             if(hodnoty.SelectedChamp != null)
             championnamelbl.Text = hodnoty.SelectedChamp;
        }
    }
}
