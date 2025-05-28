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
    public partial class FormReport6 : Form
    {
        const string reportPath = "Project.Report6.rdlc"; // Update if different
        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";

        public FormReport6()
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

                // Query for Payment Status Percentage
                string queryPaymentStatusPercentage = @"
                    SELECT 
                        Status,
                        ROUND(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Payment WHERE Status IS NOT NULL), 2) AS Percentage
                    FROM 
                        Payment
                    WHERE 
                        Status IS NOT NULL
                    GROUP BY 
                        Status";
                SqlDataAdapter daPaymentStatusPercentage = new SqlDataAdapter(queryPaymentStatusPercentage, con);
                DataTable dtPaymentStatusPercentage = new DataTable();
                daPaymentStatusPercentage.Fill(dtPaymentStatusPercentage);

                // Add a dummy row if no data is returned
                if (dtPaymentStatusPercentage.Rows.Count == 0)
                {
                    dtPaymentStatusPercentage.Rows.Add("No Data", 0.0); // Dummy row for Status, Percentage
                }

                // Create ReportDataSource
                ReportDataSource rdsPaymentSuccess = new ReportDataSource("PaymentSuccess", dtPaymentStatusPercentage);


                // Updated Query: Disputed vs Non-Disputed
                string queryDisputed = @"
            SELECT 
                CASE 
                    WHEN Status = 'Pending' THEN 'Disputed'
                    ELSE 'Non-Disputed'
                END AS StatusLabel,
                ROUND(COUNT(*) * 100.0 / 
                    (SELECT COUNT(*) FROM Payment WHERE Status IN ('Completed', 'Failed', 'Pending')), 2
                ) AS Percentage
            FROM 
                Payment
            WHERE 
                Status IN ('Completed', 'Failed', 'Pending')
            GROUP BY 
                CASE 
                    WHEN Status = 'Pending' THEN 'Disputed'
                    ELSE 'Non-Disputed'
                END";

                SqlDataAdapter daDisputed = new SqlDataAdapter(queryDisputed, con);
                DataTable dtDisputed = new DataTable();
                daDisputed.Fill(dtDisputed);

                // Add dummy row if no data is returned
                if (dtDisputed.Rows.Count == 0)
                {
                    dtDisputed.Rows.Add("No Data", 0.0);
                }

                // Set up ReportDataSource — match the name used in RDLC dataset
                ReportDataSource rdsDisputed = new ReportDataSource("Disputed", dtDisputed);

                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsPaymentSuccess);
                    reportViewer1.LocalReport.DataSources.Add(rdsDisputed);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }

            }
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Refresh the report before exporting
                reportViewer1.RefreshReport();

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                // Render the report to byte array
                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);

                // Ask user where to save the file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Report As PDF";
                    saveFileDialog.FileName = "Report8.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                        MessageBox.Show("Report saved successfully!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReport6_Load(object sender, EventArgs e)
        {

        }
    }
}