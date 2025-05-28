using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Panel panelNavbar;
        private Panel panelContent;

        private PictureBox logo;
        private Label appTitle;

        private void InitializeCustomLayout()
        {
            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.BackColor = System.Drawing.Color.White;
            this.Controls.Add(panelContent);
        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowMainPage();
        }

        public void ShowMainPage()
        {
            this.Controls.Clear();
            mainpage mainPage = new mainpage(this);
            mainPage.Dock = DockStyle.Fill;
            this.Controls.Add(mainPage);
        }

        public void ShowDashboard()
        {
            this.Controls.Clear();
            InitializeComponent();
            InitializeCustomLayout();
            LoadPage(new dashboard());
        }

        private void searchtripb_Click(object sender, EventArgs e) => LoadPage(new searchTrip());
        private void bookingb_Click(object sender, EventArgs e) => LoadPage(new etickets());
        private void homeb_Click(object sender, EventArgs e) => LoadPage(new dashboard());
        private void reviewb_Click(object sender, EventArgs e) => LoadPage(new reviews());
        private void myprofileb_Click(object sender, EventArgs e) => LoadPage(new myprofile());
        //private void reportb_Click(object sender, EventArgs e) => LoadPage(new reports());

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
