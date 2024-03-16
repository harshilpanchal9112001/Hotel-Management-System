using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
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
            Application.Run(new Loading());
            //Application.Run(new LoginPage());
            //Application.Run(new Home());
            //Application.Run(new Bill());
        }
    }
}
