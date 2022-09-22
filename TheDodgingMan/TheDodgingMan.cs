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
    public partial class TheDodgingMan : Form
    {
        public TheDodgingMan()
        {
            InitializeComponent();
            over.Visible = false;
            RestartButton.Visible = false;
            heartsatend.Visible = false;
            ExitButton.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        int enemyspeed = 8;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemy(enemyspeed);
            Coins(8);
            CoinsCollection();
            GameOver();
        }

        int collectedcoins = 0;

        Random r = new Random();
        int x;
        void Enemy(int speed)
        {
            if (dodgebox1.Top >= 500)
            {
                x = r.Next(0, 350);
                dodgebox1.Location = new Point(x, 0);
            }
            else
            {
                dodgebox1.Top += enemyspeed;
            }

            if (dodgebox2.Top >= 500)
            {
                x = r.Next(0, 200);
                dodgebox2.Location = new Point(x, 0);
            }
            else
            {
                dodgebox2.Top += enemyspeed;
            }

            if (dodgebox3.Top >= 500)
            {
                x = r.Next(200, 350);
                dodgebox3.Location = new Point(x, 0);
            }
            else
            {
                dodgebox3.Top += enemyspeed;
            }
        }

        void Coins(int speed)
        {
            if (heart3.Top >= 500)
            {
                x = r.Next(0, 400);
                heart3.Location = new Point(x, 0);
            }
            else
            {
                heart3.Top += speed;
            }

            if (heart2.Top >= 500)
            {
                x = r.Next(0, 400);
                heart2.Location = new Point(x, 0);
            }
            else
            {
                heart2.Top += speed;
            }

            if (heart1.Top >= 500)
            {
                x = r.Next(50, 300);
                heart1.Location = new Point(x, 0);
            }
            else
            {
                heart1.Top += speed;
            }

        }

        void GameOverReset()
        {
            heartsatend.Text = "You got " + collectedcoins.ToString() + " hearts!";

            dodgebox1.Visible = false;
            dodgebox2.Visible = false;
            dodgebox3.Visible = false;
            heart3.Visible = false;
            heart2.Visible = false;
            heart1.Visible = false;
            heartscountlabel.Visible = false;
            tdmOfficial.Visible = false;
            timer1.Enabled = false;
            over.Visible = true;
            RestartButton.Visible = true;
            ExitButton.Visible = true;
            heartsatend.Visible = true;
        }
        void GameOver()
        {
            if (tdmOfficial.Bounds.IntersectsWith(dodgebox1.Bounds) ||
                tdmOfficial.Bounds.IntersectsWith(dodgebox2.Bounds) ||
                tdmOfficial.Bounds.IntersectsWith(dodgebox3.Bounds))
            {
                GameOverReset();
            }

        }      

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        
        void CoinsCollection()
        {
            if (tdmOfficial.Bounds.IntersectsWith(heart3.Bounds))
            {
                collectedcoins++;
                heartscountlabel.Text = "Hearts: " + collectedcoins.ToString();
                x = r.Next(50, 300);
                heart3.Location = new Point(x, 0);
            }
            if (tdmOfficial.Bounds.IntersectsWith(heart2.Bounds))
            {
                collectedcoins++;
                heartscountlabel.Text = "Hearts: " + collectedcoins.ToString();
                x = r.Next(50, 300);
                heart2.Location = new Point(x, 0);
            }
            if (tdmOfficial.Bounds.IntersectsWith(heart1.Bounds))
            {
                collectedcoins++;
                heartscountlabel.Text = "Hearts: " + collectedcoins.ToString();
                x = r.Next(50, 300);
                heart1.Location = new Point(x, 0);
            }
        }

        private void GameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void tdmOfficial_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                if (tdmOfficial.Left>0)
                tdmOfficial.Left += -19;
            }
            if (e.KeyCode==Keys.Right)
            {
                if (tdmOfficial.Right<454)
                tdmOfficial.Left += 19;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
