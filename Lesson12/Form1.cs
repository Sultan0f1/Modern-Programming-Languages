using System;
using System.Windows.Forms;

namespace Lesson12
{
    public partial class Form1 : Form
    {
        Button firstCard = null;
        Button secondCard = null;
        Random rnd = new Random();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        int score = 0;
        int pairs = 0;
        bool wait = false;

        public Form1()
        {
            InitializeComponent();

            card1.Click += Card_Click;
            card2.Click += Card_Click;
            card3.Click += Card_Click;
            card4.Click += Card_Click;
            card5.Click += Card_Click;
            card6.Click += Card_Click;
            card7.Click += Card_Click;
            card8.Click += Card_Click;

            newButton.Click += New_Click;
            exitButton.Click += Exit_Click;

            timer.Interval = 800;
            timer.Tick += Timer_Tick;

            NewGame();
        }

        void NewGame()
        {
            timer.Stop();

            card1.Tag = "Qırmızı";
            card2.Tag = "Qırmızı";
            card3.Tag = "Göy";
            card4.Tag = "Göy";
            card5.Tag = "Yaşıl";
            card6.Tag = "Yaşıl";
            card7.Tag = "Sarı";
            card8.Tag = "Sarı";

            ShuffleCards();

            ResetCard(card1);
            ResetCard(card2);
            ResetCard(card3);
            ResetCard(card4);
            ResetCard(card5);
            ResetCard(card6);
            ResetCard(card7);
            ResetCard(card8);

            firstCard = null;
            secondCard = null;
            score = 0;
            pairs = 0;
            wait = false;
            scoreLabel.Text = "Xal: 0";
            markLabel.Text = "";
        }

        void ShuffleCards()
        {
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
            SwapColors(rnd.Next(8), rnd.Next(8));
        }

        void SwapColors(int a, int b)
        {
            Button cardA = GetCard(a);
            Button cardB = GetCard(b);
            object temp = cardA.Tag;
            cardA.Tag = cardB.Tag;
            cardB.Tag = temp;
        }

        Button GetCard(int n)
        {
            if (n == 0)
            {
                return card1;
            }
            else if (n == 1)
            {
                return card2;
            }
            else if (n == 2)
            {
                return card3;
            }
            else if (n == 3)
            {
                return card4;
            }
            else if (n == 4)
            {
                return card5;
            }
            else if (n == 5)
            {
                return card6;
            }
            else if (n == 6)
            {
                return card7;
            }
            else
            {
                return card8;
            }
        }

        void ResetCard(Button card)
        {
            card.Text = "";
            card.Enabled = true;
        }

        void Card_Click(object sender, EventArgs e)
        {
            if (wait == true)
            {
                return;
            }

            Button card = (Button)sender;

            if (card == firstCard)
            {
                return;
            }

            card.Text = card.Tag.ToString();

            if (firstCard == null)
            {
                firstCard = card;
            }
            else
            {
                secondCard = card;

                if (firstCard.Tag.ToString() == secondCard.Tag.ToString())
                {
                    firstCard.Enabled = false;
                    secondCard.Enabled = false;
                    score = score + 1;
                    pairs = pairs + 1;
                    scoreLabel.Text = "Xal: " + score;
                    markLabel.Text = "✅";
                    firstCard = null;
                    secondCard = null;

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

            firstCard.Text = "";
            secondCard.Text = "";
            firstCard = null;
            secondCard = null;
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
