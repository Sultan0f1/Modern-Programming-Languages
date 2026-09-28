namespace ders5
{
    public partial class Form1 : Form
    {
        private decimal birinciEded;
        private string emeliyyat = "";
        private bool yeniEdedBaslayib;

        public Form1()
        {
            InitializeComponent();
            yeniEdedBaslayib = true;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is not Button duymə)
                return;

            switch (duymə.Text)
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
                case "+": buttonPlus_Click(sender, e); break;
                case "-": buttonMinus_Click(sender, e); break;
                case "x": buttonMultiply_Click(sender, e); break;
                case "/": buttonDivide_Click(sender, e); break;
                case "%": buttonPercent_Click(sender, e); break;
                case "Sqrt": buttonSqrt_Click(sender, e); break;
                case "c": buttonClear_Click(sender, e); break;
                case "<--": buttonBackspace_Click(sender, e); break;
                case "=": buttonEquals_Click(sender, e); break;
            }
        }

        private void button1_Click(object? sender, EventArgs e) => EdedYaz("1");
        private void button2_Click(object? sender, EventArgs e) => EdedYaz("2");
        private void button3_Click(object? sender, EventArgs e) => EdedYaz("3");
        private void button4_Click(object? sender, EventArgs e) => EdedYaz("4");
        private void button5_Click(object? sender, EventArgs e) => EdedYaz("5");
        private void button6_Click(object? sender, EventArgs e) => EdedYaz("6");
        private void button7_Click(object? sender, EventArgs e) => EdedYaz("7");
        private void button8_Click(object? sender, EventArgs e) => EdedYaz("8");
        private void button9_Click(object? sender, EventArgs e) => EdedYaz("9");
        private void button0_Click(object? sender, EventArgs e) => EdedYaz("0");

        private void EdedYaz(string eded)
        {
            if (yeniEdedBaslayib || displayTextBox.Text == "0")
                displayTextBox.Text = eded;
            else
                displayTextBox.Text += eded;

            yeniEdedBaslayib = false;
        }

        private void buttonDecimal_Click(object? sender, EventArgs e)
        {
            if (yeniEdedBaslayib)
            {
                displayTextBox.Text = "0.";
                yeniEdedBaslayib = false;
            }
            else if (!displayTextBox.Text.Contains('.'))
            {
                displayTextBox.Text += ".";
            }
        }

        private void buttonPlus_Click(object? sender, EventArgs e) => EmeliyyatSec("+");
        private void buttonMinus_Click(object? sender, EventArgs e) => EmeliyyatSec("-");
        private void buttonMultiply_Click(object? sender, EventArgs e) => EmeliyyatSec("x");
        private void buttonDivide_Click(object? sender, EventArgs e) => EmeliyyatSec("/");

        private void EmeliyyatSec(string secilenEmeliyyat)
        {
            if (!decimal.TryParse(displayTextBox.Text, out decimal cariEded))
                return;

            if (emeliyyat != "" && !yeniEdedBaslayib)
                NeticeHesabla(false);
            else
                birinciEded = cariEded;

            emeliyyat = secilenEmeliyyat;
            yeniEdedBaslayib = true;
        }

        private void buttonEquals_Click(object? sender, EventArgs e)
        {
            NeticeHesabla(true);
        }

        private void NeticeHesabla(bool tarixceyeYaz)
        {
            if (emeliyyat == "" || !decimal.TryParse(displayTextBox.Text, out decimal ikinciEded))
                return;

            decimal netice;

            if (emeliyyat == "+")
                netice = birinciEded + ikinciEded;
            else if (emeliyyat == "-")
                netice = birinciEded - ikinciEded;
            else if (emeliyyat == "x")
                netice = birinciEded * ikinciEded;
            else
            {
                if (ikinciEded == 0)
                {
                    displayTextBox.Text = "Cannot divide by zero";
                    emeliyyat = "";
                    yeniEdedBaslayib = true;
                    return;
                }

                netice = birinciEded / ikinciEded;
            }

            string tarixce = birinciEded + " " + emeliyyat + " " + ikinciEded + " = " + netice;
            displayTextBox.Text = netice.ToString("G29");
            birinciEded = netice;
            emeliyyat = "";
            yeniEdedBaslayib = true;

            if (tarixceyeYaz)
                historyListBox.Items.Insert(0, tarixce);
        }

        private void buttonPercent_Click(object? sender, EventArgs e)
        {
            if (decimal.TryParse(displayTextBox.Text, out decimal eded))
            {
                displayTextBox.Text = (eded / 100).ToString("G29");
                yeniEdedBaslayib = true;
            }
        }

        private void buttonSqrt_Click(object? sender, EventArgs e)
        {
            if (decimal.TryParse(displayTextBox.Text, out decimal eded) && eded >= 0)
            {
                displayTextBox.Text = Math.Sqrt((double)eded).ToString("G15");
                yeniEdedBaslayib = true;
            }
        }

        private void buttonClear_Click(object? sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            birinciEded = 0;
            emeliyyat = "";
            yeniEdedBaslayib = true;
        }

        private void buttonBackspace_Click(object? sender, EventArgs e)
        {
            if (yeniEdedBaslayib || displayTextBox.Text.Length <= 1)
            {
                displayTextBox.Text = "0";
                yeniEdedBaslayib = true;
            }
            else
            {
                displayTextBox.Text = displayTextBox.Text[..^1];
            }
        }
    }
}