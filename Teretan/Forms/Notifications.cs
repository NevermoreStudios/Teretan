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
            I18N.TranslateControls(this);
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            try
            {
                List<User> usr = Util.GetNotif();
                foreach (User item in usr)
                {
                    if (item.Expired())
                    {
                        notificationList.Items.Add(I18N.String("notif-left", item.Name, item.Surname, item.GetSubLeft()));
                    }
                    else
                    {
                        notificationList.Items.Add(I18N.String("notif-inactive", item.Name, item.Surname));
                    }
                }
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
        }
    }
}
