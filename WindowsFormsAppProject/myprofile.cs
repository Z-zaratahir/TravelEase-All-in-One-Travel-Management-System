using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class myprofile : UserControl
    {
        private int travelerID;

        public myprofile(int userID)
        {
            InitializeComponent();
            travelerID = userID;  
            this.Load += new EventHandler(myprofile_Load);
        }

        private async void myprofile_Load(object sender, EventArgs e)
        {
            await LoadTravelerProfile(travelerID);  
            await LoadPastTrips(travelerID);  
            await LoadPreferences();
            await LoadTravelerPreferences(travelerID);
        }

        private async Task LoadTravelerProfile(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    p.FName,
                    p.ZipCode,
                    u.Password,
                    p.DOB
                FROM 
                    Traveler t
                Join Person p
                on t.TravelerID=p.Registration
                Join [User] u
                on u.UserID=t.TravelerID
                WHERE 
                    TravelerID = @TravelerID";

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
                                nametextb.Text = reader["FName"].ToString();
                                zipcodetextb.Text = reader["ZipCode"].ToString();
                               
                                dobtextb.Text = reader["DOB"].ToString();
                                textBox2.Text = reader["Password"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile data: " + ex.Message);
                }
            }
        }

        private async Task LoadPastTrips(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    b.BookingID, 
                    t.TripID, 
                    b.Date AS BookingDate, 
                    t.DepartureDate, 
                    t.ReturnDate, 
                    t.Price
                FROM 
                    Booking b
                INNER JOIN 
                    BookingAttempt ba on ba.AttemptID=b.AttemptID
                Join
                    Trip t ON ba.TripID = t.TripID
                WHERE 
                    ba.TravelerID = @TravelerID"; 
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

                            while (await reader.ReadAsync())
                            {
                                dataGridView1.Rows.Add(
                                    reader["TripID"],
                                    reader["BookingID"],
                                    reader["DepartureDate"],
                                    reader["ReturnDate"],
                                    reader["Price"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading past trips: " + ex.Message);
                }
            }
        }

        private async void updatechangesb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametextb.Text) || string.IsNullOrEmpty(zipcodetextb.Text) ||
                string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(dobtextb.Text))  // Check for DOB field as well
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            string query = @"
        UPDATE [User]
        SET 
            
            Password = @Password
        WHERE UserID = @TravelerID;

        UPDATE Person
        SET 
            ZipCode = @ZipCode,
            FName = @Name,
            DOB = @DOB
        WHERE Registration = @TravelerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                       cmd.Parameters.AddWithValue("@Name", nametextb.Text);  
                        cmd.Parameters.AddWithValue("@ZipCode", zipcodetextb.Text); 
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);  
                        cmd.Parameters.AddWithValue("@TravelerID", travelerID); 
                        cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dobtextb.Text));  

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");
                            await LoadTravelerProfile(travelerID); 
                        }
                        else
                        {
                            MessageBox.Show("Error updating profile.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating profile: " + ex.Message);
                }
            }
        }

        private async Task LoadPreferences()

        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = "SELECT PreferenceID, BudgetRange FROM Preferences";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataGridView2.Rows.Clear();

                            while (await reader.ReadAsync())
                            {
                                dataGridView2.Rows.Add(
                                    reader["PreferenceID"],
                                    reader["BudgetRange"]
                                );
                            }

                            MessageBox.Show("Preferences Added! " );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading preferences: " + ex.Message);
                }
            }
        }

        private async Task LoadTravelerPreferences(int travelerID)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            string query = @"
        SELECT 
            p.PreferenceID, 
            p.BudgetRange
        FROM 
            Traveler_Preference tp
        INNER JOIN 
            Preferences p ON tp.PreferenceID = p.PreferenceID
        WHERE 
            tp.TravelerID = @TravelerID";  

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
                           dataGridView3.Rows.Clear();

                            while (await reader.ReadAsync())
                            {
                                dataGridView3.Rows.Add(
                                    reader["PreferenceID"],
                                    reader["BudgetRange"]
                                );
                            }
                            MessageBox.Show("Traveler Preferences Added! ");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading traveler preferences: " + ex.Message);
                }
            }
        }


        private void nametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodetextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void tidtextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void statuscombob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dobtextb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernameb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedPreferenceID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["PreferenceID"].Value);
                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                string query = "INSERT INTO Traveler_Preference (PreferenceID, TravelerID) VALUES (@PreferenceID, @TravelerID)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        await connection.OpenAsync();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@PreferenceID", selectedPreferenceID);
                            cmd.Parameters.AddWithValue("@TravelerID", travelerID);  

                            int rowsAffected = await cmd.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Preference added successfully!");
                                await LoadTravelerPreferences(travelerID);
                            }
                            else
                            {
                                MessageBox.Show("Error adding preference.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding preference: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a preference to add.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
