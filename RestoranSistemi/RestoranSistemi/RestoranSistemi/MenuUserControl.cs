using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;



namespace RestoranSistemi
{
    public partial class MenuUserControl : UserControl
    {

        public string UserEmail { get; set; }

        public MenuUserControl(string userEmail)
        {
            InitializeComponent();
            lblHosgeldiniz.Text = $"HOŞGELDİNİZ {globalVariables.AdminName}";
            this.UserEmail = userEmail;
            this.listBoxYemekler.SelectedIndexChanged += new System.EventHandler(this.listBoxYemekler_SelectedIndexChanged);
            //listBoxYemekler.DrawMode = DrawMode.OwnerDrawFixed; // veya OwnerDrawVariable
            //listBoxYemekler.DrawItem += listBoxYemekler_DrawItem;

            // ListBoxSepet'i başlangıçta gizle
            listBoxSepet.Visible = false;

            // Sepetten çıkar butonu başlangıçta gizli olmalı
            btnSepettenCikar.Visible = false;

            btnUrunEkle.Visible = false;
            listBoxYemekler.Items.Clear();  // Başlangıçta listBox'u temizle


        }




        // Sepet için bir liste tanımlayalım
        private List<string> sepet = new List<string>();

        private void btnSoup_Click(object sender, EventArgs e)
        {
            // Çorbalar kategorisi için formu aç
            btnUrunEkle.Visible = true;
            OpenCategory("corbalar");

        }
        private void btnSalad_Click(object sender, EventArgs e)
        {
            // Çorbalar kategorisi için formu aç
            btnUrunEkle.Visible = true;

            OpenCategory("salatalar");

        }
        private void araSicak_Click(object sender, EventArgs e)
        {

            // Çorbalar kategorisi için formu aç
            btnUrunEkle.Visible = true;
            OpenCategory("ara_sicaklar");

        }
        private void anaYemekler_Click(object sender, EventArgs e)
        {
            // Çorbalar kategorisi için formu aç
            btnUrunEkle.Visible = true;
            OpenCategory("ana_yemekler");

        }
        private void icecekler_Click(object sender, EventArgs e)
        {
            // Çorbalar kategorisi için formu aç
            btnUrunEkle.Visible = true;
            OpenCategory("icecekler");

        }



        private void OpenCategory(string category)
        {
            // Veritabanı bağlantısı ve sorgu işlemi burada yapılacak.
            string query = "SELECT name, price FROM Menu_Items WHERE category = @Kategori";  // Gerekli sütunları seçiyoruz

            // Veritabanından verileri alacak bir metod çağırıyoruz.
            DataTable yemekler = GetDataFromDatabase(query, category);

            // ListBox'ı temizliyoruz
            listBoxYemekler.Items.Clear();

            // Veritabanından gelen yemekleri ListBox'a ekliyoruz
            foreach (DataRow row in yemekler.Rows)
            {
                string yemekAdi = row["name"].ToString();  // Yemek adı
                decimal fiyat = Convert.ToDecimal(row["price"]);  // Fiyat
                string gosterilecekBilgi = $"{yemekAdi} - {fiyat:C}";  // Yemek ve fiyatı birleştir
                listBoxYemekler.Items.Add(gosterilecekBilgi);  // Biçimlendirilmiş metni ListBox'a ekle
            }

            // Verileri ekleyip eklemediğini kontrol et
            if (listBoxYemekler.Items.Count == 0)
            {
                MessageBox.Show("Kategoriye ait yemekler bulunamadı.");
            }


        }

