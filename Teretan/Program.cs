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

            // lazini baza testovi
            List<User> lu = Database.GetUsers();
            List<Product> lp = Database.GetProducts();
            List<Order> lo = Database.GetOrders();
            new Products().Show();
            // end lazini baza testovi

            Application.Run(new Main());
            Database.Dispose();
        }
    }
}
