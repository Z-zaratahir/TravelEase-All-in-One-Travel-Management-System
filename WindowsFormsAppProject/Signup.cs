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
        private int travelerID;
        public Signup(Form1 form)
        {
            InitializeComponent();
            setComboBox();
            mainForm = form;  
        }

        private async void loginb_Click(object sender, EventArgs e)
        {
            string firstName = fnametb.Text;
            string lastName = lastnametb.Text;
            string city = citytb.Text;
            string state = statetb.Text;
            string zipCode = zipcodetb.Text;
            string cnic = dobtextb.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            string role = rolecombo.SelectedItem.ToString();
            string username = usernametextb.Text;
            string password = passwordtextb.Text;

            await InsertUserData(firstName, lastName, city, state, zipCode, cnic, dateOfBirth, role, username, password);
        }


        private async Task InsertUserData(string firstName, string lastName, string city, string state, string zipCode, string cnic, DateTime dateOfBirth, string role, string username, string password)
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;";

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
                                travelerID = newRegistration;
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
                           
                            this.Hide();
                            mainForm.ShowDashboard(travelerID);
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

       

       

        private void setComboBox()
        {
            rolecombo.Items.Add("Traveler");
            rolecombo.Items.Add("Operator");
            rolecombo.SelectedIndex = 0;
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

        private void rolecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextb_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
