using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheDodgingMan
{
    public partial class TheDodgingMan : Form
    {
        private const int EnemySpeed = 8;
        private int CollectedCoins = 0;
        private Random r = new Random();
        private int x;

        public TheDodgingMan()
        {
            InitializeComponent();
            over.Visible = false;
            RestartButton.Visible = false;
            heartsatend.Visible = false;
            ExitButton.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemy(EnemySpeed);
            Coins(8);
            CoinsCollection();
            GameOver();
        }

        private void Enemy(int speed)
        {
            if (dodgebox1.Top >= 500)
            {
                x = r.Next(0, 350);
                dodgebox1.Location = new Point(x, 0);
            }
            else
            {
                dodgebox1.Top += EnemySpeed;
            }

            if (dodgebox2.Top >= 500)
            {
                x = r.Next(0, 200);
                dodgebox2.Location = new Point(x, 0);
            }
            else
            {
                dodgebox2.Top += EnemySpeed;
            }

            if (dodgebox3.Top >= 500)
            {
                x = r.Next(200, 350);
                dodgebox3.Location = new Point(x, 0);
            }
            else
            {
                dodgebox3.Top += EnemySpeed;
            }
        }

        private void Coins(int speed)
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

        private void GameOverReset()
        {
            heartsatend.Text = "You got " + CollectedCoins.ToString() + " hearts!";

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
        private void GameOver()
        {
            if (tdmOfficial.Bounds.IntersectsWith(dodgebox1.Bounds) ||
                tdmOfficial.Bounds.IntersectsWith(dodgebox2.Bounds) ||
                tdmOfficial.Bounds.IntersectsWith(dodgebox3.Bounds))
            {
                GameOverReset();
            }

        }

        private void CoinsCollection()
        {
            if (tdmOfficial.Bounds.IntersectsWith(heart3.Bounds))
            {
                CollectedCoins++;
                heartscountlabel.Text = "Hearts: " + CollectedCoins.ToString();
                x = r.Next(50, 300);
                heart3.Location = new Point(x, 0);
            }
            if (tdmOfficial.Bounds.IntersectsWith(heart2.Bounds))
            {
                CollectedCoins++;
                heartscountlabel.Text = "Hearts: " + CollectedCoins.ToString();
                x = r.Next(50, 300);
                heart2.Location = new Point(x, 0);
            }
            if (tdmOfficial.Bounds.IntersectsWith(heart1.Bounds))
            {
                CollectedCoins++;
                heartscountlabel.Text = "Hearts: " + CollectedCoins.ToString();
                x = r.Next(50, 300);
                heart1.Location = new Point(x, 0);
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (tdmOfficial.Left > 0)
                tdmOfficial.Left -= 19;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (tdmOfficial.Right < 454)
                tdmOfficial.Left += 19;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
