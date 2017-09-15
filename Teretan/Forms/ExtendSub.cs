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
    public partial class ExtendSub : Form
    {
        public ExtendSub(int uid)
        {
            InitializeComponent();
            this.uid = uid;
        }
        int uid;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User u = Database.GetUsers("SELECT * FROM `users` WHERE ID='{0}'", uid.ToString())[0];
                u.SubscriptionLength = new TimeSpan(Math.Max(u.GetSubLeft(), 0) + (int)numericUpDown1.Value, 0, 0, 0);
                u.SubscriptionDate = DateTime.Now;
                Database.UpdateUser(u);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska: Ili korisnik ne postoji ili postoji greska sa pretplatom");
            }
            this.Close();
        }
    }
}
