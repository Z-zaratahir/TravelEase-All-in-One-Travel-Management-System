namespace Project
{
    partial class PlatformAnalytics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformAnalytics));
            this.admin = new System.Windows.Forms.Label();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.chartTotalUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTotalBookings = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.labelRevenueAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(275, 144);
            this.admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(452, 62);
            this.admin.TabIndex = 4;
            this.admin.Text = "PLATFORM ANALYTICS";
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalUsers.CausesValidation = false;
            this.labelTotalUsers.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUsers.Location = new System.Drawing.Point(191, 219);
            this.labelTotalUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(116, 25);
            this.labelTotalUsers.TabIndex = 5;
            this.labelTotalUsers.Text = "Total Users";
            this.labelTotalUsers.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartTotalUsers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalUsers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalUsers.Legends.Add(legend1);
            this.chartTotalUsers.Location = new System.Drawing.Point(150, 246);
            this.chartTotalUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTotalUsers.Name = "chartTotalUsers";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTotalUsers.Series.Add(series1);
            this.chartTotalUsers.Size = new System.Drawing.Size(217, 166);
            this.chartTotalUsers.TabIndex = 6;
            this.chartTotalUsers.Text = "chart1";
            this.chartTotalUsers.Click += new System.EventHandler(this.chartTotalUsers_Click);
            // 
            // labelTotalBookings
            // 
            this.labelTotalBookings.AutoSize = true;
            this.labelTotalBookings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalBookings.CausesValidation = false;
            this.labelTotalBookings.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBookings.Location = new System.Drawing.Point(407, 219);
            this.labelTotalBookings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalBookings.Name = "labelTotalBookings";
            this.labelTotalBookings.Size = new System.Drawing.Size(150, 25);
            this.labelTotalBookings.TabIndex = 7;
            this.labelTotalBookings.Text = "Total Bookings";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(383, 246);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(207, 166);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalRevenue.CausesValidation = false;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.Location = new System.Drawing.Point(613, 219);
            this.labelTotalRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(144, 25);
            this.labelTotalRevenue.TabIndex = 9;
            this.labelTotalRevenue.Text = "Total Revenue";
            this.labelTotalRevenue.Click += new System.EventHandler(this.labelTotalRevenue_Click);
            // 
            // labelRevenueAmount
            // 
            this.labelRevenueAmount.AutoSize = true;
            this.labelRevenueAmount.BackColor = System.Drawing.Color.White;
            this.labelRevenueAmount.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold);
            this.labelRevenueAmount.ForeColor = System.Drawing.Color.Red;
            this.labelRevenueAmount.Location = new System.Drawing.Point(625, 266);
            this.labelRevenueAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRevenueAmount.Name = "labelRevenueAmount";
            this.labelRevenueAmount.Size = new System.Drawing.Size(82, 25);
            this.labelRevenueAmount.TabIndex = 10;
            this.labelRevenueAmount.Text = "Rs. 0.00";
            this.labelRevenueAmount.UseWaitCursor = true;
            this.labelRevenueAmount.Click += new System.EventHandler(this.labelRevenueAmount_Click);
            // 
            // PlatformAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.labelRevenueAmount);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelTotalBookings);
            this.Controls.Add(this.chartTotalUsers);
            this.Controls.Add(this.labelTotalUsers);
            this.Controls.Add(this.admin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlatformAnalytics";
            this.Size = new System.Drawing.Size(1000, 520);
            this.Load += new System.EventHandler(this.PlatformAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label labelTotalUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalUsers;
        private System.Windows.Forms.Label labelTotalBookings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.Label labelRevenueAmount;
    }
}
