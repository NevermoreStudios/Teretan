using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            DB_Handler.Init();

            //lazini baza testovi

            List<User> lu = DB_Handler.GetUser("SELECT * FROM Users");
            List<Product> lp = DB_Handler.GetProduct("SELECT * FROM Products");
            List<Order> lo = DB_Handler.GetOrder("SELECT * FROM Orders");
            Console.WriteLine(Util.GetNotif().Count);
            Console.WriteLine(Preferences.get("Yellow"));
            Console.WriteLine(Preferences.get("Red"));
            new Notifications().Show();

            //end lazini baza testovi

            Application.Run(new Main());
            DB_Handler.Dispose();
        }
    }
}
