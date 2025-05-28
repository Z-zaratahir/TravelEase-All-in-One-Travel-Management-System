using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class PlatformAnalytics : UserControl
    {
        public PlatformAnalytics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalRevenue_Click(object sender, EventArgs e)
        {

        }

        private void chartTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void PlatformAnalytics_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // --- Load Total Revenue ---
                string query = @"
                    SELECT SUM(B.TotalAmount)
                    FROM Booking B
                    JOIN Payment P ON B.PaymentID = P.PaymentID
                    WHERE P.Status = 'Completed'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalRevenue = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    labelRevenueAmount.Text = "Rs. " + totalRevenue.ToString("N2");
                }

                // ✅ Load charts inside the same connection scope
                LoadTotalUsersChart(conn);
                LoadBookingTrendChart(conn);
            }
        }
        private void LoadTotalUsersChart(SqlConnection conn)
        {
            // Clear previous chart data
            chartTotalUsers.Series.Clear();
            chartTotalUsers.Titles.Clear();

            chartTotalUsers.Titles.Add("User Type Distribution");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Users");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Traveler count
            string travelerQuery = "SELECT COUNT(*) FROM Traveler";
            using (SqlCommand cmd = new SqlCommand(travelerQuery, conn))
            {
                int travelerCount = (int)cmd.ExecuteScalar();
                series.Points.AddXY("Traveler", travelerCount);
            }

            // Operator count
            string operatorQuery = "SELECT COUNT(*) FROM Operator";
            using (SqlCommand cmd = new SqlCommand(operatorQuery, conn))
            {
                int operatorCount = (int)cmd.ExecuteScalar();
                series.Points.AddXY("Operator", operatorCount);
            }

            chartTotalUsers.Series.Add(series);
        }

        private void LoadBookingTrendChart(SqlConnection conn)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Monthly Booking Trends");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Bookings");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            string query = @"
        SELECT 
            FORMAT(Date, 'yyyy-MM') AS Month,
            COUNT(*) AS BookingCount
        FROM Booking
        GROUP BY FORMAT(Date, 'yyyy-MM')
        ORDER BY Month";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string month = reader["Month"].ToString();
                    int count = Convert.ToInt32(reader["BookingCount"]);
                    series.Points.AddXY(month, count);
                }
            }

            chart1.Series.Add(series);
        }
       

       

        private void labelRevenueAmount_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {

        }
    }
}
