using System;
using System.Windows.Forms;

namespace Teretan
{
    /// <summary>
    /// Dialog for extending a user's subscription.
    /// </summary>
    /// <seealso cref="Form" />
    public partial class ExtendSub : Form
    {
        User CurrentUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSub"/> class.
        /// </summary>
        /// <param name="UID">User ID of the user whose subscription should be extended</param>
        public ExtendSub(int UID)
        {
            InitializeComponent();
            I18N.TranslateControls(this);
            try
            {
                CurrentUser = Database.GetUserById(UID);
            }
            catch(Exception ex)
            {
                Util.DBError(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(CurrentUser.SubscriptionExpiry < DateTime.Now)
                {
                    CurrentUser.SubscriptionExpiry = DateTime.Now;
                }
                CurrentUser.SubscriptionExpiry = CurrentUser.SubscriptionExpiry.Add(new TimeSpan((int)extend.Value, 0, 0, 0));
                Database.UpdateUser(CurrentUser);
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
            Close();
        }
    }
}
