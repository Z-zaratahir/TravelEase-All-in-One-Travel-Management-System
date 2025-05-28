using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ServiceProvider : Form
    {
        public ServiceProvider()
        {
            InitializeComponent();
            InitializeCustomLayout();
        }
        private Panel panelNavbar;
        private Panel panelContent;

        private PictureBox logo;
        private Label appTitle;

        private void InitializeCustomLayout()
        {

            // Panel Content
            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.BackColor = Color.White;
            this.Controls.Add(panelContent);

        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServiceProvider_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegiteration_Click(object sender, EventArgs e)
        {
            LoadPage(new ServiceIntegration());
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            LoadPage(new ServiceListing());
        }

        private void buttonBookingManagement_Click(object sender, EventArgs e)
        {
            LoadPage(new BookingManagement());
        }

        private void buttonPerformance_Click(object sender, EventArgs e)
        {
            LoadPage(new PerformanceReports());
        }
    }
}
