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
    public partial class FormReport8 : Form
    {
        const string reportPath = "Project.Report8.rdlc"; // Update if different
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public FormReport8()
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
                string queryAbandoned = @"SELECT 
                                            CASE 
                                                WHEN BA.IsCompleted = 0 THEN 'Abandoned'
                                                ELSE 'Not Abandoned'
                                            END AS Status,
                                            ROUND(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM BookingAttempt), 2) AS Percentage
                                        FROM 
                                            BookingAttempt BA
                                        GROUP BY 
                                            CASE 
                                                WHEN BA.IsCompleted = 0 THEN 'Abandoned'
                                                ELSE 'Not Abandoned'
                                            END;";
                SqlDataAdapter daAbandonedRate = new SqlDataAdapter(queryAbandoned, con);
                DataTable dtAbandonedRate = new DataTable();
                daAbandonedRate.Fill(dtAbandonedRate);

                // Add a dummy row if no data is returned
                if (dtAbandonedRate.Rows.Count == 0)
                {
                    dtAbandonedRate.Rows.Add("No Data", 0.0); // Dummy row for Status, Percentage
                }

                // Create ReportDataSource
                ReportDataSource rdsAbandonedRate = new ReportDataSource("AbandonedRate", dtAbandonedRate);


                string queryReasons = @"
                    SELECT 
                        Reason,
                        ROUND(COUNT(*) * 100.0 / 
                              (SELECT COUNT(*) FROM BookingAttempt WHERE IsCompleted = 0 AND Reason IS NOT NULL), 2) AS Percentage
                    FROM 
                        BookingAttempt
                    WHERE 
                        IsCompleted = 0 AND Reason IS NOT NULL
                    GROUP BY 
                        Reason;";

                SqlDataAdapter daReasons = new SqlDataAdapter(queryReasons, con);
                DataTable dtReasons = new DataTable();
                daReasons.Fill(dtReasons);

                // Add dummy row if no data
                if (dtReasons.Rows.Count == 0)
                {
                    dtReasons.Rows.Add("No Data", 0.0); // Dummy Reason, Percentage
                }

                // Create and bind the report data source
                ReportDataSource rdsReasons = new ReportDataSource("Reasons", dtReasons);


                string queryRecovery = @"
                    SELECT 
                        CASE 
                            WHEN BA2.TravelerID IS NOT NULL THEN 'Recovered'
                            ELSE 'Not Recovered'
                        END AS Status,
                        ROUND(COUNT(*) * 100.0 / 
                              (SELECT COUNT(*) FROM BookingAttempt WHERE IsCompleted = 0), 2) AS Percentage
                    FROM 
                        BookingAttempt BA1
                    LEFT JOIN 
                        (SELECT DISTINCT TravelerID FROM BookingAttempt WHERE IsCompleted = 1) BA2
                        ON BA1.TravelerID = BA2.TravelerID
                    WHERE 
                        BA1.IsCompleted = 0
                    GROUP BY 
                        CASE 
                            WHEN BA2.TravelerID IS NOT NULL THEN 'Recovered'
                            ELSE 'Not Recovered'
                        END;";

                SqlDataAdapter daRecovery = new SqlDataAdapter(queryRecovery, con);
                DataTable dtRecovery = new DataTable();
                daRecovery.Fill(dtRecovery);

                // Add dummy row if no data
                if (dtRecovery.Rows.Count == 0)
                {
                    dtRecovery.Rows.Add("No Data", 0.0); // Dummy row for Status, Percentage
                }

                // Create and bind the report data source
                ReportDataSource rdsRecovery = new ReportDataSource("Recovery", dtRecovery);


                // Query for Potential Revenue Loss
                string queryRevenueLoss = @"
                    SELECT 
                        'Potential Revenue Loss' AS Status,
                        ROUND(SUM(T.Price), 2) AS PotentialRevenueLoss
                    FROM 
                        BookingAttempt BA
                    JOIN 
                        Trip T ON BA.TripID = T.TripID
                    WHERE 
                        BA.IsCompleted = 0;";

                SqlDataAdapter daRevenueLoss = new SqlDataAdapter(queryRevenueLoss, con);
                DataTable dtRevenueLoss = new DataTable();
                daRevenueLoss.Fill(dtRevenueLoss);

                // Add dummy row if no data
                if (dtRevenueLoss.Rows.Count == 0)
                {
                    dtRevenueLoss.Rows.Add("No Data", 0.0); // Dummy row for Status, PotentialRevenueLoss
                }

                // Create and bind the report data source
                ReportDataSource rdsRevenueLoss = new ReportDataSource("RevenueLoss", dtRevenueLoss);

                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsAbandonedRate);
                    reportViewer1.LocalReport.DataSources.Add(rdsReasons);
                    reportViewer1.LocalReport.DataSources.Add(rdsRecovery);
                    reportViewer1.LocalReport.DataSources.Add(rdsRevenueLoss);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }

            }
        }

        private void FormReport8_Load(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Refresh the report before rendering
                reportViewer1.RefreshReport();

                // Render the report to a byte array in PDF format
                Warning[] warnings;
                string[] streamIds;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding,
                    out extension, out streamIds, out warnings);

                // Open Save File Dialog to choose location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Report as PDF";
                saveFileDialog.FileName = "Report6.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                    MessageBox.Show("Report downloaded successfully!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading report: " + ex.Message);
            }
        }
    }
}
