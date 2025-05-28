//using Project.AdminInterface;
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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
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

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new UserOperator());
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            LoadPage(new tourCategories());
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            LoadPage(new PlatformAnalytics());
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            LoadPage(new ReviewModeration());
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
