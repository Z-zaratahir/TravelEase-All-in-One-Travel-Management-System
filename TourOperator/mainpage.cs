using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppProject
{
    public partial class mainpage : UserControl
    {
        private Form1 mainForm;  // Reference to Form1
        public mainpage(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            this.BackgroundImage = Properties.Resources.mainpage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Invalidate(); // Force redraw, just in case
        }

        // Login button click event
        private void loginb_Click(object sender, EventArgs e)
        {
            if (rolecombo.SelectedIndex == -1)
            {
                HighlightComboBox();
                MessageBox.Show("Please select whether you are a Traveler or Operator before continuing.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Controls.Clear();
            string selectedRole = rolecombo.SelectedItem?.ToString() ?? "Traveler";
            if (selectedRole == "Operator")
            {
                var opLogin = new TourOperatorLogin(mainForm, selectedRole);
                opLogin.Dock = DockStyle.Fill;
                this.Controls.Add(opLogin);
            }
            else
            {
                login loginForm = new login(mainForm, selectedRole);
                loginForm.Dock = DockStyle.Fill;
                this.Controls.Add(loginForm);
            }
        }

        // SignUp button click event
        private void Signupb_Click(object sender, EventArgs e)
        {
            if (rolecombo.SelectedIndex == -1)
            {
                HighlightComboBox();
                MessageBox.Show("Please select whether you are a Traveler or Operator before continuing.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Controls.Clear();
            string selectedRole = rolecombo.SelectedItem?.ToString() ?? "Traveler";
            if (selectedRole == "Operator")
            {
                var opSignup = new TourOperatorSignUp(mainForm, selectedRole);
                opSignup.Dock = DockStyle.Fill;
                this.Controls.Add(opSignup);
            }
            else
            {
                Signup signUpForm = new Signup(mainForm, selectedRole);
                signUpForm.Dock = DockStyle.Fill;
                this.Controls.Add(signUpForm);
            }
        }

        private void HighlightComboBox()
        {
            rolecombo.FlatStyle = FlatStyle.Flat;
            rolecombo.BackColor = Color.White;
            rolecombo.Paint += Rolecombo_PaintPinkBorder;
            rolecombo.Invalidate();
        }

        private void Rolecombo_PaintPinkBorder(object sender, PaintEventArgs e)
        {
            var combo = sender as ComboBox;
            using (Pen pinkPen = new Pen(Color.FromArgb(240, 164, 211), 2))
            {
                e.Graphics.DrawRectangle(pinkPen, 0, 0, combo.Width - 1, combo.Height - 1);
            }
        }

        // Removed duplicate InitializeComponent method
        private void mainpage_Load(object sender, EventArgs e)
        {
        }
    }
}
