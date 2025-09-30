using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 0; // Başlangıçta kuş sabit
        int score = 0;
        Button buttonRestart;

        public Form1()
        {
            InitializeComponent();

            // Yeniden Oyna butonu oluştur
            buttonRestart = new Button();
            buttonRestart.Text = "Yeniden Oyna";
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(120, 40);
            buttonRestart.Location = new Point(340, 200);
            buttonRestart.BackColor = Color.Yellow;
            buttonRestart.Visible = false;
            buttonRestart.Click += buttonRestart_Click;

            this.Controls.Add(buttonRestart);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;
            scoreText.Text = "Score: " + score;

            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }

            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                flappyBird.Bounds.IntersectsWith(BoruUst.Bounds) ||
                flappyBird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }

            if (score > 5)
            {
                boruHızı = 15;
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10; // Space basınca yukarı zıplar
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // Space bırakınca aşağı düşer
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!";
            buttonRestart.Visible = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            // Değerleri sıfırla
            score = 0;
            boruHızı = 8;
            gravity = 0; // kuş sabit duracak
            scoreText.Text = "Score: 0";

            // Flappy Bird konumunu resetle
            flappyBird.Top = 200;
            flappyBird.Left = 100;

            // Boruları resetle
            BoruAlt.Left = 800;
            BoruUst.Left = 950;

            // Oyunu tekrar başlat
            buttonRestart.Visible = false;
            gameTimer.Start();

            // Form focus'u geri al, böylece Space tuşu çalışır
            this.Focus();
        }

        // BoruAlt tıklama olayı (boş)
        private void BoruAlt_Click(object sender, EventArgs e)
        {
        }

        // pictureBox3 tıklama olayı (boş)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
