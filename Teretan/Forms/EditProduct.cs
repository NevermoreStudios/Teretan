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
            Text = "Dodaj proizvod";
            editButton.Text = "Dodaj";
        }

        public EditProduct(Product product)
        {
            InitializeComponent();
            Text = "Izmeni Proizvod";
            editButton.Text = "Izmeni";
            edit = true;
            nameBox.Text = product.Name;
            descBox.Text = product.Description;
            this.product = product;
        }

        private void Edit(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception)
            {
                MessageBox.Show("Greška: Obavezno polje nije popunjeno ili nije u potrebnom formatu");
            }
            Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
