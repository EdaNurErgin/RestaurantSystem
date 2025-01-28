
namespace RestoranSistemi
{
    partial class Bilgi
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 192);
            textBox2.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(276, 166);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "! Kayıtlı değilsen kayıt ol butonuna bas.";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(255, 192, 192);
            textBox4.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(276, 195);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "! Kayıtlıysan giriş butonuna bas.";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 192);
            textBox3.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(276, 224);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "! İstediğin kategoriden yemek seç,sepete ekle.";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 192, 192);
            textBox5.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(276, 253);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 59);
            textBox5.TabIndex = 5;
            textBox5.Text = "! Sepete girdikten sonra tekrar menüye yönlendirilmek için sepete tekrar tıklayarak sepeti kapatmayı unutma.";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 192, 192);
            textBox6.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(276, 318);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 23);
            textBox6.TabIndex = 6;
            textBox6.Text = "! Siparişini onaylamadan çıkış yapma.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 363);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 7;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DeepPink;
            label2.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 47);
            label2.Name = "label2";
            label2.Size = new Size(398, 93);
            label2.TabIndex = 9;
            label2.Text = "Bilgilendirme";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bilgi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Name = "Bilgi";
            Padding = new Padding(0, 5, 0, 0);
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        private void geriDonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label label2;
    }
}