using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class etickets : UserControl
    {
        public etickets()
        {
            InitializeComponent();
        }




        private void mybookings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Save Travel Pass as PNG";
                saveDialog.FileName = "TravelPass.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = @"D:\Semester04\DB\Project\Images\travelTicket.png"; // Adjust path
                    File.Copy(sourcePath, saveDialog.FileName, true);
                    MessageBox.Show("Download complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
