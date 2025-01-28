using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantı stringi
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void epostaTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void GirisClick(object sender, EventArgs e)
        {
            string email = epostaTextBox.Text.Trim();
            string password = sifreTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.WriteLine("E-posta: " + email);  // Kontrol amaçlı
            Console.WriteLine("Şifre: " + password);  // Kontrol amaçlı

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sorgu
                    string query = "SELECT user_id, role,name,email FROM Users WHERE email = @Email AND password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                string name = reader["name"].ToString(); // Veritabanından name çekildi
                                                                         // int userId = Convert.ToInt32(reader["user_id"]); // user_id'yi aldık
                                string mailll = reader["email"].ToString();

                                int userId = int.Parse(reader["user_id"].ToString());
                                globalVariables.AdminID = userId;

                                if (role == "admin")
                                {
                                    MessageBox.Show("Admin girişi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // yoneticiEkrani'na name bilgisini gönder
                                    globalVariables.AdminName = name;
                                    yoneticiEkrani yoneticiEkrani = new yoneticiEkrani();
                                    yoneticiEkrani.ShowDialog();
                                    this.Close();
                                }
                                else if (role == "employee")
                                {
                                    MessageBox.Show("Çalışan girişi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    globalVariables.AdminName = name;

                                    calisanEkrani calisanEkrani = new calisanEkrani();
                                    calisanEkrani.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Menu formuna mail bilgisini gönderiyoruz
                                    globalVariables.AdminName = name;
                                    Menu menuForm = new Menu(mailll); // mail parametre olarak gönderiliyor
                                    menuForm.ShowDialog(); // Menu formunu açıyoruz
                                    this.Close();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Hatalı e-posta veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}

