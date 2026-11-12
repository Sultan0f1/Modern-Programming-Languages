
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int c1, c2, c3, c4, c5, c6, c7, c8;

        bool s1, s2, s3, s4, s5, s6, s7, s8;

        int red, blue, green, yellow;

        int first = 0;
        int fColor = 0;
        int w1 = 0, w2 = 0;
        int point = 0;

        Random rand = new Random();
        Color back = Color.Gainsboro;

        private Color GetColor(int n)
        {
            if (n == 1) return Color.Red;
            if (n == 2) return Color.Blue;
            if (n == 3) return Color.Green;
            return Color.Gold;
        }

        private int RandomColor()
        {
            while (true)
            {
                int n = rand.Next(1, 5);

                if (n == 1 && red < 2) { red++; return 1; }
                if (n == 2 && blue < 2) { blue++; return 2; }
                if (n == 3 && green < 2) { green++; return 3; }
                if (n == 4 && yellow < 2) { yellow++; return 4; }
            }
        }

        private void CloseCard(int n)
        {
            if (n == 1) { s1 = false; pictureBox1.BackColor = back; }
            if (n == 2) { s2 = false; pictureBox2.BackColor = back; }
            if (n == 3) { s3 = false; pictureBox3.BackColor = back; }
            if (n == 4) { s4 = false; pictureBox4.BackColor = back; }
            if (n == 5) { s5 = false; pictureBox5.BackColor = back; }
            if (n == 6) { s6 = false; pictureBox6.BackColor = back; }
            if (n == 7) { s7 = false; pictureBox7.BackColor = back; }
            if (n == 8) { s8 = false; pictureBox8.BackColor = back; }
        }

        private void CloseWrong()
        {
            if (w1 != 0)
            {
                CloseCard(w1);
                CloseCard(w2);

                w1 = 0;
                w2 = 0;

                pictureBox10.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            red = 0;
            blue = 0;
            green = 0;
            yellow = 0;

            c1 = RandomColor();
            c2 = RandomColor();
            c3 = RandomColor();
            c4 = RandomColor();
            c5 = RandomColor();
            c6 = RandomColor();
            c7 = RandomColor();
            c8 = RandomColor();

            s1 = false; s2 = false;
            s3 = false; s4 = false;
            s5 = false; s6 = false;
            s7 = false; s8 = false;

            pictureBox1.BackColor = back;
            pictureBox2.BackColor = back;
            pictureBox3.BackColor = back;
            pictureBox4.BackColor = back;
            pictureBox5.BackColor = back;
            pictureBox6.BackColor = back;
            pictureBox7.BackColor = back;
            pictureBox8.BackColor = back;

            first = 0;
            fColor = 0;
            w1 = 0;
            w2 = 0;
            point = 0;

            label2.Text = point.ToString();

            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s1 == true) return;

            s1 = true;
            pictureBox1.BackColor = GetColor(c1);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 1;
                fColor = c1;
            }
            else
            {
                if (fColor == c1)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 1;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s2 == true) return;

            s2 = true;
            pictureBox2.BackColor = GetColor(c2);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 2;
                fColor = c2;
            }
            else
            {
                if (fColor == c2)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 2;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s3 == true) return;

            s3 = true;
            pictureBox3.BackColor = GetColor(c3);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 3;
                fColor = c3;
            }
            else
            {
                if (fColor == c3)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 3;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s4 == true) return;

            s4 = true;
            pictureBox4.BackColor = GetColor(c4);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 4;
                fColor = c4;
            }
            else
            {
                if (fColor == c4)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 4;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s5 == true) return;

            s5 = true;
            pictureBox5.BackColor = GetColor(c5);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 5;
                fColor = c5;
            }
            else
            {
                if (fColor == c5)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 5;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s6 == true) return;

            s6 = true;
            pictureBox6.BackColor = GetColor(c6);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 6;
                fColor = c6;
            }
            else
            {
                if (fColor == c6)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 6;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s7 == true) return;

            s7 = true;
            pictureBox7.BackColor = GetColor(c7);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 7;
                fColor = c7;
            }
            else
            {
                if (fColor == c7)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 7;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (s8 == true) return;

            s8 = true;
            pictureBox8.BackColor = GetColor(c8);

            if (first == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                first = 8;
                fColor = c8;
            }
            else
            {
                if (fColor == c8)
                {
                    point++;
                    label2.Text = point.ToString();

                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;

                    w1 = first;
                    w2 = 8;
                }

                first = 0;
            }

            if (point == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.",
                    "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e) { }

        private void pictureBox10_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Oyundan çıxış edilsinmi?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
