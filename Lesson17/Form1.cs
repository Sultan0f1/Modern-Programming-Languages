using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace The_Bomb_Exploded
{
    public partial class Form1 : Form
    {
        const int ManSpeed = 20;
        Random rnd = new Random();
        int step = 0;              // addım sayı
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;


            this.KeyPreview = true;
            this.KeyDown -= Form1_KeyDown;
            this.KeyDown += Form1_KeyDown;

            NewGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            PictureBox from = pictureBox3.Visible ? pictureBox3 : pictureBox4;
            PictureBox to;
            int x = from.Left;

            if (e.KeyCode == Keys.Left)
            {
                to = pictureBox3;
                x -= ManSpeed;
            }
            else if (e.KeyCode == Keys.Right)
            {
                to = pictureBox4;
                x += ManSpeed;
            }
            else
            {
                return;
            }

            if (x < 0)
            {
                x = 0;
            }
            if (x > ClientSize.Width - to.Width)
            {
                x = ClientSize.Width - to.Width;
            }
            from.Visible = false;
            to.Left = x;
            to.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            pictureBox1.Top += (int)pictureBox1.Tag;

            if ((pictureBox3.Visible && pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds)) ||
                (pictureBox4.Visible && pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds)))
            {
                EndGame();
                return;
            }

            if (pictureBox1.Top > ClientSize.Height)
            {
                step++;
                ResetBomb(pictureBox1);
            }

            pictureBox2.Top += (int)pictureBox2.Tag;

            if ((pictureBox3.Visible && pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds)) ||
                (pictureBox4.Visible && pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds)))
            {
                EndGame();
                return;
            }

            if (pictureBox2.Top > ClientSize.Height)
            {
                step++;
                ResetBomb(pictureBox2);
            }
        }

        private void ResetBomb(PictureBox bomb)
        {
            bomb.Left = rnd.Next(0, ClientSize.Width - bomb.Width + 1);
            bomb.Top = -bomb.Height - rnd.Next(0, 300);
            bomb.Tag = rnd.Next(8, 16);
        }

        private void EndGame()
        {
            gameOver = true;
            timer1.Stop();

            MessageBox.Show("Oyun bitdi! Sizin nəticə: " + step, "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult result = MessageBox.Show("Yeni oyun başlasınmı?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NewGame();
            }

            else
            {
                Application.Exit();
            }
                
        }

        private void NewGame()
        {
            step = 0;
            gameOver = false;

            int x = (ClientSize.Width - pictureBox4.Width) / 2;
            pictureBox3.Left = x;
            pictureBox4.Left = x;
            pictureBox3.Top = ClientSize.Height - pictureBox3.Height - 10;
            pictureBox4.Top = ClientSize.Height - pictureBox4.Height - 10;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            ResetBomb(pictureBox1);
            ResetBomb(pictureBox2);

            timer1.Start();
        }
    }
}