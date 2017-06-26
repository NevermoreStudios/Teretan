using System;
using System.Windows.Forms;

namespace Teretan
{
    public partial class EditProduct : Form
    {
        Product Current;
        bool Editing;

        public EditProduct()
        {
            BaseConstruct(new Product(0, "", ""));
        }

        public EditProduct(Product Current)
        {
            BaseConstruct(Current);
            Editing = true;
            nameBox.Text = Current.Name;
            descBox.Text = Current.Description;
            editButton.Text = I18N.String("edit");
            Text = I18N.String("form-edit-product");
        }

        private void BaseConstruct(Product Current)
        {
            InitializeComponent();
            I18N.TranslateControls(this);
            this.Current = Current;
        }

        private void Edit(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim(),
                   desc = descBox.Text.Trim();
            if(name.Length == 0 || desc.Length == 0)
            {
                Util.ShowError("all-fields-required");
                return;
            }
            try
            {
                Product newProduct = new Product(Current.ID, name, desc);
                if (Editing)
                {
                    Database.UpdateProduct(newProduct);
                }
                else
                {
                    Database.AddProduct(newProduct);
                }
            }
            catch (Exception ex)
            {
                Util.ThrowError(ex);
                Util.ShowError("db-error");
            }
            Close();
        }
    }
}
