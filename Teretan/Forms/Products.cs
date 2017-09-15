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
            grid.Columns.Add("ID", I18N.String("id"));
            grid.Columns.Add("Ime", I18N.String("name"));
            grid.Columns.Add("Opis", I18N.String("description"));
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

        private void EditProduct(object sender, EventArgs e)
        {
            // TODO: I18N
            if(grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati proizvod!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new EditProduct(new Product(grid.SelectedRows[0])).ShowDialog();
                Reload();
            }
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            // TODO: I18N
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati proizvod!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Product sel = new Product(grid.SelectedRows[0]);
                if (Database.CheckProduct(sel))
                {
                    MessageBox.Show("Neki korisnici su kupili ovaj proizvod i nije ga moguce obrisati");
                }
                else
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da obrisete:" + sel.Name, "Da li ste sigurni?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Database.RemoveProduct(sel);
                    }
                }
                Reload();
            }
        }
    }
}
