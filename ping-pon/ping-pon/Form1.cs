using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pon
{
    public partial class Form1 : Form
    {

        int playerspeed = 6;
        int ballspeed;
        int p1vel;
        int p2vel;
        int bvelX = 2;
        int bvelY = 2;

        int p1scoreint;
        int p2scoreint;
        bool PAUSE = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!PAUSE)
            {
                ball.Location = new Point(ball.Location.X + bvelX, ball.Location.Y + bvelY);

                player1.Location = new Point(player1.Location.X + p1vel, player1.Location.Y);
                player2.Location = new Point(player2.Location.X + p2vel, player2.Location.Y);
            }

            if (ball.Location.Y < 0)
            {
                p1scoreint++;
                ball.Location = new Point(this.Width / 2, this.Height / 2);
                
                
            }
            if (ball.Location.Y > this.Height)
            {
                p2scoreint++;
                ball.Location = new Point(this.Width / 2, this.Height / 2);
                
            }

            if (ball.Location.X > player1.Location.X && ball.Location.X + ball.Width < player1.Location.X + player1.Width && ball.Location.Y + ball.Height > player1.Location.Y)
            {
                bvelY *= -1;
            }
            if (ball.Location.X > player2.Location.X && ball.Location.X + ball.Width < player2.Location.X + player2.Width && ball.Location.Y < player2.Location.Y + player2.Height)
            {
                bvelY *= -1;
            }

            if (ball.Location.X < 0)
            {
                bvelX *= -1;
            }
            if (ball.Location.X + ball.Width > this.Width)
            {
                bvelX *= -1;
            }

            p1score.Text = p1scoreint.ToString();
            p2score.Text = p2scoreint.ToString();



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                p1vel = playerspeed;
            }
            else if (e.KeyCode == Keys.Left)
            {
                p1vel = -playerspeed;
            }
            else if (e.KeyCode == Keys.D)
            {
                p2vel = playerspeed;
            }
            else if (e.KeyCode == Keys.A)
            {
                p2vel = -playerspeed;
            }

            else if (e.KeyCode == Keys.P)
            {
                if (!PAUSE)
                {
                    PAUSE = true;
                }
                else if (PAUSE){
                    PAUSE = false;
                }
            }
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                p1vel = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                p1vel = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                p2vel = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                p2vel = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
