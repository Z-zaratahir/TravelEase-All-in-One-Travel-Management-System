using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class dashboard : UserControl
    {
        private int travelerID;

        public dashboard(int userID)
        {
            InitializeComponent();
            travelerID = userID; 
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadTravelerTrips(travelerID);
        }

        private async void LoadTravelerTrips(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    t.TripID,
                    t.TotalSlots,
                    t.AvailableSlots,
                    t.ReturnDate,
                    t.Price,
                    t.DepartureDate,
                    t.CategoryID,
                    b.IsCompleted
                FROM 
                    BookingAttempt b
                INNER JOIN 
                    Trip t ON b.TripID = t.TripID
                WHERE 
                    b.TravelerID = @TravelerID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (dataGridView1.Rows.Count > 0)
                            {
                                dataGridView1.Rows.Clear();
                            }

                            while (await reader.ReadAsync())
                            {
                                dataGridView1.Rows.Add(
                                    reader["TripID"],
                                    reader["TotalSlots"],
                                    reader["AvailableSlots"],
                                    reader["ReturnDate"],
                                    reader["Price"],
                                    reader["DepartureDate"],
                                    reader["CategoryID"],
                                     reader["isCompleted"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private async void Cancelb_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTripID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TripID"].Value);
                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                string cancelQuery = "UPDATE BookingAttempt SET IsCompleted = 0 WHERE TripID = @TripID AND TravelerID = @TravelerID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        await connection.OpenAsync();

                        using (SqlCommand cmd = new SqlCommand(cancelQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@TripID", selectedTripID);
                            cmd.Parameters.AddWithValue("@TravelerID", travelerID);

                            int rowsAffected = await cmd.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Booking has been successfully canceled!");
                                LoadTravelerTrips(travelerID);
                            }
                            else
                            {
                                MessageBox.Show("Error canceling the booking. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error canceling booking: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to cancel.");
            }
        }

        private async void viewconfirmb_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTripID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TripID"].Value);

                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                string query = @"
            SELECT 
                t.TripID,
                t.TotalSlots,
                t.AvailableSlots,
                t.ReturnDate,
                t.Price,
                t.DepartureDate,
                t.CategoryID,
                c.CategoryName,
              
                b.IsCompleted  -- Check the booking status (canceled or not)
            FROM 
                Trip t
            INNER JOIN 
                TourCategories c ON t.CategoryID = c.CategoryID
            INNER JOIN
               
                BookingAttempt b ON b.TripID = t.TripID
            WHERE 
                t.TripID = @TripID;";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@TripID", selectedTripID);

                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                if (reader.HasRows)
                                {
                                    await reader.ReadAsync();

                                    bool isCanceled = Convert.ToBoolean(reader["IsCompleted"]);
                                    string confirmationMessage;

                                    if (!isCanceled)
                                    {
                                        confirmationMessage = $"Trip ID: {reader["TripID"]} (Canceled)\n" +
                                                              $"Price: {reader["Price"]:C}\n" +
                                                              $"Departure Date: {reader["DepartureDate"]:d}\n" +
                                                              $"Return Date: {reader["ReturnDate"]:d}\n" +
                                                              $"Total Slots: {reader["TotalSlots"]}\n" +
                                                              $"Available Slots: {reader["AvailableSlots"]}\n" +
                                                              $"Category: {reader["CategoryName"]}\n" +
                                                             
                                                              "This trip has been canceled.";
                                    }
                                    else
                                    {
                                        confirmationMessage = $"Trip ID: {reader["TripID"]}\n" +
                                                              $"Price: {reader["Price"]:C}\n" +
                                                              $"Departure Date: {reader["DepartureDate"]:d}\n" +
                                                              $"Return Date: {reader["ReturnDate"]:d}\n" +
                                                              $"Total Slots: {reader["TotalSlots"]}\n" +
                                                              $"Available Slots: {reader["AvailableSlots"]}\n" +
                                                              $"Category: {reader["CategoryName"]}\n";
                                                             
                                    }

                                    MessageBox.Show(confirmationMessage, "Trip Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No details found for this trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading confirmation: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to view the confirmation.");
            }
        }


         private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       }
    }
}
