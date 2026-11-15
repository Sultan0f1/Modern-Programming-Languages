namespace Nici
{
    public partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // button1
            button1.Location = new Point(32, 486);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 0;
            button1.Text = "Panel yarat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickWithRecovery;

            // button2
            button2.Location = new Point(198, 486);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 1;
            button2.Text = "Bombanı köçür";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // button3
            button3.Location = new Point(404, 486);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 2;
            button3.Text = "Çıxış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(760, 18);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 3;
            label1.Text = "Xal:";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(804, 18);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 4;
            label2.Text = "0";

            // pictureBox1
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(350, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(900, 550);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bomba oyunu";
            Load += Form1_Load;
            Load += ConfigureGameAssets;
            ControlAdded += TrackSpawnedPanel;

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
