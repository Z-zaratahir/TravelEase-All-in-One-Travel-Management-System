using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsAppProject
{
    public partial class etickets : UserControl
    {
        private int travelerID;
        public etickets(int userID)
        {
            InitializeComponent();
            travelerID = userID;  
            this.Load += new EventHandler(etickets_Load);
        }

        private async void etickets_Load(object sender, EventArgs e)
        {
           
            await LoadAvailableTrips();  
        }

        private async Task LoadAvailableTrips()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
        SELECT t.TripID
        FROM Trip t
        INNER JOIN BookingAttempt ba ON ba.TripID = t.TripID
        JOIN Booking b ON b.AttemptID = ba.AttemptID
        WHERE ba.TravelerID = @TravelerID";  

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
                            tripIDcbox.Items.Clear();

                            while (await reader.ReadAsync())
                            {
                                tripIDcbox.Items.Add(Convert.ToInt32(reader["TripID"]));
                            }

                            if (tripIDcbox.Items.Count > 0)
                                tripIDcbox.SelectedIndex = 0;  
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private async Task LoadTripDetails(int selectedTripID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
        SELECT 
            t.TripID,
            td.Destination,
            t.DepartureDate,
            t.ReturnDate,
            b.NumberOfPeople AS GroupSize,
            t.Price,
            ba.IsCompleted AS PaymentStatus,
            h.HotelName,
            a.ActivityID, -- Fetch ActivityID
            a.Activity,-- Fetch Activity Name
            tp.PassID
        FROM 
            Trip t
        JOIN
            TripDestinations td ON td.TripID = t.TripID
        INNER JOIN 
            BookingAttempt ba ON ba.TripID = t.TripID
        JOIN
            Booking b ON b.AttemptID = ba.AttemptID
        LEFT JOIN 
            Hotel h ON h.ProviderID = t.ProviderID
        LEFT JOIN 
            TourCategoryActivities a ON a.CategoryID = t.CategoryID
        Join
            TravelPass tp ON tp.BookingID=b.BookingID
        WHERE 
            ba.TravelerID = @TravelerID AND t.TripID = @SelectedTripID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);
                        cmd.Parameters.AddWithValue("@SelectedTripID", selectedTripID);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            activity.Rows.Clear();

                            if (await reader.ReadAsync())
                            {
                                destination.Text = reader["Destination"].ToString();
                                departuredate.Text = Convert.ToDateTime(reader["DepartureDate"]).ToString("MM/dd/yyyy");
                                returndate.Text = Convert.ToDateTime(reader["ReturnDate"]).ToString("MM/dd/yyyy");
                                totalpeople.Text = reader["GroupSize"].ToString();
                                price.Text = "$" + reader["Price"].ToString();
                                paymentstatus.Text = reader["PaymentStatus"].ToString() == "1" ? "Completed" : "Pending";
                                hotelname.Text = reader["HotelName"].ToString();
                               
                                transportprovider.Text = reader["PassID"].ToString(); // Assuming you need PassID for transport
                               while (await reader.ReadAsync())
                                {

                                   activity.Rows.Add(
                                        reader["ActivityID"].ToString(),
                                        reader["Activity"].ToString()
                                    );
                                }
                            }

                           if (activity.Rows.Count == 0)
                            {
                                label7.Text = "No activities available for this trip.";
                            }
                            else
                            {
                                label7.Text = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trip details: " + ex.Message);
                }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Save Travel Pass as PNG";
                saveDialog.FileName = "TravelPass.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = @"D:\Semester04\DB\Project\Images\travelTicket.png"; // Adjust path
                    File.Copy(sourcePath, saveDialog.FileName, true);
                    MessageBox.Show("Download complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void mybookings_Load(object sender, EventArgs e)
        {

        }
        async private void tripIDcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTripID = Convert.ToInt32(tripIDcbox.SelectedItem);

            await LoadTripDetails(selectedTripID);
        }

        private void activity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dwvoucherb_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Save Travel Pass as PNG";
                saveDialog.FileName = "TravelPass.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = @"D:\Semester04\DB\Project\Images\travelTicket.png"; // Adjust path
                    File.Copy(sourcePath, saveDialog.FileName, true);
                    MessageBox.Show("Download complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dwpassb_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Save Travel Pass as PNG";
                saveDialog.FileName = "TravelPass.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = @"D:\Semester04\DB\Project\Images\travelTicket.png"; // Adjust path
                    File.Copy(sourcePath, saveDialog.FileName, true);
                    MessageBox.Show("Download complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
