namespace RestoranSistemi
{
    partial class Calisan_SiparisOzeti
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
            label3 = new Label();
            label1 = new Label();
            lblOzet = new Label();
            lblOzetFiyat = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(12, 412);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 6;
            label3.Text = "Sistemden Çıkış Yap";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(306, 55);
            label1.Name = "label1";
            label1.Size = new Size(187, 26);
            label1.TabIndex = 7;
            label1.Text = "GÜNLÜK ÖZET";
            // 
            // lblOzet
            // 
            lblOzet.AutoSize = true;
            lblOzet.Font = new Font("Tahoma", 14F, FontStyle.Bold | FontStyle.Italic);
            lblOzet.Location = new Point(180, 94);
            lblOzet.Name = "lblOzet";
            lblOzet.Size = new Size(0, 23);
            lblOzet.TabIndex = 8;
            // 
            // lblOzetFiyat
            // 
            lblOzetFiyat.AutoSize = true;
            lblOzetFiyat.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblOzetFiyat.Location = new Point(476, 94);
            lblOzetFiyat.Name = "lblOzetFiyat";
            lblOzetFiyat.Size = new Size(0, 23);
            lblOzetFiyat.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(43, 381);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 11;
            label2.Text = "Geri Dön";
            label2.Click += label2_Click;
            // 
            // Calisan_SiparisOzeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(804, 461);
            Controls.Add(label2);
            Controls.Add(lblOzetFiyat);
            Controls.Add(lblOzet);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Calisan_SiparisOzeti";
            Load += Calisan_SiparisOzeti_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label lblOzet;
        private Label lblOzetFiyat;
        private Label label2;
    }
}