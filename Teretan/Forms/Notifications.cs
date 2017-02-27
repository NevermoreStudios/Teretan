using System;
using System.Collections.Generic;
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
            List<User> usr = Util.GetNotif();
            foreach (User item in usr)
            {
                int g = item.GetSubLeft();
                if (g > 0)
                {
                    notificationList.Items.Add(string.Format("User {0} {1} has only {2} days left", item.Name, item.Surname,g));
                }
                else
                {
                    notificationList.Items.Add(string.Format("User {0} {1} does not have a active subscription", item.Name, item.Surname));
                }
            }
            
        }
    }
}