        private DataTable GetDataFromDatabase(string query, string category)
        {
            // Bağlantıyı yaparak veritabanından veri çekme işlemi
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kategori", category);  // Parametreyi güvenli şekilde ekliyoruz
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);  // Verileri DataTable'a dolduruyoruz
                    return dataTable;
                }
            }
        }





        public int GetUserId(string UserEmail)
        {
            Console.WriteLine($"UserEmail: {UserEmail}");  // Debugging için ekleyebilirsiniz

            string getUserIdQuery = "SELECT user_id FROM Users WHERE email = @UserEmail";
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(getUserIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserEmail", UserEmail.ToString());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0); // İlk kolonun değeri, user_id

                        }
                    }
                }
            }

            return -1; // Eğer id bulunamazsa
        }





        // Yemeklerin üstüne tıklanınca sepete ekleme işlemi
        // Yemeklerin üstüne tıklanınca sepete ekleme işlemi
        private void listBoxYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen yemek
            string selectedYemek = listBoxYemekler.SelectedItem?.ToString();



        }


        // Sepetteki yemeği çıkarma işlemi
        private void listBoxSepet_MouseClick(object sender, MouseEventArgs e)
        {
            // Sepetteki tıklanan yemek
            int index = listBoxSepet.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                // Seçilen yemeği sepetten çıkaralım
                string yemek = listBoxSepet.Items[index].ToString();
                sepet.Remove(yemek);
                listBoxSepet.Items.RemoveAt(index);
            }
        }

        // Sepetim butonuna basıldığında ListBox'ı görünür yapma işlemi
        private void btnSepetim_Click(object sender, EventArgs e)
        {

            listBoxSepet.Visible = !listBoxSepet.Visible;

            // Eğer sepet görünüyorsa, Sepetten çıkar butonunu görünür yap
            if (listBoxSepet.Visible)
            {
                btnSepettenCikar.Visible = true;
                btnUrunEkle.Visible = false;
            }
            else
            {
                btnSepettenCikar.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {

            //Sepetteki öğeyi seçtiğinizde---------------------- -
            string selectedYemek = listBoxSepet.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedYemek))
            {
                // Seçilen yemeği listeden çıkar
                listBoxSepet.Items.Remove(selectedYemek);

                // Sepetten çıkarılan yemeğin fiyatını ayıklayıp toplam fiyattan çıkar
                string[] parcalar = selectedYemek.Split('-');
                if (parcalar.Length >= 2)
                {
                    string fiyatMetni = parcalar[1].Trim();
                    fiyatMetni = fiyatMetni.Replace("₺", "").Replace("$", "").Trim();
                    fiyatMetni = fiyatMetni.Replace(",", ".");

                    if (decimal.TryParse(fiyatMetni, out decimal fiyatDolar))
                    {
                        toplamFiyatDolar -= fiyatDolar; // Toplam fiyattan çıkarma işlemi
                        ToplamFiyatGuncelle(); // Toplam fiyatı güncelle
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
            }
        }

















        private void button1_Click(object sender, EventArgs e)
        {

        }


        private decimal toplamFiyatDolar = 0.00m; // Toplam fiyat dolar cinsinden

        // Toplam fiyatı güncelleyen fonksiyon
        private void ToplamFiyatGuncelle()
        {
            lblToplamFiyat2.Text = $"Toplam Fiyat: {toplamFiyatDolar:C2}"; // Dolar cinsinden formatla
        }











        private void MenuUserControl_Load(object sender, EventArgs e)
        {

            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            // Toplam fiyatı sıfırla
            toplamFiyatDolar = 0.00m;

            // Sepetteki tüm yemeklerin fiyatını topla
            foreach (var item in listBoxSepet.Items)
            {
                string[] parcalar = item.ToString().Split('-');
                if (parcalar.Length >= 2)
                {
                    string fiyatMetni = parcalar[1].Trim();
                    fiyatMetni = fiyatMetni.Replace("₺", "").Replace("$", "").Trim();
                    fiyatMetni = fiyatMetni.Replace(",", ".");

                    // Fiyatı sayıya dönüştür
                    if (decimal.TryParse(fiyatMetni, out decimal fiyat))
                    {
                        toplamFiyatDolar += fiyat;
                    }
                }
            }

            // Toplam fiyatı ekranda göster
            lblToplamFiyat2.Text = $"{toplamFiyatDolar:C}";  // Fiyatı formatla ve label üzerinde göster
        }






        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string selectedYemek = listBoxYemekler.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedYemek))
            {
                // Yemek bilgilerini ayıklayın
                string[] parcalar = selectedYemek.Split('-');
                if (parcalar.Length >= 2)
                {
                    string fiyatMetni = parcalar[1].Trim();

                    // Eğer fiyat metninde sembol varsa, temizleyelim
                    fiyatMetni = fiyatMetni.Replace("₺", "").Replace("$", "").Trim(); // Semboller temizlendi

                    // Eğer fiyat metninde virgül varsa, nokta ile değiştiriyoruz
                    fiyatMetni = fiyatMetni.Replace(",", ".");

                    // Fiyatı sayıya dönüştür
                    if (decimal.TryParse(fiyatMetni, out decimal fiyatDolar))
                    {
                        // Sepete ekleme kontrolü
                        if (!sepet.Contains(selectedYemek)) // Aynı yemek tekrar eklenmesin
                        {
                            sepet.Add(selectedYemek);
                            listBoxSepet.Items.Add(selectedYemek); // Sepeti güncelle
                            toplamFiyatDolar += fiyatDolar; // Dolar cinsinden toplam fiyatı ekleyin
                            ToplamFiyatGuncelle(); // Toplam fiyatı güncelle
                        }
                        else
                        {
                            // Kullanıcıya seçenek sun
                            DialogResult result = MessageBox.Show(
                                "Bu yemek zaten sepette mevcut. Yine de eklemek ister misiniz?",
                                "Yemek Ekleme",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Ürünü tekrar ekle
                                sepet.Add(selectedYemek);
                                listBoxSepet.Items.Add(selectedYemek); // Sepeti güncelle
                                toplamFiyatDolar += fiyatDolar; // Dolar cinsinden toplam fiyatı ekleyin
                                ToplamFiyatGuncelle(); // Toplam fiyatı güncelle
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fiyat formatı hatalı.");
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bilgisi formatı hatalı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
            }
        }















        private void SiparisVerButton_Click(object sender, EventArgs e)
        {
            // Sepetteki ürünleri alıyoruz (örnek: listBoxSepet)
            List<string> sepet = new List<string>();
            foreach (var item in listBoxSepet.Items)
            {
                sepet.Add(item.ToString());
            }

            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş! Lütfen ürün ekleyin.");
                return;
            }

            // Sipariş bilgileri
            DateTime siparisTarihi = DateTime.Now;
            decimal toplamTutar = toplamFiyatDolar;  // Örnek toplam tutar. Sepetteki ürünlerden hesaplanabilir.

            try
            {
                // Veritabanı bağlantısı
                using (SqlConnection connection = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = CafeNew; Trusted_Connection = True; TrustServerCertificate = True;"))
                {
                    connection.Open();

                    // 2. Orders Tablosuna Sipariş Kaydı
                    string insertOrderQuery = @"
                        INSERT INTO Orders (user_id, status, total_amount)
                        OUTPUT INSERTED.order_id
                        VALUES (@UserId, @Status, @TotalAmount);
                    ";

                    using (SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, connection))
                    {
                        //cmdOrder.Parameters.AddWithValue("@UserEmail", UserEmail);
                        cmdOrder.Parameters.AddWithValue("@OrderDate", siparisTarihi);
                        cmdOrder.Parameters.AddWithValue("@TotalAmount", toplamTutar);
                        cmdOrder.Parameters.AddWithValue("@UserId", GetUserId(UserEmail));
                        cmdOrder.Parameters.AddWithValue("@Status", "Hazırlanıyor");

                        // Sipariş ID'sini alıyoruz
                        int orderId = (int)cmdOrder.ExecuteScalar();

                        // 2. Order_Items Tablosuna Ürün Kayıtları
                        foreach (var urunAd in sepet)
                        {
                            // Menü öğesinin detaylarını almak için veritabanı sorgusu yapıyoruz.
                            string selectItemQuery = @"
                        SELECT item_id,price 
                        FROM Menu_Items 
                        WHERE name = @ItemName;
                    ";

                            using (SqlCommand cmdItemDetails = new SqlCommand(selectItemQuery, connection))
                            {
                                string temizUrunAd = urunAd.Split('-')[0].Trim();
                                cmdItemDetails.Parameters.AddWithValue("@ItemName", temizUrunAd);

                                //cmdItemDetails.Parameters.AddWithValue("@ItemName", urunAd);

                                using (SqlDataReader reader = cmdItemDetails.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int itemId = reader.GetInt32(0);  // item_id'yi alıyoruz
                                        decimal unitPrice = reader.GetDecimal(1);  // unit_price'yi alıyoruz
                                        reader.Close(); // DataReader'ı kapatın!
                                        int quantity = 1;  // Sepetinizdeki miktarı burada alabilirsiniz, örneğin her ürün için 1 adet eklenmişse, bu değeri değiştirebilirsiniz
                                        decimal totalPrice = quantity * unitPrice;  // Toplam fiyatı hesaplıyoruz

                                        // Sepet öğelerini veritabanına ekliyoruz
                                        string insertOrderItemQuery = @"
                                    INSERT INTO Order_Items (order_id, item_id, quantity, unit_price, total_price) 
                                    VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @TotalPrice)";

                                        using (SqlCommand cmdItem = new SqlCommand(insertOrderItemQuery, connection))
                                        {
                                            // Parametreler ekleniyor
                                            cmdItem.Parameters.AddWithValue("@OrderID", orderId);       // Sipariş ID'si
                                            cmdItem.Parameters.AddWithValue("@ItemID", itemId);         // Menü öğesi ID'si
                                            cmdItem.Parameters.AddWithValue("@Quantity", quantity);     // Miktar
                                            cmdItem.Parameters.AddWithValue("@UnitPrice", unitPrice);   // Birim fiyat
                                            cmdItem.Parameters.AddWithValue("@TotalPrice", totalPrice); // Toplam fiyat (miktar * birim fiyat)

                                            // Sorguyu çalıştır
                                            cmdItem.ExecuteNonQuery();

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Ürün {urunAd} bulunamadı.");
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Siparişiniz başarıyla oluşturuldu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cikisYapClick(object sender, EventArgs e)
        {
            // Kullanıcıya çıkış yapmayı onaylatmak için bir MessageBox gösterelim
            var dialogResult = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Global değişkenleri sıfırlayalım (Eğer varsa, özellikle kullanıcı bilgilerini temizliyoruz)
                globalVariables.AdminName = string.Empty;  // Admin adı temizleniyor (Kullanıcı oturumunu sıfırlıyoruz)
                this.Visible = false;  // MenuUserControl gizleniyo

                // **Admin girişi yapılmadığı için** müşteri girişini yaptık, Form1'i açıyoruz.
                Form1 form1 = new Form1();
                form1.Show();  // Form1'i gösteriyoruz
            }
        }


    }
}
