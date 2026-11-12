using System;
using System.Windows.Forms;

namespace Lesson12
{
    public partial class Form1 : Form
    {
        Button[] cards;
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

        public Form1()
        {
            InitializeComponent();

            cards = new Button[] {
                card1, card2, card3, card4,
                card5, card6, card7, card8
            };

            for (int i = 0; i < 8; i++)
            {
                cards[i].Click += Card_Click;
            }

            newButton.Click += New_Click;
            exitButton.Click += Exit_Click;

            timer.Interval = 800;
            timer.Tick += Timer_Tick;

            NewGame();
        }

        void NewGame()
        {
            timer.Stop();

            string[] list = {
                "Qırmızı", "Qırmızı", "Göy", "Göy",
                "Yaşıl", "Yaşıl", "Sarı", "Sarı"
            };

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
