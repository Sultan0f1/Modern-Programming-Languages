namespace ders6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel paymentPanel;
        private Panel menuPanel;
        private Panel cartPanel;
        private Label titleLabel;
        private Label menuLabel;
        private Label cartLabel;
        private Label amountLabel;
        private Label changeLabel;
        private Label accountLabel;
        private TextBox amountTextBox;
        private TextBox changeTextBox;
        private TextBox accountTextBox;
        private ListBox cartListBox;
        private Button removeButton;
        private Button resetButton;
        private Button totalButton;
        private Button calculateButton;
        private Button clearButton;

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
            paymentPanel = new Panel();
            menuPanel = new Panel();
            cartPanel = new Panel();
            titleLabel = new Label();
            menuLabel = new Label();
            cartLabel = new Label();
            amountLabel = new Label();
            changeLabel = new Label();
            accountLabel = new Label();
            amountTextBox = new TextBox();
            changeTextBox = new TextBox();
            accountTextBox = new TextBox();
            cartListBox = new ListBox();
            removeButton = new Button();
            resetButton = new Button();
            totalButton = new Button();
            calculateButton = new Button();
            clearButton = new Button();
            SuspendLayout();

            paymentPanel.BackColor = Color.Gainsboro;
            paymentPanel.Dock = DockStyle.Left;
            paymentPanel.Padding = new Padding(20);
            paymentPanel.Width = 185;
            paymentPanel.Controls.AddRange(new Control[] { amountLabel, amountTextBox, changeLabel, changeTextBox, calculateButton, clearButton });

            menuPanel.BackColor = Color.WhiteSmoke;
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Padding = new Padding(28, 55, 28, 20);
            menuPanel.Controls.Add(menuLabel);
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            menuLabel.Location = new Point(205, 18);
            menuLabel.Text = "MENYU";

            cartPanel.BackColor = Color.Gainsboro;
            cartPanel.Dock = DockStyle.Right;
            cartPanel.Padding = new Padding(20);
            cartPanel.Width = 205;
            cartPanel.Controls.AddRange(new Control[] { cartLabel, cartListBox, removeButton, resetButton, totalButton, accountLabel, accountTextBox });

            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            titleLabel.Location = new Point(49, 25);
            titleLabel.Text = "Cafe";
            paymentPanel.Controls.Add(titleLabel);

            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(20, 92);
            amountLabel.Text = "Məbləğ:";
            amountTextBox.Location = new Point(20, 115);
            amountTextBox.Size = new Size(145, 27);

            changeLabel.AutoSize = true;
            changeLabel.Location = new Point(20, 158);
            changeLabel.Text = "Qalıq:";
            changeTextBox.Location = new Point(20, 181);
            changeTextBox.ReadOnly = true;
            changeTextBox.Size = new Size(145, 27);

            calculateButton.BackColor = Color.Green;
            calculateButton.ForeColor = Color.White;
            calculateButton.Location = new Point(20, 225);
            calculateButton.Size = new Size(145, 38);
            calculateButton.Text = "Hesabla";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;

            clearButton.BackColor = Color.Firebrick;
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(20, 275);
            clearButton.Size = new Size(145, 38);
            clearButton.Text = "Təmizlə";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;

            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            cartLabel.Location = new Point(64, 15);
            cartLabel.Text = "Səbət";
            cartListBox.Location = new Point(20, 55);
            cartListBox.Size = new Size(165, 190);

            removeButton.Location = new Point(20, 255);
            removeButton.Size = new Size(165, 35);
            removeButton.Text = "Səbətdən sil";
            removeButton.Click += removeButton_Click;
            resetButton.Location = new Point(20, 298);
            resetButton.Size = new Size(165, 35);
            resetButton.Text = "Yenilə";
            resetButton.Click += resetButton_Click;
            totalButton.Location = new Point(20, 341);
            totalButton.Size = new Size(165, 35);
            totalButton.Text = "Yekun hesab";
            totalButton.Click += totalButton_Click;

            accountLabel.AutoSize = true;
            accountLabel.Location = new Point(20, 395);
            accountLabel.Text = "Hesab:";
            accountTextBox.Location = new Point(75, 391);
            accountTextBox.ReadOnly = true;
            accountTextBox.Size = new Size(110, 27);

            Controls.Add(menuPanel);
            Controls.Add(cartPanel);
            Controls.Add(paymentPanel);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe system";
            ResumeLayout(false);
        }

        #endregion
    }
}
