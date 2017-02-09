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
            List<User> kopija = DB_Handler.GetUser("SELECT * FROM Users WHERE ID = 1");
            kopija[0].Name = "Kopija laze";
            DB_Handler.AddUser(kopija[0]);
            DB_Handler.AddProduct(new Product(0, "jos jedan proizvod", "hahahahah"));

            //end lazini baza testovi

            Application.Run(new Main());
            DB_Handler.Dispose();
        }
    }
}
