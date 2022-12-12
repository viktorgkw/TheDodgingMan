using System;
using System.Windows.Forms;

namespace TheDodgingMan
{
    public partial class TheDodgingManStartMenu : Form
    {
        public TheDodgingManStartMenu()
        {
            InitializeComponent();
        }

        private void gamestartbutton_Click(object sender, EventArgs e)
        {
            Hide();

            TheDodgingMan secondForm = new TheDodgingMan();
            secondForm.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            TheDodgingManInfo thingForm = new TheDodgingManInfo();
            thingForm.Show();
        }
    }
}
