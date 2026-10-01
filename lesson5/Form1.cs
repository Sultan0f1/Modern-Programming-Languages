using System.Globalization;

namespace ders6
{
    public partial class Form1 : Form
    {
        private readonly List<MenuItem> cart = new();

        public Form1()
        {
            InitializeComponent();
            CreateMenu();
        }

        private void CreateMenu()
        {
            var menuItems = new[]
            {
                new MenuItem("Tort", 5.00m),
                new MenuItem("Kola", 2.00m),
                new MenuItem("Limonad", 3.00m),
                new MenuItem("Burger", 7.00m),
                new MenuItem("Sendviç", 6.00m),
                new MenuItem("Pizza", 8.00m),
                new MenuItem("Muffin", 4.00m),
                new MenuItem("Hot-doq", 5.00m),
                new MenuItem("Peçenye", 3.00m)
            };

            for (var index = 0; index < menuItems.Length; index++)
            {
                var item = menuItems[index];
                var button = new Button
                {
                    Text = $"{item.Name}\r\n{item.Price:0.00} AZN",
                    Tag = item,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.White,
                    Location = new Point(15 + (index % 3) * 125, 75 + (index / 3) * 105),
                    Size = new Size(115, 85),
                    UseVisualStyleBackColor = false
                };
                button.Click += menuItem_Click;
                menuPanel.Controls.Add(button);
            }
        }

        private void menuItem_Click(object? sender, EventArgs e)
        {
            if (sender is not Button { Tag: MenuItem item })
            {
                return;
            }

            cart.Add(item);
            cartListBox.Items.Add($"{item.Name} - {item.Price:0.00} AZN");
        }

        private void removeButton_Click(object? sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex < 0)
            {
                return;
            }

            var selectedIndex = cartListBox.SelectedIndex;
            var item = cart[selectedIndex];
            cart.RemoveAt(selectedIndex);
            cartListBox.Items.RemoveAt(selectedIndex);
            MessageBox.Show($"{item.Name} səbətdən silindi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetButton_Click(object? sender, EventArgs e)
        {
            var answer = MessageBox.Show(
                "Xanalar sıfırlansınmı?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            cart.Clear();
            cartListBox.Items.Clear();
            amountTextBox.Clear();
            changeTextBox.Clear();
            accountTextBox.Clear();
        }

        private void totalButton_Click(object? sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            accountTextBox.Text = Total.ToString("0.00", CultureInfo.CurrentCulture);
        }

        private void calculateButton_Click(object? sender, EventArgs e)
        {
            if (!TryReadAmount(out var amount))
            {
                MessageBox.Show("Daxil edilən məbləğ düzgün deyil", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryReadAmount(accountTextBox.Text, out var account))
            {
                MessageBox.Show("Əvvəlcə yekun hesabı hesablayın", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (amount < account)
            {
                changeTextBox.Clear();
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            changeTextBox.Text = (amount - account).ToString("0.00", CultureInfo.CurrentCulture);
        }

        private void clearButton_Click(object? sender, EventArgs e)
        {
            amountTextBox.Clear();
            changeTextBox.Clear();
        }

        private bool TryReadAmount(out decimal amount)
        {
            return TryReadAmount(amountTextBox.Text, out amount);
        }

        private static bool TryReadAmount(string text, out decimal amount)
        {
            return decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out amount)
                || decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
        }

        private decimal Total => cart.Sum(item => item.Price);

        private sealed record MenuItem(string Name, decimal Price);
    }
}
