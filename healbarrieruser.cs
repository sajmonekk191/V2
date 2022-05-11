using System;
using System.Windows.Forms;
using VoidSharp.Other;

namespace VoidSharp
{
    public partial class healbarrieruser : UserControl
    {
        public healbarrieruser()
        {
            InitializeComponent();
            darkCombobox1.DropDownStyle = ComboBoxStyle.DropDownList;
            darkCombobox1.Items.Insert(0, "Select Champion");
            darkCombobox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                hodnoty.HBActivated = true;
            else
                hodnoty.HBActivated= false;

        }

        private void UpdateValue_Tick(object sender, EventArgs e)
        {
            try
            {
                hodnoty.Health = Convert.ToInt32(textBox1.Text);
            }
            catch { };
        }

        private void darkCombobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(darkCombobox1.SelectedItem.ToString().Trim())
            {
                case "D":
                    hodnoty.selectedD = true;
                    hodnoty.selectedF = false;
                    break;
                case "F":
                    hodnoty.selectedF = true;
                    hodnoty.selectedD = false;
                    break;
            }
        }
    }
}
