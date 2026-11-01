using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teyyare_line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string enis = AudioPath("inishazirliklari.wav");
        string tur = AudioPath("turbulans.wav");
        string kem = AudioPath("kemerler.wav");
        string tsk = AudioPath("tesekkurler.wav");
        string beep = AudioPath("beep.wav");
        string onof = AudioPath("isikacmakapamasesi.wav");

        private static string AudioPath(string name) { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Audio", name); }
        private static void PlaySound(string path) { if (!File.Exists(path)) { MessageBox.Show("Səs faylı tapılmadı: " + Path.GetFileName(path), "Nicat"); return; } using (SoundPlayer player = new SoundPlayer(path)) { player.Play(); } }

        bool Gas = false;

        // Eniş Hazırlığı (designer-də button1_Click_1-ə bağlıdır)
        private void button1_Click_1(object sender, EventArgs e)
        {
            PlaySound(enis);
        }

        // Turbulans
        private void button2_Click(object sender, EventArgs e)
        {
            PlaySound(tur);
        }

        // Kəmərlər
        private void button3_Click(object sender, EventArgs e)
        {
            PlaySound(kem);
        }

        // Təşəkkür
        private void button4_Click(object sender, EventArgs e)
        {
            PlaySound(tsk);
        }

        // Beep
        private void button5_Click(object sender, EventArgs e)
        {
            PlaySound(beep);
        }

        // GAS - timer başlayır, təyyarə və işıq yavaş-yavaş irəli gedir
        private void button6_Click(object sender, EventArgs e)
        {
            Gas = true;
            timer1.Start();
        }

        // Timer - hər tikdə təyyarə və işıq 1 piksel yuxarı gedir
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Gas == true && pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);
            }
            else
            {
                timer1.Stop();
                Gas = false;
                MessageBox.Show("Uçuş başa çatdı.");
            }
        }

        // Break - dialoq çıxır, Yes olsa proqram bağlanır
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxmaq istəyirsiniz?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        // ON/OFF - işıq yanıb sönür
        private void button8_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                PlaySound(onof);
            }
            else
            {
                pictureBox2.Visible = true;
                PlaySound(onof);
            }
        }

        // Designer-də bağlı olan boş metodlar (silmə, xəta verər)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}