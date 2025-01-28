namespace RestoranSistemi
{
    partial class Calisan_AktifSiparisler
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(151, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 399);
            dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(12, 418);
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
            label1.ForeColor = Color.Green;
            label1.Location = new Point(40, 392);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 7;
            label1.Text = "Geri Dön";
            label1.Click += label1_Click;
            // 
            // Calisan_AktifSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(804, 461);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "Calisan_AktifSiparisler";
            Text = "Calisan_AktifSiparisler";
            Load += Calisan_AktifSiparisler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label3;
        private Label label1;
    }
}