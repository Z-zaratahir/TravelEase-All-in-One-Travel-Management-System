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

namespace WindowsFormsAppProject
{
    public partial class login : UserControl
    {
        private Form1 mainForm;  // Reference to Form1
        private string selectedRole = "Traveler";
        public login(Form1 form, string role)
        {
            InitializeComponent();
            mainForm = form;  // Store the reference of Form1
            selectedRole = role;
        }

        private void loginb_Click(object sender, EventArgs e)
        {
            // Get the input from the user
            string inputUsername = usernametextb.Text;
            string inputPassword = passwordtextb.Text;

            // Define the connection string (use your database connection details here)
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            // Define the query to check the credentials
            string query = "SELECT COUNT(*) FROM [User] WHERE UserName = @username AND Password = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create the SQL command with parameters to prevent SQL Injection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@username", inputUsername);
                        command.Parameters.AddWithValue("@password", inputPassword);

                        // Open the connection
                        connection.Open();

                        // Execute the query and get the result
                        int result = (int)command.ExecuteScalar();

                        // Check if the result is greater than 0, meaning the credentials are correct
                        if (result > 0)
                        {
                            // Hide the login screen and show the main page
                            this.Hide();
                            var mainPage = new mainpage(mainForm);
                            mainPage.Show();
                        }
                        else
                        {
                            // Show an error message if credentials are incorrect
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (e.g., database connection issues)
                MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordtextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupForm = new Signup(mainForm, selectedRole);
           
            signupForm.Show(); 
        }
    }
}
