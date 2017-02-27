using System;

namespace Teretan
{
    public class Order
    {
        public int ID { get; }
        public int Product { get; }
        public int User { get; }
        public DateTime Date { get; }

        public Order(int ID, int Product, int User, DateTime Date)
        {
            this.ID = ID;
            this.Product = Product;
            this.User = User;
            this.Date = Date;
        }
    }
}
