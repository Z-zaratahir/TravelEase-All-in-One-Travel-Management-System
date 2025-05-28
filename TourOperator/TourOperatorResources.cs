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
    public partial class TourOperatorResources : UserControl
    {
        private Label labelResources;
        private TabControl resourcesTabControl;
        private TabPage tabAccommodation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView accommodationsDataGridView;

        public TourOperatorResources()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.AutoScroll = false;
            this.Size = new Size(897, 400);

            LoadHotelData();
            AdjustControlPositions();
        }

        private void InitializeComponent()
        {
            this.labelResources = new System.Windows.Forms.Label();
            this.resourcesTabControl = new System.Windows.Forms.TabControl();
            this.tabAccommodation = new System.Windows.Forms.TabPage();
            this.accommodationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcesTabControl.SuspendLayout();
            this.tabAccommodation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelResources.Location = new System.Drawing.Point(10, 10);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(317, 38);
            this.labelResources.TabIndex = 2;
            this.labelResources.Text = "Resource Management";
            // 
            // resourcesTabControl
            // 
            this.resourcesTabControl.Controls.Add(this.tabAccommodation);
            this.resourcesTabControl.Location = new System.Drawing.Point(30, 40);
            this.resourcesTabControl.Name = "resourcesTabControl";
            this.resourcesTabControl.SelectedIndex = 0;
            this.resourcesTabControl.Size = new System.Drawing.Size(780, 300);
            this.resourcesTabControl.TabIndex = 1;
            // 
            // tabAccommodation
            // 
            this.tabAccommodation.Controls.Add(this.accommodationsDataGridView);
            this.tabAccommodation.Location = new System.Drawing.Point(4, 29);
            this.tabAccommodation.Name = "tabAccommodation";
            this.tabAccommodation.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccommodation.Size = new System.Drawing.Size(872, 317);
            this.tabAccommodation.TabIndex = 0;
            this.tabAccommodation.Text = "Accommodation";
            this.tabAccommodation.UseVisualStyleBackColor = true;
            // 
            // accommodationsDataGridView
            // 
            this.accommodationsDataGridView.AllowUserToAddRows = false;
            this.accommodationsDataGridView.AllowUserToDeleteRows = false;
            this.accommodationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accommodationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.accommodationsDataGridView.Location = new System.Drawing.Point(5, 5);
            this.accommodationsDataGridView.Name = "accommodationsDataGridView";
            this.accommodationsDataGridView.ReadOnly = true;
            this.accommodationsDataGridView.RowHeadersWidth = 52;
            this.accommodationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accommodationsDataGridView.Size = new System.Drawing.Size(762, 270);
            this.accommodationsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // TourOperatorResources
            // 
            this.Controls.Add(this.resourcesTabControl);
            this.Controls.Add(this.labelResources);
            this.Name = "TourOperatorResources";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.TourOperatorResources_Load);
            this.resourcesTabControl.ResumeLayout(false);
            this.tabAccommodation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accommodationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadHotelData()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    h.HotelID,
                    h.HotelName,
                    h.Location,
                    h.Stars,
                    sp.Name AS ContactPerson,
                    sp.PhoneNumber,
                    h.Rooms AS AvailableRooms
                FROM Hotel h
                JOIN ServiceProvider sp ON h.ProviderID = sp.ProviderID
            ";

            accommodationsDataGridView.Rows.Clear();
            accommodationsDataGridView.Columns.Clear();

            accommodationsDataGridView.Columns.Add("HotelID", "HotelID");
            accommodationsDataGridView.Columns.Add("Name", "Name");
            accommodationsDataGridView.Columns.Add("Location", "Location");
            accommodationsDataGridView.Columns.Add("Rating", "Rating");
            accommodationsDataGridView.Columns.Add("ContactPerson", "Contact Person");
            accommodationsDataGridView.Columns.Add("Phone", "Phone");
            accommodationsDataGridView.Columns.Add("AvailableRooms", "Available Rooms");

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accommodationsDataGridView.Rows.Add(
                            reader["HotelID"].ToString(),
                            reader["HotelName"].ToString(),
                            reader["Location"].ToString(),
                            reader["Stars"].ToString() + "-star",
                            reader["ContactPerson"].ToString(),
                            reader["PhoneNumber"].ToString(),
                            reader["AvailableRooms"].ToString()
                        );
                    }
                }
            }
        }

        private void AdjustControlPositions()
        {
            // Center the resources label
            labelResources.Left = (this.Width - labelResources.Width) / 2;
            labelResources.Top = 5;
            labelResources.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void TourOperatorResources_Load(object sender, EventArgs e)
        {

        }
    }
}