using System.Drawing;
using System.Windows.Forms;

namespace Lesson12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            card1 = new Button();
            card2 = new Button();
            card3 = new Button();
            card4 = new Button();
            card5 = new Button();
            card6 = new Button();
            card7 = new Button();
            card8 = new Button();
            scoreLabel = new Label();
            markLabel = new Label();
            newButton = new Button();
            exitButton = new Button();
            SuspendLayout();

            card1.Location = new Point(35, 35);
            card2.Location = new Point(245, 35);
            card3.Location = new Point(455, 35);
            card4.Location = new Point(665, 35);
            card5.Location = new Point(35, 205);
            card6.Location = new Point(245, 205);
            card7.Location = new Point(455, 205);
            card8.Location = new Point(665, 205);

            card1.Size = new Size(160, 130);
            card2.Size = new Size(160, 130);
            card3.Size = new Size(160, 130);
            card4.Size = new Size(160, 130);
            card5.Size = new Size(160, 130);
            card6.Size = new Size(160, 130);
            card7.Size = new Size(160, 130);
            card8.Size = new Size(160, 130);

            card1.Font = new Font("Arial", 24, FontStyle.Bold);
            card2.Font = new Font("Arial", 24, FontStyle.Bold);
            card3.Font = new Font("Arial", 24, FontStyle.Bold);
            card4.Font = new Font("Arial", 24, FontStyle.Bold);
            card5.Font = new Font("Arial", 24, FontStyle.Bold);
            card6.Font = new Font("Arial", 24, FontStyle.Bold);
            card7.Font = new Font("Arial", 24, FontStyle.Bold);
            card8.Font = new Font("Arial", 24, FontStyle.Bold);

            card1.BackColor = Color.White;
            card2.BackColor = Color.White;
            card3.BackColor = Color.White;
            card4.BackColor = Color.White;
            card5.BackColor = Color.White;
            card6.BackColor = Color.White;
            card7.BackColor = Color.White;
            card8.BackColor = Color.White;

            card1.UseVisualStyleBackColor = false;
            card2.UseVisualStyleBackColor = false;
            card3.UseVisualStyleBackColor = false;
            card4.UseVisualStyleBackColor = false;
            card5.UseVisualStyleBackColor = false;
            card6.UseVisualStyleBackColor = false;
            card7.UseVisualStyleBackColor = false;
            card8.UseVisualStyleBackColor = false;

            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Arial", 22, FontStyle.Bold);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(35, 390);
            scoreLabel.Text = "Xal: 0";

            markLabel.Font = new Font("Arial", 30, FontStyle.Bold);
            markLabel.ForeColor = Color.White;
            markLabel.Location = new Point(270, 380);
            markLabel.Size = new Size(90, 55);
            markLabel.Text = "";

            newButton.Location = new Point(475, 390);
            newButton.Size = new Size(130, 45);
            newButton.Text = "Yeni oyun";
            newButton.UseVisualStyleBackColor = true;

            exitButton.Location = new Point(680, 390);
            exitButton.Size = new Size(130, 45);
            exitButton.Text = "Çıxış";
            exitButton.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(900, 480);

            Controls.Add(card1);
            Controls.Add(card2);
            Controls.Add(card3);
            Controls.Add(card4);
            Controls.Add(card5);
            Controls.Add(card6);
            Controls.Add(card7);
            Controls.Add(card8);
            Controls.Add(scoreLabel);
            Controls.Add(markLabel);
            Controls.Add(newButton);
            Controls.Add(exitButton);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Game";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button card1;
        private Button card2;
        private Button card3;
        private Button card4;
        private Button card5;
        private Button card6;
        private Button card7;
        private Button card8;
        private Label scoreLabel;
        private Label markLabel;
        private Button newButton;
        private Button exitButton;
    }
}
