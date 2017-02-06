using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public class Product
    {
        public Product(int ID,string Name,string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
        public int ID;
        public string Name;
        public string Description;
    }
}
