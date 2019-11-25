using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FappyBird0._1v
{
    public partial class Form1 : Form
    {
        //public event EventHandler OkayToProceedChanged;
        double score;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            overtext.Visible = false;
            yourScore.Visible = false;
            RestartButton.Visible = false;
            score = 0;
            pauseGame();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            unpauseGame();
            pictureBox2.Visible = false;
        }
        private void pauseGame()
        {
            Pause.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

        }
        private void unpauseGame()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            Pause.Visible = false; ;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveCactuses(5);
            movePillar(5);
            gameOver();
        }
        Random r = new Random();
        void movePillar(int speed)       

        {
            if (TopFirstPillar.Left >= -50)
            {
                TopFirstPillar.Left += -speed;
            }
            else
            {
                TopFirstPillar.Height = r.Next(50,150);
                TopFirstPillar.Left = 830;
            }

            if (BottomFirstPillar.Left >= -50)
            {
                BottomFirstPillar.Left += -speed;
            }
            else
            {
                BottomFirstPillar.Height = r.Next(150, 250);
                BottomFirstPillar.Left = 830;
                //BottomFirstPillar.Top = 100;
            }

            if (TopSecondPillar.Left >= -50)
            {
                TopSecondPillar.Left += -speed;
            }
            else
            {
                TopSecondPillar.Left = 830;
            }

            if (BottomSecondPillar.Left >= -50)
            {
                BottomSecondPillar.Left += -speed;
            }
            else
            {
                BottomSecondPillar.Left = 830;
            }


        }
        void moveCactuses(int speed)//function to move cactuses
        {
            if (Cactus1.Left >= -50)
            {
                Cactus1.Left += -speed; 
            }
            else
                Cactus1.Left = 830;

            if (Cactus2.Left >= -50)
            {
                Cactus2.Left += -speed;

            }

            else
            {
                Cactus2.Left = 830;
            }
            if (Cactus3.Left >= -50)
            {
                Cactus3.Left += -speed;

            }

            else
            {
                Cactus3.Left = 830;
            }

            if (Cactus4.Left >= -50)
            {
                Cactus4.Left += -speed;

            }

            else
            {
                Cactus4.Left = 830;
            }
            if (Cactus5.Left >= -50)
            {
                Cactus5.Left += -speed;

            }

            else
            {
                Cactus5.Left = 830;
            }

        }

        void gameOver()
        {
            if( (Bird.Bounds.IntersectsWith(TopFirstPillar.Bounds)) ||
                 (Bird.Bounds.IntersectsWith(BottomFirstPillar.Bounds)) ||
                  (Bird.Bounds.IntersectsWith(TopSecondPillar.Bounds)) ||
                   (Bird.Bounds.IntersectsWith(BottomSecondPillar.Bounds)) )
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                label1.Visible = false;
                overtext.Visible = true;
                RestartButton.Visible = true;
                RestartButton.Enabled = true;
                yourScore.Text = $"Your Score: {0}" + score.ToString();
                yourScore.Visible = true;

            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if(Bird.Top<=402)
            Bird.Top += 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    Bird.Top += -40;
                }
                if(e.KeyCode == Keys.P)
                {
                    pauseGame();
                }
            }
            else if (e.KeyCode == Keys.P)
            {
                unpauseGame();
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            resetWorld();
        }

        private void resetWorld()
        {
            //180,-8 top1st
            //180,225 bot1st
            //560,-8 top2nd
            //560,225 bot2nd
            //44,157 bird
            RestartButton.Enabled = false;
            label1.Visible = true;
            yourScore.Visible = false;

            TopFirstPillar.Left = 180;
            TopFirstPillar.Top = -8;

            BottomFirstPillar.Left = 180;
            BottomFirstPillar.Top = 225;

            TopSecondPillar.Left = 560;
            TopSecondPillar.Top = -8;

            BottomSecondPillar.Left = 560;
            BottomSecondPillar.Top = 225;
            Bird.Left = 44;
            Bird.Top = 157;

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            overtext.Visible = false;
            RestartButton.Visible = false;
            score = 0;
            label1.Text = "Score: 0";

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            writeScore();
        }
        private void writeScore()
        {
            score = score + 1;
            label1.Text = $"Score: {0}" + score.ToString();
        }

    }
}
