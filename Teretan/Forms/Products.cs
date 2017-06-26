using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teretan
{
    public partial class Products : Form
    {
        List<Product> products;

        public Products()
        {
            products = Database.GetProducts();
            InitializeComponent();
            I18N.TranslateControls(this);
            Reload(true);
        }

        private void Reload()
        {
            Reload(false);
        }

        private void Reload(bool first)
        {
            if(!first)
            {
                products = Database.GetProducts();
                grid.Rows.Clear();
                grid.Columns.Clear();
            }
            grid.Columns.Add("id", I18N.String("id"));
            grid.Columns.Add("name", I18N.String("name"));
            grid.Columns.Add("desc", I18N.String("description"));
            grid.Columns[0].Visible = false;
            foreach(Product p in products)
            {
                grid.Rows.Add(new string[] { p.ID.ToString(), p.Name, p.Description });
            }
            grid.AutoResizeColumns();
            grid.AutoResizeRows();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            new EditProduct().ShowDialog();
            Reload();
        }

        private bool Selected()
        {
            if(grid.SelectedRows.Count == 0)
            {
                Util.ShowError("select-product");
                return false;
            }
            return true;
        }

        private void EditProduct(object sender, EventArgs e)
        {
            if(Selected())
            {
                new EditProduct(new Product(grid.SelectedRows[0])).ShowDialog();
                Reload();
            }
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            if (Selected())
            {
                Product sel = new Product(grid.SelectedRows[0]);
                if (Database.CheckProduct(sel))
                {
                    Util.ShowError("bought-error");
                }
                else
                {
                    if (Util.Question("product-delete-confirm", sel.Name))
                    {
                        Database.RemoveProduct(sel);
                    }
                }
                Reload();
            }
        }
    }
}
