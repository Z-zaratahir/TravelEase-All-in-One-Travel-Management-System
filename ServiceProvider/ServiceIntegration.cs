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
    public partial class ServiceIntegration : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public ServiceIntegration()
        {
            InitializeComponent();
        }

        private void LoadPendingServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    SP.ProviderID,
                    SP.Name,
                    SP.PhoneNumber,
                    SP.Type,
                    SP.VehicleType,
                    SP.Language,
                    SP.Experience,
                    SA.AssignmentID,
                    SA.IsAccepted
                FROM 
                    ServiceProvider SP
                JOIN 
                    ServiceAssignment SA ON SP.ProviderID = SA.ProviderID
                WHERE 
                    SA.IsAccepted IS NULL";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void admin_Click(object sender, EventArgs e)
        {

        }

        private void ServiceIntegration_Load(object sender, EventArgs e)
        {
            LoadPendingServices();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            UpdateIsAcceptedValue(1);
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            UpdateIsAcceptedValue(0);
        }

        private void UpdateIsAcceptedValue(int value)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service to update.");
                return;
            }

            int assignmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AssignmentID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ServiceAssignment SET IsAccepted = @val WHERE AssignmentID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@val", value);
                    cmd.Parameters.AddWithValue("@id", assignmentId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(value == 1 ? "Service Approved." : "Service Rejected.");
                        LoadPendingServices(); // Refresh table
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadPendingServices();
        }
    }
}
