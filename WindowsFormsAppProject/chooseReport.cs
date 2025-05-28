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
    public partial class chooseReport : UserControl
    {
        public chooseReport()
        {
            InitializeComponent();
        }

        private void r4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            reports r=new reports();
            r.Dock = DockStyle.Fill;
            this.Controls.Add(r);
        }

        private void r5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Report5\Report5\bin\Debug\Project");

        }

        private void r1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Report1\Report1\bin\Debug\Project");

       
        }

        private void r2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Report2\Report2\bin\Debug\Project");

        
        }

        private void r3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Report3\Report3\bin\Debug\Project");

        }

        private void r6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Semester04\DB\Project\Report6\Report6\bin\Debug\Project");

        }
    }
}
