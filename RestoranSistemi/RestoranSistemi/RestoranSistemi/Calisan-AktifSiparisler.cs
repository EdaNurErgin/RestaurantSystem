using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestoranSistemi
{
    public partial class Calisan_AktifSiparisler : Form
    {
        public Calisan_AktifSiparisler()
        {
            InitializeComponent();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }

        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

        public void LoadDataIntoDataGridView()
        {
            string query = @"SELECT 
                                Orders.order_id AS OrderID,
                                Menu_Items.name AS MenuItemName,
                                Users.name AS UserName,
                                Orders.status AS OrderStatus,
                                Orders.created_at AS OrderCreatedAt,
                                Users.address AS Address
                                
                             FROM 
                                Order_Items
                             INNER JOIN Orders ON Order_Items.order_id = Orders.order_id
                             INNER JOIN Users ON Orders.user_id = Users.user_id
                             INNER JOIN Menu_Items ON Order_Items.item_id = Menu_Items.item_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // DataTable'e veri yükleme
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // DataGridView'e bağlama
                    dataGridView1.DataSource = table;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // Kolon başlıklarını düzenleme
                    dataGridView1.Columns["OrderID"].Visible = false; // ID kolonunu gizliyoruz
                    dataGridView1.Columns["MenuItemName"].HeaderText = "Ürün Adı";
                    dataGridView1.Columns["UserName"].HeaderText = "Kullanıcı Adı";
                    dataGridView1.Columns["OrderCreatedAt"].HeaderText = "Oluşturulma Tarihi";
                    dataGridView1.Columns["Address"].HeaderText = "Adres";
                    // DataGridView'e ComboBox kolonu ekleme
                    AddComboBoxColumn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Veri Yükleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddComboBoxColumn()
        {
            // Sipariş Durumu için ComboBox kolonu ekleme
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Sipariş Durumu",
                Name = "OrderStatusComboBox",
                DataPropertyName = "OrderStatus", // Veritabanından gelen kolon
                FlatStyle = FlatStyle.Flat
            };

            // Durum seçeneklerini belirtiyoruz
            comboBoxColumn.Items.AddRange("Hazırlanıyor", "Hazır", "Teslim Edildi");

            // Var olan DataGridView'e ekle
            dataGridView1.Columns.Remove("OrderStatus"); // Orijinal kolon silinir
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void Calisan_AktifSiparisler_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer ComboBox kolonunda değişiklik yapılmışsa
            if (dataGridView1.Columns[e.ColumnIndex].Name == "OrderStatusComboBox")
            {
                // Güncellenen sipariş durumu ve ID'sini al
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                string newStatus = dataGridView1.Rows[e.RowIndex].Cells["OrderStatusComboBox"].Value.ToString();
                MessageBox.Show($"Güncellenecek Kullanıcı ID: {globalVariables.AdminID}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Veritabanını güncelle
                UpdateOrderStatus(orderId, newStatus, globalVariables.AdminID);
            }
        }

        private void UpdateOrderStatus(int orderId, string newStatus, int userId)
        {
            string updateQuery = "UPDATE Orders SET status = @Status WHERE order_id = @OrderID";
            string updateEmployeeStatsQuery = "UPDATE Employee_Stats SET completed_orders = ISNULL(completed_orders, 0) + 1 WHERE user_id = @UserID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Bağlantı Durumu: " + connection.State.ToString());
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // Bağlantıyı aç
                    Console.WriteLine("Bağlantı açıldı.");
                }

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Sipariş durumu güncelle
                        using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@OrderID", orderId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                throw new Exception("Sipariş durumu güncellenemedi.");
                            }
                            else
                            {
                                MessageBox.Show("Siparis durumu başarıyla guncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        // Eğer sipariş "Hazır" ise, çalışan istatistiğini güncelle
                        try
                        {
                            if (newStatus == "Teslim Edildi")
                            {
                                using (SqlCommand statsCommand = new SqlCommand(updateEmployeeStatsQuery, connection, transaction))
                                {
                                    statsCommand.Parameters.AddWithValue("@UserID", userId);

                                    int rowsAffectedStats = statsCommand.ExecuteNonQuery();
                                    if (rowsAffectedStats <= 0)
                                    {
                                        throw new Exception("Çalışan istatistikleri güncellenemedi.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Çalışan istatistikleri başarıyla guncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hata mesajını kullanıcıya göster
                            MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            calisanEkrani geri = new calisanEkrani();
            geri.Show();
            this.Close();
        }
    }
}
