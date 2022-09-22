using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

