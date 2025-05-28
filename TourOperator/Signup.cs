using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Signup : UserControl
    {
        private Form1 mainForm;  
        private string selectedRole = "Traveler"; // Default

        public Signup(Form1 form, string role)
        {
            InitializeComponent();
            mainForm = form;
            selectedRole = role;
        }

        private async void loginb_Click(object sender, EventArgs e)
        {
            // Retrieve form data
            string firstName = fnametb.Text;
            string lastName = lastnametb.Text;
            string city = citytb.Text;
            string state = statetb.Text;
            string zipCode = zipcodetb.Text;
            string cnic = dobtextb.Text;  
            DateTime dateOfBirth = dateTimePicker1.Value;
            string role = selectedRole;
            string username = usernametextb.Text;
            string password = passwordtextb.Text; 
                        await Task.Run(() => InsertUserData(firstName, lastName, city, state, zipCode, cnic, dateOfBirth, role, username, password));
        }

        private async Task InsertUserData(string firstName, string lastName, string city, string state, string zipCode, string cnic, DateTime dateOfBirth, string role, string username, string password)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            // SQL to get the max registration ID
            string getMaxRegistrationQuery = "SELECT ISNULL(MAX(Registration), 0) + 1 FROM Person";

            string insertPersonQuery = "INSERT INTO Person (Registration, FName, LName, City, State, ZipCode, DOB, Role, CNIC, RDate) " +
                                       "VALUES (@Registration, @FName, @LName, @City, @State, @ZipCode, @DOB, @Role, @CNIC, GETDATE());";

            string insertUserQuery = "INSERT INTO [User] (UserID, UserName, Password) " +
                                     "VALUES (@UserID, @UserName, @Password);";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int newRegistration;

                            // Step 1: Get the next Registration value
                            using (SqlCommand getMaxCmd = new SqlCommand(getMaxRegistrationQuery, connection, transaction))
                            {
                                newRegistration = Convert.ToInt32(await getMaxCmd.ExecuteScalarAsync());
                            }

                            // Step 2: Insert into Person
                            using (SqlCommand command = new SqlCommand(insertPersonQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Registration", newRegistration);
                                command.Parameters.AddWithValue("@FName", firstName);
                                command.Parameters.AddWithValue("@LName", lastName);
                                command.Parameters.AddWithValue("@City", city);
                                command.Parameters.AddWithValue("@State", state);
                                command.Parameters.AddWithValue("@ZipCode", zipCode);
                                command.Parameters.AddWithValue("@DOB", dateOfBirth);
                                command.Parameters.AddWithValue("@Role", role);
                                command.Parameters.AddWithValue("@CNIC", cnic);

                                await command.ExecuteNonQueryAsync();
                            }

                            // Step 3: Insert into User
                            // Step 3: Insert into User
                            using (SqlCommand userCommand = new SqlCommand(insertUserQuery, connection, transaction))
                            {
                                userCommand.Parameters.AddWithValue("@UserID", newRegistration);
                                userCommand.Parameters.AddWithValue("@UserName", username);
                                userCommand.Parameters.AddWithValue("@Password", password); // Consider hashing
                                await userCommand.ExecuteNonQueryAsync();
                            }

                            // Step 4: If Traveler, insert into Traveler table
                            if (role == "Traveler")
                            {
                                string insertTravelerQuery = "INSERT INTO Traveler (TravelerID) VALUES (@UserID);";

                                using (SqlCommand travelerCommand = new SqlCommand(insertTravelerQuery, connection, transaction))
                                {
                                    travelerCommand.Parameters.AddWithValue("@UserID", newRegistration);
                                    await travelerCommand.ExecuteNonQueryAsync();
                                }
                            }


                            transaction.Commit();

                            MessageBox.Show("Sign-up successful!");
                            ClearFormFields();
                            this.Hide();
                            var mainPage = new mainpage(mainForm);
                            mainPage.Show();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to validate the user inputs
        private bool ValidateInputs(string firstName, string lastName, string city, string state, string zipCode, string username, string password)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(city) ||
                string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                return false;
            }
            // Additional checks (like valid zip code format, password length, etc.) can be added here
            return true;
        }

        // Function to insert user data into both Person and User tables
        private void ClearFormFields()
        {
            fnametb.Clear();
            lastnametb.Clear();
            citytb.Clear();
            statetb.Clear();
            zipcodetb.Clear();
            usernametextb.Clear();
            passwordtextb.Clear();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

       
        private void fnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void citytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void statetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dobtextb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void usernametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void Signup_Load_2(object sender, EventArgs e)
        {

        }
    }
}
