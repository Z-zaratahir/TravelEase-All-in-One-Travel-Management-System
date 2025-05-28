using Microsoft.Reporting.WinForms;
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

namespace Project
{

    public partial class FormReport5 : Form
    {
        const string reportPath = "Project.Report5.rdlc"; // Update if necessary
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;"; // Update connection string if needed

        public FormReport5()
        {
            InitializeComponent();
        }

        private void FormReport5_Load(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding,
                    out extension, out streamids, out warnings);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Report As PDF";
                    saveFileDialog.FileName = "Report.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                        MessageBox.Show("Report successfully saved as PDF.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting report: " + ex.Message);
            }
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

                string queryBookingsPerDestination = @"
                    SELECT 
                        TD.Destination, 
                        COUNT(B.BookingID) AS NumberOfBookings
                    FROM 
                        TripDestinations TD
                    JOIN 
                        Trip T ON T.TripID = TD.TripID
                    JOIN 
                        BookingAttempt BA ON BA.TripID = T.TripID AND BA.IsCompleted = 1
                    JOIN 
                        Booking B ON B.AttemptID = BA.AttemptID
                    GROUP BY 
                        TD.Destination
                    ORDER BY 
                        NumberOfBookings DESC;";

                SqlDataAdapter daBookingsPerDestination = new SqlDataAdapter(queryBookingsPerDestination, con);
                DataTable dtBookingsPerDestination = new DataTable();
                daBookingsPerDestination.Fill(dtBookingsPerDestination);

                // If no data, add a dummy row
                if (dtBookingsPerDestination.Rows.Count == 0)
                    dtBookingsPerDestination.Rows.Add("No Data", 0); // Dummy row for Destination and NumberOfBookings

                // Create a ReportDataSource with the new dataset name
                ReportDataSource rdsBookingsPerDestination = new ReportDataSource("BookingsPerDestination", dtBookingsPerDestination);

                string query = @"
                    SELECT 
                        DATENAME(MONTH, BA.AttemptDate) AS MonthName,
                        COUNT(B.BookingID) AS NumberOfBookings
                    FROM 
                        BookingAttempt BA
                    JOIN 
                        Booking B ON B.AttemptID = BA.AttemptID
                    WHERE 
                        BA.IsCompleted = 1
                    GROUP BY 
                        MONTH(BA.AttemptDate), DATENAME(MONTH, BA.AttemptDate)
                    ORDER BY 
                        MONTH(BA.AttemptDate);";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    dt.Rows.Add("No Data", 0); // Optional dummy row

                ReportDataSource rds = new ReportDataSource("MonthlyBookings", dt);

                string querySatisfaction = @"
                    SELECT 
                        td.Destination,
                        AVG(r.Rating) AS AverageRating
                    FROM 
                        Review r
                    JOIN 
                        TripDestinations td ON r.TripID = td.TripID
                    GROUP BY 
                        td.DestinationID, td.Destination
                    ORDER BY 
                        AverageRating DESC;";

                SqlDataAdapter daSatisfaction = new SqlDataAdapter(querySatisfaction, con);
                DataTable dtSatisfaction = new DataTable();
                daSatisfaction.Fill(dtSatisfaction);

                if (dtSatisfaction.Rows.Count == 0)
                    dtSatisfaction.Rows.Add("No Data", 0.0); // Optional dummy row

                ReportDataSource rdsSatisfaction = new ReportDataSource("DestinationRatings", dtSatisfaction);

                string queryGrowth = @"
                    WITH MonthlyBookings AS (
                        SELECT 
                            d.Destination,
                            YEAR(b.Date) AS Year,
                            MONTH(b.Date) AS Month,
                            COUNT(b.BookingID) AS Bookings
                        FROM TripDestinations d
                        JOIN Trip t ON d.TripID = t.TripID
                        JOIN BookingAttempt ba ON t.TripID = ba.TripID
                        JOIN Booking b ON ba.AttemptID = b.AttemptID
                        WHERE b.Date >= DATEADD(MONTH, -2, GETDATE())  -- Filter bookings from the last 2 months
                        GROUP BY d.Destination, YEAR(b.Date), MONTH(b.Date)
                    )
                    SELECT 
                        curr.Destination,
                        (curr.Bookings - ISNULL(prev.Bookings, 0)) AS Growth
                    FROM MonthlyBookings curr
                    LEFT JOIN MonthlyBookings prev
                        ON curr.Destination = prev.Destination
                        AND curr.Year = prev.Year
                        AND curr.Month = prev.Month + 1  -- Compare current month to the previous month
                    WHERE curr.Year = YEAR(GETDATE()) 
                      AND curr.Month = MONTH(GETDATE()) - 1  -- Filter for the last month
                    ORDER BY Growth DESC;";  // Order by the growth in descending order

                // Create SqlDataAdapter to fetch data using the query
                SqlDataAdapter daGrowth = new SqlDataAdapter(queryGrowth, con);
                DataTable dtGrowth = new DataTable();
                daGrowth.Fill(dtGrowth);

                // Add a dummy row if no data is returned
                if (dtGrowth.Rows.Count == 0)
                {
                    dtGrowth.Rows.Add("No Data", 0); // Dummy row for Destination, Growth
                }

                // Create ReportDataSource
                ReportDataSource rdsGrowth = new ReportDataSource("GrowthReport", dtGrowth);


                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsBookingsPerDestination);
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.DataSources.Add(rdsSatisfaction);
                    reportViewer1.LocalReport.DataSources.Add(rdsGrowth);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }
            }
        }
    }


}
