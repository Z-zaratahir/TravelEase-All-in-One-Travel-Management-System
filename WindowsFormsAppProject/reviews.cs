using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class reviews : UserControl
    {
        private int travelerID;  

        public reviews(int userID)
        {
            InitializeComponent();
            travelerID = userID;  
            this.Load += new EventHandler(reviews_Load);
        }

        private async void reviews_Load(object sender, EventArgs e)
        {
            MessageBox.Show("In Reviews_Load: ");
            await LoadTripsForReview(travelerID);
            await LoadTravelerReviews(travelerID); 
        }

       private async Task LoadTripsForReview(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT t.TripID, t.CategoryID, t.DepartureDate, t.Price 
                FROM Trip t
                INNER JOIN BookingAttempt ba ON ba.TripID = t.TripID
                INNER JOIN Booking b ON b.AttemptID = ba.AttemptID
                WHERE ba.TravelerID = @TravelerID AND ba.IsCompleted = 1"; 
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
                            comboBox1.Items.Clear();

                            while (await reader.ReadAsync())
                            {
                                string tripDetails = $"{reader["CategoryID"]} - {reader["DepartureDate"]} - ${reader["Price"]}";
                                comboBox1.Items.Add(new ComboBoxItem
                                {
                                    Text = tripDetails,
                                    Value = Convert.ToInt32(reader["TripID"])

                                });
                            }

                            if (comboBox1.Items.Count > 0)
                                comboBox1.SelectedIndex = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
           
        }

        private async Task<int> GetOperatorIDForTrip(int tripID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = "SELECT OperatorID FROM Trip WHERE TripID = @TripID";
            int operatorID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TripID", tripID);
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != DBNull.Value)
                        {
                            operatorID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching operator ID: " + ex.Message);
                }
            }

            return operatorID;
        }

        private async Task InsertReview(int tripID, int rating, DateTime reviewDate, string comment, int operatorID)
        {
           
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                INSERT INTO Review (Rating, ReviewDate, Comment, OperatorID, TravelerID, TripID, AdminID)
                VALUES (@Rating, @ReviewDate, @Comment, @OperatorID, @TravelerID, @TripID, NULL);";  // AdminID is NULL

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@ReviewDate", reviewDate);
                        cmd.Parameters.AddWithValue("@Comment", comment);
                        cmd.Parameters.AddWithValue("@OperatorID", operatorID);
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID);
                        cmd.Parameters.AddWithValue("@TripID", tripID);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your review has been submitted!");
                            LoadTravelerReviews(travelerID);
                        }
                        else
                        {
                            MessageBox.Show("Error submitting the review.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting review: " + ex.Message);
                }
            }
        }
    

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reviewb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reviewb4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reviewb5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reviewb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reviewb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       async private void button1_Click(object sender, EventArgs e)//submit button
        {
            MessageBox.Show("Inserting Review!");
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            int selectedTripID = ((ComboBoxItem)comboBox1.SelectedItem).Value;
            int rating=0;
            if (reviewb1.Checked) rating= 1;   
            if (reviewb2.Checked) rating = 2;  
            if (reviewb3.Checked) rating = 3;   
            if (reviewb4.Checked) rating = 4;  
            if (reviewb5.Checked) rating = 5;   
            string comment = richTextBox1.Text;
            DateTime reviewDate = DateTime.Now;
            int operatorID = await GetOperatorIDForTrip(selectedTripID);  

            await InsertReview(selectedTripID, rating, reviewDate, comment, operatorID);
        }
        private async Task LoadTravelerReviews(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT r.ReviewID, r.Rating, r.ReviewDate, r.Comment
                FROM Review r
                INNER JOIN Trip t ON r.TripID = t.TripID
                WHERE r.TravelerID = @TravelerID";  

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
                            dataGridView1.Rows.Clear();

                            int rowCount = 0;

                            while (await reader.ReadAsync())
                            {
                                dataGridView1.Rows.Add(
                                    reader["ReviewID"],
                                    reader["Rating"],
                                    reader["ReviewDate"],
                                    reader["Comment"]
                                );
                                
                            }

                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reviews: " + ex.Message);
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
