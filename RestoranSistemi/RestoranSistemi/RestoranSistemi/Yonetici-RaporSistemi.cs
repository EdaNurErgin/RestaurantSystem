using Microsoft.Data.SqlClient;

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
using System.Windows.Forms.DataVisualization.Charting;

namespace RestoranSistemi
{
    public partial class Yonetici_RaporSistemi : Form
    {
        private Chart chartReports; // Dinamik Chart bileşeni
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";

        public Yonetici_RaporSistemi()
        {
            InitializeComponent();
            InitializeChart(); // Chart bileşenini oluştur
        }

        private void InitializeChart()
        {
            // Chart bileşeni oluşturma
            chartReports = new Chart
            {
                Dock = DockStyle.Fill, // Formu kaplayacak şekilde ayarla
                Name = "chartReports"
            };

            // Chart alanı (ChartArea) oluştur
            ChartArea chartArea = new ChartArea("MainArea")
            {
                AxisY = { IsStartedFromZero = true, IntervalAutoMode = IntervalAutoMode.VariableCount },
                AxisX = { IntervalAutoMode = IntervalAutoMode.VariableCount },
                Position = new ElementPosition(20, 30, 60, 60) // Pozisyonu burada belirtiyoruz

            };

            chartReports.ChartAreas.Add(chartArea);

            // Grafiği formun kontrol listesine ekle
            this.Controls.Add(chartReports);
        }


        private void btnGoster_Click(object sender, EventArgs e)
        {
            string reportType = cmbRapor.SelectedItem?.ToString();
            string query = "";

            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Lütfen bir rapor türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (reportType == "Günlük")
            {
                query = "SELECT * FROM Reports WHERE report_type = 'Günlük' AND generated_at >= CAST(GETDATE() AS DATE)";
            }
            else if (reportType == "Haftalık")
            {
                query = "SELECT * FROM Reports WHERE report_type = 'Haftalık' AND generated_at >= DATEADD(week, DATEDIFF(week, 0, GETDATE()), 0)";
            }
            else if (reportType == "Aylık")
            {
                query = "SELECT * FROM Reports WHERE report_type = 'Aylık' AND generated_at >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)";
            }

            DisplayReports(query);
        }

        private void DisplayReports(string query)
        {
            chartReports.Series.Clear(); // Önceki serileri temizle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    // Yeni bir seri oluştur
                    Series series = new Series("Raporlar")
                    {
                        ChartType = SeriesChartType.Column, // Grafik türü: Sütun
                        IsValueShownAsLabel = true // Değerlerin grafik üzerinde gösterilmesi
                    };

                    while (reader.Read())
                    {
                        string reportType = reader["report_type"].ToString();
                        DateTime generatedAt = Convert.ToDateTime(reader["generated_at"]);
                        string content = reader["content"].ToString();

                        // İçerikten toplam sipariş değerini ayrıştır
                        string[] lines = content.Split('\n');
                        int totalOrders = ExtractValue(lines[0]);

                        // Grafik serisine veri ekle
                        series.Points.AddXY($"{reportType} ({generatedAt:yyyy-MM-dd})", totalOrders);
                    }
                    // Ekseni yeniden hesapla
                    chartReports.ChartAreas[0].RecalculateAxesScale();

                    // Seriyi grafiğe ekle
                    chartReports.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Yardımcı metod: İçerikten toplam sipariş değerini ayrıştırır
        private int ExtractValue(string line)
        {
            return int.Parse(line.Split(':')[1].Trim());
        }


        private void btnRaporlariGuncelle_Click_1(object sender, EventArgs e)
        {
            CreateAndSaveReports("Günlük");
            CreateAndSaveReports("Haftalık");
            CreateAndSaveReports("Aylık");
            MessageBox.Show("Günlük, haftalık ve aylık raporlar başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CreateAndSaveReports(string reportType)
        {
            StringBuilder reportContent = new StringBuilder();
            string query = "";

            // Rapor türüne göre sorgu belirleniyor
            if (reportType == "Günlük")
            {
                query = "SELECT COUNT(order_id) AS TotalOrders, SUM(total_amount) AS TotalRevenue " +
                        "FROM Orders WHERE created_at >= CAST(GETDATE() AS DATE)";
            }
            else if (reportType == "Haftalık")
            {
                query = "SELECT COUNT(order_id) AS TotalOrders, SUM(total_amount) AS TotalRevenue " +
                        "FROM Orders WHERE created_at >= DATEADD(week, DATEDIFF(week, 0, GETDATE()), 0)";
            }
            else if (reportType == "Aylık")
            {
                query = "SELECT COUNT(order_id) AS TotalOrders, SUM(total_amount) AS TotalRevenue " +
                        "FROM Orders WHERE created_at >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)";
            }
            else
            {
                return;
            }

            // Veritabanından veriyi çekip rapor içeriğini oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalOrders = reader["TotalOrders"] != DBNull.Value ? Convert.ToInt32(reader["TotalOrders"]) : 0;
                        decimal totalRevenue = reader["TotalRevenue"] != DBNull.Value ? Convert.ToDecimal(reader["TotalRevenue"]) : 0;

                        reportContent.AppendLine($"Toplam Sipariş: {totalOrders}");
                        reportContent.AppendLine($"Toplam Gelir: {totalRevenue:C}");
                        reportContent.AppendLine($"Rapor Tarihi: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Oluşturulan raporu veritabanına kaydetme
            SaveReportToDatabase(reportType, reportContent.ToString());
        }

        private void SaveReportToDatabase(string reportType, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reports (report_type, content, generated_at) " +
                               "VALUES (@ReportType, @Content, @GeneratedAt)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReportType", reportType);
                command.Parameters.AddWithValue("@Content", content);
                command.Parameters.AddWithValue("@GeneratedAt", DateTime.Now);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            yoneticiEkrani gerı = new yoneticiEkrani();
            gerı.Show();
            this.Close();
        }
    }
}
