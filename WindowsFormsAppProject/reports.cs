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
using Microsoft.Reporting.WinForms;


namespace WindowsFormsAppProject
{
    public partial class reports : UserControl
    {

        public reports()
        {
            InitializeComponent();
            
        }

      

        private void reports_Load(object sender, EventArgs e)
            
        {
           
            this.view_TotalBookingsTableAdapter.Fill(this.travelEaseDataSet.view_TotalBookings);
            this.view_CancellationRateTableAdapter.Fill(this.travelEaseDataSet.view_CancellationRate);
            this.view_RevenueByCategoryTableAdapter.Fill(this.travelEaseDataSet.view_RevenueByCategory);

            this.view_AgeNationalityDistributionTableAdapter.Fill(this.travelEaseDataSet2.view_AgeNationalityDistribution);
            this.view_AvgBookingValueTableAdapter.Fill(this.travelEaseDataSet2.view_AvgBookingValue);
            this.view_AvgSpendingHabitsTableAdapter.Fill(this.travelEaseDataSet2.view_AvgSpendingHabits);
            this.view_AvgBookingValueTableAdapter.Fill(this.travelEaseDataSet2.view_AvgBookingValue);
            this.view_PeakBookingPeriodsTableAdapter.Fill(this.travelEaseDataSet2.view_PeakBookingPeriods);
            this.view_PreferredTripTypesDestinationsTableAdapter.Fill(this.travelEaseDataSet2.view_PreferredTripTypesDestinations);


            this.view_ActiveUsersTableAdapter.Fill(this.travelEaseDataSet3.view_ActiveUsers);
            this.view_NewUserRegistrationsTableAdapter.Fill(this.travelEaseDataSet3.view_NewUserRegistrations);
            this.view_PartnershipGrowthTableAdapter.Fill(this.travelEaseDataSet3.view_PartnershipGrowth);
            this.view_RegionalExpansionTableAdapter.Fill(this.travelEaseDataSet3.view_RegionalExpansion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void downloadb_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Report as PDF";
                    saveFileDialog.FileName = "User_Report.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, bytes);
                        MessageBox.Show("Report downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting PDF: " + ex.Message);
            }
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
