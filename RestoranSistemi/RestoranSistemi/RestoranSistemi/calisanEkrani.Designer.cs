namespace RestoranSistemi
{
    partial class calisanEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAktif = new Button();
            btnOzet = new Button();
            label1 = new Label();
            lblHosgeldiniz = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAktif
            // 
            btnAktif.BackColor = Color.DarkBlue;
            btnAktif.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAktif.ForeColor = SystemColors.Control;
            btnAktif.Location = new Point(137, 176);
            btnAktif.Name = "btnAktif";
            btnAktif.Size = new Size(209, 121);
            btnAktif.TabIndex = 0;
            btnAktif.Text = "AKTİF SİPARİŞLER ";
            btnAktif.UseVisualStyleBackColor = false;
            btnAktif.Click += btnAktif_Click;
            // 
            // btnOzet
            // 
            btnOzet.BackColor = Color.DarkBlue;
            btnOzet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOzet.ForeColor = SystemColors.Control;
            btnOzet.Location = new Point(441, 176);
            btnOzet.Name = "btnOzet";
            btnOzet.Size = new Size(209, 121);
            btnOzet.TabIndex = 1;
            btnOzet.Text = "GÜNLÜK SİPARİŞ ÖZETİ";
            btnOzet.UseVisualStyleBackColor = false;
            btnOzet.Click += btnOzet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(291, 66);
            label1.Name = "label1";
            label1.Size = new Size(221, 26);
            label1.TabIndex = 2;
            label1.Text = "ÇALIŞAN SAYFASI";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHosgeldiniz.Location = new Point(317, 107);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(0, 19);
            lblHosgeldiniz.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(364, 136);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 6;
            label3.Text = "Çıkış Yap";
            label3.Click += label3_Click;
            // 
            // calisanEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(804, 461);
            Controls.Add(label3);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(label1);
            Controls.Add(btnOzet);
            Controls.Add(btnAktif);
            Name = "calisanEkrani";
            Text = "calisanEkrani";
            Load += calisanEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAktif;
        private Button btnOzet;
        private Label label1;
        private Label lblHosgeldiniz;
        private Label label3;
    }
}