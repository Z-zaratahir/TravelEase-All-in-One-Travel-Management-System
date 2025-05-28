using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class TourOperatorLogin : UserControl
    {
        // Form controls
        private TextBox txtCompanyName;
        private Button btnLogin;
        private Label lblCompanyName;
        private Panel headerPanel;
        private Label lblTitle;
        private Label lblSwitchToSignUp;
        private Label lblSwitchToLogin;
        private TextBox txtConfirmPassword;
        private Button btnSignUp;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private Form1 mainForm;
        private string selectedRole;

        public TourOperatorLogin(Form1 form, string role)
        {
            mainForm = form;
            selectedRole = role;
            this.Size = new Size(1436, 865);
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
            title.Text = "Log In to Your TravelEase Account!";
            title.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.AutoSize = true;
            title.Location = new Point(250, 120);
            this.Controls.Add(title);

            // Username
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(270, 200);
            lblUsername.Size = new Size(100, 25);
            this.Controls.Add(lblUsername);
            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(400, 200);
            txtUsername.Size = new Size(200, 25);
            this.Controls.Add(txtUsername);

            // Password
            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(270, 240);
            lblPassword.Size = new Size(100, 25);
            this.Controls.Add(lblPassword);
            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(400, 240);
            txtPassword.Size = new Size(200, 25);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            // Company Name
            Label lblCompanyName = new Label();
            lblCompanyName.Text = "Company Name:";
            lblCompanyName.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            lblCompanyName.Location = new Point(270, 280);
            lblCompanyName.Size = new Size(120, 25);
            this.Controls.Add(lblCompanyName);
            TextBox txtCompanyName = new TextBox();
            txtCompanyName.Location = new Point(400, 280);
            txtCompanyName.Size = new Size(200, 25);
            this.Controls.Add(txtCompanyName);

            // Sign Up Link
            LinkLabel linkSignUp = new LinkLabel();
            linkSignUp.Text = "Sign Up!";
            linkSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            linkSignUp.Location = new Point(405, 330);
            linkSignUp.Size = new Size(60, 20);
            linkSignUp.LinkColor = Color.Blue;
            linkSignUp.ActiveLinkColor = Color.Blue;
            linkSignUp.VisitedLinkColor = Color.Blue;
            linkSignUp.TextAlign = ContentAlignment.MiddleLeft;
            linkSignUp.Click += (s, e) =>
            {
                var parent = this.Parent;
                if (parent != null)
                {
                    parent.Controls.Clear();
                    parent.Controls.Add(new TourOperatorSignUp(mainForm, selectedRole));
                }
            };
            this.Controls.Add(linkSignUp);

            Label lblNoAccount = new Label();
            lblNoAccount.Text = "Do not have an account?";
            lblNoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNoAccount.Location = new Point(430, 331);
            lblNoAccount.Size = new Size(170, 20);
            lblNoAccount.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblNoAccount);

            // Log In Button
            Button btnLogin = new Button();
            btnLogin.Text = "Log In!";
            btnLogin.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(240, 164, 211);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(450, 360);
            btnLogin.Size = new Size(150, 45);
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            this.ResumeLayout(false);
        }

        private void ShowSignUpView()
        {
            lblTitle.Text = "Sign Up";
            btnLogin.Visible = false;
            lblSwitchToSignUp.Visible = false;

            // Show sign up controls
            txtConfirmPassword.Visible = true;
            btnSignUp.Visible = true;
            lblSwitchToLogin.Visible = true;

            // Move password label and textbox up for confirm password
            lblCompanyName.Location = new Point(50, 155);
            txtCompanyName.Location = new Point(50, 180);

            // Add confirm password label
            if (!this.Controls.ContainsKey("lblConfirmPassword"))
            {
                Label lblConfirmPassword = new Label();
                lblConfirmPassword.Name = "lblConfirmPassword";
                lblConfirmPassword.Text = "Confirm Password:";
                lblConfirmPassword.Font = new Font("Segoe UI", 10);
                lblConfirmPassword.Location = new Point(50, 205);
                lblConfirmPassword.AutoSize = true;
                this.Controls.Add(lblConfirmPassword);
                lblConfirmPassword.BringToFront();
            }
            this.Controls["lblConfirmPassword"].Visible = true;
        }

        private void ShowLoginView()
        {
            lblTitle.Text = "Tour Operator Login";
            btnLogin.Visible = true;
            lblSwitchToSignUp.Visible = true;

            // Hide sign up controls
            txtConfirmPassword.Visible = false;
            btnSignUp.Visible = false;
            lblSwitchToLogin.Visible = false;

            // Move password label and textbox back
            lblCompanyName.Location = new Point(50, 165);
            txtCompanyName.Location = new Point(50, 190);

            // Hide confirm password label
            if (this.Controls.ContainsKey("lblConfirmPassword"))
                this.Controls["lblConfirmPassword"].Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Find the controls
            TextBox txtUsername = null, txtPassword = null, txtCompanyName = null;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    if (tb.Location == new Point(400, 200)) txtUsername = tb;
                    else if (tb.Location == new Point(400, 240)) txtPassword = tb;
                    else if (tb.Location == new Point(400, 280)) txtCompanyName = tb;
                }
            }
            if (txtUsername == null || txtPassword == null || txtCompanyName == null)
            {
                MessageBox.Show("Internal error: Could not find input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string company = txtCompanyName.Text.Trim();
            // Input validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(company))
            {
                MessageBox.Show("Please fill in all fields (Username, Password, Company Name).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            // SQL check
            try
            {
                string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // 1. Check username/password and get UserID
                    string userQuery = "SELECT UserID FROM [User] WHERE UserName = @username AND Password = @password";
                    int userId = -1;
                    using (var cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        userId = (int)result;
                    }
                    MessageBox.Show("User ID: " + userId.ToString());

                    // 2. Check if this user is an operator and company matches
                    string opQuery = "SELECT COUNT(*) FROM Operator WHERE OperatorID = @userId AND CompanyName = @company";
                    using (var cmd = new SqlCommand(opQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@company", company);
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Company name does not match for this operator.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Success! Proceed to dashboard
                    MessageBox.Show("Login successful! Welcome, operator.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 dashboard = new Form2();
                    dashboard.Show();
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                        parentForm.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCompanyName.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Company names do not match.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // For now, just show a success message (no database)
            MessageBox.Show("Account created successfully! You are now logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Navigate to the correct Tour Operator Dashboard here
            // var dashboard = new TourOperatorDashboard();
            // dashboard.Show();
            // this.Hide();
        }

        private void AddCompanyNameField()
        {
            companyNameLabel = new Label();
            companyNameLabel.Text = "Company Name:";
            companyNameLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            companyNameLabel.Location = new Point(txtCompanyName.Left, txtCompanyName.Bottom + 20);
            companyNameLabel.Size = new Size(120, 25);
            this.Controls.Add(companyNameLabel);

            companyNameTextBox = new TextBox();
            companyNameTextBox.Location = new Point(txtCompanyName.Left + 130, txtCompanyName.Bottom + 20);
            companyNameTextBox.Size = new Size(200, 25);
            this.Controls.Add(companyNameTextBox);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TourOperatorLogin
            // 
            this.Name = "TourOperatorLogin";
            this.Load += new System.EventHandler(this.TourOperatorLogin_Load);
            this.ResumeLayout(false);

        }

        private void TourOperatorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}