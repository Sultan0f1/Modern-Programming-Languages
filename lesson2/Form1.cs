namespace ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.SelectedIndex = 0;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal numberOne) ||
                !decimal.TryParse(textBox2.Text, out decimal numberTwo))
            {
                MessageBox.Show("Please enter valid numbers.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal answer;

            switch (comboBox1.SelectedItem?.ToString())
            {
                case "+":
                    answer = numberOne + numberTwo;
                    break;
                case "-":
                    answer = numberOne - numberTwo;
                    break;
                case "*":
                    answer = numberOne * numberTwo;
                    break;
                case "/":
                    if (numberTwo == 0)
                    {
                        MessageBox.Show("You cannot divide by zero.", "Calculation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    answer = numberOne / numberTwo;
                    break;
                default:
                    MessageBox.Show("Please select an operation.", "Calculation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            label5.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            label5.Text = "0";
            textBox1.Focus();
        }
    }
}
