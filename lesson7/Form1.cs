namespace dersmers
{
    public partial class Form1 : Form
    {
        private decimal totalIncome;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSell_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBoxCount.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Xanalar boş ola bilməz.");
                return;
            }

            if (!int.TryParse(textBoxCount.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Say mənfi və ya sıfır ola bilməz.");
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Qiymət mənfi və ya sıfır ola bilməz.");
                return;
            }

            decimal result = count * price;
            dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));

            totalIncome += result;
            labelTotal.Text = $"Toplam gəlir: {totalIncome:F2}";

            textBox1.Clear();
            textBoxCount.Clear();
            textBoxPrice.Clear();
        }

        private void buttonExit_Click(object? sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Çıxış edilsinmi?",
                "Çıxış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
