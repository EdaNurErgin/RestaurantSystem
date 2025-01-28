using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sifre1kayitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre2kayitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayitClick(object sender, EventArgs e)
        {
            // Kullanıcının formdan girdiği verileri alıyoruz
            int tc = int.Parse(txtTC.Text);
            string isim = isimkayitTextBox.Text;
            string email = epostakayitTextBox.Text;
            string sifre1 = sifre1kayitTextBox.Text;
            string sifre2 = sifre2kayitTextBox.Text;

            // Şifrelerin eşleşip eşleşmediğini kontrol ediyoruz
            if (sifre1 != sifre2)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            // Parola gücünü kontrol ediyoruz
            if (!IsPasswordStrong(sifre1))
            {
                MessageBox.Show("Parola en az 8 karakter uzunluğunda olmalı ve bir büyük harf, bir küçük harf ile bir sayı içermelidir.");
                return;
            }

            // Email formatını kontrol ediyoruz
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Geçerli bir email adresi giriniz.");
                return;
            }

            // Veritabanı bağlantı dizesini tanımlıyoruz
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                // Veritabanına bağlantıyı açıyoruz
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanına veri eklemek için SQL sorgusunu hazırlıyoruz
                    string query = "INSERT INTO Users (user_id, name, email, password, role) VALUES (@UserID, @Name, @Email, @Password, @Role)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri sorguya ekliyoruz
                        command.Parameters.AddWithValue("@UserID", tc);
                        command.Parameters.AddWithValue("@Name", isim);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", sifre1);  // Şifreyi alıyoruz
                        command.Parameters.AddWithValue("@Role", "customer");  // Varsayılan olarak müşteri rolü atıyoruz

                        // Sorguyu çalıştırıyoruz
                        command.ExecuteNonQuery();

                        // Başarılı olursa kullanıcıya mesaj gösteriyoruz
                        MessageBox.Show("Kayıt başarılı!");

                        // Menü formunu açıyoruz
                        Form2 yeniForm = new Form2(); // Menu formunu oluşturuyoruz
                        yeniForm.ShowDialog(); // Menu formunu modal olarak açıyoruz
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata olursa hata mesajı gösteriyoruz
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        // Parola gücünü kontrol eden metod
        private bool IsPasswordStrong(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        // Email formatını kontrol eden metod
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void isimkayitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void epostakayitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
