using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trivia_master
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
            LoadingForm fm = new LoadingForm();
            fm.Show();
            Application.Run();
        }
    }
}
