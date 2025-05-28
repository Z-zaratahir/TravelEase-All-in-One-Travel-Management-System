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
using Microsoft.VisualBasic;

namespace Project
{
    public partial class tourCategories : UserControl
    {
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public tourCategories()
        {
            InitializeComponent();
            dataGridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategories.ReadOnly = true;
            dataGridCategories.AllowUserToAddRows = false;

        }
        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, CategoryName, AdminId FROM TourCategories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridCategories.DataSource = table;
            }
        }
        private void buttonRegiteration_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void buttonAddCAtegory_Click(object sender, EventArgs e)
        {
            // Prompt for Category Name
            string categoryName = Microsoft.VisualBasic.Interaction.InputBox("Enter Category Name:", "Add Category", "");

            // Prompt for Admin ID
            string adminIdStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin ID:", "Add Category", "");

            if (!string.IsNullOrWhiteSpace(categoryName) && !string.IsNullOrWhiteSpace(adminIdStr) && int.TryParse(adminIdStr, out int adminId))
            {
                // Get the last CategoryID and increment it
                int newCategoryId = GetNextCategoryId();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TourCategories (CategoryID, CategoryName, AdminId) VALUES (@CategoryID, @CategoryName, @AdminId)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", newCategoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.Parameters.AddWithValue("@AdminId", adminId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadCategories();
            }
            else
            {
                MessageBox.Show("Please enter valid Category Name and Admin ID.");
            }
        }

        private int GetNextCategoryId()
        {
            int lastCategoryId = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(CategoryID) FROM TourCategories";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastCategoryId = Convert.ToInt32(result);
                }
            }

            return lastCategoryId + 1; // Increment by 1
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridCategories.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(dataGridCategories.SelectedRows[0].Cells["CategoryID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM TourCategories WHERE CategoryID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", categoryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadCategories();
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private void tourCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
