using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace RestoranSistemi
{
    public partial class Menu : Form
    {
        private string selectedCategory; // Seçilen kategori adı
        private string userName; // Giriş yapan kullanıcı adı
        private string userRole; // Kullanıcı rolü (customer, employee, admin)
        public string UserEmail { get; set; } // Mail bilgisini alacak property
        public Menu(string userEmail)
        {
            InitializeComponent();

            // UserControl'ü oluştur ve forma ekle
            MenuUserControl menu = new MenuUserControl(userEmail);
            menu.Dock = DockStyle.Left; // Menü sol tarafa sabitlensin
            this.Controls.Add(menu);
            this.userName = userName;
            this.userRole = userRole;
            this.Text = $"{userName} - {userRole} - Menüsü"; // Form başlığında kullanıcı adı ve rolü
            this.UserEmail = userEmail; // Mail bilgisini alıyoruz
        }

        //// Bağlantı dizesi
        //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;");
        //string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";
        // Eskiden "connection" adındaki alanı kullanıyordunuz, ancak bu artık local scope'da tanımlandı.
        // Artık bağlantı nesnesi burada sadece method içi kullanılacak şekilde tanımlanmış durumda.
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";


        //private string selectedCategory; // Seçilen kategori adı

        //public Menu(string category)
        //{
        //    InitializeComponent();
        //    selectedCategory = category;
        //}

        private void Menu_Load(object sender, EventArgs e)
        {
            ////this.Text = $"{selectedCategory} Türleri"; // Form başlığı
            ////LoadMenuItems();
            //MenuUserControl menuUserControl = new MenuUserControl();

            //// Mail bilgisini MenuUserControl'e aktarıyoruz
            //menuUserControl.UserEmail = this.UserEmail; // Menu formundaki UserEmail'i, MenuUserControl'e gönderiyoruz

            //// UserControl'ü formun içine ekliyoruz
            //menuUserControl.Dock = DockStyle.Fill; // Kontrolün formda nasıl yerleşeceğini ayarlıyoruz
            //this.Controls.Add(menuUserControl);
            // Veritabanı bağlantısı ve sorgusu
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;"; // Bağlantı dizesi (yapılandırmanız gerekebilir)
            string query = "SELECT name FROM Users WHERE email = @Email"; // Mail'e göre kullanıcı adını almak için SQL sorgusu

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", UserEmail); // Kullanıcı e-posta adresi ile sorgu yapıyoruz

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar(); // Sadece bir değer döndürecek, burada 'name' değerini alıyoruz

                    if (result != null)
                    {
                        string userName = result.ToString(); // Kullanıcı adını alıyoruz
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //// MenuUserControl'ü dinamik olarak ekliyoruz
            //MenuUserControl menuUserControl = new MenuUserControl();

            //// Mail bilgisini MenuUserControl'e aktarıyoruz
            //menuUserControl.UserEmail = this.UserEmail; // Menu formundaki UserEmail'i, MenuUserControl'e gönderiyoruz

            //// UserControl'ü formun içine ekliyoruz
            //menuUserControl.Dock = DockStyle.Fill; // Kontrolün formda nasıl yerleşeceğini ayarlıyoruz
            //this.Controls.Add(menuUserControl);


            string userEmail = UserEmail;  // Menü formunda elde ettiğiniz UserEmail
            MenuUserControl menuUserControl = new MenuUserControl(userEmail);
            this.Controls.Add(menuUserControl);  // Kontrolü forma ekleyin

            
        }

        

        //private void LoadMenuItems()
        //{
        //    string query = "SELECT Name FROM Dishes WHERE Category = @category";

        //    // 'using' bloğu kullanılarak connection ve command yönetimi sağlanıyor
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@category", selectedCategory);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            Yemekler.Items.Clear(); // ListBox'ı temizle
        //            while (reader.Read())
        //            {
        //                Yemekler.Items.Add(reader["Name"].ToString());
        //            }
        //        }
        //    }
        //}

        private void LoadMenuItems()
        {
        //    if (string.IsNullOrEmpty(selectedCategory))
        //    {
        //        MessageBox.Show("Kategori seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    string query = "SELECT Name FROM Menu_Items WHERE category = @category";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@category", selectedCategory);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            Yemekler.Items.Clear(); // ListBox'ı temizle
        //            while (reader.Read())
        //            {
        //                Yemekler.Items.Add(reader["Name"].ToString());
        //            }
        //        }
        //    }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Gereksizse burayı silebilirsiniz
        }
    }
}
