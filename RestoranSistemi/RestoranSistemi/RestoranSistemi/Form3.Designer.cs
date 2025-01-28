namespace RestoranSistemi
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            isimkayitTextBox = new TextBox();
            label3 = new Label();
            epostakayitTextBox = new TextBox();
            sifre1kayitTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            sifre2kayitTextBox = new TextBox();
            KayitButton = new Button();
            label6 = new Label();
            txtTC = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 33);
            label1.Name = "label1";
            label1.Size = new Size(253, 62);
            label1.TabIndex = 1;
            label1.Text = "Kayıt Bilgileri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 166);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 2;
            label2.Text = "İsim:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // isimkayitTextBox
            // 
            isimkayitTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isimkayitTextBox.Location = new Point(354, 166);
            isimkayitTextBox.Name = "isimkayitTextBox";
            isimkayitTextBox.Size = new Size(208, 28);
            isimkayitTextBox.TabIndex = 4;
            isimkayitTextBox.TextAlign = HorizontalAlignment.Center;
            isimkayitTextBox.TextChanged += isimkayitTextBox_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(206, 214);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 5;
            label3.Text = "E-Posta :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epostakayitTextBox
            // 
            epostakayitTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            epostakayitTextBox.Location = new Point(354, 215);
            epostakayitTextBox.Name = "epostakayitTextBox";
            epostakayitTextBox.Size = new Size(208, 28);
            epostakayitTextBox.TabIndex = 6;
            epostakayitTextBox.TextAlign = HorizontalAlignment.Center;
            epostakayitTextBox.TextChanged += epostakayitTextBox_TextChanged;
            // 
            // sifre1kayitTextBox
            // 
            sifre1kayitTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifre1kayitTextBox.Location = new Point(354, 263);
            sifre1kayitTextBox.Name = "sifre1kayitTextBox";
            sifre1kayitTextBox.PasswordChar = '*';
            sifre1kayitTextBox.Size = new Size(208, 28);
            sifre1kayitTextBox.TabIndex = 7;
            sifre1kayitTextBox.TextAlign = HorizontalAlignment.Center;
            sifre1kayitTextBox.TextChanged += sifre1kayitTextBox_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(206, 263);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 8;
            label4.Text = "Şifre:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 309);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 9;
            label5.Text = "Tekrar Şifre";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sifre2kayitTextBox
            // 
            sifre2kayitTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifre2kayitTextBox.Location = new Point(354, 310);
            sifre2kayitTextBox.Name = "sifre2kayitTextBox";
            sifre2kayitTextBox.PasswordChar = '*';
            sifre2kayitTextBox.Size = new Size(208, 28);
            sifre2kayitTextBox.TabIndex = 10;
            sifre2kayitTextBox.TextAlign = HorizontalAlignment.Center;
            sifre2kayitTextBox.TextChanged += sifre2kayitTextBox_TextChanged;
            // 
            // KayitButton
            // 
            KayitButton.BackColor = Color.FromArgb(255, 128, 128);
            KayitButton.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KayitButton.Location = new Point(340, 370);
            KayitButton.Name = "KayitButton";
            KayitButton.Size = new Size(104, 36);
            KayitButton.TabIndex = 11;
            KayitButton.Text = "Kayıt Ol";
            KayitButton.UseVisualStyleBackColor = false;
            KayitButton.Click += KayitClick;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 116);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 12;
            label6.Text = "TC:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTC
            // 
            txtTC.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTC.Location = new Point(354, 117);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(208, 28);
            txtTC.TabIndex = 13;
            txtTC.TextAlign = HorizontalAlignment.Center;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(txtTC);
            Controls.Add(label6);
            Controls.Add(KayitButton);
            Controls.Add(sifre2kayitTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sifre1kayitTextBox);
            Controls.Add(epostakayitTextBox);
            Controls.Add(label3);
            Controls.Add(isimkayitTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            txtTC.TabIndex = 0;
            isimkayitTextBox.TabIndex = 1;
            epostakayitTextBox.TabIndex = 2;
            sifre1kayitTextBox.TabIndex = 3;
            sifre2kayitTextBox.TabIndex = 4;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox isimkayitTextBox;
        private Label label3;
        private TextBox epostakayitTextBox;
        private TextBox sifre1kayitTextBox;
        private Label label4;
        private Label label5;
        private TextBox sifre2kayitTextBox;
        private Button KayitButton;
        private Label label6;
        private TextBox txtTC;
    }
}