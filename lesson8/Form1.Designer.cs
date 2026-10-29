namespace FaylMeneceri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnQovluq;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.ListBox lstFayllar;
        private System.Windows.Forms.TextBox txtMetn;
        private System.Windows.Forms.Label lblFayllar;
        private System.Windows.Forms.Label lblMetn;
        private System.Windows.Forms.Label lblMelumat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

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
            this.components = new System.ComponentModel.Container();
            this.btnQovluq = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.lstFayllar = new System.Windows.Forms.ListBox();
            this.txtMetn = new System.Windows.Forms.TextBox();
            this.lblFayllar = new System.Windows.Forms.Label();
            this.lblMetn = new System.Windows.Forms.Label();
            this.lblMelumat = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQovluq
            // 
            this.btnQovluq.Location = new System.Drawing.Point(16, 20);
            this.btnQovluq.Name = "btnQovluq";
            this.btnQovluq.Size = new System.Drawing.Size(136, 38);
            this.btnQovluq.TabIndex = 0;
            this.btnQovluq.Text = "Qovluq seç";
            this.btnQovluq.UseVisualStyleBackColor = true;
            this.btnQovluq.Click += new System.EventHandler(this.btnQovluq_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(170, 20);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(136, 38);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnSaxla
            // 
            this.btnSaxla.Location = new System.Drawing.Point(324, 20);
            this.btnSaxla.Name = "btnSaxla";
            this.btnSaxla.Size = new System.Drawing.Size(136, 38);
            this.btnSaxla.TabIndex = 2;
            this.btnSaxla.Text = "Yadda saxla";
            this.btnSaxla.UseVisualStyleBackColor = true;
            this.btnSaxla.Click += new System.EventHandler(this.btnSaxla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(478, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 38);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYol
            // 
            this.txtYol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYol.Location = new System.Drawing.Point(632, 27);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(272, 23);
            this.txtYol.TabIndex = 4;
            // 
            // lblFayllar
            // 
            this.lblFayllar.AutoSize = true;
            this.lblFayllar.Location = new System.Drawing.Point(16, 80);
            this.lblFayllar.Name = "lblFayllar";
            this.lblFayllar.Size = new System.Drawing.Size(43, 15);
            this.lblFayllar.TabIndex = 5;
            this.lblFayllar.Text = "Fayllar";
            // 
            // lblMetn
            // 
            this.lblMetn.AutoSize = true;
            this.lblMetn.Location = new System.Drawing.Point(288, 80);
            this.lblMetn.Name = "lblMetn";
            this.lblMetn.Size = new System.Drawing.Size(35, 15);
            this.lblMetn.TabIndex = 6;
            this.lblMetn.Text = "Mətn";
            // 
            // lstFayllar
            // 
            this.lstFayllar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFayllar.FormattingEnabled = true;
            this.lstFayllar.ItemHeight = 15;
            this.lstFayllar.Location = new System.Drawing.Point(16, 104);
            this.lstFayllar.Name = "lstFayllar";
            this.lstFayllar.Size = new System.Drawing.Size(248, 349);
            this.lstFayllar.TabIndex = 7;
            this.lstFayllar.SelectedIndexChanged += new System.EventHandler(this.lstFayllar_SelectedIndexChanged);
            // 
            // txtMetn
            // 
            this.txtMetn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMetn.Location = new System.Drawing.Point(288, 104);
            this.txtMetn.Multiline = true;
            this.txtMetn.Name = "txtMetn";
            this.txtMetn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetn.Size = new System.Drawing.Size(616, 349);
            this.txtMetn.TabIndex = 8;
            this.txtMetn.WordWrap = true;
            // 
            // lblMelumat
            // 
            this.lblMelumat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMelumat.Location = new System.Drawing.Point(16, 480);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblMelumat.Size = new System.Drawing.Size(888, 46);
            this.lblMelumat.TabIndex = 9;
            this.lblMelumat.Text = "Fayl seçilməyib";
            this.lblMelumat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.Text = "Hazırdır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.lblMelumat);
            this.Controls.Add(this.txtMetn);
            this.Controls.Add(this.lstFayllar);
            this.Controls.Add(this.lblMetn);
            this.Controls.Add(this.lblFayllar);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSaxla);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnQovluq);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fayl Meneceri";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

