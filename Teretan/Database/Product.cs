using System;
using System.Windows.Forms;

namespace Teretan
{
    public class Product
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }

        public Product(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }

        public Product(DataGridViewRow row) : this(
            Convert.ToInt32(row.Cells[0].Value),
            row.Cells[1].Value.ToString(),
            row.Cells[2].Value.ToString()
        ) { }
    }
}
