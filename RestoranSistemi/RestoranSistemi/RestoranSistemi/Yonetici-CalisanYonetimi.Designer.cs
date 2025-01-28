namespace RestoranSistemi
{
    partial class Yonetici_CalisanYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_CalisanYonetimi));
            calisanDuzenle = new Button();
            panel1 = new Panel();
            calisanListele = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // calisanDuzenle
            // 
            calisanDuzenle.BackColor = Color.Wheat;
            calisanDuzenle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            calisanDuzenle.ForeColor = Color.Black;
            calisanDuzenle.Location = new Point(45, 72);
            calisanDuzenle.Name = "calisanDuzenle";
            calisanDuzenle.Size = new Size(126, 58);
            calisanDuzenle.TabIndex = 0;
            calisanDuzenle.Text = "ÇALIŞAN DÜZENLE";
            calisanDuzenle.UseVisualStyleBackColor = false;
            calisanDuzenle.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(213, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 418);
            panel1.TabIndex = 2;
            // 
            // calisanListele
            // 
            calisanListele.BackColor = Color.Wheat;
            calisanListele.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            calisanListele.ForeColor = Color.Black;
            calisanListele.Location = new Point(45, 166);
            calisanListele.Name = "calisanListele";
            calisanListele.Size = new Size(126, 58);
            calisanListele.TabIndex = 3;
            calisanListele.Text = "ÇALIŞAN  LİSTELE";
            calisanListele.UseVisualStyleBackColor = false;
            calisanListele.Click += calisanListele_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(38, 414);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 6;
            label3.Text = "Sistemden Çıkış Yap";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(72, 388);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 7;
            label1.Text = "Geri Dön";
            label1.Click += label1_Click;
            // 
            // Yonetici_CalisanYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 461);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(calisanListele);
            Controls.Add(panel1);
            Controls.Add(calisanDuzenle);
            Name = "Yonetici_CalisanYonetimi";
            Text = "Yonetici_CalisanYonetimi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calisanDuzenle;
        private Panel panel1;
        private Button calisanListele;
        private Label label3;
        private Label label1;
    }
}