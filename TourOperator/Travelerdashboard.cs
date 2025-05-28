using System;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    internal static class Travelerdashboard
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Start the application with the main page
            Application.Run(new Form1());
        }
    }
}
