using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
    public partial class Yonetici_MenuYonetimi : Form
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

        public Yonetici_MenuYonetimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMenuItems("salatalar");

        }

        private void calisanDuzenle_Click(object sender, EventArgs e)
        {
            LoadMenuItems("corbalar");
        }

        private void Yonetici_MenuYonetimi_Load(object sender, EventArgs e)
        {

        }
        // Veritabanından belirli kategoriye ait ürünleri getir ve göster

        private void LoadMenuItems(string category)
        {
            listBoxItems.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT name, description, price FROM Menu_Items WHERE Category = @Category";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Category", category);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string price = reader["price"].ToString();
                        string description = reader["description"].ToString();

                        listBoxItems.Items.Add($"{name} - {price} TL - {description}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnAraSicaklar_Click(object sender, EventArgs e)
        {
            LoadMenuItems("ara_sicaklar");

        }

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            LoadMenuItems("ana_yemekler");

        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            LoadMenuItems("icecekler");

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                // Seçilen öğeyi al
                string selectedItem = listBoxItems.SelectedItem.ToString();

                // Ürün adını almak için ListBox'taki formatı çöz
                string[] parts = selectedItem.Split('-');
                string productName = parts[0].Trim(); // Ürün adı, formatın ilk kısmıdır

                // Veritabanından ürünü sil
                DeleteMenuItem(productName);

                // ListBox'ı güncelle
                listBoxItems.Items.Remove(selectedItem);

                MessageBox.Show($"{productName} başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteMenuItem(string productName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Menu_Items WHERE name = @ProductName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Ürün başarıyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Ürün bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                // Seçilen öğeyi al
                string selectedItem = listBoxItems.SelectedItem.ToString();

                // Ürün adını almak için ListBox'taki formatı çöz
                string[] parts = selectedItem.Split('-');
                string oldProductName = parts[0].Trim(); // Eski ürün adı, formatın ilk kısmıdır

                // Kullanıcıdan yeni bilgileri al (Dialog veya yeni form açabilirsiniz)
                string newProductName = Prompt.ShowDialog("Yeni ürün adını girin:", oldProductName);
                string newDescription = Prompt.ShowDialog("Yeni açıklamayı girin:", parts[2].Trim());
                string newPriceStr = Prompt.ShowDialog("Yeni fiyatı girin (TL):", parts[1].Trim().Replace(" TL", ""));
                if (!decimal.TryParse(newPriceStr, out decimal newPrice))
                {
                    MessageBox.Show("Geçerli bir fiyat girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanında güncelle
                UpdateMenuItem(oldProductName, newProductName, newDescription, newPrice);

                // ListBox'ı güncelle
                listBoxItems.Items[listBoxItems.SelectedIndex] = $"{newProductName} - {newPrice} TL - {newDescription}";

                MessageBox.Show($"{oldProductName} başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateMenuItem(string oldProductName, string newProductName, string newDescription, decimal newPrice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Menu_Items SET name = @NewName, description = @NewDescription, price = @NewPrice WHERE name = @OldName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewName", newProductName);
                command.Parameters.AddWithValue("@NewDescription", newDescription);
                command.Parameters.AddWithValue("@NewPrice", newPrice);
                command.Parameters.AddWithValue("@OldName", oldProductName);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Ürün başarıyla güncellendi.");
                    }
                    else
                    {
                        Console.WriteLine("Ürün bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string ShowInputDialog(string promptMessage)
        {
            // Yeni bir dialog formu oluştur
            Form prompt = new Form()
            {
                Width = 500,  // Genişliği artır
                Height = 200, // Yüksekliği artır
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Kategori Seçimi"  // Pencere başlığı
            };

            // Kullanıcıya mesajı gösterecek bir Label ekle
            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = promptMessage,
                AutoSize = true
            };

            // Kullanıcının giriş yapacağı bir ComboBox ekle
            ComboBox categoryComboBox = new ComboBox()
            {
                Left = 20,
                Top = 60,
                Width = 440,  // Genişlik ayarı
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // ComboBox'a seçenekleri ekle
            categoryComboBox.Items.AddRange(new string[]
            {
        "corbalar",
        "salatalar",
        "ara_sicaklar",
        "ana_yemekler",
        "icecekler"
            });

            // Tamam butonu ekle
            Button confirmation = new Button()
            {
                Text = "Tamam",
                Left = 350,
                Width = 100,
                Top = 120,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            // Dialog'a elemanları ekle
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(categoryComboBox);
            prompt.Controls.Add(confirmation);

            // Butonu varsayılan buton olarak ayarla
            prompt.AcceptButton = confirmation;

            // Dialog'u göster ve seçilen değeri döndür
            return prompt.ShowDialog() == DialogResult.OK ? categoryComboBox.SelectedItem?.ToString() : null;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string newProductName = PromptUrunEkle.ShowDialog("Ürün adını girin:", "");
            string newCategory = ShowInputDialog("Kategori girin:");
            if (string.IsNullOrEmpty(newCategory)) return;
            string newDescription = PromptUrunEkle.ShowDialog("Açıklama girin:", "");
            string newPriceStr = PromptUrunEkle.ShowDialog("Fiyat girin (TL):", "");

            if (!decimal.TryParse(newPriceStr, out decimal newPrice))
            {
                MessageBox.Show("Geçerli bir fiyat girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına ekle
            AddMenuItem(newProductName, newCategory, newDescription, newPrice);

            // Kullanıcıya bilgi ver
            MessageBox.Show($"{newProductName} başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AddMenuItem(string name, string category, string description, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Menu_Items (name, category, description, price, availability, created_at, updated_at) " +
                               "VALUES (@Name, @Category, @Description, @Price, 1, GETDATE(), GETDATE())";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Price", price);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Yeni ürün başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            yoneticiEkrani gerı = new yoneticiEkrani();
            gerı.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
