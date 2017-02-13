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
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            List<User> usr=Util.GetNotif();
            foreach (User item in usr)
            {
                int g = Util.GetSubLeft(item);
                if (g > 0) {
                    listBox1.Items.Add(String.Format("User {0} {1} has only {2}days left", item.Name, item.Surname,g)); }
                else {
                    listBox1.Items.Add(String.Format("User {0} {1} does not have a active subscription", item.Name, item.Surname));
                }
            }
            
        }
    }
}
