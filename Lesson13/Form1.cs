using System.Media;

namespace Nici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        Random g = new Random();
        Random n = new Random();

        Random xl = new Random();
        Random yl = new Random();
        SoundPlayer sp = new SoundPlayer("D:\\bomba.wav");
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new Size(60, 60);
            panel.Location = new Point(xl.Next(0, 770), yl.Next(0, 400));
            panel.BackColor = Color.FromArgb(r.Next(0, 256), g.Next(0, 256), n.Next(0, 256));
            this.Controls.Add(panel);
            count++;
            label2.Text = count.ToString();
            if (panel.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                sp.Play();
                MessageBox.Show("oyun bitdi");
                count = 0;
                label2.Text = count.ToString();
                while (this.Controls.Count > 2)
                {
                    this.Controls.RemoveAt(2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("oyun bitdi", "xeberdarliq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(xl.Next(0, 770), yl.Next(0, 400));
        }
    }
}
