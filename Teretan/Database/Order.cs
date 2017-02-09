using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public class Order
    {
        public Order(int ID,int IDProduct, int IDUser, DateTime Date)
        {
            this.ID = ID;
            this.IDProduct = IDProduct;
            this.IDUser = IDUser;
            this.Date = Date;
        }

        public int ID;
        public int IDProduct;
        public int IDUser;
        public DateTime Date;
    }
}
