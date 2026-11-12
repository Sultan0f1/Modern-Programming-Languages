using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson12
{
    public class Form1 : Form
    {
        Button[] cards = new Button[8];
        string[] colors = new string[8];
        bool[] open = new bool[8];
        bool[] found = new bool[8];

        Random rnd = new Random();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        int first = -1;
        int second = -1;
        int score = 0;
        int pairs = 0;
        bool wait = false;

        Label scoreLabel = new Label();
        Label markLabel = new Label();

        public Form1()
        {
            Text = "Memory Game";
            Size = new Size(900, 540);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Black;

            for (int i = 0; i < 8; i++)
            {
                cards[i] = new Button();
                cards[i].Size = new Size(150, 125);
                cards[i].Location = new Point(35 + (i % 4) * 210, 35 + (i / 4) * 165);
                cards[i].Font = new Font("Arial", 24, FontStyle.Bold);
                cards[i].BackColor = Color.White;
                cards[i].Click += Card_Click;
                Controls.Add(cards[i]);
            }

            scoreLabel.Text = "Xal: 0";
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Font = new Font("Arial", 22, FontStyle.Bold);
            scoreLabel.Location = new Point(35, 385);
            scoreLabel.AutoSize = true;
            Controls.Add(scoreLabel);

            markLabel.Text = "";
            markLabel.ForeColor = Color.White;
            markLabel.Font = new Font("Arial", 30, FontStyle.Bold);
            markLabel.Location = new Point(270, 375);
            markLabel.Size = new Size(90, 55);
            Controls.Add(markLabel);

            Button newButton = new Button();
            newButton.Text = "Yeni oyun";
            newButton.Location = new Point(475, 390);
            newButton.Size = new Size(130, 45);
            newButton.Click += New_Click;
            Controls.Add(newButton);

            Button exitButton = new Button();
            exitButton.Text = "Çıxış";
            exitButton.Location = new Point(680, 390);
            exitButton.Size = new Size(130, 45);
            exitButton.Click += Exit_Click;
            Controls.Add(exitButton);

            timer.Interval = 800;
            timer.Tick += Timer_Tick;

            NewGame();
        }

        void NewGame()
        {
            timer.Stop();

            string[] list = { "Qırmızı", "Qırmızı", "Göy", "Göy",
                              "Yaşıl", "Yaşıl", "Sarı", "Sarı" };

            for (int i = 7; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            for (int i = 0; i < 8; i++)
            {
                colors[i] = list[i];
                open[i] = false;
                found[i] = false;
                cards[i].Text = "";
                cards[i].BackColor = Color.White;
                cards[i].Enabled = true;
            }

            first = -1;
            second = -1;
            score = 0;
            pairs = 0;
            wait = false;
            scoreLabel.Text = "Xal: 0";
            markLabel.Text = "";
        }

        void Card_Click(object sender, EventArgs e)
        {
            if (wait == true)
            {
                return;
            }

            Button card = (Button)sender;
            int n = Array.IndexOf(cards, card);

            if (open[n] == true)
            {
                return;
            }

            if (found[n] == true)
            {
                return;
            }

            cards[n].Text = colors[n];
            open[n] = true;

            if (first == -1)
            {
                first = n;
            }
            else
            {
                second = n;

                if (colors[first] == colors[second])
                {
                    found[first] = true;
                    found[second] = true;
                    score = score + 1;
                    pairs = pairs + 1;
                    scoreLabel.Text = "Xal: " + score;
                    markLabel.Text = "✅";
                    first = -1;
                    second = -1;

                    if (pairs == 4)
                    {
                        MessageBox.Show("Oyun bitdi!");
                    }
                }
                else
                {
                    markLabel.Text = "❌";
                    wait = true;
                    timer.Start();
                }
            }
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            cards[first].Text = "";
            cards[second].Text = "";
            open[first] = false;
            open[second] = false;

            first = -1;
            second = -1;
            wait = false;
        }

        void New_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
