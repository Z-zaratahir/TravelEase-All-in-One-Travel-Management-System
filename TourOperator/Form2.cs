using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppProject
{
    public partial class Form2 : Form
    {
        private Panel panelNavbar;
        private Panel panelContent;

        private Label appTitle;

        public Form2()
        {
            InitializeComponent();
            InitializeCustomLayout(); // Set up panels and layout
        }

        private void InitializeCustomLayout()
        {
            // Exact form size matching the screenshot 959, 565
            this.Size = new Size(959, 565);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TravelEase - Tour Operator Dashboard";

            // Set background image if it exists
            try
            {
                this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                // If the background image resource doesn't exist, use a plain color instead
                this.BackColor = Color.LightGray;
            }

            // Panel Content - Position it exactly
            panelContent = new Panel();
            panelContent.Size = new Size(925, 445);
            panelContent.Location = new Point(10, 80);
            panelContent.BackColor = Color.Transparent;
            panelContent.AutoScroll = false;
            this.Controls.Add(panelContent);

            // Create and add the navbar at the top - make it touch the edges
            panelNavbar = new Panel();
            panelNavbar.Size = new Size(959, 70);
            panelNavbar.Location = new Point(0, 0); // Start from left edge
            panelNavbar.BackColor = Color.FromArgb(240, 164, 211);
            this.Controls.Add(panelNavbar);

            // Add application title next to logo
            appTitle = new Label();
            appTitle.Text = "TravelEase";
            appTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            appTitle.AutoSize = true;
            appTitle.Location = new Point(70, 20);
            appTitle.ForeColor = Color.Black;
            panelNavbar.Controls.Add(appTitle);

            // Add navigation buttons - positioned to fit on smaller screen
            int buttonX = 230; // Start buttons more to the left
            int buttonWidth = 120; // Make buttons smaller
            int buttonSpacing = 10; // Reduce spacing

            Button tripManagementBtn = CreateNavButton("Trip Management", buttonX);
            buttonX += buttonWidth + buttonSpacing;
            tripManagementBtn.Click += (sender, e) => LoadTourOperatorTab("tripManagement");

            Button bookingsBtn = CreateNavButton("Bookings", buttonX);
            buttonX += buttonWidth + buttonSpacing;
            bookingsBtn.Click += (sender, e) => LoadTourOperatorTab("bookings");

            Button resourcesBtn = CreateNavButton("Resources", buttonX);
            buttonX += buttonWidth + buttonSpacing;
            resourcesBtn.Click += (sender, e) => LoadTourOperatorTab("resources");

            Button analyticsBtn = CreateNavButton("Analytics", buttonX);
            analyticsBtn.Click += (sender, e) => LoadTourOperatorTab("analytics");

            // Add logout button - ensure it's visible on screen
            Button logoutBtn = new Button();
            logoutBtn.Text = "Logout";
            logoutBtn.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            logoutBtn.Size = new Size(80, 30);
            logoutBtn.Location = new Point(850, 20);
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.BackColor = Color.FromArgb(255, 192, 203);
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.Click += (sender, e) => Application.Exit();
            panelNavbar.Controls.Add(logoutBtn);
        }

        private Button CreateNavButton(string text, int x)
        {
            Button button = new Button();
            button.Text = text;
            button.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            button.Location = new Point(x, 20);
            button.Size = new Size(120, 30);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(240, 164, 211);
            panelNavbar.Controls.Add(button);
            return button;
        }

        private void LoadTourOperatorTab(string tabName)
        {
            // Clear existing content
            panelContent.Controls.Clear();

            // Create a UserControl based on the tab name
            UserControl tabControl = null;

            switch (tabName)
            {
                case "tripManagement":
                    tabControl = new TourOperatorTrips();
                    break;
                case "bookings":
                    tabControl = new TourOperatorBookings();
                    break;
                case "resources":
                    tabControl = new TourOperatorResources();
                    break;
                case "analytics":
                    tabControl = new TourOperatorAnalytics();
                    break;
                default:
                    // Default to trip management
                    tabControl = new TourOperatorTrips();
                    break;
            }

            if (tabControl != null)
            {
                LoadPage(tabControl);
            }
        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();
            // Use exact positioning rather than Dock
            page.Size = panelContent.Size;
            page.Location = new Point(0, 0);
            panelContent.Controls.Add(page);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Load the Trip Management tab by default
            LoadTourOperatorTab("tripManagement");
            //this.reportViewer1.RefreshReport();
        }
    }
}