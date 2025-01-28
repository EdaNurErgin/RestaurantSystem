using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace RestoranSistemi
{
    public partial class yonetici_calisanYonetimiUserControl : UserControl
    {
        public yonetici_calisanYonetimiUserControl()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void calisanEkle_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            string isim = txtIsim.Text;
            string email = txtPosta.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "INSERT INTO Users (user_id,name, email, password, phone, address, role, created_at, updated_at) " +
                       "VALUES (@tc, @isim, @email, @isim+'.01', @telefon, @adres, 'employee', GETDATE(), GETDATE())";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametrelerin atanması
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@isim", isim);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", isim + ".01");
                    command.Parameters.AddWithValue("@telefon", telefon);
                    command.Parameters.AddWithValue("@adres", adres);

                    try
                    {
                        // Bağlantıyı aç ve sorguyu çalıştır
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Çalışan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Çalışan eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata yönetimi
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Silinecek çalışanın TC kimlik numarasını al
            string tc = txtTCcikar.Text;

            // Bağlantı dizesi
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

            // Silme işlemi öncesinde rol kontrolü için sorgu
            string roleCheckQuery = "SELECT role FROM Users WHERE user_id = @tc";

            // Çalışanı silmek için sorgu
            string deleteQuery = "DELETE FROM Users WHERE user_id = @tc AND role = 'employee'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // Role kontrolü yap
                    using (SqlCommand roleCheckCommand = new SqlCommand(roleCheckQuery, connection))
                    {
                        roleCheckCommand.Parameters.AddWithValue("@tc", tc);

                        // Role değerini al
                        string role = roleCheckCommand.ExecuteScalar()?.ToString();

                        if (role != "employee")
                        {
                            MessageBox.Show("Bu kullanıcı bir çalışan değil veya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Role kontrolünden geçtikten sonra silme işlemi
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@tc", tc);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Çalışan başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Çalışan silinemedi. Veritabanında bulunamayabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}