namespace dersmers
{
    partial class Form1
    {
        private Label labelFlowerName;
        private Label labelCount;
        private Label labelPrice;
        private Label labelTotal;
        private TextBox textBox1;
        private TextBox textBoxCount;
        private TextBox textBoxPrice;
        private Button buttonSell;
        private Button buttonExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn flowerColumn;
        private DataGridViewTextBoxColumn countColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn resultColumn;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelFlowerName = new Label();
            labelCount = new Label();
            labelPrice = new Label();
            labelTotal = new Label();
            textBox1 = new TextBox();
            textBoxCount = new TextBox();
            textBoxPrice = new TextBox();
            buttonSell = new Button();
            buttonExit = new Button();
            dataGridView1 = new DataGridView();
            flowerColumn = new DataGridViewTextBoxColumn();
            countColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            resultColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            labelFlowerName.AutoSize = true;
            labelFlowerName.Location = new Point(25, 285);
            labelFlowerName.Text = "Gül növü";
            labelCount.AutoSize = true;
            labelCount.Location = new Point(25, 325);
            labelCount.Text = "Say";
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(150, 325);
            labelPrice.Text = "Qiymət";
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTotal.Location = new Point(520, 285);
            labelTotal.Text = "Toplam gəlir: 0.00";

            textBox1.Location = new Point(25, 305);
            textBox1.Size = new Size(240, 23);
            textBoxCount.Location = new Point(25, 345);
            textBoxCount.Size = new Size(100, 23);
            textBoxPrice.Location = new Point(150, 345);
            textBoxPrice.Size = new Size(115, 23);

            buttonSell.Location = new Point(300, 325);
            buttonSell.Size = new Size(100, 43);
            buttonSell.Text = "Satış et";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            buttonExit.Location = new Point(650, 325);
            buttonExit.Size = new Size(100, 43);
            buttonExit.Text = "Çıxış";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flowerColumn, countColumn, priceColumn, resultColumn });
            dataGridView1.Location = new Point(25, 20);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(725, 240);
            flowerColumn.HeaderText = "Gül növü (gül adı)";
            countColumn.HeaderText = "Satış sayı";
            priceColumn.HeaderText = "Qiyməti";
            resultColumn.HeaderText = "Yekun qiyməti";

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(dataGridView1);
            Controls.Add(labelFlowerName);
            Controls.Add(labelCount);
            Controls.Add(labelPrice);
            Controls.Add(labelTotal);
            Controls.Add(textBox1);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonSell);
            Controls.Add(buttonExit);
            Text = "Gül satışı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
