using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretan
{
    public partial class EditProduct : Form
    {
        public EditProduct(Product p)
        {
            InitializeComponent();
            textBox1.Text = p.Name;
            textBox2.Text = p.Description;
            Prod = p;
        }

        Product Prod;

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Handler.UpdateProduct(new Product(Prod.ID, textBox1.Text, textBox2.Text));
            this.Close();
        }

    }
}
