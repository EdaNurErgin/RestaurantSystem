namespace RestoranSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            girisYap = new Button();
            kayıtOl = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Tempus Sans ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 98);
            label1.Name = "label1";
            label1.Size = new Size(398, 93);
            label1.TabIndex = 0;
            label1.Text = "Restorandan Sipariş Ver";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // girisYap
            // 
            girisYap.AutoSize = true;
            girisYap.BackColor = Color.FromArgb(255, 128, 128);
            girisYap.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            girisYap.Location = new Point(344, 232);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(138, 43);
            girisYap.TabIndex = 3;
            girisYap.Text = "Giriş Yap";
            girisYap.UseVisualStyleBackColor = false;
            girisYap.Click += girisYapClick;
            // 
            // kayıtOl
            // 
            kayıtOl.AutoSize = true;
            kayıtOl.BackColor = Color.FromArgb(255, 128, 128);
            kayıtOl.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kayıtOl.Location = new Point(344, 300);
            kayıtOl.Name = "kayıtOl";
            kayıtOl.Size = new Size(138, 43);
            kayıtOl.TabIndex = 4;
            kayıtOl.Text = "Kayıt Ol";
            kayıtOl.UseVisualStyleBackColor = false;
            kayıtOl.Click += kayıtOlClick;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 36);
            button1.Name = "button1";
            button1.Size = new Size(90, 68);
            button1.TabIndex = 5;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Bilgilen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(804, 461);
            Controls.Add(button1);
            Controls.Add(kayıtOl);
            Controls.Add(girisYap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button girisYap;
        private Button kayıtOl;
        private Button button1;
    }
}
