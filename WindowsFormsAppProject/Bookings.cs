using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Bookings : Form
    {
        private int tripID;
        private int travelerID;
        private decimal tripPrice;

        public Bookings(int tripID, int travelerID)
        {
            InitializeComponent();
            this.tripID = tripID;
            this.travelerID = travelerID;
        }

        private async void Bookings_Load(object sender, EventArgs e)
        {
           
            comboBox1.Items.Add("Credit Card");
            comboBox1.Items.Add("PayPal");
            comboBox1.Items.Add("Bank Transfer");

            comboBox1.SelectedIndex = 0;

            await LoadTravelerDetails(travelerID);  
            await LoadTripDetails(tripID);         

            numericUpDown1.ValueChanged += new EventHandler(GroupSizeChanged);
            comboBox1.SelectedIndexChanged += new EventHandler(PaymentMethodChanged);
        }

        private async Task LoadTravelerDetails(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT p.FName, p.CNIC
                FROM Person p
                WHERE p.Registration = @TravelerID";

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
                            if (await reader.ReadAsync())
                            {
                                travelername.Text = reader["FName"].ToString();  
                                cnic.Text = reader["CNIC"].ToString();          
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading traveler details: " + ex.Message);
                }
            }
        }

        private async Task LoadTripDetails(int tripID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT tc.CategoryName, t.DepartureDate, t.Price
                FROM Trip t
                JOIN TourCategories tc ON t.CategoryID = tc.CategoryID
                WHERE t.TripID = @TripID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TripID", tripID);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tripPrice = Convert.ToDecimal(reader["Price"]); 
                                tripcategory.Text = reader["CategoryName"].ToString(); 
                                departuredate.Text = Convert.ToDateTime(reader["DepartureDate"]).ToString("MM/dd/yyyy"); 
                                price.Text = "$" + tripPrice.ToString(); 
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

        private void UpdateTotalAmount()
        {
            int groupSize = (int)numericUpDown1.Value; 
            decimal totalAmount = tripPrice * groupSize;  

            string selectedPaymentMethod = comboBox1.SelectedItem.ToString();
            if (selectedPaymentMethod == "Credit Card")
            {
                totalAmount += totalAmount * 0.02m;  
            }
            else if (selectedPaymentMethod == "PayPal")
            {
                totalAmount += totalAmount * 0.03m;  
            }

            label9.Text = "$" + totalAmount.ToString("F2");
        }

        private void GroupSizeChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount(); 
        }

        private void PaymentMethodChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount(); 
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int newAttemptID = await GetNextAttemptID();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string insertBookingAttemptQuery = @"
                    INSERT INTO BookingAttempt (AttemptID, AttemptDate, IsCompleted, TravelerID, TripID)
                    VALUES (@AttemptID, @AttemptDate, 0, @TravelerID, @TripID)"; 
                    using (SqlCommand cmd = new SqlCommand(insertBookingAttemptQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@AttemptID", newAttemptID);
                        cmd.Parameters.AddWithValue("@AttemptDate", DateTime.Now); 
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);
                        cmd.Parameters.AddWithValue("@TripID", tripID);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking attempt created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error creating booking attempt.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task<int> GetNextAttemptID()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int nextAttemptID = 1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT MAX(AttemptID) FROM BookingAttempt";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        var result = await cmd.ExecuteScalarAsync();

                        if (result != DBNull.Value)
                        {
                            nextAttemptID = Convert.ToInt32(result) + 1; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next AttemptID: " + ex.Message);
            }

            return nextAttemptID;
        }

        private async void makepayment_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = comboBox1.SelectedItem.ToString();
            decimal totalAmount = Convert.ToDecimal(label9.Text.Replace("$", ""));  // Assuming totalAmountLabel is the label showing total amount

            if (string.IsNullOrEmpty(selectedPaymentMethod) || totalAmount <= 0)
            {
                MessageBox.Show("Please select a valid payment method and ensure the total amount is greater than zero.");
                return;
            }

            var confirmPaymentDialog = MessageBox.Show($"Are you sure you want to pay {totalAmount:C} using {selectedPaymentMethod}?",
                                                        "Confirm Payment", MessageBoxButtons.YesNo);

            if (confirmPaymentDialog == DialogResult.Yes)
            {
               await ProcessPayment(totalAmount, selectedPaymentMethod);
            }
        }

        private async Task ProcessPayment(decimal totalAmount, string paymentMethod)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            try
            {
                 string updateBookingAttemptQuery = @"
            UPDATE BookingAttempt 
            SET IsCompleted = 1 
            WHERE TravelerID = @TravelerID AND TripID = @TripID AND IsCompleted = 0";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(updateBookingAttemptQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);
                        cmd.Parameters.AddWithValue("@TripID", tripID);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking attempt marked as completed!");
                        }
                        else
                        {
                            MessageBox.Show("Error updating booking attempt.");
                            return;
                        }
                    }
                }

               int adminID = 1;  
                int paymentID = await InsertPaymentRecord(totalAmount, paymentMethod);
                int bookingID = await GetLastBookingID();
                
                string insertBookingQuery = @"
            INSERT INTO Booking (BookingID, TotalAmount, NumberOfPeople, Date, AdminID, PaymentID, AttemptID) 
            VALUES (@bookingID,@TotalAmount, @NumberOfPeople, @Date, @AdminID, @PaymentID, @AttemptID)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(insertBookingQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@NumberOfPeople", numericUpDown1.Value); 
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now); 
                        cmd.Parameters.AddWithValue("@AdminID", adminID); 
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID); 
                        cmd.Parameters.AddWithValue("@AttemptID", await GetLastBookingAttemptID()); 

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment successful and booking completed!");
                        }
                        else
                        {
                            MessageBox.Show("Error inserting booking.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }

        private async Task<int> InsertPaymentRecord(decimal totalAmount, string paymentMethod)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int paymentID = await GetLastPaymentID();

            try
            {
                string insertPaymentQuery = @"
            INSERT INTO Payment (PaymentID,Date, PaymentMethod,TravelerID) 
            OUTPUT INSERTED.PaymentID
            VALUES (@paymentID,getdate(), @PaymentMethod,@travelerID)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        cmd.Parameters.AddWithValue("@Amount", totalAmount);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                        paymentID = (int)await cmd.ExecuteScalarAsync(); // Get the inserted PaymentID

                        if (paymentID == 0)
                        {
                            MessageBox.Show("Error processing payment.");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment record: " + ex.Message);
            }

            return paymentID;
        }
        
        private async Task<int> GetLastBookingAttemptID()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int attemptID = 0;

            try
            {
                string query = "SELECT MAX(AttemptID) FROM BookingAttempt";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = await cmd.ExecuteScalarAsync();
                        attemptID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving AttemptID: " + ex.Message);
            }

            return attemptID;
        }
        private async Task<int> GetLastBookingID()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int attemptID = 0;

            try
            {
                string query = "SELECT MAX(BookingID) FROM Booking";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = await cmd.ExecuteScalarAsync();
                        attemptID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        attemptID += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving AttemptID: " + ex.Message);
            }

            return attemptID;
        }
        private async Task<int> GetLastPaymentID()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            int attemptID = 0;

            try
            {
                string query = "SELECT MAX(PaymentID) FROM  Payment";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = await cmd.ExecuteScalarAsync();
                        attemptID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        attemptID += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving AttemptID: " + ex.Message);
            }

            return attemptID;
        }
        private void travelername_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cnic_Click(object sender, EventArgs e)
        {

        }

    }
}



