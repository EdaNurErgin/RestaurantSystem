namespace RestoranSistemi
{
    partial class yonetici_calisanYonetimiUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            calısanEkle = new GroupBox();
            calisanEkle = new Button();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPosta = new TextBox();
            label4 = new Label();
            txtIsim = new TextBox();
            label3 = new Label();
            txtTC = new TextBox();
            label2 = new Label();
            calisanCikar = new GroupBox();
            button1 = new Button();
            label10 = new Label();
            txtTCcikar = new TextBox();
            calısanEkle.SuspendLayout();
            calisanCikar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(155, 53);
            label1.Name = "label1";
            label1.Size = new Size(238, 26);
            label1.TabIndex = 0;
            label1.Text = "ÇALIŞAN DÜZENLE";
            // 
            // calısanEkle
            // 
            calısanEkle.Controls.Add(calisanEkle);
            calısanEkle.Controls.Add(txtAdres);
            calısanEkle.Controls.Add(txtTelefon);
            calısanEkle.Controls.Add(label6);
            calısanEkle.Controls.Add(label5);
            calısanEkle.Controls.Add(txtPosta);
            calısanEkle.Controls.Add(label4);
            calısanEkle.Controls.Add(txtIsim);
            calısanEkle.Controls.Add(label3);
            calısanEkle.Controls.Add(txtTC);
            calısanEkle.Controls.Add(label2);
            calısanEkle.Location = new Point(35, 125);
            calısanEkle.Name = "calısanEkle";
            calısanEkle.Size = new Size(219, 254);
            calısanEkle.TabIndex = 1;
            calısanEkle.TabStop = false;
            calısanEkle.Text = "EKLE";
            // 
            // calisanEkle
            // 
            calisanEkle.BackColor = Color.LightGreen;
            calisanEkle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            calisanEkle.Location = new Point(104, 205);
            calisanEkle.Name = "calisanEkle";
            calisanEkle.Size = new Size(84, 31);
            calisanEkle.TabIndex = 2;
            calisanEkle.Text = "EKLE";
            calisanEkle.UseVisualStyleBackColor = false;
            calisanEkle.Click += calisanEkle_Click;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.White;
            txtAdres.BorderStyle = BorderStyle.FixedSingle;
            txtAdres.Location = new Point(88, 158);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 10;
            txtAdres.TextChanged += textBox5_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Location = new Point(88, 126);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 165);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 8;
            label6.Text = "ADRES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 133);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 7;
            label5.Text = "TELEFON";
            // 
            // txtPosta
            // 
            txtPosta.BackColor = Color.White;
            txtPosta.BorderStyle = BorderStyle.FixedSingle;
            txtPosta.Location = new Point(88, 94);
            txtPosta.Name = "txtPosta";
            txtPosta.Size = new Size(100, 23);
            txtPosta.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 5;
            label4.Text = "E-POSTA";
            // 
            // txtIsim
            // 
            txtIsim.BackColor = Color.White;
            txtIsim.BorderStyle = BorderStyle.FixedSingle;
            txtIsim.Location = new Point(88, 62);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(100, 23);
            txtIsim.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(22, 16);
            label3.TabIndex = 3;
            label3.Text = "TC";
            // 
            // txtTC
            // 
            txtTC.BackColor = Color.White;
            txtTC.BorderStyle = BorderStyle.FixedSingle;
            txtTC.Location = new Point(88, 30);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(36, 16);
            label2.TabIndex = 2;
            label2.Text = "İSİM";
            // 
            // calisanCikar
            // 
            calisanCikar.Controls.Add(button1);
            calisanCikar.Controls.Add(label10);
            calisanCikar.Controls.Add(txtTCcikar);
            calisanCikar.Location = new Point(313, 125);
            calisanCikar.Name = "calisanCikar";
            calisanCikar.Size = new Size(219, 254);
            calisanCikar.TabIndex = 11;
            calisanCikar.TabStop = false;
            calisanCikar.Text = "ÇIKAR";
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(104, 69);
            button1.Name = "button1";
            button1.Size = new Size(84, 31);
            button1.TabIndex = 2;
            button1.Text = "ÇIKAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(20, 37);
            label10.Name = "label10";
            label10.Size = new Size(22, 16);
            label10.TabIndex = 3;
            label10.Text = "TC";
            // 
            // txtTCcikar
            // 
            txtTCcikar.BackColor = Color.White;
            txtTCcikar.BorderStyle = BorderStyle.FixedSingle;
            txtTCcikar.Location = new Point(88, 30);
            txtTCcikar.Name = "txtTCcikar";
            txtTCcikar.Size = new Size(100, 23);
            txtTCcikar.TabIndex = 2;
            // 
            // yonetici_calisanYonetimiUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(calisanCikar);
            Controls.Add(calısanEkle);
            Controls.Add(label1);
            Name = "yonetici_calisanYonetimiUserControl";
            Size = new Size(579, 418);
            calısanEkle.ResumeLayout(false);
            calısanEkle.PerformLayout();
            calisanCikar.ResumeLayout(false);
            calisanCikar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox calısanEkle;
        private Label label2;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private Label label6;
        private Label label5;
        private TextBox txtPosta;
        private Label label4;
        private TextBox txtIsim;
        private Label label3;
        private TextBox txtTC;
        private Button calisanEkle;
        private GroupBox calisanCikar;
        private Button button1;
        private Label label10;
        private TextBox txtTCcikar;
    }
}
