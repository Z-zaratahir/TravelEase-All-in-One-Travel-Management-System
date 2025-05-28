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
    public partial class mainpage : UserControl
    {
        private Form1 mainForm;  
        public mainpage(Form1 form)
        {
            InitializeComponent();
            mainForm = form;  
        }

    
        private void loginb_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();

           
            login loginForm = new login(mainForm);


            loginForm.Dock = DockStyle.Fill;
            this.Controls.Add(loginForm);


        }

       
        private void Signupb_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();

            

            Signup signUpForm = new Signup(mainForm);

            signUpForm.Dock = DockStyle.Fill;
            this.Controls.Add(signUpForm);

         
        

          
        }

        private void mainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
