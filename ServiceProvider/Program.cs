using System;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminInterface());
            Application.Run(new ServiceProvider());
            //Application.Run(new FormReport());
            //Application.Run(new FormReport8());
            //Application.Run(new FormReport6());

        }
    }
}
