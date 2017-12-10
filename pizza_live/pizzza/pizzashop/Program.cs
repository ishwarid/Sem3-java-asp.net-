using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pizzashop
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
            //Application.Run(new Stock());
            Application.Run(new login());
            //Application.Run(new Report());
            //Application.Run(new Products());
            //Application.Run(new Form2());

        }
    }
}
