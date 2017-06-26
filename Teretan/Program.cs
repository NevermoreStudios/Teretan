using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teretan
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
            Database.Init();
            Preferences.Init();
            I18N.Init();

            Application.Run(new Main());
            Database.Dispose();
        }
    }
}
