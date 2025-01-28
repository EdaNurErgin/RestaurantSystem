namespace RestoranSistemi
{
    partial class Yonetici_RaporSistemi
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
            cmbRapor = new ComboBox();
            btnGoster = new Button();
            btnRaporlariGuncelle = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbRapor
            // 
            cmbRapor.FormattingEnabled = true;
            cmbRapor.Items.AddRange(new object[] { "Günlük", "Haftalık", "Aylık" });
            cmbRapor.Location = new Point(74, 33);
            cmbRapor.Name = "cmbRapor";
            cmbRapor.Size = new Size(275, 23);
            cmbRapor.TabIndex = 5;
            // 
            // btnGoster
            // 
            btnGoster.BackColor = Color.CornflowerBlue;
            btnGoster.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnGoster.FlatAppearance.BorderSize = 0;
            btnGoster.FlatStyle = FlatStyle.Popup;
            btnGoster.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGoster.Location = new Point(390, 33);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(75, 23);
            btnGoster.TabIndex = 6;
            btnGoster.Text = "GÖSTER";
            btnGoster.UseVisualStyleBackColor = false;
            btnGoster.Click += btnGoster_Click;
            // 
            // btnRaporlariGuncelle
            // 
            btnRaporlariGuncelle.BackColor = Color.Chartreuse;
            btnRaporlariGuncelle.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnRaporlariGuncelle.FlatAppearance.BorderSize = 0;
            btnRaporlariGuncelle.FlatStyle = FlatStyle.Popup;
            btnRaporlariGuncelle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaporlariGuncelle.ForeColor = Color.Navy;
            btnRaporlariGuncelle.Location = new Point(507, 17);
            btnRaporlariGuncelle.Name = "btnRaporlariGuncelle";
            btnRaporlariGuncelle.Size = new Size(102, 52);
            btnRaporlariGuncelle.TabIndex = 8;
            btnRaporlariGuncelle.Text = "RAPORLARI GÜNCELLE";
            btnRaporlariGuncelle.UseVisualStyleBackColor = false;
            btnRaporlariGuncelle.Click += btnRaporlariGuncelle_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(38, 407);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 13;
            label3.Text = "Sistemden Çıkış Yap";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(74, 390);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 14;
            label1.Text = "Geri Dön";
            label1.Click += label1_Click;
            // 
            // Yonetici_RaporSistemi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir__5_;
            ClientSize = new Size(804, 461);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnRaporlariGuncelle);
            Controls.Add(btnGoster);
            Controls.Add(cmbRapor);
            Name = "Yonetici_RaporSistemi";
            Text = "Yonetici_RaporSistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRapor;
        private Button btnGoster;
        private Button btnRaporlariGuncelle;
        private Label label3;
        private Label label1;
    }
}