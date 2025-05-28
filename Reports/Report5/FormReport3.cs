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
    public partial class FormReport3 : Form
    {
        const string reportPath = "Project.Report3.rdlc";
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
        public FormReport3()
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

                string queryOperatorRating = @"
                                            SELECT 
                                                O.CompanyName AS OperatorName,
                                                ROUND(AVG(CAST(R.Rating AS FLOAT)), 2) AS AverageRating
                                            FROM Review R
                                            JOIN Operator O ON R.OperatorID = O.OperatorID
                                            WHERE R.Rating IS NOT NULL
                                            GROUP BY O.CompanyName";

                SqlDataAdapter daRatings = new SqlDataAdapter(queryOperatorRating, con);
                DataTable dtRatings = new DataTable();
                daRatings.Fill(dtRatings);

                // Dummy row in case of no data
                if (dtRatings.Rows.Count == 0)
                    dtRatings.Rows.Add("No Data", 0.0);

                ReportDataSource rdsRatings = new ReportDataSource("Ratings", dtRatings);

                string queryTotalRevenue = @"
                    SELECT 
                        O.CompanyName AS OperatorName,
                        SUM(B.TotalAmount) AS TotalRevenue
                    FROM 
                        Operator O
                    JOIN 
                        Trip T ON O.OperatorID = T.OperatorID
                    JOIN 
                        BookingAttempt BA ON T.TripID = BA.TripID
                    JOIN 
                        Booking B ON B.AttemptID = BA.AttemptID
                    JOIN 
                        Payment P ON B.PaymentID = P.PaymentID
                    WHERE 
                        BA.IsCompleted = 1
                    GROUP BY 
                        O.CompanyName;";

                SqlDataAdapter daOperatorRevenue = new SqlDataAdapter(queryTotalRevenue, con);
                DataTable dtOperatorRevenue = new DataTable();
                daOperatorRevenue.Fill(dtOperatorRevenue);

                // If no data, add a dummy row
                if (dtOperatorRevenue.Rows.Count == 0)
                    dtOperatorRevenue.Rows.Add("No Data", 0.0);

                // Create a ReportDataSource with the new dataset name
                ReportDataSource rdsOperatorRevenue = new ReportDataSource("OperatorRevenue", dtOperatorRevenue);

                string queryResponseTime = @"
                    SELECT 
                        PassID,
                        DATEDIFF(MINUTE, RequestDate, GeneratedDate) AS ResponseTimeInMinutes
                    FROM 
                        TravelPass
                    WHERE 
                        RequestDate IS NOT NULL AND GeneratedDate IS NOT NULL;";

                SqlDataAdapter daResponseTime = new SqlDataAdapter(queryResponseTime, con);
                DataTable dtResponseTime = new DataTable();
                daResponseTime.Fill(dtResponseTime);

                // If no data, add a dummy row
                if (dtResponseTime.Rows.Count == 0)
                    dtResponseTime.Rows.Add(0, 0); // Dummy row for PassID and ResponseTimeInMinutes

                // Create a ReportDataSource with the new dataset name
                ReportDataSource rdsResponseTime = new ReportDataSource("ResponseTime", dtResponseTime);


                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsRatings);
                    reportViewer1.LocalReport.DataSources.Add(rdsOperatorRevenue);
                    reportViewer1.LocalReport.DataSources.Add(rdsResponseTime);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }
            }
        }

        private void FormReport3_Load(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Render the report as a byte array
                Warning[] warnings;
                string[] streamIds;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding,
                    out extension, out streamIds, out warnings);

                // Ask user where to save the file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Report As PDF";
                    saveFileDialog.FileName = "OperatorReport.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                        MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
