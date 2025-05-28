using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class searchTrip : UserControl
    {
        private int travelerID;
        public searchTrip(int travelerID)
        {
            InitializeComponent();
            this.travelerID = travelerID;
        }

        private async void searchTrip_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adventure Tours");
            comboBox1.Items.Add("Beach Holidays");
            comboBox1.Items.Add("Cultural Tours");
            comboBox1.Items.Add("Family Packages");
            comboBox1.Items.Add("Luxury Cruises");
            comboBox1.Items.Add("Historical Tours");
            comboBox1.Items.Add("Nature Escapes");
            comboBox1.Items.Add("Wildlife Safari");
            comboBox1.Items.Add("Adventure Sports");
            comboBox1.Items.Add("Eco-Friendly Tours");

            comboBox1.SelectedIndex = 0; 
            numericUpDown1.Minimum = 0;     
            numericUpDown1.Maximum = 10000; 
            numericUpDown1.Increment = 100; 
            numericUpDown1.DecimalPlaces = 0;  
            await LoadTrips(null, null, null, null);  
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string category = comboBox1.SelectedItem?.ToString(); 
            DateTime? departureDate = dateTimePicker1.Value < DateTime.Now ? (DateTime?)null : dateTimePicker1.Value;  
            DateTime? returnDate = dateTimePicker2.Value < DateTime.Now ? (DateTime?)null : dateTimePicker2.Value;
            decimal? budgetRange = numericUpDown1.Value > 0 ? numericUpDown1.Value : (decimal?)null; 

            await LoadTrips(category, departureDate, returnDate, budgetRange);
        }

        private async Task LoadTrips(string category, DateTime? departureDate, DateTime? returnDate, decimal? budgetRange)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
        SELECT 
            t.TripID,
            c.CategoryName,
            t.DepartureDate,
            t.ReturnDate,
            t.Price,
            t.AvailableSlots
        FROM 
            Trip t
        INNER JOIN 
            TourCategories c ON t.CategoryID = c.CategoryID
        WHERE 
            t.DepartureDate >= GETDATE()";  
            if (category != null)
                query += " AND c.CategoryName = @Category";

            if (departureDate.HasValue)
                query += " AND t.DepartureDate >= @DepartureDate";

            if (returnDate.HasValue)
                query += " AND t.ReturnDate <= @ReturnDate";

            if (budgetRange.HasValue)
                query += " AND t.Price <= @BudgetRange";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (category != null)
                            cmd.Parameters.AddWithValue("@Category", category);

                        if (departureDate.HasValue)
                            cmd.Parameters.AddWithValue("@DepartureDate", departureDate.Value);

                        if (returnDate.HasValue)
                            cmd.Parameters.AddWithValue("@ReturnDate", returnDate.Value);

                        if (budgetRange.HasValue)
                            cmd.Parameters.AddWithValue("@BudgetRange", budgetRange.Value);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataGridView1.Rows.Clear();

                            int rowCount = 0; 
                            while (await reader.ReadAsync())
                            {
                                dataGridView1.Rows.Add(
                                    reader["TripID"],
                                    reader["CategoryName"],
                                    reader["DepartureDate"],
                                    reader["ReturnDate"],
                                    reader["Price"],
                                    reader["AvailableSlots"]
                                );

                                rowCount++;  
                            }

                            label7.Text = $"{rowCount} results appeared";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }


        private void bookb_Click(object sender, EventArgs e)
        {
        }

        private void addToWishlistb_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
       

    

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)//add to wishlist
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTripID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TripID"].Value);
                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

                string checkWishlistQuery = "SELECT WishListID FROM WishList WHERE TravelerID = @TravelerID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        using (SqlCommand cmd = new SqlCommand(checkWishlistQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@TravelerID", travelerID);

                            object result = await cmd.ExecuteScalarAsync(); 

                            int wishListID;

                            if (result != DBNull.Value)  
                            {
                                wishListID = Convert.ToInt32(result);  
                            }
                            else  // If no wishlist exists, create a new one
                            {
                                // Step 2: Create a new wishlist for the traveler
                                string createWishlistQuery = "INSERT INTO WishList (TravelerID) OUTPUT INSERTED.WishListID VALUES (@TravelerID)";

                                using (SqlCommand createWishlistCmd = new SqlCommand(createWishlistQuery, connection))
                                {
                                    createWishlistCmd.Parameters.AddWithValue("@TravelerID", travelerID);
                                    wishListID = (int)await createWishlistCmd.ExecuteScalarAsync();  // Get the new WishListID
                                }
                            }

                            // Step 3: Add the selected trip to the wishlist
                            string addTripToWishlistQuery = "INSERT INTO WishList_Contains (WishListID, TripID, DateAdded, IsNotified) VALUES (@WishListID, @TripID, GETDATE(), 0)";

                            using (SqlCommand addTripCmd = new SqlCommand(addTripToWishlistQuery, connection))
                            {
                                addTripCmd.Parameters.AddWithValue("@WishListID", wishListID);
                                addTripCmd.Parameters.AddWithValue("@TripID", selectedTripID);

                                int rowsAffected = await addTripCmd.ExecuteNonQueryAsync();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Trip added to your wishlist!");
                                }
                                else
                                {
                                    MessageBox.Show("Error adding trip to wishlist.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to add to the wishlist.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTripID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TripID"].Value);

                // Create an instance of the Bookings form
                Bookings bookingsForm = new Bookings(selectedTripID,travelerID);  // Replace 'Bookings' with the actual name of the form class

                // Show the Bookings form as a non-modal dialog (it will stay open while the current form is also open)
                bookingsForm.Show();
            }
            else
            {
                MessageBox.Show("Select a Trip First!");
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;  // Reset to first category (e.g., "Adventure Tours")
            dateTimePicker1.Value = DateTime.Now; // Reset Departure Date to current date
            dateTimePicker2.Value = DateTime.Now; // Reset Return Date to current date
            numericUpDown1.Value = 0;  // Reset Budget Range to 0

            LoadTrips(null, null, null, null);// Reload trips without filters (show all available trips)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

