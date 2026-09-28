namespace ders4
{
    public partial class Form1 : Form
    {
        int ticketNumber = 1;

        public Form1()
        {
            InitializeComponent();

            string[] cities =
            {
                "choose city",
                "Bakı",
                "Gəncə",
                "Sumqayıt",
                "Şəki",
                "Qəbələ"
            };

            fromComboBox.Items.AddRange(cities);
            toComboBox.Items.AddRange(cities);

            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
        }

        // Proqramdan çıxış
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?",
                "Çıxış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Şəhərlərin yerini dəyişmək
        private void swapButton_Click(object sender, EventArgs e)
        {
            if (fromComboBox.SelectedIndex <= 0 ||
                toComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Əvvəlcə hər iki şəhəri seçin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int temp = fromComboBox.SelectedIndex;

            fromComboBox.SelectedIndex =
                toComboBox.SelectedIndex;

            toComboBox.SelectedIndex = temp;
        }

        // Bilet yaratmaq
        private void ticketButton_Click(object sender, EventArgs e)
        {
            // Gediş şəhəri
            if (fromComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Gediş şəhərini seçin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                fromComboBox.Focus();
                return;
            }

            // Təyinat şəhəri
            if (toComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Təyinat şəhərini seçin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                toComboBox.Focus();
                return;
            }

            // Eyni şəhər seçilə bilməz
            if (fromComboBox.SelectedIndex ==
                toComboBox.SelectedIndex)
            {
                MessageBox.Show(
                    "Gediş və təyinat şəhəri eyni ola bilməz.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Ad və soyad
            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ad və soyad daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nameTextBox.Focus();
                return;
            }

            // FIN
            if (finTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "FIN kodunu daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                finTextBox.Focus();
                return;
            }

            if (finTextBox.Text.Trim().Length != 7)
            {
                MessageBox.Show(
                    "FIN kodu 7 simvoldan ibarət olmalıdır.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                finTextBox.Focus();
                return;
            }

            // Yer
            if (placeTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Yer nömrəsini daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                placeTextBox.Focus();
                return;
            }

            // Telefon
            if (phoneTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Telefon nömrəsini daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                phoneTextBox.Focus();
                return;
            }

            // Email
            if (emailTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Email ünvanını daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                emailTextBox.Focus();
                return;
            }

            if (!emailTextBox.Text.Contains("@") ||
                !emailTextBox.Text.Contains("."))
            {
                MessageBox.Show(
                    "Email ünvanı düzgün deyil.",
                    "Məsələn: user@gmail.com",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                emailTextBox.Focus();
                return;
            }

            // Tarix
            if (dateTextBox.Text.Trim() == "" ||
                dateTextBox.Text == "  /  /")
            {
                MessageBox.Show(
                    "Tarixi daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dateTextBox.Focus();
                return;
            }

            // Saat
            if (timeTextBox.Text.Trim() == "" ||
                timeTextBox.Text == ":")
            {
                MessageBox.Show(
                    "Saatı daxil edin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                timeTextBox.Focus();
                return;
            }

            // Tarixin düzgünlüyünü yoxlamaq
            DateTime date;

            if (!DateTime.TryParse(dateTextBox.Text, out date))
            {
                MessageBox.Show(
                    "Tarix düzgün daxil edilməyib.",
                    "Məsələn: 30/09/2026",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dateTextBox.Focus();
                return;
            }

            // Keçmiş tarix seçilməsin
            if (date.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Keçmiş tarixə bilet almaq olmaz.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dateTextBox.Focus();
                return;
            }

            // Saatın düzgünlüyünü yoxlamaq
            TimeSpan time;

            if (!TimeSpan.TryParse(timeTextBox.Text, out time))
            {
                MessageBox.Show(
                    "Saat düzgün daxil edilməyib.",
                    "Məsələn: 14:30",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                timeTextBox.Focus();
                return;
            }

            // 00:00 - 23:59
            if (time.Hours < 0 || time.Hours > 23)
            {
                MessageBox.Show(
                    "Saat düzgün deyil.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                timeTextBox.Focus();
                return;
            }

            // Bilet ID
            string ticketId =
                "BMU-" + ticketNumber.ToString("000");

            // Bilet
            string ticket =
                "Ticket ID: " + ticketId +
                " | Gediş: " + fromComboBox.Text +
                " | Təyinat: " + toComboBox.Text +
                " | Tarix: " + dateTextBox.Text +
                " | Saat: " + timeTextBox.Text +
                " | Yer: " + placeTextBox.Text +
                " | Ad: " + nameTextBox.Text +
                " | FIN: " + finTextBox.Text.ToUpper() +
                " | Telefon: " + phoneTextBox.Text +
                " | Email: " + emailTextBox.Text;

            ticketsListBox.Items.Add(ticket);

            ticketsListBox.SelectedIndex =
                ticketsListBox.Items.Count - 1;

            MessageBox.Show(
                "Bilet uğurla yaradıldı!\n\n" +
                "Ticket ID: " + ticketId,
                "Uğurlu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ticketNumber++;

            ClearTicketInputs();
        }

        // Bilet silmək
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ticketsListBox.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Silmək üçün bilet seçin.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçilmiş bileti silmək istəyirsiniz?",
                "Bileti sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = ticketsListBox.SelectedIndex;

                ticketsListBox.Items.RemoveAt(index);

                // Siyahıda başqa bilet varsa onu seç
                if (ticketsListBox.Items.Count > 0)
                {
                    if (index >= ticketsListBox.Items.Count)
                    {
                        index =
                            ticketsListBox.Items.Count - 1;
                    }

                    ticketsListBox.SelectedIndex = index;
                }

                MessageBox.Show(
                    "Bilet silindi.",
                    "Məlumat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Bütün xanaları təmizləmək
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

            nameTextBox.Focus();
        }
    }
}