using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teretan
{
    public partial class AddOrder : Form
    {
        int uid;
        List<Product> p;

        public AddOrder(int uid)
        {
            InitializeComponent();
            I18N.TranslateControls(this);
            this.uid = uid;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectProduct.SelectedIndex == -1)
                {
                    Util.ShowError("select-product");
                    return;
                }
                Database.AddOrder(new Order(0, p[selectProduct.SelectedIndex].ID, uid, selectDate.Value));
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
            Close();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            try
            {
                p = Database.GetProducts();
                if(p.Count == 0)
                {
                    Util.ShowError("no-products");
                    Close();
                }
                else
                {
                    foreach (Product prod in p)
                    {
                        selectProduct.Items.Add(prod.Name);
                    }
                    selectProduct.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
                Close();
            }
        }
    }
}
