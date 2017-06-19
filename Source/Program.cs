using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
        }
    }
}
