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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranSistemi
{
    public partial class yonetici_calisanListeleUserControl : UserControl
    {
        public yonetici_calisanListeleUserControl()
        {
            InitializeComponent();
        }

        private void dtCalisanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yonetici_calisanListeleUserControl_Load(object sender, EventArgs e)
        {
            // 1. Veritabanı bağlantı dizesi
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

            // 2. SQL sorgusu (role alanı "employee" olanları filtrele)
            string query = "SELECT user_id, name, email, password, phone FROM Users WHERE role = 'employee'";

            // 3. ListView ayarları
            lstCalisanlar.Clear();
            lstCalisanlar.View = View.Details;
            lstCalisanlar.FullRowSelect = true;
            lstCalisanlar.GridLines = true;
            lstCalisanlar.Columns.Add("TC", 50);
            lstCalisanlar.Columns.Add("Name", 150);
            lstCalisanlar.Columns.Add("Email", 200);
            lstCalisanlar.Columns.Add("Password", 150);
            lstCalisanlar.Columns.Add("Phone", 100);

            try
            {
                // 4. Veritabanı bağlantısı ve veri çekme
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 5. Veriyi ListView'e ekleme
                            while (reader.Read())
                            {
                                string[] row = {
                            reader["user_id"].ToString(),
                            reader["name"].ToString(),
                            reader["email"].ToString(),
                            reader["password"].ToString(),
                            reader["phone"].ToString()
                        };
                                ListViewItem item = new ListViewItem(row);
                                lstCalisanlar.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void lstCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
