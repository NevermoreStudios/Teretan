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
            Database.AddOrder(new Order(0, p[comboBox1.SelectedIndex].ID, uid, dateTimePicker1.Value));
            this.Close();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            p = Database.GetProducts();
            foreach (Product prod in p)
            {
                comboBox1.Items.Add(prod.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
