using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppProject
{
    public partial class TourOperatorTrips : UserControl
    {
        public TourOperatorTrips()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.AutoScroll = false;
            // Set size to match parent panel
            //this.Size = new Size(925, 445);
            this.Size = new Size(897, 400);

            SetControlStyles();
            AdjustControlPositions();
            LoadTripsData();
            this.Load += OnControlLoaded;
        }

        private void AdjustControlPositions()
        {
            // Center the trip management label
            labelTrips.Left = (this.Width - labelTrips.Width) / 2 ;
            labelTrips.Top = 5;
            labelTrips.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Position the data grid view - make it narrower to fit
            tripsDataGridView.Width = this.Width - 20;
            tripsDataGridView.Left = 23;
            tripsDataGridView.Height = 160;
            tripsDataGridView.Top = 35;
            
            // Position the trip details panel - make it smaller to fit
            tripDetailsPanel.Width = tripsDataGridView.Width;
            tripDetailsPanel.Left = tripsDataGridView.Left;
            tripDetailsPanel.Height = 230;
            tripDetailsPanel.Top = tripsDataGridView.Bottom + 10;

            // Adjust font sizes for all controls
            foreach (Control ctrl in tripDetailsPanel.Controls)
            {
                if (ctrl is Label && ctrl != labelDetails)
                {
                    ctrl.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                }
                else if (ctrl is TextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is NumericUpDown)
                {
                    ctrl.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                }
            }

            // Position button controls toward right edge
            createTripButton.Location = new Point(tripDetailsPanel.Width - 140, 50);
            createTripButton.Size = new Size(120, 30);
            
            updateTripButton.Location = new Point(tripDetailsPanel.Width - 140, 90);
            updateTripButton.Size = new Size(120, 30);
            
            deleteTripButton.Location = new Point(tripDetailsPanel.Width - 140, 130);
            deleteTripButton.Size = new Size(120, 30);

            // Make detail panel labels and inputs more compact
            int labelY = 40;
            int increment = 25; // Smaller spacing between controls
            
            labelTripName.Location = new Point(10, labelY);
            textBoxTripName.Location = new Point(90, labelY);
            textBoxTripName.Size = new Size(200, 22);
            
            labelY += increment;
            labelDestination.Location = new Point(10, labelY);
            textBoxDestination.Location = new Point(90, labelY);
            textBoxDestination.Size = new Size(200, 22);
            
            labelY += increment;
            labelCategory.Location = new Point(10, labelY);
            comboBoxCategory.Location = new Point(90, labelY);
            comboBoxCategory.Size = new Size(200, 22);
            
            labelY += increment;
            labelStartDate.Location = new Point(10, labelY);
            dateTimePickerStart.Location = new Point(90, labelY);
            dateTimePickerStart.Size = new Size(200, 22);
            
            labelY += increment;
            labelEndDate.Location = new Point(10, labelY);
            dateTimePickerEnd.Location = new Point(90, labelY);
            dateTimePickerEnd.Size = new Size(200, 22);
            
            labelY += increment;
            labelPrice.Location = new Point(10, labelY);
            textBoxPrice.Location = new Point(90, labelY);
            textBoxPrice.Size = new Size(200, 22);
            
            labelY += increment;
            labelCapacity.Location = new Point(10, labelY);
            numericUpDownCapacity.Location = new Point(90, labelY);
            numericUpDownCapacity.Size = new Size(200, 22);

            // Description and inclusions - moved to fit better
            labelDescription.Location = new Point(320, 40);
            textBoxDescription.Location = new Point(320, 60);
            textBoxDescription.Size = new Size(300, 70);
            
            labelInclusions.Location = new Point(320, 140);
            textBoxInclusions.Location = new Point(320, 160);
            textBoxInclusions.Size = new Size(300, 60);
            
            // Make the details header smaller
            labelDetails.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            labelDetails.Location = new Point(10, 10);
        }

        private void SetControlStyles()
        {
            // Set transparent background for labels
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                    control.ForeColor = Color.Black;
                }
            }

            // Customize the DataGridView
            tripsDataGridView.BorderStyle = BorderStyle.FixedSingle;
            tripsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 213, 234);
            tripsDataGridView.EnableHeadersVisualStyles = false;
            tripsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 164, 211);
            tripsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tripsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            tripsDataGridView.RowHeadersWidth = 25;
            tripsDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            
            // Adjust column widths to fit smaller screen
            tripsDataGridView.Columns["TripID"].Width = 50;
            tripsDataGridView.Columns["TripName"].Width = 150;
            tripsDataGridView.Columns["Destination"].Width = 150;
            tripsDataGridView.Columns["Category"].Width = 100;
            tripsDataGridView.Columns["StartDate"].Width = 90;
            tripsDataGridView.Columns["EndDate"].Width = 90;
            tripsDataGridView.Columns["Capacity"].Width = 70;
            tripsDataGridView.Columns["Price"].Width = 70;
            tripsDataGridView.Columns["Status"].Width = 80;
            
            // Trip details panel to match Form1's styling
            tripDetailsPanel.BackColor = Color.White;
            tripDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            
            // Style all buttons to match Form1
            StyleButtons(createTripButton);
            StyleButtons(updateTripButton);
            StyleButtons(deleteTripButton);

            // Set label for title
            labelTrips.BackColor = Color.Transparent;
            labelTrips.ForeColor = Color.Black;
            labelTrips.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void StyleButtons(Button button)
        {
            button.BackColor = Color.FromArgb(249, 175, 211);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.Black;
            button.Font = new Font("Segoe UI", 8, FontStyle.Bold);
        }

        private void LoadTripsData()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    t.TripID,
                    (SELECT TOP 1 i.Title FROM Itinerary i WHERE i.TripID = t.TripID ORDER BY i.DayNumber ASC) AS TripName,
                    (SELECT TOP 1 d.Destination FROM TripDestinations d WHERE d.TripID = t.TripID) AS Destination,
                    c.CategoryName AS Category,
                    t.DepartureDate AS StartDate,
                    t.ReturnDate AS EndDate,
                    t.TotalSlots AS Capacity,
                    t.Price,
                    t.TripStatus AS Status
                FROM Trip t
                LEFT JOIN TourCategories c ON t.CategoryID = c.CategoryID
                ORDER BY t.TripID
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tripsDataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        tripsDataGridView.Rows.Add(
                            reader["TripID"],
                            reader["TripName"],
                            reader["Destination"],
                            reader["Category"],
                            Convert.ToDateTime(reader["StartDate"]).ToString("MM/dd/yyyy"),
                            Convert.ToDateTime(reader["EndDate"]).ToString("MM/dd/yyyy"),
                            reader["Capacity"],
                            reader["Price"],
                            reader["Status"]
                        );
                    }
                }
            }
        }

        private void OnControlLoaded(object sender, EventArgs e)
        {
            // Additional initialization when control is loaded
            if (tripsDataGridView.Rows.Count > 0)
            {
                // Select the first row by default
                tripsDataGridView.Rows[0].Selected = true;
                DisplayTripDetails(0);
            }

            // Register a selection changed event for the grid
            tripsDataGridView.SelectionChanged += (s, args) => 
            {
                if (tripsDataGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = tripsDataGridView.SelectedRows[0].Index;
                    DisplayTripDetails(selectedIndex);
                }
            };
        }

        private void DisplayTripDetails(int rowIndex)
        {
            // Display selected trip details in the form fields
            if (rowIndex >= 0 && rowIndex < tripsDataGridView.Rows.Count)
            {
                DataGridViewRow row = tripsDataGridView.Rows[rowIndex];
                textBoxTripName.Text = row.Cells["TripName"].Value.ToString();
                textBoxDestination.Text = row.Cells["Destination"].Value.ToString();
                comboBoxCategory.Text = row.Cells["Category"].Value.ToString();
                
                // Parse dates
                if (DateTime.TryParse(row.Cells["StartDate"].Value.ToString(), out DateTime startDate))
                    dateTimePickerStart.Value = startDate;
                
                if (DateTime.TryParse(row.Cells["EndDate"].Value.ToString(), out DateTime endDate))
                    dateTimePickerEnd.Value = endDate;
                
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                
                // Parse capacity
                if (int.TryParse(row.Cells["Capacity"].Value.ToString(), out int capacity))
                    numericUpDownCapacity.Value = capacity;
                
                // Sample descriptions and inclusions
                textBoxDescription.Text = $"Experience the beauty of {row.Cells["Destination"].Value} with our {row.Cells["Category"].Value} package. This trip offers an unforgettable adventure for all travelers.";
                textBoxInclusions.Text = "✓ Hotel accommodation\n✓ Daily breakfast\n✓ Local guide\n✓ Transportation\n✓ Welcome dinner";
            }
        }

        private int GetCategoryIdByName(string categoryName)
        {
            string connectionString = "Data Source=DESKTOP-7U5G8UD\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID FROM TourCategories WHERE CategoryName = @CategoryName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int categoryId))
                        return categoryId;
                    else
                        throw new Exception("Category not found in database.");
                }
            }
        }

        private int GetDestinationIdByName(string destinationName)
        {
            string connectionString = "Data Source=DESKTOP-7U5G8UD\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DestinationID FROM Destinations WHERE Destination = @Destination";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Destination", destinationName);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int destinationId))
                        return destinationId;
                    else
                        throw new Exception("Destination not found in database.");
                }
            }
        }

        private void CreateTripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textBoxTripName.Text) || 
                    string.IsNullOrWhiteSpace(textBoxDestination.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxCategory.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Data Source=DESKTOP-7U5G8UD\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;";
                int categoryId = GetCategoryIdByName(comboBoxCategory.Text);
                int newTripId;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Generate new TripID
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(TripID), 0) + 1 FROM Trip", conn))
                    {
                        newTripId = (int)cmd.ExecuteScalar();
                    }
                    // Insert into Trip
                    string insertTrip = @"INSERT INTO Trip (TripID, CategoryID, DepartureDate, ReturnDate, TotalSlots, Price, TripStatus) VALUES (@TripID, @CategoryID, @DepartureDate, @ReturnDate, @TotalSlots, @Price, @TripStatus)";
                    using (SqlCommand cmd = new SqlCommand(insertTrip, conn))
                    {
                        cmd.Parameters.AddWithValue("@TripID", newTripId);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@DepartureDate", dateTimePickerStart.Value);
                        cmd.Parameters.AddWithValue("@ReturnDate", dateTimePickerEnd.Value);
                        cmd.Parameters.AddWithValue("@TotalSlots", (int)numericUpDownCapacity.Value);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                        cmd.Parameters.AddWithValue("@TripStatus", "Upcoming");
                        cmd.ExecuteNonQuery();
                    }
                    // Get new ItineraryID
                    int newItineraryId;
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(ItineraryID), 0) + 1 FROM Itinerary", conn))
                    {
                        newItineraryId = (int)cmd.ExecuteScalar();
                    }
                    string insertItinerary = @"INSERT INTO Itinerary (ItineraryID, TripID, DayNumber, Title) VALUES (@ItineraryID, @TripID, 1, @Title)";
                    using (SqlCommand cmd = new SqlCommand(insertItinerary, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItineraryID", newItineraryId);
                        cmd.Parameters.AddWithValue("@TripID", newTripId);
                        cmd.Parameters.AddWithValue("@Title", textBoxTripName.Text);
                        cmd.ExecuteNonQuery();
                    }
                    // Insert into TripDestinations
                    int destinationId = GetDestinationIdByName(textBoxDestination.Text);
                    string insertDest = @"INSERT INTO TripDestinations (TripID, DestinationID) VALUES (@TripID, @DestinationID)";
                    using (SqlCommand cmd = new SqlCommand(insertDest, conn))
                    {
                        cmd.Parameters.AddWithValue("@TripID", newTripId);
                        cmd.Parameters.AddWithValue("@DestinationID", destinationId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Trip created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTripsData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tripsDataGridView.SelectedRows.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(textBoxTripName.Text) || 
                        string.IsNullOrWhiteSpace(textBoxDestination.Text) ||
                        string.IsNullOrWhiteSpace(comboBoxCategory.Text) ||
                        string.IsNullOrWhiteSpace(textBoxPrice.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string connectionString = "Data Source=DESKTOP-7U5G8UD\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;";
                    int categoryId = GetCategoryIdByName(comboBoxCategory.Text);
                    int tripId = Convert.ToInt32(tripsDataGridView.SelectedRows[0].Cells["TripID"].Value);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Update Trip
                        string updateTrip = @"UPDATE Trip SET CategoryID=@CategoryID, DepartureDate=@DepartureDate, ReturnDate=@ReturnDate, TotalSlots=@TotalSlots, Price=@Price WHERE TripID=@TripID";
                        using (SqlCommand cmd = new SqlCommand(updateTrip, conn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                            cmd.Parameters.AddWithValue("@DepartureDate", dateTimePickerStart.Value);
                            cmd.Parameters.AddWithValue("@ReturnDate", dateTimePickerEnd.Value);
                            cmd.Parameters.AddWithValue("@TotalSlots", (int)numericUpDownCapacity.Value);
                            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                            cmd.Parameters.AddWithValue("@TripID", tripId);
                            cmd.ExecuteNonQuery();
                        }
                        // Update Itinerary (TripName)
                        string updateItinerary = @"UPDATE Itinerary SET Title=@Title WHERE TripID=@TripID AND DayNumber=1";
                        using (SqlCommand cmd = new SqlCommand(updateItinerary, conn))
                        {
                            cmd.Parameters.AddWithValue("@Title", textBoxTripName.Text);
                            cmd.Parameters.AddWithValue("@TripID", tripId);
                            cmd.ExecuteNonQuery();
                        }
                        // Update TripDestinations
                        string updateDest = @"UPDATE TripDestinations SET Destination=@Destination WHERE TripID=@TripID";
                        using (SqlCommand cmd = new SqlCommand(updateDest, conn))
                        {
                            cmd.Parameters.AddWithValue("@Destination", textBoxDestination.Text);
                            cmd.Parameters.AddWithValue("@TripID", tripId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Trip updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTripsData();
                }
                else
                {
                    MessageBox.Show("Please select a trip to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tripsDataGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this trip?", 
                        "Confirm Deletion", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int tripId = Convert.ToInt32(tripsDataGridView.SelectedRows[0].Cells["TripID"].Value);
                        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            // Delete from TripDestinations
                            string delDest = "DELETE FROM TripDestinations WHERE TripID=@TripID";
                            using (SqlCommand cmd = new SqlCommand(delDest, conn))
                            {
                                cmd.Parameters.AddWithValue("@TripID", tripId);
                                cmd.ExecuteNonQuery();
                            }
                            // Delete from Itinerary
                            string delItin = "DELETE FROM Itinerary WHERE TripID=@TripID";
                            using (SqlCommand cmd = new SqlCommand(delItin, conn))
                            {
                                cmd.Parameters.AddWithValue("@TripID", tripId);
                                cmd.ExecuteNonQuery();
                            }
                            // Delete from WishList_Contains
                            string deleteWishList = "DELETE FROM WishList_Contains WHERE TripID = @TripID";
                            using (SqlCommand cmd = new SqlCommand(deleteWishList, conn))
                            {
                                cmd.Parameters.AddWithValue("@TripID", tripId);
                                cmd.ExecuteNonQuery();
                            }
                            // Delete from Trip
                            string deleteTrip = "DELETE FROM Trip WHERE TripID=@TripID";
                            using (SqlCommand cmd = new SqlCommand(deleteTrip, conn))
                            {
                                cmd.Parameters.AddWithValue("@TripID", tripId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Trip deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTripsData();
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a trip to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBoxTripName.Text = string.Empty;
            textBoxDestination.Text = string.Empty;
            comboBoxCategory.SelectedIndex = -1;
            dateTimePickerStart.Value = DateTime.Now.AddDays(30);
            dateTimePickerEnd.Value = DateTime.Now.AddDays(37);
            textBoxPrice.Text = string.Empty;
            numericUpDownCapacity.Value = 10;
            textBoxDescription.Text = string.Empty;
            textBoxInclusions.Text = string.Empty;
        }

        private void tripsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}