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
    public partial class Form1 : Form
    {
        private int travelerID;
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
            panelContent.BackColor = Color.White;
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

        private void ShowMainPage()
        {
            this.Controls.Clear();

            selectInterface mainPage = new selectInterface(this);
            mainPage.Dock = DockStyle.Fill;
            this.Controls.Add(mainPage);
        }
      

        public void ShowDashboard(int userID)
        {

            this.Controls.Clear();
            InitializeComponent();
            travelerID=userID;
             InitializeCustomLayout(); 
            LoadPage(new dashboard(userID));
        }
        private void searchtripb_Click(object sender, EventArgs e)
        {
            LoadPage(new searchTrip(travelerID));
        }

        private void bookingb_Click(object sender, EventArgs e)
        {
            LoadPage(new etickets(travelerID));
        }

        private void homeb_Click(object sender, EventArgs e)
        {
            LoadPage(new dashboard(travelerID ));
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reviewb_Click(object sender, EventArgs e)
        {
            LoadPage(new reviews(travelerID));
        }

        private void myprofileb_Click(object sender, EventArgs e)
        {
            LoadPage(new myprofile(travelerID));
        }

        private void reportb_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new wishlist(travelerID));
        }
    }
}
