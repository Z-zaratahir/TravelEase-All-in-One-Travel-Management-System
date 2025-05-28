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
    public partial class TourOperatorAnalytics : UserControl
    {
        private Label labelAnalytics;
        private TabControl analyticsTabControl;
        private TabPage tabSales;
        private TabPage tabPerformance;
        private TabPage tabReports;

        private DataGridView salesDataGridView;
        private Panel chartPanel;
        private ComboBox periodComboBox;
        private Label labelPeriod;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView tripPerformanceDataGridView;

        public TourOperatorAnalytics()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.AutoScroll = false;
            this.Size = new Size(897, 400);

            AdjustControlPositions();
        }

        private void InitializeComponent()
        {
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.analyticsTabControl = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tripPerformanceDataGridView = new System.Windows.Forms.DataGridView();
            this.analyticsTabControl.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPerformanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAnalytics
            // 
            this.labelAnalytics.AutoSize = true;
            this.labelAnalytics.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelAnalytics.Location = new System.Drawing.Point(10, 10);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(286, 38);
            this.labelAnalytics.TabIndex = 2;
            this.labelAnalytics.Text = "Analytics Dashboard";
            // 
            // analyticsTabControl
            // 
            this.analyticsTabControl.Controls.Add(this.tabSales);
            this.analyticsTabControl.Controls.Add(this.tabPerformance);
            this.analyticsTabControl.Controls.Add(this.tabReports);
            this.analyticsTabControl.Location = new System.Drawing.Point(10, 40);
            this.analyticsTabControl.Name = "analyticsTabControl";
            this.analyticsTabControl.SelectedIndex = 0;
            this.analyticsTabControl.Size = new System.Drawing.Size(880, 350);
            this.analyticsTabControl.TabIndex = 1;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.labelPeriod);
            this.tabSales.Controls.Add(this.periodComboBox);
            this.tabSales.Controls.Add(this.salesDataGridView);
            this.tabSales.Controls.Add(this.chartPanel);
            this.tabSales.Location = new System.Drawing.Point(4, 29);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(872, 317);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales Performance";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(570, 10);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(58, 20);
            this.labelPeriod.TabIndex = 0;
            this.labelPeriod.Text = "Period:";
            // 
            // periodComboBox
            // 
            this.periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "Last Month",
            "Last Quarter",
            "Last Year",
            "All Time"});
            this.periodComboBox.Location = new System.Drawing.Point(620, 8);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(120, 28);
            this.periodComboBox.TabIndex = 1;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.salesDataGridView.Location = new System.Drawing.Point(5, 35);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.RowHeadersWidth = 62;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(862, 140);
            this.salesDataGridView.TabIndex = 0;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.White;
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Location = new System.Drawing.Point(5, 180);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(862, 139);
            this.chartPanel.TabIndex = 1;
            this.chartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPanel_Paint);
            // 
            // tabPerformance
            // 
            this.tabPerformance.Controls.Add(this.tripPerformanceDataGridView);
            this.tabPerformance.Location = new System.Drawing.Point(4, 29);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerformance.Size = new System.Drawing.Size(872, 317);
            this.tabPerformance.TabIndex = 1;
            this.tabPerformance.Text = "Trip Performance";
            this.tabPerformance.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(872, 317);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Generated Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tripPerformanceDataGridView
            // 
            this.tripPerformanceDataGridView.AllowUserToAddRows = false;
            this.tripPerformanceDataGridView.AllowUserToDeleteRows = false;
            this.tripPerformanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripPerformanceDataGridView.Location = new System.Drawing.Point(5, 5);
            this.tripPerformanceDataGridView.Name = "tripPerformanceDataGridView";
            this.tripPerformanceDataGridView.ReadOnly = true;
            this.tripPerformanceDataGridView.RowHeadersWidth = 62;
            this.tripPerformanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tripPerformanceDataGridView.Size = new System.Drawing.Size(862, 300);
            this.tripPerformanceDataGridView.TabIndex = 0;
            // 
            // TourOperatorAnalytics
            // 
            this.Controls.Add(this.analyticsTabControl);
            this.Controls.Add(this.labelAnalytics);
            this.Name = "TourOperatorAnalytics";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.TourOperatorAnalytics_Load);
            this.analyticsTabControl.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPerformanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AdjustControlPositions()
        {
            // Center the analytics label
            labelAnalytics.Left = (this.Width - labelAnalytics.Width) / 2;
            labelAnalytics.Top = 5;
            labelAnalytics.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Draw sample bar chart using real data from salesDataGridView
            Font labelFont = new Font("Arial", 8);
            Brush textBrush = Brushes.Black;
            Brush barBrush = Brushes.SkyBlue;
            Pen borderPen = Pens.DarkBlue;

            int margin = 40;
            int chartWidth = chartPanel.Width - 2 * margin;
            int chartHeight = chartPanel.Height - 2 * margin;
            int barWidth = 50;
            int spacing = 30;

            g.DrawLine(Pens.Black, margin, chartPanel.Height - margin, chartPanel.Width - margin, chartPanel.Height - margin); // X-axis
            g.DrawLine(Pens.Black, margin, margin, margin, chartPanel.Height - margin); // Y-axis

            // Get data from salesDataGridView
            int rowCount = Math.Min(5, salesDataGridView.Rows.Count); // Show top 5
            string[] labels = new string[rowCount];
            int[] values = new int[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                labels[i] = salesDataGridView.Rows[i].Cells["Destination"].Value?.ToString() ?? "";
                int.TryParse(salesDataGridView.Rows[i].Cells["Bookings"].Value?.ToString(), out values[i]);
            }
            int maxValue = values.Length > 0 ? values.Max() : 1;

            for (int i = 0; i < labels.Length; i++)
            {
                int barHeight = (int)((double)values[i] / maxValue * chartHeight);
                int x = margin + i * (barWidth + spacing);
                int y = chartPanel.Height - margin - barHeight;
                Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);
                g.FillRectangle(barBrush, barRect);
                g.DrawRectangle(borderPen, barRect);
                g.DrawString(labels[i], labelFont, textBrush, x + barWidth / 2 - 15, chartPanel.Height - margin + 5);
                g.DrawString(values[i].ToString(), labelFont, textBrush, x + barWidth / 2 - 5, y - 15);
            }
            g.DrawString("Total Bookings by Destination", new Font("Arial", 10, FontStyle.Bold), textBrush, margin + 50, margin - 20);
            for (int i = 0; i <= 4; i++)
            {
                int value = i * maxValue / 4;
                int y = chartPanel.Height - margin - i * chartHeight / 4;
                g.DrawString(value.ToString(), labelFont, textBrush, margin - 25, y - 6);
                g.DrawLine(Pens.LightGray, margin, y, chartPanel.Width - margin, y);
            }
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TourOperatorAnalytics_Load(object sender, EventArgs e)
        {
            LoadSalesPerformanceData();
            LoadTripPerformanceData();
            SetupReportButtons();
        }

        private void LoadSalesPerformanceData()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    t.TripID,
                    ISNULL((SELECT TOP 1 d.Destination FROM TripDestinations d WHERE d.TripID = t.TripID), '') AS Destination,
                    COUNT(b.BookingID) AS Bookings,
                    ISNULL(SUM(b.TotalAmount), 0) AS Revenue,
                    ISNULL(AVG(r.Rating), 0) AS AvgRating
                FROM Trip t
                LEFT JOIN BookingAttempt ba ON t.TripID = ba.TripID
                LEFT JOIN Booking b ON ba.AttemptID = b.AttemptID
                LEFT JOIN Review r ON t.TripID = r.TripID
                GROUP BY t.TripID
            ";

            salesDataGridView.Rows.Clear();
            salesDataGridView.Columns.Clear();
            salesDataGridView.Columns.Add("TripID", "Trip ID");
            salesDataGridView.Columns.Add("Destination", "Destination");
            salesDataGridView.Columns.Add("Bookings", "Bookings");
            salesDataGridView.Columns.Add("Revenue", "Revenue");
            salesDataGridView.Columns.Add("AvgRating", "Avg. Rating");

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salesDataGridView.Rows.Add(
                            reader["TripID"].ToString(),
                            reader["Destination"].ToString(),
                            reader["Bookings"].ToString(),
                            reader["Revenue"].ToString(),
                            reader["AvgRating"].ToString()
                        );
                    }
                }
            }
            chartPanel.Invalidate(); // Redraw chart with new data
        }

        private void LoadTripPerformanceData()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    t.TripID,
                    ISNULL((SELECT TOP 1 d.Destination FROM TripDestinations d WHERE d.TripID = t.TripID), '') AS Destination,
                    t.TotalSlots,
                    COUNT(b.BookingID) AS BookedSlots,
                    t.TotalSlots - COUNT(b.BookingID) AS AvailableSlots,
                    CASE WHEN t.TotalSlots > 0 THEN CAST(COUNT(b.BookingID) AS FLOAT) / t.TotalSlots * 100 ELSE 0 END AS CompletionPercent,
                    ISNULL(AVG(r.Rating), 0) AS AvgRating
                FROM Trip t
                LEFT JOIN BookingAttempt ba ON t.TripID = ba.TripID
                LEFT JOIN Booking b ON ba.AttemptID = b.AttemptID
                LEFT JOIN Review r ON t.TripID = r.TripID
                GROUP BY t.TripID, t.TotalSlots
            ";

            tripPerformanceDataGridView.Rows.Clear();
            tripPerformanceDataGridView.Columns.Clear();
            tripPerformanceDataGridView.Columns.Add("TripID", "Trip ID");
            tripPerformanceDataGridView.Columns.Add("Destination", "Destination");
            tripPerformanceDataGridView.Columns.Add("TotalSlots", "Total Slots");
            tripPerformanceDataGridView.Columns.Add("BookedSlots", "Booked Slots");
            tripPerformanceDataGridView.Columns.Add("AvailableSlots", "Available Slots");
            tripPerformanceDataGridView.Columns.Add("CompletionPercent", "Completion %");
            tripPerformanceDataGridView.Columns.Add("AvgRating", "Avg. Rating");

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tripPerformanceDataGridView.Rows.Add(
                            reader["TripID"].ToString(),
                            reader["Destination"].ToString(),
                            reader["TotalSlots"].ToString(),
                            reader["BookedSlots"].ToString(),
                            reader["AvailableSlots"].ToString(),
                            string.Format("{0:0.##}%", reader["CompletionPercent"]),
                            reader["AvgRating"].ToString()
                        );
                    }
                }
            }
        }

        private void SetupReportButtons()
        {
            // Add report buttons to tabReports
            tabReports.Controls.Clear();
            int y = 20;
            int spacing = 45;
            string[] reportNames = new string[] {
                "Tour Operator Performance Report",
                "Destination Popularity Report"
            };
            for (int i = 0; i < reportNames.Length; i++)
            {
                Button btn = new Button();
                btn.Text = reportNames[i];
                btn.Size = new Size(350, 35);
                btn.Location = new Point(50, y);
                btn.Tag = reportNames[i];
                if (btn.Text == "Tour Operator Performance Report")
                {
                    btn.Click += (s, e) => {
                        //var reportForm = new TourOperatorReviews();/////////////////////////////////////////////
                       // reportForm.Show();////////////////////////////////////////
                    };
                    // Add Download PDF button for this report
                    Button downloadBtn = new Button();
                    downloadBtn.Text = "Download PDF";
                    downloadBtn.Size = new Size(120, 35);
                    downloadBtn.Location = new Point(420, y);
                    downloadBtn.Click += (s, e) => {
                        //var reportForm = new TourOperatorReviews();////////////////////////////////////////////
                        //reportForm.ExportToPdf();/////////////////////////////////////////////
                        MessageBox.Show("Operator Performance report downloaded as PDF.");
                    };
                    tabReports.Controls.Add(downloadBtn);
                }
                else if (btn.Text == "Destination Popularity Report")
                {
                    btn.Click += (s, e) => {
                        //var reportForm = new Destinations();///////////////////////////////
                        //reportForm.Show();//////////////////////////////////////////////////////////////////
                    };
                    // Add Download PDF button for this report
                    Button downloadBtn = new Button();
                    downloadBtn.Text = "Download PDF";
                    downloadBtn.Size = new Size(120, 35);
                    downloadBtn.Location = new Point(420, y);
                    downloadBtn.Click += (s, e) => {
                        //var reportForm = new Destinations();////////////////////////////////////////////
                        //reportForm.ExportToPdf();/////////////////////////////////////////
                        MessageBox.Show("Destination Popularity report downloaded as PDF.");
                    };
                    tabReports.Controls.Add(downloadBtn);
                }
                tabReports.Controls.Add(btn);
                y += spacing;
            }
        }
    }
}