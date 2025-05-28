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

namespace Project
{

    public partial class UserOperator : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public UserOperator()
        {
            InitializeComponent();

        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            LoadPendingUsers();
        }

        private void UserOperator_Load(object sender, EventArgs e)
        {
            LoadPendingUsers();
        }

        private void LoadPendingUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, UserName, Password, AdminID FROM [User] WHERE IsApproved = 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE [User] SET IsApproved = 1 WHERE UserID = @Id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User approved successfully.");
                LoadPendingUsers(); // Refresh grid
            }
            else
            {
                MessageBox.Show("Please select a user to approve.");
            }
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE [User] SET IsApproved = 0 WHERE UserID = @Id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User rejected.");
                LoadPendingUsers(); // Refresh grid
            }
            else
            {
                MessageBox.Show("Please select a user to reject.");
            }
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOperator_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // to avoid header clicks
            {
                int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check Traveler
                    string travelerQuery = "SELECT COUNT(*) FROM Traveler WHERE TravelerID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(travelerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            radioButtonUser.Checked = true;
                            radioButtonOperator.Checked = false;
                            return;
                        }
                    }

                    // Check Operator
                    string operatorQuery = "SELECT COUNT(*) FROM Operator WHERE OperatorID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(operatorQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            radioButtonOperator.Checked = true;
                            radioButtonUser.Checked = false;
                            return;
                        }
                    }

                    // If neither
                    radioButtonUser.Checked = false;
                    radioButtonOperator.Checked = false;
                }
            }
        }

    }
}
