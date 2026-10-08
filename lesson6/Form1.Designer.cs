namespace WinFormsApp2
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
            searchGroupBox = new GroupBox();
            inputLabel = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            resultTextBox = new TextBox();
            yenioyunbtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();

            searchGroupBox.Controls.Add(inputLabel);
            searchGroupBox.Controls.Add(textBox1);
            searchGroupBox.Controls.Add(button1);
            searchGroupBox.Location = new Point(20, 25);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(455, 325);
            searchGroupBox.TabIndex = 0;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Ədəd axtarışı";

            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(125, 58);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(145, 20);
            inputLabel.TabIndex = 0;
            inputLabel.Text = "Axtarılan ədəd";

            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(57, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 34);
            textBox1.TabIndex = 1;

            button1.Enabled = false;
            button1.Location = new Point(57, 195);
            button1.Name = "button1";
            button1.Size = new Size(325, 54);
            button1.TabIndex = 2;
            button1.Text = "Yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            resultTextBox.BackColor = Color.White;
            resultTextBox.Location = new Point(510, 25);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(330, 250);
            resultTextBox.TabIndex = 3;

            yenioyunbtn.Location = new Point(510, 295);
            yenioyunbtn.Name = "yenioyunbtn";
            yenioyunbtn.Size = new Size(330, 55);
            yenioyunbtn.TabIndex = 4;
            yenioyunbtn.Text = "Yeni oyun";
            yenioyunbtn.UseVisualStyleBackColor = true;
            yenioyunbtn.Click += yenioyunbtn_Click;

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 390);
            Controls.Add(yenioyunbtn);
            Controls.Add(resultTextBox);
            Controls.Add(searchGroupBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random number";
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox searchGroupBox;
        private Label inputLabel;
        private TextBox textBox1;
        private Button button1;
        private TextBox resultTextBox;
        private Button yenioyunbtn;
        private ErrorProvider errorProvider1;

        #endregion
    }
}
