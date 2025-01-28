namespace RestoranSistemi
{
    partial class yoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticiEkrani));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(77, 201);
            button1.Name = "button1";
            button1.Size = new Size(161, 110);
            button1.TabIndex = 0;
            button1.Text = "ÇALIŞAN YÖNETİMİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(185, 70);
            label1.Name = "label1";
            label1.Size = new Size(426, 31);
            label1.TabIndex = 1;
            label1.Text = "RESTORAN YÖNETİCİ SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(288, 111);
            label2.Name = "label2";
            label2.Size = new Size(0, 22);
            label2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.HotPink;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(322, 201);
            button2.Name = "button2";
            button2.Size = new Size(161, 110);
            button2.TabIndex = 3;
            button2.Text = "MENÜ YÖNETİMİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.HotPink;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(567, 201);
            button3.Name = "button3";
            button3.Size = new Size(161, 110);
            button3.TabIndex = 4;
            button3.Text = "SİPARİŞ VE İŞLEM RAPORLARI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(364, 148);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 5;
            label3.Text = "Çıkış Yap";
            label3.Click += label3_Click;
            // 
            // yoneticiEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 461);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "yoneticiEkrani";
            Text = "yoneticiEkrani";
            Load += yoneticiEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}