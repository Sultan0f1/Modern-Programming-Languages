using System;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class TaskBoardForm : Form
    {
        public TaskBoardForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text))
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("dd.MM.yyyy"));
            }
            else
            {
                MessageBox.Show("Xanalar boşdur", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn))
                return;

            var result = MessageBox.Show("Bu tapşırıq silinsin?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dataGridView1.CancelEdit();

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
