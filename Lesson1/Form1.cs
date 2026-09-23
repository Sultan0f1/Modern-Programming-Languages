using System;
using System.Windows.Forms;

namespace lesson1
{
    public partial class Form1 : Form
    {
        string registeredName = "";
        string registeredEmail = "";
        string registeredPassword = "";

        public Form1()
        {
            InitializeComponent();

            // Placeholder-lər
            textBox1.PlaceholderText = "Ad və soyad";
            textBox2.PlaceholderText = "Email";
            textBox3.PlaceholderText = "Şifrə";
            textBox4.PlaceholderText = "Şifrəni təkrar edin";

            textBox5.PlaceholderText = "Email";
            textBox6.PlaceholderText = "Şifrə";

        }


        private bool IsValidEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            int lastAtIndex = email.LastIndexOf('@');
            int dotIndex = email.IndexOf('.', atIndex + 1);

            return atIndex > 0 &&
                   atIndex == lastAtIndex &&
                   dotIndex > atIndex + 1 &&
                   dotIndex < email.Length - 1 &&
                   !email.Contains(" ") &&
                   !email.Contains("..") &&
                   !email.EndsWith('.');
        }


        // QEYDİYYAT
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim().ToLowerInvariant();
            string password = textBox3.Text;
            string repeatedPassword = textBox4.Text;

            if (name == "" ||
                email == "" ||
                password == "" ||
                repeatedPassword == "")
            {
                MessageBox.Show(
                    "Bütün xanaları doldurun!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (!IsValidEmail(email))
            {
                MessageBox.Show(
                    "Düzgün email daxil edin!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (registeredEmail != "" &&
                     (email == registeredEmail ||
                      string.Equals(name, registeredName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(
                    "Bu ad və ya email ilə artıq qeydiyyatdan keçilib!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (password.Length < 6)
            {
                MessageBox.Show(
                    "Şifrə ən azı 6 simvol olmalıdır!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (password != repeatedPassword)
            {
                MessageBox.Show(
                    "Şifrələr uyğun deyil!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else
            {
                registeredName = name;
                registeredEmail = email;
                registeredPassword = password;

                MessageBox.Show(
                    "Qeydiyyat uğurla tamamlandı!",
                    "Bildiriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox5.Text = registeredEmail;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }


        // LOGIN
        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox5.Text.Trim().ToLowerInvariant();

            if (email == "" ||
                textBox6.Text == "")
            {
                MessageBox.Show("Email və şifrəni daxil edin!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (email == registeredEmail &&
                     textBox6.Text == registeredPassword)
            {
                MessageBox.Show("Xoş gəldiniz, " + registeredName + "!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Email və ya şifrə yanlışdır!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        // QEYDİYYAT ŞİFRƏSİNİ GÖSTƏR
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }


        // LOGIN ŞİFRƏSİNİ GÖSTƏR
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}