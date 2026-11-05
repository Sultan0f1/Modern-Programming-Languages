using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace kart_oyunu

{
    public partial class Form1 : Form
    {

        SoundPlayer player = new SoundPlayer("bombasesi.wav");

        Random random = new Random();
        PictureBox[] qutular;

        int bombayeri;
        int xal = 0;

        bool[] acilan = new bool[6];
        bool oyunBitdi = false;
        public Form1()
        {
            InitializeComponent();
            
          

            qutular = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, };

            foreach (PictureBox qutu in qutular)
            {
                qutu.SizeMode = PictureBoxSizeMode.Zoom;
                qutu.Click += Qutu_Click;
            }

            button1.Click += button1_Click;
            button2.Click += button2_Click;

            YeniOyun();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }

        private void Qutu_Click(object? sender, EventArgs e)
        {
            if (oyunBitdi)
                return;

            PictureBox secilenQutu = sender as PictureBox;

            int index = Array.IndexOf(qutular, secilenQutu);

            if (acilan[index])
                return;

            acilan[index] = true;

            // Bomba tapıldıqda
            if (index == bombayeri)
            {
                secilenQutu.Image = Properties.Resources.bomba;

                oyunBitdi = true;

               // player.Play();

                SystemSounds.Hand.Play();

                MessageBox.Show(
                    "Oyun bitdi",
                    "Məğlubiyyət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                foreach (PictureBox qutu in qutular)
                {
                    qutu.Enabled = false;
                }
            }
            else
            {
                // Pişik tapıldıqda
                secilenQutu.Image = Properties.Resources.pisik;

                xal++;

                label2.Text = xal.ToString();

                // 5 pişik tapıldıqda
                if (xal == 5)
                {
                    oyunBitdi = true;

                    MessageBox.Show(
                        "Oyunu qazandınız, Yeni oyun üçün OK düyməsinə basın",
                        "Təbriklər!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    YeniOyun();

                }


            }
        }

        private void YeniOyun()
        {
            xal = 0;
            label2.Text = "0";
            oyunBitdi = false;
            bombayeri = random.Next(0, 6);
            acilan = new bool[6];

            foreach (PictureBox qutu in qutular)
            {
                qutu.Image = Properties.Resources.sual;
                qutu.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show(
                "Oyunu bitirmək istədiyinizə əminsiniz?",
                "Təsdiqləmə",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }           
    }
}
