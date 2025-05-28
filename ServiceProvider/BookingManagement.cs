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
    public partial class BookingManagement : UserControl
    {
        private string connectionString = "Data Source=MARYAMATRIX\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True";
        public BookingManagement()
        {
            InitializeComponent();
            comboBoxChoose.Items.AddRange(new string[] { "Confirm Reservation", "Update Availability", "Track Payment" });
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.ToString() != "Track Payment") return;

            if (radioButtonPaid.Checked && dataGridViewBooking.SelectedRows.Count > 0)
            {
                var paymentID = dataGridViewBooking.SelectedRows[0].Cells["PaymentID"].Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Payment SET Status = 'Completed' WHERE PaymentID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", paymentID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment marked as completed.");
                comboBoxChoose_SelectedIndexChanged(null, null);
            }
        
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.ToString() != "Update Availability") return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Trip", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable dt = (DataTable)dataGridViewBooking.DataSource;
                adapter.Update(dt);
            }

            MessageBox.Show("Trip availability updated.");
            comboBoxChoose_SelectedIndexChanged(null, null);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.ToString() != "Confirm Reservation") return;

            if (dataGridViewBooking.SelectedRows.Count > 0)
            {
                var bookingID = dataGridViewBooking.SelectedRows[0].Cells["BookingID"].Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking SET isConfirmed = 1 WHERE BookingID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", bookingID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking confirmed.");
                comboBoxChoose_SelectedIndexChanged(null, null);
            }

        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.ToString() != "Confirm Reservation") return;

            if (dataGridViewBooking.SelectedRows.Count > 0)
            {
                var bookingID = dataGridViewBooking.SelectedRows[0].Cells["BookingID"].Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking SET isConfirmed = 0 WHERE BookingID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", bookingID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking rejected.");
                comboBoxChoose_SelectedIndexChanged(null, null);
            }
        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = comboBoxChoose.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();

                if (choice == "Confirm Reservation")
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Booking WHERE isConfirmed IS NULL", conn);
                }
                else if (choice == "Update Availability")
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Trip", conn);
                }
                else if (choice == "Track Payment")
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Payment WHERE Status != 'Completed'", conn);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBooking.DataSource = dt;
            }
        }
    }
}
