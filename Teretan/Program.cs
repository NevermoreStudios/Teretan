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
            I18N.Init();
            Database.Init();
            Preferences.Init();

            Application.Run(new Main());
            Database.Dispose();
        }
    }
}
