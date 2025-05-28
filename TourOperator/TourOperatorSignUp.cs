using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class TourOperatorSignUp : UserControl
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtCompanyName;
        private Button btnSignUp;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblCompanyName;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private Form1 mainForm;
        private string selectedRole;

        public TourOperatorSignUp(Form1 form, string role)
        {
            mainForm = form;
            selectedRole = role;
            this.Size = new Size(1436, 865);
            this.BackgroundImage = Properties.Resources.Screenshot_2025_05_05_113850;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.SuspendLayout();
            this.BackColor = Color.White;
            this.Size = new Size(1436, 865);
            this.BackgroundImage = Properties.Resources.Screenshot_2025_05_05_113850;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Title
            Label title = new Label();
            title.Text = "Create Your Operator Account!";
            title.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.AutoSize = true;
            title.Location = new Point(250, 110);
            this.Controls.Add(title);

            // First Name
            Label lblFirstName = new Label();
            lblFirstName.Text = "First Name:";
            lblFirstName.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(150, 200);
            lblFirstName.Size = new Size(100, 25);
            this.Controls.Add(lblFirstName);
            TextBox txtFirstName = new TextBox();
            txtFirstName.Location = new Point(270, 200);
            txtFirstName.Size = new Size(120, 25);
            this.Controls.Add(txtFirstName);

            // Last Name
            Label lblLastName = new Label();
            lblLastName.Text = "Last Name:";
            lblLastName.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(150, 240);
            lblLastName.Size = new Size(100, 25);
            this.Controls.Add(lblLastName);
            TextBox txtLastName = new TextBox();
            txtLastName.Location = new Point(270, 240);
            txtLastName.Size = new Size(120, 25);
            this.Controls.Add(txtLastName);

            // City
            Label lblCity = new Label();
            lblCity.Text = "City:";
            lblCity.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblCity.Location = new Point(150, 280);
            lblCity.Size = new Size(100, 25);
            this.Controls.Add(lblCity);
            TextBox txtCity = new TextBox();
            txtCity.Location = new Point(270, 280);
            txtCity.Size = new Size(120, 25);
            this.Controls.Add(txtCity);

            // State
            Label lblState = new Label();
            lblState.Text = "State:";
            lblState.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblState.Location = new Point(150, 320);
            lblState.Size = new Size(100, 25);
            this.Controls.Add(lblState);
            TextBox txtState = new TextBox();
            txtState.Location = new Point(270, 320);
            txtState.Size = new Size(120, 25);
            this.Controls.Add(txtState);

            // Zip Code
            Label lblZip = new Label();
            lblZip.Text = "Zip Code:";
            lblZip.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblZip.Location = new Point(150, 360);
            lblZip.Size = new Size(100, 25);
            this.Controls.Add(lblZip);
            MaskedTextBox mtxtZip = new MaskedTextBox();
            mtxtZip.Mask = "00000";
            mtxtZip.Location = new Point(270, 360);
            mtxtZip.Size = new Size(120, 25);
            this.Controls.Add(mtxtZip);

            // CNIC
            Label lblCNIC = new Label();
            lblCNIC.Text = "CNIC:";
            lblCNIC.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblCNIC.Location = new Point(150, 400);
            lblCNIC.Size = new Size(100, 25);
            this.Controls.Add(lblCNIC);
            MaskedTextBox mtxtCNIC = new MaskedTextBox();
            mtxtCNIC.Mask = "00000-0000000-0";
            mtxtCNIC.Location = new Point(270, 400);
            mtxtCNIC.Size = new Size(120, 25);
            this.Controls.Add(mtxtCNIC);

            // DOB
            Label lblDOB = new Label();
            lblDOB.Text = "DOB:";
            lblDOB.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(150, 440);
            lblDOB.Size = new Size(100, 25);
            this.Controls.Add(lblDOB);
            DateTimePicker dtpDOB = new DateTimePicker();
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "yyyy-MM-dd";
            dtpDOB.Location = new Point(270, 440);
            dtpDOB.Size = new Size(180, 25);
            this.Controls.Add(dtpDOB);

            // Username
            lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(459, 200);
            lblUsername.Size = new Size(100, 25);
            this.Controls.Add(lblUsername);
            txtUsername = new TextBox();
            txtUsername.Location = new Point(610, 200);
            txtUsername.Size = new Size(200, 25);
            this.Controls.Add(txtUsername);

            // Password
            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(459, 240);
            lblPassword.Size = new Size(100, 25);
            this.Controls.Add(lblPassword);
            txtPassword = new TextBox();
            txtPassword.Location = new Point(610, 240);
            txtPassword.Size = new Size(200, 25);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            // Company Name
            lblCompanyName = new Label();
            lblCompanyName.Text = "Company Name:";
            lblCompanyName.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblCompanyName.Location = new Point(459, 320);
            lblCompanyName.Size = new Size(120, 25);
            this.Controls.Add(lblCompanyName);
            txtCompanyName = new TextBox();
            txtCompanyName.Location = new Point(610, 320);
            txtCompanyName.Size = new Size(200, 25);
            this.Controls.Add(txtCompanyName);

            // Confirm Password
            lblConfirmPassword = new Label();
            lblConfirmPassword.Text = "Confirm Password:";
            lblConfirmPassword.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(459, 280);
            lblConfirmPassword.Size = new Size(140, 25);
            this.Controls.Add(lblConfirmPassword);
            txtConfirmPassword = new TextBox();
            txtConfirmPassword.Location = new Point(610, 280);
            txtConfirmPassword.Size = new Size(200, 25);
            txtConfirmPassword.PasswordChar = '*';
            this.Controls.Add(txtConfirmPassword);

            // Sign Up Button
            btnSignUp = new Button();
            btnSignUp.Text = "Sign up!";
            btnSignUp.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            btnSignUp.BackColor = Color.FromArgb(240, 164, 211);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(663, 380);
            btnSignUp.Size = new Size(150, 45);
            btnSignUp.Click += BtnSignUp_Click;
            this.Controls.Add(btnSignUp);

            // Already have an account? Log in!
            LinkLabel linkLogin = new LinkLabel();
            linkLogin.Text = "Already have an account? Log in!";
            linkLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            linkLogin.Location = new Point(632, 353);
            linkLogin.Size = new Size(190, 20);
            linkLogin.LinkColor = Color.Blue;
            linkLogin.ActiveLinkColor = Color.Blue;
            linkLogin.VisitedLinkColor = Color.Blue;
            linkLogin.TextAlign = ContentAlignment.MiddleLeft;
            linkLogin.Click += (s, e) => {
                var parent = this.Parent;
                if (parent != null)
                {
                    parent.Controls.Clear();
                    parent.Controls.Add(new TourOperatorLogin(mainForm, selectedRole));
                }
            };
            this.Controls.Add(linkLogin);

            this.ResumeLayout(false);
        }

        private void AddCompanyNameField()
        {
            companyNameLabel = new Label();
            companyNameLabel.Text = "Company Name:";
            companyNameLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            companyNameLabel.Location = new Point(txtPassword.Left, txtPassword.Bottom + 20);
            companyNameLabel.Size = new Size(120, 25);
            this.Controls.Add(companyNameLabel);

            companyNameTextBox = new TextBox();
            companyNameTextBox.Location = new Point(txtPassword.Left + 130, txtPassword.Bottom + 20);
            companyNameTextBox.Size = new Size(200, 25);
            this.Controls.Add(companyNameTextBox);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            // Find all controls
            TextBox txtFirstName = null, txtLastName = null, txtCity = null, txtState = null;
            MaskedTextBox mtxtZip = null, mtxtCNIC = null;
            DateTimePicker dtpDOB = null;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    if (tb.Location == new Point(270, 200)) txtFirstName = tb;
                    else if (tb.Location == new Point(270, 240)) txtLastName = tb;
                    else if (tb.Location == new Point(270, 280)) txtCity = tb;
                    else if (tb.Location == new Point(270, 320)) txtState = tb;
                }
                else if (c is MaskedTextBox mtb)
                {
                    if (mtb.Location == new Point(270, 360)) mtxtZip = mtb;
                    else if (mtb.Location == new Point(270, 400)) mtxtCNIC = mtb;
                }
                else if (c is DateTimePicker dtp && dtp.Location == new Point(270, 440))
                {
                    dtpDOB = dtp;
                }
            }
            // Validate all fields
            if (txtFirstName == null || txtLastName == null || txtCity == null || txtState == null || mtxtZip == null || mtxtCNIC == null || dtpDOB == null ||
                txtUsername == null || txtPassword == null || txtCompanyName == null || txtConfirmPassword == null)
            {
                MessageBox.Show("Internal error: Could not find all input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string zip = mtxtZip.Text.Trim();
            string cnic = mtxtCNIC.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string company = txtCompanyName.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            // Check for empty fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) ||
                string.IsNullOrEmpty(zip) || string.IsNullOrEmpty(cnic) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(company) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate patterns
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9_]{3,}$"))
            {
                MessageBox.Show("Username must be at least 3 characters and contain only letters, numbers, or underscores.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (company.Length < 2)
            {
                MessageBox.Show("Company name must be at least 2 characters.", "Invalid Company Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(zip, @"^\d{4,}$"))
            {
                MessageBox.Show("Zip Code must be at least 4 digits.", "Invalid Zip Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cnic.Replace("-", ""), @"^\d{13}$"))
            {
                MessageBox.Show("CNIC must be 13 digits (with or without dashes).", "Invalid CNIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check uniqueness of username and password
            try
            {
                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();
                    string checkUser = "SELECT COUNT(*) FROM [User] WHERE UserName = @username";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(checkUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int exists = (int)cmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    // Get new IDs
                    int newReg = 0, newUserID = 0, newOperatorID = 0;
                    using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT ISNULL(MAX(Registration), 0) + 1 FROM Person", conn))
                    {
                        newReg = (int)cmd.ExecuteScalar();
                    }
                    using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT ISNULL(MAX(UserID), 0) + 1 FROM [User]", conn))
                    {
                        newUserID = (int)cmd.ExecuteScalar();
                    }
                    using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT ISNULL(MAX(OperatorID), 0) + 1 FROM Operator", conn))
                    {
                        newOperatorID = (int)cmd.ExecuteScalar();
                    }
                    // Insert into Person
                    string insertPerson = @"INSERT INTO Person (Registration, FName, LName, City, State, ZipCode, Role, RDate, CNIC, DOB)
                        VALUES (@Registration, @FName, @LName, @City, @State, @ZipCode, 'Operator', GETDATE(), @CNIC, @DOB);";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(insertPerson, conn))
                    {
                        cmd.Parameters.AddWithValue("@Registration", newReg);
                        cmd.Parameters.AddWithValue("@FName", firstName);
                        cmd.Parameters.AddWithValue("@LName", lastName);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@ZipCode", zip);
                        cmd.Parameters.AddWithValue("@CNIC", cnic);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.ExecuteNonQuery();
                    }
                    // Insert into User
                    string insertUser = "INSERT INTO [User] (UserID, UserName, Password) VALUES (@UserID, @UserName, @Password);";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(insertUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", newUserID);
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();
                    }
                    // Insert into Operator
                    string insertOperator = "INSERT INTO Operator (OperatorID, CompanyName) VALUES (@OperatorID, @CompanyName);";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(insertOperator, conn))
                    {
                        cmd.Parameters.AddWithValue("@OperatorID", newUserID);
                        cmd.Parameters.AddWithValue("@CompanyName", company);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally switch to login page
                    //var parent = this.Parent;
                    Form2 dashboard = new Form2();
                    dashboard.Show();
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                        parentForm.Hide();
                    //if (parent != null)
                    //{
                    //    parent.Controls.Clear();
                    //    parent.Controls.Add(new TourOperatorLogin(mainForm, selectedRole));
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TourOperatorSignUp
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "TourOperatorSignUp";
            this.Load += new System.EventHandler(this.TourOperatorSignUp_Load);
            this.ResumeLayout(false);

        }

        private void TourOperatorSignUp_Load(object sender, EventArgs e)
        {

        }
    }
} 