using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Project
{
    public partial class FormReport : Form
    {
        const string reportPath = "Project.Report4.rdlc";
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";


        public FormReport()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Chart 1: Query for Hotel Occupancy Rate
                string queryOccupancyRate = @"
                    SELECT 
                        H.HotelName,
                        CAST(COUNT(B.BookingID) AS FLOAT) / H.Rooms * 100 AS OccupancyRate
                    FROM 
                        Hotel H
                    JOIN 
                        ServiceProvider SP ON H.ProviderID = SP.ProviderID
                    JOIN 
                        ServiceAssignment SA ON SA.ProviderID = SP.ProviderID
                    JOIN 
                        Operator O ON O.OperatorID = SA.OperatorID
                    JOIN 
                        Trip T ON T.OperatorID = O.OperatorID
                    JOIN 
                        BookingAttempt BA ON BA.TripID = T.TripID AND BA.IsCompleted = 1
                    JOIN 
                        Booking B ON B.AttemptID = BA.AttemptID
                    GROUP BY 
                        H.HotelName, H.Rooms";
                SqlDataAdapter daOccupancyRate = new SqlDataAdapter(queryOccupancyRate, con);
                DataTable dtOccupancyRate = new DataTable();
                daOccupancyRate.Fill(dtOccupancyRate);

                // Add a dummy row if no data is returned for Occupancy Rate
                if (dtOccupancyRate.Rows.Count == 0)
                {
                    dtOccupancyRate.Rows.Add("No Data", 0.0); // Dummy row for HotelName, OccupancyRate
                }

                // Create ReportDataSource for Occupancy Rate
                ReportDataSource rdsOccupancyRate = new ReportDataSource("DataSetOccupancyRate", dtOccupancyRate);

                // Chart 2: Query for Average Rating
                string queryAverageRating = @"
                    SELECT 
                        Name AS GuideName,
                        AVG(CAST(Rating AS FLOAT)) AS AverageRating
                    FROM 
                        ServiceProvider
                    WHERE 
                        LOWER(LTRIM(RTRIM(Type))) = 'guide'
                        AND Rating IS NOT NULL
                    GROUP BY 
                        Name";
                SqlDataAdapter daAverageRating = new SqlDataAdapter(queryAverageRating, con);
                DataTable dtAverageRating = new DataTable();
                daAverageRating.Fill(dtAverageRating);

                // Add a dummy row if no data is returned for Average Rating
                if (dtAverageRating.Rows.Count == 0)
                {
                    dtAverageRating.Rows.Add("No Data", 0.0); // Dummy row for GuideName, AverageRating
                }

                // Create ReportDataSource for Average Rating
                ReportDataSource rdsAverageRating = new ReportDataSource("AverageRating", dtAverageRating);

                // Chart 3: Query for On-Time Performance
                string queryOnTimePerformance = @"
                    SELECT 
                        O.CompanyName AS OperatorName,
                        (SUM(CASE WHEN DATEDIFF(MINUTE, T.DepartureDate, T.ActualDepartureDate) <= 30 THEN 1 ELSE 0 END) * 100.0) / COUNT(*) AS OnTimePerformance
                    FROM 
                        Trip T
                    JOIN 
                        Operator O ON T.OperatorID = O.OperatorID
                    WHERE 
                        T.DepartureDate IS NOT NULL 
                        AND T.ActualDepartureDate IS NOT NULL
                    GROUP BY 
                        O.CompanyName";
                SqlDataAdapter daOnTimePerformance = new SqlDataAdapter(queryOnTimePerformance, con);
                DataTable dtOnTimePerformance = new DataTable();
                daOnTimePerformance.Fill(dtOnTimePerformance);

                // Add a dummy row if no data is returned for On-Time Performance
                if (dtOnTimePerformance.Rows.Count == 0)
                {
                    dtOnTimePerformance.Rows.Add("No Data", 0.0); // Dummy row for OperatorName, OnTimePerformance
                }

                // Create ReportDataSource for On-Time Performance
                ReportDataSource rdsTimeTravel = new ReportDataSource("TimeTravel", dtOnTimePerformance);



                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsOccupancyRate);
                    reportViewer1.LocalReport.DataSources.Add(rdsAverageRating);
                    reportViewer1.LocalReport.DataSources.Add(rdsTimeTravel);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warnings;
                string[] streamIds;
                string mimeType = "";
                string encoding = "";
                string extension = "";

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out extension,
                    out streamIds, out warnings);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Report as PDF";
                    saveFileDialog.FileName = "AnalyticsReport.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                        MessageBox.Show("Report successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export report: " + ex.Message);
            }
        }

    }
}