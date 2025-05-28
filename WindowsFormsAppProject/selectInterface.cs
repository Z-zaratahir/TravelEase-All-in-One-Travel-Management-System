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
    public partial class selectInterface : UserControl
    {
        private Form1 mainForm;
        public selectInterface(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void travelerb_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            mainpage mainPage = new mainpage(mainForm);
            mainPage.Dock = DockStyle.Fill;
            this.Controls.Add(mainPage);
        }

        private void adminb_Click(object sender, EventArgs e)

        {
            this.Hide();
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Project\Project\bin\Debug\Project");
       

        }

        private void serviceprovider_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\ServiceProvider\ServiceProvider\bin\Debug\Project");

        }

        private void reportb_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            chooseReport reportForm = new chooseReport();  
         
            reportForm.Dock = DockStyle.Fill;

            this.Controls.Add(reportForm);

            reportForm.Show();
        }

        private void operatorb_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\TourOperator\TourOperator\bin\Debug\WindowsFormsAppProject");

        }
    }
}
