using System;
using System.Windows.Forms;

namespace Teretan
{
    public partial class EditProduct : Form
    {
        Product product;
        bool edit;

        public EditProduct()
        {
            InitializeComponent();
            product = new Product(0, "", "");
        }

        public EditProduct(Product product)
        {
            InitializeComponent();
            edit = true;
            nameBox.Text = product.Name;
            descBox.Text = product.Description;
            this.product = product;
        }

        private void Edit(object sender, EventArgs e)
        {
            Product newProduct = new Product(product.ID, nameBox.Text, descBox.Text);
            if (edit)
            {
                Database.UpdateProduct(newProduct);
            }
            else
            {
                Database.AddProduct(newProduct);
            }
            Close();
        }
    }
}
