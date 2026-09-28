namespace ders5
{
    public partial class Form1 : Form
    {
        private bool click;
        private char operand;
        private double a;

        public Form1()
        {
            InitializeComponent();
            displayTextBox.Text = "0";
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            switch (button.Text)
            {
                case "1": button1_Click(sender, e); break;
                case "2": button2_Click(sender, e); break;
                case "3": button3_Click(sender, e); break;
                case "4": button4_Click(sender, e); break;
                case "5": button5_Click(sender, e); break;
                case "6": button6_Click(sender, e); break;
                case "7": button7_Click(sender, e); break;
                case "8": button8_Click(sender, e); break;
                case "9": button9_Click(sender, e); break;
                case "0": button0_Click(sender, e); break;
                case ".": buttonDecimal_Click(sender, e); break;
                case "c": buttonClear_Click(sender, e); break;
                case "<--": buttonBackspace_Click(sender, e); break;
                case "+": buttonPlus_Click(sender, e); break;
                case "-": buttonMinus_Click(sender, e); break;
                case "x": buttonMultiply_Click(sender, e); break;
                case "/": buttonDivide_Click(sender, e); break;
                case "=": buttonEquals_Click(sender, e); break;
                case "Sqrt": buttonSqrt_Click(sender, e); break;
                case "%": buttonPercent_Click(sender, e); break;
            }
        }

        private void button1_Click(object? sender, EventArgs e) => NumberClick("1");
        private void button2_Click(object? sender, EventArgs e) => NumberClick("2");
        private void button3_Click(object? sender, EventArgs e) => NumberClick("3");
        private void button4_Click(object? sender, EventArgs e) => NumberClick("4");
        private void button5_Click(object? sender, EventArgs e) => NumberClick("5");
        private void button6_Click(object? sender, EventArgs e) => NumberClick("6");
        private void button7_Click(object? sender, EventArgs e) => NumberClick("7");
        private void button8_Click(object? sender, EventArgs e) => NumberClick("8");
        private void button9_Click(object? sender, EventArgs e) => NumberClick("9");
        private void button0_Click(object? sender, EventArgs e) => NumberClick("0");

        private void NumberClick(string number)
        {
            if (click)
            {
                displayTextBox.Text = "";
                click = false;
            }

            if (displayTextBox.Text == "0")
                displayTextBox.Text = "";

            displayTextBox.Text += number;
        }

        private void buttonDecimal_Click(object? sender, EventArgs e)
        {
            if (!displayTextBox.Text.Contains("."))
                displayTextBox.Text += ".";
        }

        private void buttonClear_Click(object? sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            click = false;
            operand = '\0';
            a = 0;
        }

        private void buttonBackspace_Click(object? sender, EventArgs e)
        {
            if (displayTextBox.Text.Length > 1)
                displayTextBox.Text = displayTextBox.Text.Substring(0, displayTextBox.Text.Length - 1);
            else
                displayTextBox.Text = "0";
        }

        private void buttonPlus_Click(object? sender, EventArgs e) => SelectOperand('+');
        private void buttonMinus_Click(object? sender, EventArgs e) => SelectOperand('-');
        private void buttonMultiply_Click(object? sender, EventArgs e) => SelectOperand('*');
        private void buttonDivide_Click(object? sender, EventArgs e) => SelectOperand('/');

        private void SelectOperand(char selectedOperand)
        {
            if (displayTextBox.Text == "")
            {
                displayTextBox.Text = "Invalid value";
                return;
            }

            if (!double.TryParse(displayTextBox.Text, out a))
            {
                displayTextBox.Text = "Invalid value";
                return;
            }

            operand = selectedOperand;
            click = true;
        }

        private void buttonEquals_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(displayTextBox.Text, out double secondNumber))
            {
                displayTextBox.Text = "Invalid value";
                return;
            }

            double result;

            switch (operand)
            {
                case '+':
                    result = a + secondNumber;
                    break;
                case '-':
                    result = a - secondNumber;
                    break;
                case '*':
                    result = a * secondNumber;
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        displayTextBox.Text = "Divide by zero error";
                        return;
                    }

                    result = a / secondNumber;
                    break;
                default:
                    return;
            }

            string history = a + " " + operand + " " + secondNumber + " = " + result;
            displayTextBox.Text = result.ToString();
            historyListBox.Items.Insert(0, history);
            click = true;
        }

        private void buttonSqrt_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(displayTextBox.Text, out double number) || number < 0)
            {
                displayTextBox.Text = "Invalid value";
                return;
            }

            displayTextBox.Text = Math.Sqrt(number).ToString();
            click = true;
        }

        private void buttonPercent_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(displayTextBox.Text, out double number))
            {
                displayTextBox.Text = "Invalid value";
                return;
            }

            displayTextBox.Text = (number * 100).ToString();
            click = true;
        }
    }
}