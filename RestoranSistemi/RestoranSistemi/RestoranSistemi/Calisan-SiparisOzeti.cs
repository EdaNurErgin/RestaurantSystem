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
    public partial class Calisan_SiparisOzeti : Form
    {
        private Chart chart1;
        public Calisan_SiparisOzeti()
        {
            InitializeComponent();
            InitializeChart();
        }
        private void InitializeChart()
        {
            chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;
            chart1.Width = 200;
            chart1.Height = 200;
            chart1.Left = 50;
            chart1.Top = 50;
            this.Controls.Add(chart1);
        }
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=CafeNew;Trusted_Connection=True;TrustServerCertificate=True;";
        private void Calisan_SiparisOzeti_Load(object sender, EventArgs e)
        {
            LoadDailyOrderSummary(globalVariables.AdminID);
        }
        private void LoadDailyOrderSummary(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT date, 
                   SUM(completed_orders) AS TotalOrders, 
                   SUM(total_sales) AS TotalSales
            FROM Employee_Stats
            WHERE user_id = @UserID
            GROUP BY date
            ORDER BY date";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    SqlDataReader reader = command.ExecuteReader();
                    List<DateTime> dates = new List<DateTime>();
                    List<int> totalOrders = new List<int>();
                    List<decimal> totalSales = new List<decimal>();

                    while (reader.Read())
                    {
                        DateTime date = Convert.ToDateTime(reader["date"]);
                        int orders = reader["TotalOrders"] != DBNull.Value ? Convert.ToInt32(reader["TotalOrders"]) : 0;
                        decimal sales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0;
                        lblOzet.Text = $"Toplam Sipariş: {orders.ToString()}";
                        lblOzetFiyat.Text = $"Toplam Satış Tutarı: {sales.ToString()}";
                        dates.Add(date);
                        totalOrders.Add(orders);
                        totalSales.Add(sales);
                    }

                    // Display the chart with data
                    DisplayChart(dates, totalOrders, totalSales);
                }
            }
        }
        private void DisplayChart(List<DateTime> dates, List<int> totalOrders, List<decimal> totalSales)
        {
            // Clear existing data
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Create a new ChartArea
            ChartArea chartArea = new ChartArea("ChartArea1");
            chart1.ChartAreas.Add(chartArea);
            chartArea.Position = new ElementPosition(22, 40, 50, 50); // (sol, üst, genişlik, yükseklik) yüzdelik değerlerle


            // Add series for completed orders
            Series ordersSeries = new Series("Completed Orders")
            {
                ChartType = SeriesChartType.Line,  // Line chart for orders
                BorderWidth = 3
            };

            // Add series for total sales
            Series salesSeries = new Series("Total Sales")
            {
                ChartType = SeriesChartType.Line,  // Line chart for sales
                BorderWidth = 3
            };

            // Populate series with data
            for (int i = 0; i < dates.Count; i++)
            {
                ordersSeries.Points.AddXY(dates[i], totalOrders[i]);
                salesSeries.Points.AddXY(dates[i], (double)totalSales[i]);
            }

            // Add the series to the chart
            chart1.Series.Add(ordersSeries);
            chart1.Series.Add(salesSeries);

            // Set chart titles and axis labels
            chart1.Titles.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Tarih";
            chart1.ChartAreas[0].AxisY.Title = "Değerler";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";  // Format date on X-axis
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            calisanEkrani geri = new calisanEkrani();
            geri.Show();
            this.Close();
        }
    }
}
