namespace ders5
{
    partial class Form1
    {
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
            displayTextBox = new TextBox();
            historyListBox = new ListBox();
            SuspendLayout();

            displayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            displayTextBox.BackColor = Color.White;
            displayTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            displayTextBox.Location = new Point(30, 25);
            displayTextBox.Multiline = true;
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new Size(1110, 170);
            displayTextBox.TabIndex = 0;
            displayTextBox.Text = "0";
            displayTextBox.TextAlign = HorizontalAlignment.Right;

            historyListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            historyListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            historyListBox.FormattingEnabled = true;
            historyListBox.ItemHeight = 25;
            historyListBox.Location = new Point(890, 205);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(250, 465);
            historyListBox.TabIndex = 1;

            CreateButtons();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 185, 211);
            ClientSize = new Size(1170, 700);
            Controls.Add(displayTextBox);
            Controls.Add(historyListBox);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void CreateButtons()
        {
            string[,] captions =
            {
                { "1", "2", "3", "+", "<--" },
                { "4", "5", "6", "-", "%" },
                { "7", "8", "9", "x", "Sqrt" },
                { "c", "0", ".", "/", "=" }
            };

            int left = 30;
            int top = 205;
            int width = 132;
            int height = 110;
            int gap = 26;

            for (int row = 0; row < captions.GetLength(0); row++)
            {
                for (int column = 0; column < captions.GetLength(1); column++)
                {
                    Button button = new Button
                    {
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Standard,
                        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                        Location = new Point(left + column * (width + gap), top + row * (height + 20)),
                        Name = "button" + captions[row, column].Replace("<", "Back"),
                        Size = new Size(width, height),
                        TabIndex = row * captions.GetLength(1) + column,
                        Text = captions[row, column],
                        UseVisualStyleBackColor = true
                    };

                    switch (row * captions.GetLength(1) + column)
                    {
                        case 0: button1 = button; break;
                        case 1: button2 = button; break;
                        case 2: button3 = button; break;
                        case 3: buttonPlus = button; break;
                        case 4: buttonBackspace = button; break;
                        case 5: button4 = button; break;
                        case 6: button5 = button; break;
                        case 7: button6 = button; break;
                        case 8: buttonMinus = button; break;
                        case 9: buttonPercent = button; break;
                        case 10: button7 = button; break;
                        case 11: button8 = button; break;
                        case 12: button9 = button; break;
                        case 13: buttonMultiply = button; break;
                        case 14: buttonSqrt = button; break;
                        case 15: buttonClear = button; break;
                        case 16: button0 = button; break;
                        case 17: buttonDecimal = button; break;
                        case 18: buttonDivide = button; break;
                        case 19: buttonEquals = button; break;
                    }

                    button.Click += Button_Click;
                    Controls.Add(button);
                }
            }
        }

        private TextBox displayTextBox;
        private ListBox historyListBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonPercent;
        private Button buttonSqrt;
        private Button buttonClear;
        private Button buttonBackspace;
        private Button buttonDecimal;
        private Button buttonEquals;

        #endregion
    }
}
