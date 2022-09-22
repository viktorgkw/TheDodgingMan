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
    public partial class TheDodgingManStartMenu : Form
    {
        public TheDodgingManStartMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void gamestartbutton_Click(object sender, EventArgs e)
        {
            TheDodgingMan secondForm = new TheDodgingMan();
            secondForm.Show();
            this.Hide();
        }

        private void TheDodgingManStartMenu_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            TheDodgingManInfo thingForm = new TheDodgingManInfo();
            thingForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
