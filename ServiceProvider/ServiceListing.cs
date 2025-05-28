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
    public partial class ServiceListing : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";


        public ServiceListing()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to add.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 🔹 Get next ProviderID manually
                int newProviderID = 1;
                using (SqlCommand maxCmd = new SqlCommand("SELECT ISNULL(MAX(ProviderID), 0) + 1 FROM ServiceProvider", conn))
                {
                    newProviderID = (int)maxCmd.ExecuteScalar();
                }

                // 🔹 Insert into ServiceProvider using custom ProviderID
                string insertSP = @"
INSERT INTO ServiceProvider (ProviderID, Name, PhoneNumber, Type, VehicleType, Language, Experience)
VALUES (@ProviderID, @Name, @PhoneNumber, @Type, @VehicleType, @Language, @Experience);";

                SqlCommand cmdSP = new SqlCommand(insertSP, conn);
                cmdSP.Parameters.AddWithValue("@ProviderID", newProviderID);
                cmdSP.Parameters.AddWithValue("@Name", row.Cells["Name"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@PhoneNumber", row.Cells["PhoneNumber"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Type", row.Cells["Type"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@VehicleType", row.Cells["VehicleType"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Language", row.Cells["Language"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Experience", row.Cells["Experience"].Value ?? DBNull.Value);

                cmdSP.ExecuteNonQuery();

                // 🔹 If Hotel Provider, insert hotel
                if ((row.Cells["Type"].Value ?? "").ToString() == "Hotel Provider")
                {
                    int newHotelID = 1;
                    using (SqlCommand maxHotelCmd = new SqlCommand("SELECT ISNULL(MAX(HotelID), 0) + 1 FROM Hotel", conn))
                    {
                        newHotelID = (int)maxHotelCmd.ExecuteScalar();
                    }

                    string insertHotel = @"
INSERT INTO Hotel (HotelID, HotelName, Rooms, AvailabilityStatus, Location, Stars, ProviderID)
VALUES (@HID, @Name, @Rooms, @Status, @Loc, @Stars, @PID);";

                    SqlCommand cmdH = new SqlCommand(insertHotel, conn);
                    cmdH.Parameters.AddWithValue("@HID", newHotelID);
                    cmdH.Parameters.AddWithValue("@Name", row.Cells["HotelName"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Rooms", row.Cells["Rooms"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Status", row.Cells["AvailabilityStatus"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Loc", row.Cells["Location"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Stars", row.Cells["Stars"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@PID", newProviderID);

                    cmdH.ExecuteNonQuery();
                }

                MessageBox.Show("Service added successfully.");
                buttonLoad_Click(sender, e);
            }
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to edit.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            int providerID = Convert.ToInt32(row.Cells["ProviderID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateSP = @"
        UPDATE ServiceProvider
        SET Name = @Name, PhoneNumber = @Phone, Type = @Type,
            VehicleType = @Vehicle, Language = @Lang, Experience = @Exp
        WHERE ProviderID = @PID";

                SqlCommand cmdSP = new SqlCommand(updateSP, conn);
                cmdSP.Parameters.AddWithValue("@Name", row.Cells["Name"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Phone", row.Cells["PhoneNumber"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Type", row.Cells["Type"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Vehicle", row.Cells["VehicleType"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Lang", row.Cells["Language"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@Exp", row.Cells["Experience"].Value ?? DBNull.Value);
                cmdSP.Parameters.AddWithValue("@PID", providerID);
                cmdSP.ExecuteNonQuery();

                if ((row.Cells["Type"].Value ?? "").ToString() == "Hotel Provider")
                {
                    string updateHotel = @"
            IF EXISTS (SELECT 1 FROM Hotel WHERE ProviderID = @PID)
            BEGIN
                UPDATE Hotel
                SET HotelName = @Name, Rooms = @Rooms, AvailabilityStatus = @Status,
                    Location = @Loc, Stars = @Stars
                WHERE ProviderID = @PID
            END
            ELSE
            BEGIN
                INSERT INTO Hotel (HotelName, Rooms, AvailabilityStatus, Location, Stars, ProviderID)
                VALUES (@Name, @Rooms, @Status, @Loc, @Stars, @PID)
            END";

                    SqlCommand cmdH = new SqlCommand(updateHotel, conn);
                   
                    cmdH.Parameters.AddWithValue("@Name", row.Cells["HotelName"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Rooms", row.Cells["Rooms"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Status", row.Cells["AvailabilityStatus"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Loc", row.Cells["Location"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@Stars", row.Cells["Stars"].Value ?? DBNull.Value);
                    cmdH.Parameters.AddWithValue("@PID", providerID);
                    cmdH.ExecuteNonQuery();
                }

                MessageBox.Show("Service updated.");
                buttonLoad_Click(sender, e);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a service to delete.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            int providerID = Convert.ToInt32(row.Cells["ProviderID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Delete from Hotel first (if any), then ServiceProvider
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Hotel WHERE ProviderID = @PID", conn);
                cmd1.Parameters.AddWithValue("@PID", providerID);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM ServiceProvider WHERE ProviderID = @PID", conn);
                cmd2.Parameters.AddWithValue("@PID", providerID);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Service deleted.");
                buttonLoad_Click(sender, e);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            SP.ProviderID, SP.Name, SP.PhoneNumber, SP.Type,
            SP.VehicleType, SP.Language, SP.Experience,
            H.HotelID, H.HotelName, H.Rooms, H.AvailabilityStatus, H.Location, H.Stars, H.ProviderID
        FROM 
            ServiceProvider SP
        LEFT JOIN 
            Hotel H ON SP.ProviderID = H.ProviderID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void labelServiceListing_Click(object sender, EventArgs e)
        {

        }
    }
}
