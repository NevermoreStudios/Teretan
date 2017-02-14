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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        List<Product> lp = new List<Product>();

        private void Products_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id =dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                desc = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Product sel = new Product(Convert.ToInt32(id), name, desc);
            new EditProduct(sel).ShowDialog();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                desc = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Product sel = new Product(Convert.ToInt32(id), name, desc);
            if (DB_Handler.CheckProduct(sel))
            {
                if (MessageBox.Show("Da li ste sigurni da zelite da obrisete:" + sel.Name, "Da li ste sigurni?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB_Handler.RemoveProduct(sel);
                }
            }
            else
            {
                MessageBox.Show("Neki korisnici su kupili ovaj proizvod i nije ga moguce obrisati");
            }
            load();
        }

        private void load()
        {
            lp.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            lp = DB_Handler.GetProduct("SELECT * FROM Products");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns[0].Visible = false;
            for (int i = 0; i < lp.Count; i++)
            {
                string[] arr = new string[3];
                arr[0] = lp[i].ID.ToString(); ;
                arr[1] = lp[i].Name;
                arr[2] = lp[i].Description;
                dataGridView1.Rows.Add(arr);
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }
    }
}
