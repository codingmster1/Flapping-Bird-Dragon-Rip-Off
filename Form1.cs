using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_test_FB
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 8;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipe1.Left -= pipeSpeed;
            pipe2.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipe1.Left < -150)
            {

                pipe1.Left = 800;
                score++;
            }
            if (pipe2.Left < -190)
            {
                pipe2.Left = 950;
                score++;

            }
            if (score > 10)
            {
                pipeSpeed = 12;
            }
            if (score > 25)
            {
                pipeSpeed = 16;
            }
            if (score > 35)
            {
                pipeSpeed = 20;
            }
            if (score > 60)
            {
                pipeSpeed = 25;
            }
            if (score > 100)
            {
                pipeSpeed = 28;
            }
            if (score > 125)
            {
                pipeSpeed = 15;
            }
            if (score > 140)
            {
                pipeSpeed = 10;
            }
            if (score > 160)
            {
                pipeSpeed = 30;
            }
            if (score > 200)
            {
                pipeSpeed = 35;
            }
            if (Bird.Top < -25)
            {
                endGame(); 
            }

            if (Bird.Bounds.IntersectsWith(pipe1.Bounds) ||
                Bird.Bounds.IntersectsWith(pipe2.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -25  
                )
            {
                endGame();
            }
        }

    
  
            
           
            

      


        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }

            {

            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over";
        }
    }


}
