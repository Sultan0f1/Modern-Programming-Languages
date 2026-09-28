namespace ders5
{
    public partial class Form1 : Form
    {
        private decimal firstNumber;
        private string pendingOperator = string.Empty;
        private bool startNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            string value = button.Text;

            if (decimal.TryParse(value, out _))
            {
                AddDigit(value);
                return;
            }

            switch (value)
            {
                case ".":
                    AddDecimalPoint();
                    break;
                case "c":
                    ClearCalculator();
                    break;
                case "<--":
                    DeleteLastDigit();
                    break;
                case "Sqrt":
                    CalculateSquareRoot();
                    break;
                case "%":
                    CalculatePercent();
                    break;
                case "+":
                case "-":
                case "x":
                case "/":
                    SelectOperator(value);
                    break;
                case "=":
                    CalculateResult();
                    break;
            }
        }

        private void AddDigit(string digit)
        {
            if (startNewNumber || displayTextBox.Text == "0")
                displayTextBox.Text = digit;
            else
                displayTextBox.Text += digit;

            startNewNumber = false;
        }

        private void AddDecimalPoint()
        {
            if (startNewNumber)
            {
                displayTextBox.Text = "0.";
                startNewNumber = false;
            }
            else if (!displayTextBox.Text.Contains('.'))
            {
                displayTextBox.Text += ".";
            }
        }

        private void SelectOperator(string operation)
        {
            if (!decimal.TryParse(displayTextBox.Text, out decimal currentNumber))
                return;

            if (!string.IsNullOrEmpty(pendingOperator) && !startNewNumber)
                CalculateResult(false);
            else
                firstNumber = currentNumber;

            pendingOperator = operation;
            startNewNumber = true;
        }

        private void CalculateResult(bool addToHistory = true)
        {
            if (string.IsNullOrEmpty(pendingOperator) ||
                !decimal.TryParse(displayTextBox.Text, out decimal secondNumber))
                return;

            decimal result;
            try
            {
                result = pendingOperator switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    "x" => firstNumber * secondNumber,
                    "/" => secondNumber == 0 ? throw new DivideByZeroException() : firstNumber / secondNumber,
                    _ => secondNumber
                };
            }
            catch (DivideByZeroException)
            {
                displayTextBox.Text = "Cannot divide by zero";
                pendingOperator = string.Empty;
                startNewNumber = true;
                return;
            }

            string expression = $"{FormatNumber(firstNumber)} {pendingOperator} {FormatNumber(secondNumber)} = {FormatNumber(result)}";
            displayTextBox.Text = FormatNumber(result);
            firstNumber = result;
            pendingOperator = string.Empty;
            startNewNumber = true;

            if (addToHistory)
                historyListBox.Items.Insert(0, expression);
        }

        private void CalculateSquareRoot()
        {
            if (!decimal.TryParse(displayTextBox.Text, out decimal number) || number < 0)
                return;

            double result = Math.Sqrt((double)number);
            displayTextBox.Text = result.ToString("G15");
            startNewNumber = true;
        }

        private void CalculatePercent()
        {
            if (decimal.TryParse(displayTextBox.Text, out decimal number))
            {
                displayTextBox.Text = FormatNumber(number / 100);
                startNewNumber = true;
            }
        }

        private void DeleteLastDigit()
        {
            if (startNewNumber || displayTextBox.Text.Length <= 1)
            {
                displayTextBox.Text = "0";
                startNewNumber = true;
                return;
            }

            displayTextBox.Text = displayTextBox.Text[..^1];
            if (displayTextBox.Text == "-")
                displayTextBox.Text = "0";
        }

        private void ClearCalculator()
        {
            displayTextBox.Text = "0";
            firstNumber = 0;
            pendingOperator = string.Empty;
            startNewNumber = true;
        }

        private static string FormatNumber(decimal number) => number.ToString("G29");
    }
}
