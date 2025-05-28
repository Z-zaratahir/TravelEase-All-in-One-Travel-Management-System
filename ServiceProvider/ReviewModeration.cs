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
    public partial class ReviewModeration : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public ReviewModeration()
        {
            InitializeComponent();
            LoadReviews();
        }

        private void LoadReviews()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ReviewID, Rating, ReviewDate, Comment FROM Review";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewReviews.DataSource = dt;
            }
        }
        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (dataGridViewReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to approve.");
                return;
            }

            // Approval means keeping the review — no DB change needed
            MessageBox.Show("Review approved and retained.");
        }

        private void buttonDeleteReview_Click(object sender, EventArgs e)
        {
            if (dataGridViewReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to delete.");
                return;
            }

            int reviewId = Convert.ToInt32(dataGridViewReviews.SelectedRows[0].Cells["ReviewID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Review WHERE ReviewID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reviewId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Review deleted successfully.");
                        LoadReviews(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the review.");
                    }
                }
            }
        }

        private void dataGridViewReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
