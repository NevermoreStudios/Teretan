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
            try
            {
                List<User> usr = Util.GetNotif();
                foreach (User item in usr)
                {
                    int g = item.GetSubLeft();
                    if (g > 0)
                    {
                        notificationList.Items.Add(string.Format("Korisnik {0} {1} ima samo {2} dana preostalo", item.Name, item.Surname, g));
                    }
                    else
                    {
                        notificationList.Items.Add(string.Format("Korisnik {0} {1} nema aktivnu pretplatu", item.Name, item.Surname));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri učitavanju korisnika");
            }
            
            
        }
    }
}
