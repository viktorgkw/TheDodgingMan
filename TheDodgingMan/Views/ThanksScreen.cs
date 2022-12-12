using System;
using System.Windows.Forms;

namespace TheDodgingMan
{
    public partial class TheDodgingManInfo : Form
    {
        public TheDodgingManInfo()
        {
            InitializeComponent();
            thankslabel.Visible = false;
        }       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gamelikecheck.Checked)
            {
                thankslabel.Visible = true;
            } else
            {
                thankslabel.Visible = false;
            }
        }
    }
}

