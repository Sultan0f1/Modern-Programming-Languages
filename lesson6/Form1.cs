namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int num;
        private int attemptCount;
        private bool gameActive;

        public Form1()
        {
            InitializeComponent();
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 100);
            attemptCount = 0;
            gameActive = true;

            errorProvider1.Clear();
            textBox1.Clear();
            resultTextBox.Clear();
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!gameActive)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ədəd daxil edin.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int guessedNumber) || guessedNumber < 0 || guessedNumber > 100)
            {
                errorProvider1.SetError(textBox1, "0-100 arasında tam ədəd daxil edin.");
                return;
            }

            attemptCount++;

            if (guessedNumber == num)
            {
                resultTextBox.Text = $"Oyunu qazandınız{Environment.NewLine}Cəhd sayı: {attemptCount}";
                gameActive = false;
                button1.Enabled = false;
                textBox1.Enabled = false;
                return;
            }

            string comparison = guessedNumber < num
                ? "Təsadüfi ədəddən kiçikdir"
                : "Təsadüfi ədəddən böyükdür";

            resultTextBox.Text = $"Daxil edilən ədəd yanlışdır{Environment.NewLine}Cəhd sayı: {attemptCount}{Environment.NewLine}{comparison}";
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
