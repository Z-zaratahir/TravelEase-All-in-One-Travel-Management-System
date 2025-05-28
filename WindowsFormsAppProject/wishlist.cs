using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class wishlist : UserControl
    {
        private int travelerID;  // Traveler ID to fetch wishlist items

        public wishlist(int userID)
        {
          
            InitializeComponent();
            travelerID = userID;  // Store the traveler ID for fetching wishlist data
            this.Load += new EventHandler(wishlist_Load); // Attach the Load event


        }

        // Form Load event to load wishlist data
        private async void wishlist_Load(object sender, EventArgs e)
        {
           
            await LoadWishList(travelerID);  // Load wishlist items when the form loads
        }


        // Method to load the wishlist items for the logged-in traveler
        private async Task LoadWishList(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
        SELECT 
            w.WishListItemID,
            t.TripID,
            t.CategoryID,
            t.DepartureDate,
            t.Price,
            w.DateAdded,
            w.IsNotified
        FROM 
            WishList_Contains w
        INNER JOIN 
            Trip t ON w.TripID = t.TripID
        WHERE 
            w.WishListID = (SELECT WishListID FROM WishList WHERE TravelerID = @TravelerID)";

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
                           // Show traveler ID for debugging

                            // Clear the DataGridView before adding new data
                            dataGridView1.Rows.Clear();

                            int rowCount = 0; // To count rows and check if any data is retrieved

                            while (await reader.ReadAsync())
                            {
                                dataGridView1.Rows.Add(
                                    reader["WishListItemID"],
                                    reader["TripID"],
                                    reader["CategoryID"],
                                    reader["DepartureDate"],
                                    reader["Price"],
                                    reader["DateAdded"]
                                );
                                rowCount++; // Increment the row count
                            }

                            // If no rows exist, show the "No items in wishlist" label
                            if (rowCount == 0)
                            {
                                label7.Text = "Your wishlist is empty.";
                            }
                            else
                            {
                                label7.Text = ""; // Clear the label when there are wishlist items
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading wishlist: " + ex.Message);
                }
            }
        }


        // Handle Remove from Wishlist button click
        private async void removeb_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedItemID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemID"].Value);

                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                string removeQuery = "DELETE FROM WishList_Contains WHERE WishListItemID = @WishListItemID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        await connection.OpenAsync();

                        using (SqlCommand cmd = new SqlCommand(removeQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@WishListItemID", selectedItemID);

                            int rowsAffected = await cmd.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Trip removed from wishlist.");
                                await LoadWishList(travelerID); // Reload wishlist after removal
                            }
                            else
                            {
                                MessageBox.Show("Error removing trip from wishlist.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error removing trip: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to remove.");
            }
        }

        // Handle Notify button click (optional functionality)
        private async void notifyb_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            // Query to find trips in the wishlist with missed departure dates or low available slots
            string query = @"
        SELECT 
            t.TripID,
            t.DepartureDate,
            t.AvailableSlots,
            t.Price,
            t.CategoryID
        FROM 
            Trip t
        INNER JOIN 
            WishList_Contains w ON w.TripID = t.TripID
        INNER JOIN 
            WishList wl ON wl.WishListID = w.WishListID
        WHERE 
            wl.TravelerID = @TravelerID  -- Ensure the trip is in the user's wishlist
        AND 
            (t.DepartureDate < GETDATE()  -- Trips whose departure date has passed
            OR 
            t.AvailableSlots < 20)"; 

    // Initialize lists to store missed and low availability trip details
    List<string> missedTrips = new List<string>();
            List<string> lowAvailabilityTrips = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);  // Passing the TravelerID

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            // Loop through the query results and categorize the trips
                            while (await reader.ReadAsync())
                            {
                                int tripID = Convert.ToInt32(reader["TripID"]);
                                DateTime departureDate = Convert.ToDateTime(reader["DepartureDate"]);
                                int availableSlots = Convert.ToInt32(reader["AvailableSlots"]);
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                int categoryID = Convert.ToInt32(reader["CategoryID"]);

                                // Add missed trips (departure date has passed)
                                if (departureDate < DateTime.Now)
                                {
                                    missedTrips.Add($"TripID: {tripID}, Price: {price}, Departure Date: {departureDate.ToShortDateString()}");
                                }

                                // Add trips with low available slots
                                if (availableSlots < 20)
                                {
                                    lowAvailabilityTrips.Add($"TripID: {tripID}, Available Slots: {availableSlots}, Price: {price}");
                                }
                            }

                            // Construct the message
                            StringBuilder message = new StringBuilder();

                            if (missedTrips.Count > 0)
                            {
                                message.AppendLine("Missed Trips (Departure Date Passed):");
                                foreach (var trip in missedTrips)
                                {
                                    message.AppendLine(trip);
                                }
                            }
                            else
                            {
                                message.AppendLine("No missed trips.");
                            }

                            if (lowAvailabilityTrips.Count > 0)
                            {
                                message.AppendLine("\nTrips with Low Available Slots:");
                                foreach (var trip in lowAvailabilityTrips)
                                {
                                    message.AppendLine(trip);
                                }
                            }
                            else
                            {
                                message.AppendLine("\nNo trips with low available slots.");
                            }

                            // Display the notification message
                            MessageBox.Show(message.ToString(), "Trip Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while fetching trip notifications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // This event handles cell content clicks in the DataGridView (if needed)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle row or cell click events here if necessary
            // For example, you could navigate to another page or show more details for the clicked trip.
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
