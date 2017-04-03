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
    public partial class AddOrder : Form
    {
        public AddOrder(int uid)
        {
            InitializeComponent();
            this.uid = uid;
        }
        int uid;
        List<Product> p;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.AddOrder(new Order(0, p[comboBox1.SelectedIndex].ID, uid, dateTimePicker1.Value));
            }
            catch (Exception)
            {
                MessageBox.Show("Greska: Obavezno polje nije popunjeno");
            }
            this.Close();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            try
            {
                p = Database.GetProducts();
                foreach (Product prod in p)
                {
                    comboBox1.Items.Add(prod.Name);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Nije definisan ni jedan proizvod");
            }
            
        }
    }
}
