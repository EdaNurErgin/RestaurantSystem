namespace RestoranSistemi
{
    partial class MenuUserControl
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
            panel1 = new Panel();
            label1 = new Label();
            SepetimButton = new Button();
            SiparisVerButton = new Button();
            İceceklerButton = new Button();
            cikisYapButton = new Button();
            AraSıcaklarButton = new Button();
            SalatalarButton = new Button();
            AnaYemeklerButton = new Button();
            CorbalarButton = new Button();
            listBoxYemekler = new ListBox();
            listBoxSepet = new ListBox();
            btnSepettenCikar = new Button();
            btnUrunEkle = new Button();
            lblToplamFiyat = new Label();
            lblToplamFiyat2 = new Label();
            lblHosgeldiniz = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SepetimButton);
            panel1.Controls.Add(SiparisVerButton);
            panel1.Controls.Add(İceceklerButton);
            panel1.Controls.Add(cikisYapButton);
            panel1.Controls.Add(AraSıcaklarButton);
            panel1.Controls.Add(SalatalarButton);
            panel1.Controls.Add(AnaYemeklerButton);
            panel1.Controls.Add(CorbalarButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 498);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(171, 74);
            label1.TabIndex = 4;
            label1.Text = "Menü";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SepetimButton
            // 
            SepetimButton.BackColor = Color.Cyan;
            SepetimButton.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SepetimButton.Location = new Point(34, 316);
            SepetimButton.Name = "SepetimButton";
            SepetimButton.Size = new Size(137, 35);
            SepetimButton.TabIndex = 6;
            SepetimButton.Text = "Sepet [Aç/Kapa]";
            SepetimButton.UseVisualStyleBackColor = false;
            SepetimButton.Click += btnSepetim_Click;
            // 
            // SiparisVerButton
            // 
            SiparisVerButton.BackColor = Color.Cyan;
            SiparisVerButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SiparisVerButton.Location = new Point(34, 357);
            SiparisVerButton.Name = "SiparisVerButton";
            SiparisVerButton.Size = new Size(137, 37);
            SiparisVerButton.TabIndex = 1;
            SiparisVerButton.Text = "Sipariş Ver";
            SiparisVerButton.UseVisualStyleBackColor = false;
            SiparisVerButton.Click += SiparisVerButton_Click;
            // 
            // İceceklerButton
            // 
            İceceklerButton.BackColor = Color.Yellow;
            İceceklerButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            İceceklerButton.Location = new Point(34, 261);
            İceceklerButton.Name = "İceceklerButton";
            İceceklerButton.Size = new Size(137, 28);
            İceceklerButton.TabIndex = 5;
            İceceklerButton.Text = "İçecekler";
            İceceklerButton.UseVisualStyleBackColor = false;
            İceceklerButton.Click += icecekler_Click;
            // 
            // cikisYapButton
            // 
            cikisYapButton.BackColor = Color.FromArgb(255, 128, 128);
            cikisYapButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cikisYapButton.Location = new Point(34, 416);
            cikisYapButton.Name = "cikisYapButton";
            cikisYapButton.Size = new Size(137, 35);
            cikisYapButton.TabIndex = 4;
            cikisYapButton.Text = "Çıkış  Yap";
            cikisYapButton.UseVisualStyleBackColor = false;
            cikisYapButton.Click += cikisYapClick;
            // 
            // AraSıcaklarButton
            // 
            AraSıcaklarButton.BackColor = Color.Yellow;
            AraSıcaklarButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AraSıcaklarButton.Location = new Point(34, 187);
            AraSıcaklarButton.Name = "AraSıcaklarButton";
            AraSıcaklarButton.Size = new Size(137, 32);
            AraSıcaklarButton.TabIndex = 3;
            AraSıcaklarButton.Text = "Ara Sıcaklar";
            AraSıcaklarButton.UseVisualStyleBackColor = false;
            AraSıcaklarButton.Click += araSicak_Click;
            // 
            // SalatalarButton
            // 
            SalatalarButton.BackColor = Color.Yellow;
            SalatalarButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalatalarButton.Location = new Point(34, 151);
            SalatalarButton.Name = "SalatalarButton";
            SalatalarButton.Size = new Size(137, 30);
            SalatalarButton.TabIndex = 2;
            SalatalarButton.Text = "Salatalar";
            SalatalarButton.UseVisualStyleBackColor = false;
            SalatalarButton.Click += btnSalad_Click;
            // 
            // AnaYemeklerButton
            // 
            AnaYemeklerButton.BackColor = Color.Yellow;
            AnaYemeklerButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnaYemeklerButton.Location = new Point(34, 225);
            AnaYemeklerButton.Name = "AnaYemeklerButton";
            AnaYemeklerButton.Size = new Size(137, 30);
            AnaYemeklerButton.TabIndex = 1;
            AnaYemeklerButton.Text = "AnaYemekler";
            AnaYemeklerButton.UseVisualStyleBackColor = false;
            AnaYemeklerButton.Click += anaYemekler_Click;
            // 
            // CorbalarButton
            // 
            CorbalarButton.BackColor = Color.Yellow;
            CorbalarButton.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CorbalarButton.Location = new Point(34, 116);
            CorbalarButton.Name = "CorbalarButton";
            CorbalarButton.Size = new Size(137, 29);
            CorbalarButton.TabIndex = 0;
            CorbalarButton.Text = "Çorbalar";
            CorbalarButton.UseVisualStyleBackColor = false;
            CorbalarButton.Click += btnSoup_Click;
            // 
            // listBoxYemekler
            // 
            listBoxYemekler.BackColor = Color.Yellow;
            listBoxYemekler.FormattingEnabled = true;
            listBoxYemekler.ItemHeight = 15;
            listBoxYemekler.Location = new Point(368, 60);
            listBoxYemekler.Name = "listBoxYemekler";
            listBoxYemekler.Size = new Size(339, 334);
            listBoxYemekler.TabIndex = 1;
            // 
            // listBoxSepet
            // 
            listBoxSepet.BackColor = Color.Cyan;
            listBoxSepet.FormattingEnabled = true;
            listBoxSepet.ItemHeight = 15;
            listBoxSepet.Location = new Point(368, 60);
            listBoxSepet.Name = "listBoxSepet";
            listBoxSepet.Size = new Size(339, 334);
            listBoxSepet.TabIndex = 2;
            listBoxSepet.Visible = false;
            listBoxSepet.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnSepettenCikar
            // 
            btnSepettenCikar.BackColor = Color.Cyan;
            btnSepettenCikar.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSepettenCikar.Location = new Point(610, 414);
            btnSepettenCikar.Name = "btnSepettenCikar";
            btnSepettenCikar.Size = new Size(97, 37);
            btnSepettenCikar.TabIndex = 3;
            btnSepettenCikar.Text = "Ürünü Çıkart";
            btnSepettenCikar.UseVisualStyleBackColor = false;
            btnSepettenCikar.Click += btnSepettenCikar_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.Yellow;
            btnUrunEkle.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUrunEkle.Location = new Point(368, 414);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(97, 37);
            btnUrunEkle.TabIndex = 7;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Visible = false;
            btnUrunEkle.Click += btnSepeteEkle_Click;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Location = new Point(634, 357);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(0, 15);
            lblToplamFiyat.TabIndex = 7;
            // 
            // lblToplamFiyat2
            // 
            lblToplamFiyat2.BackColor = Color.White;
            lblToplamFiyat2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToplamFiyat2.ForeColor = SystemColors.ActiveCaptionText;
            lblToplamFiyat2.Location = new Point(480, 414);
            lblToplamFiyat2.Name = "lblToplamFiyat2";
            lblToplamFiyat2.Size = new Size(114, 37);
            lblToplamFiyat2.TabIndex = 8;
            lblToplamFiyat2.Text = "ToplamTutar:";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHosgeldiniz.Location = new Point(427, 23);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(0, 19);
            lblHosgeldiniz.TabIndex = 9;
            // 
            // MenuUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(lblToplamFiyat2);
            Controls.Add(lblToplamFiyat);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnSepettenCikar);
            Controls.Add(listBoxSepet);
            Controls.Add(listBoxYemekler);
            Controls.Add(panel1);
            Name = "MenuUserControl";
            Size = new Size(820, 498);
            Load += MenuUserControl_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cikisYapButton;
        private Button AraSıcaklarButton;
        private Button SalatalarButton;
        private Button AnaYemeklerButton;
        private Button CorbalarButton;
        private Button İceceklerButton;
        private Button SepetimButton;
        private Button SiparisVerButton;
        private ListBox listBoxYemekler;
        private ListBox listBoxSepet;
        private Button btnSepettenCikar;
        private Label label1;
        private Button btnUrunEkle;
        private Label lblToplamFiyat;
        private Label lblToplamFiyat2;
        private Label lblHosgeldiniz;
    }
}
