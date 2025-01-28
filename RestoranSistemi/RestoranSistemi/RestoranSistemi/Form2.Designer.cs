namespace RestoranSistemi
{
    partial class Form2
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
            label3 = new Label();
            epostaTextBox = new TextBox();
            sifreTextBox = new TextBox();
            GirisButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 106);
            label1.Name = "label1";
            label1.Size = new Size(253, 62);
            label1.TabIndex = 0;
            label1.Text = "Giriş Bilgileri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 214);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 1;
            label2.Text = "E-Posta :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 272);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epostaTextBox
            // 
            epostaTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            epostaTextBox.Location = new Point(373, 214);
            epostaTextBox.Name = "epostaTextBox";
            epostaTextBox.Size = new Size(210, 28);
            epostaTextBox.TabIndex = 3;
            epostaTextBox.TextAlign = HorizontalAlignment.Center;
            epostaTextBox.TextChanged += epostaTextBox_TextChanged;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifreTextBox.Location = new Point(373, 272);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PasswordChar = '*';
            sifreTextBox.Size = new Size(210, 28);
            sifreTextBox.TabIndex = 4;
            sifreTextBox.TextAlign = HorizontalAlignment.Center;
            sifreTextBox.TextChanged += sifreTextBox_TextChanged;
            // 
            // GirisButton
            // 
            GirisButton.BackColor = Color.FromArgb(255, 128, 128);
            GirisButton.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GirisButton.Location = new Point(357, 328);
            GirisButton.Name = "GirisButton";
            GirisButton.Size = new Size(104, 36);
            GirisButton.TabIndex = 5;
            GirisButton.Text = "Giriş";
            GirisButton.UseVisualStyleBackColor = false;
            GirisButton.Click += GirisClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(GirisButton);
            Controls.Add(sifreTextBox);
            Controls.Add(epostaTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox epostaTextBox;
        private TextBox sifreTextBox;
        private Button GirisButton;
    }
}