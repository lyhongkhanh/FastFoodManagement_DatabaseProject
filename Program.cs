using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainAddminForm());
            //Application.Run(new REVENUE.Revenue_Total());
            //Application.Run(new ShoppingForm());
            Application.Run(new StartForm());
        }
    }
}
