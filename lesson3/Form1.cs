namespace ders4
{
    public partial class Form1 : Form
    {
        int ticketNumber = 1;

        public Form1()
        {
            InitializeComponent();
            string[] cities = { "choose city", "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Qəbələ" };
            fromComboBox.Items.AddRange(cities);
            toComboBox.Items.AddRange(cities);
            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            if (fromComboBox.SelectedIndex > 0 && toComboBox.SelectedIndex > 0)
            {
                int from = fromComboBox.SelectedIndex;
                fromComboBox.SelectedIndex = toComboBox.SelectedIndex;
                toComboBox.SelectedIndex = from;
            }
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            if (fromComboBox.SelectedIndex <= 0 || toComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Gediş və təyinat şəhərini seçin.", "Məlumat");
                return;
            }

            if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
            {
                MessageBox.Show("Eyni şəhərə gediş seçmək olmaz.", "Məlumat");
                return;
            }

            if (nameTextBox.Text == "" || finTextBox.Text == "")
            {
                MessageBox.Show("Ad, soyad və FIN məlumatlarını daxil edin.", "Məlumat");
                return;
            }

            if (dateTextBox.Text == "  /  /" || timeTextBox.Text == ":")
            {
                MessageBox.Show("Tarix və saatı daxil edin.", "Məlumat");
                return;
            }

            string ticketId = "BMU-" + ticketNumber;
            string ticket = "Ticket ID: " + ticketId +
                " | Gediş: " + fromComboBox.Text +
                " | Təyinat: " + toComboBox.Text +
                " | Tarix: " + dateTextBox.Text +
                " | Saat: " + timeTextBox.Text +
                " | Ad: " + nameTextBox.Text +
                " | FIN: " + finTextBox.Text;

            ticketsListBox.Items.Add(ticket);
            ticketsListBox.SelectedIndex = ticketsListBox.Items.Count - 1;
            ticketNumber = ticketNumber + 1;
            ClearTicketInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ticketsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Silmək üçün bilet seçin.", "Məlumat");
                return;
            }

            int index = ticketsListBox.SelectedIndex;
            ticketsListBox.Items.RemoveAt(index);
            if (ticketsListBox.Items.Count > 0)
            {
                if (index >= ticketsListBox.Items.Count)
                    index = ticketsListBox.Items.Count - 1;

                ticketsListBox.SelectedIndex = index;
            }
        }

        private void ClearTicketInputs()
        {
            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
            dateTextBox.Clear();
            timeTextBox.Clear();
            placeTextBox.Clear();
            nameTextBox.Clear();
            finTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
        }
    }
}
