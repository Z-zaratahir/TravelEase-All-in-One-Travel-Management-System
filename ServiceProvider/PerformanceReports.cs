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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project
{
    public partial class PerformanceReports : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public PerformanceReports()
        {
            InitializeComponent();
        }

        private void PerformanceReports_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Occupancy Rate");
            comboBox1.Items.Add("Traveler Feedback");
            comboBox1.Items.Add("Revenue");
            comboBox1.SelectedIndex = 0;
        }

        private void chartOccupancy_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Occupancy Rate":
                    DisplayOccupancyRate();
                    break;
                case "Traveler Feedback":
                    DisplayTravelerFeedback();
                    break;
                case "Revenue":
                    DisplayRevenue();
                    break;
            }
        }

        private void DisplayOccupancyRate()
        {
            chartOccupancy.Series.Clear();
            chartOccupancy.Series.Add("Occupancy Rate");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TripID, TotalSlots, AvailableSlots FROM Trip";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int tripId = reader.GetInt32(0);
                    int totalSlots = reader.GetInt32(1);
                    int availableSlots = reader.GetInt32(2);

                    // Calculate occupancy rate
                    double occupancyRate = ((double)(totalSlots - availableSlots) / totalSlots) * 100;
                    chartOccupancy.Series["Occupancy Rate"].Points.AddXY("Trip " + tripId, occupancyRate);
                }

                reader.Close();
            }

            chartOccupancy.Titles.Clear();
            chartOccupancy.Titles.Add("Occupancy Rate per Trip (%)");
        }

        private void DisplayTravelerFeedback()
        {
            chartOccupancy.Series.Clear();
            chartOccupancy.Series.Add("Average Rating");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT b.TripID, AVG(r.Rating) AS AvgRating
            FROM BookingAttempt b
            JOIN Review r ON b.TripID = r.TripID
            WHERE b.IsCompleted = 1
            GROUP BY b.TripID";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int tripId = reader.GetInt32(0);
                    double totalRevenue = Convert.ToDouble(reader[1]);

                    chartOccupancy.Series["Average Rating"].Points.AddXY("Trip " + tripId, totalRevenue);
                }

                reader.Close();
            }

            chartOccupancy.Titles.Clear();
            chartOccupancy.Titles.Add("Traveler Feedback (Average Rating)");
        }

        private void DisplayRevenue()
        {
            chartOccupancy.Series.Clear();
            chartOccupancy.Series.Add("Revenue");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT b.TripID, SUM(bk.TotalAmount) AS TotalRevenue
            FROM BookingAttempt b
            JOIN Booking bk ON b.AttemptID = bk.AttemptID
            WHERE b.IsCompleted = 1
            GROUP BY b.TripID";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int tripId = reader.GetInt32(0);
                    double totalRevenue = Convert.ToDouble(reader[1]);

                    chartOccupancy.Series["Revenue"].Points.AddXY("Trip " + tripId, totalRevenue);
                }

                reader.Close();
            }

            chartOccupancy.Titles.Clear();
            chartOccupancy.Titles.Add("Total Revenue per Trip");
        }


        private void chartfeedback_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalRevenue_Click(object sender, EventArgs e)
        {

        }

        private void labelRevenueValue_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBookingManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
