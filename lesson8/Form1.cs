using System;
using System.IO;
using System.Windows.Forms;

namespace FaylMeneceri
{
    public partial class Form1 : Form
    {
        private string qovluqYolu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Form1()
        {
            InitializeComponent();
            txtYol.Text = qovluqYolu;
            FayllariGoster();
        }

        private void btnQovluq_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialoq = new FolderBrowserDialog())
            {
                dialoq.SelectedPath = qovluqYolu;

                if (dialoq.ShowDialog() == DialogResult.OK)
                {
                    qovluqYolu = dialoq.SelectedPath;
                    txtYol.Text = qovluqYolu;
                    FayllariGoster();
                }
            }
        }

        private void FayllariGoster()
        {
            lstFayllar.Items.Clear();
            txtMetn.Clear();
            lblMelumat.Text = "Fayl seçilməyib";

            string[] fayllar = Directory.GetFiles(qovluqYolu, "*.txt");
            Array.Sort(fayllar);

            foreach (string fayl in fayllar)
            {
                lstFayllar.Items.Add(Path.GetFileName(fayl));
            }

            lblStatus.Text = "Hazırdır | Fayl sayı: " + lstFayllar.Items.Count;

            if (lstFayllar.Items.Count > 0)
            {
                lstFayllar.SelectedIndex = 0;
            }
        }

        private void FayliAc()
        {
            if (lstFayllar.SelectedIndex == -1)
            {
                MessageBox.Show("Əvvəlcə fayl seçin.");
                return;
            }

            string faylYolu = Path.Combine(qovluqYolu, lstFayllar.SelectedItem.ToString());

            txtMetn.Text = File.ReadAllText(faylYolu);

            FileInfo melumat = new FileInfo(faylYolu);
            double olcu = melumat.Length / 1024.0;

            lblMelumat.Text = "Ad: " + melumat.Name
                + "     Ölçü: " + olcu.ToString("0.0") + " KB"
                + "     Yaranma tarixi: " + melumat.CreationTime.ToString("dd.MM.yyyy");

            lblStatus.Text = "Fayl açıldı | Fayl sayı: " + lstFayllar.Items.Count;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            FayliAc();
        }

        private void lstFayllar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex != -1)
            {
                FayliAc();
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex == -1)
            {
                MessageBox.Show("Əvvəlcə fayl seçin.");
                return;
            }

            string faylYolu = Path.Combine(qovluqYolu, lstFayllar.SelectedItem.ToString());

            File.WriteAllText(faylYolu, txtMetn.Text);
            FayliAc();
            lblStatus.Text = "Yadda saxlanıldı | Fayl sayı: " + lstFayllar.Items.Count;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex == -1)
            {
                MessageBox.Show("Əvvəlcə fayl seçin.");
                return;
            }

            string ad = lstFayllar.SelectedItem.ToString();
            DialogResult cavab = MessageBox.Show(
                "'" + ad + "' faylını silmək istəyirsiniz?",
                "Faylı sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cavab == DialogResult.Yes)
            {
                string faylYolu = Path.Combine(qovluqYolu, ad);
                File.Delete(faylYolu);
                FayllariGoster();
                lblStatus.Text = "Fayl silindi | Fayl sayı: " + lstFayllar.Items.Count;
            }
        }
    }
}

