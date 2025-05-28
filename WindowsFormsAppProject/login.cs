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
        private Form1 mainForm;  
        public login(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;  
        }

        private void loginb_Click(object sender, EventArgs e)
        {
            string inputUsername = usernametextb.Text;
            string inputPassword = passwordtextb.Text;

            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

            string query = "SELECT UserID FROM [User] WHERE UserName = @username AND Password = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", inputUsername);
                        command.Parameters.AddWithValue("@password", inputPassword);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int userID = Convert.ToInt32(result);

                            this.Hide();
                            mainForm.ShowDashboard(userID); 
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
            Signup signupForm = new Signup(mainForm);
           
            signupForm.Show(); 
        }
    }
}
