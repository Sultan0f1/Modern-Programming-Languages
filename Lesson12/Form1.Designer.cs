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

            Button[] cardList = {
                card1, card2, card3, card4,
                card5, card6, card7, card8
            };

            foreach (Button card in cardList)
            {
                card.Size = new Size(160, 130);
                card.Font = new Font("Arial", 24, FontStyle.Bold);
                card.BackColor = Color.White;
                card.UseVisualStyleBackColor = false;
            }

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
