using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Teretan
{
    /// <summary>
    /// Main form of the project. Everything happens here.
    /// </summary>
    /// <seealso cref="Form" />
    public partial class Main : Form
    {
        private List<User> Users;
        private List<Order> Orders;
        private bool AddState = false;
        private bool EditState = false;
        private User CurrentUser;
        private List<DataControl> Data = new List<DataControl>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            I18N.TranslateControls(this);
            InitData();
        }

        /// <summary>
        /// Initializes the control to property bindings.
        /// </summary>
        private void InitData()
        {
            PropertyInfo[] userprops = typeof(User).GetProperties();
            Dictionary<string, PropertyInfo> temp = new Dictionary<string, PropertyInfo>();
            foreach (PropertyInfo p in userprops)
            {
                temp.Add(p.Name, p);
            }
            foreach (Control c in properties.Controls)
            {
                if (c.Tag != null)
                {
                    string[] split = c.Tag.ToString().Split(',');
                    foreach (string s in split)
                    {
                        if (s.StartsWith("input-"))
                        {
                            string[] split2 = s.Split('-');
                            int type = 0;
                            if (int.TryParse(split2[1], out type))
                            {
                                Data.Add(new DataControl(c, temp[split2[2]], type));
                                break;
                            }
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Sets if add/edit/remove controls should be enabled.
        /// </summary>
        /// <param name="v">If the controls should be enabled</param>
        /// <param name="c">Control to convert to a "Done" button</param>
        private void SetEn(bool v, Control c)
        {
            btnAddUser.Enabled = v;
            btnEditUser.Enabled = v;
            btnRemoveUser.Enabled = v;
            if(!v)
            {
                c.Text = I18N.String("done");
                c.Enabled = true;
            }
            foreach(Control control in properties.Controls)
            {
                if(!(control == tbAge || control is Label || control is ListBox))
                {
                    control.Enabled = !v;
                }
            }
            btnExtend.Enabled = CurrentUser.Active && !v;
        }

        /// <summary>
        /// Enables/disables controls available to non-new users.
        /// </summary>
        /// <param name="v">If controls available to non-new users should be enabled</param>
        private void SetNew(bool v)
        {
            btnAddOrder.Enabled = v;
            btnRemoveOrder.Enabled = v;
        }

        /// <summary>
        /// Updates the background of a table row depending on user's activity status.
        /// </summary>
        /// <param name="user">User located in the row</param>
        /// <param name="index">Index of the row</param>
        private void UpdateRowBack(User user, int index)
        {
            UserList.Rows[index].DefaultCellStyle.BackColor = !user.Active ?
                Color.Gray :
                    user.IsRed() ?
                        Color.Red :
                            user.IsYellow() ?
                                Color.Yellow :
                                Color.White;
        }

        /// <summary>
        /// Fills the table rows with user data
        /// </summary>
        private void Fill()
        {
            try
            {
                UserList.Rows.Clear();
                foreach (User usr in Users)
                {
                    UserList.Rows.Add(new string[] { usr.ID.ToString(), usr.UID.ToString(), usr.Name,
                        usr.Surname, usr.BirthDate.ToShortDateString(), usr.Email,
                        usr.Active ?
                            usr.Expired() ?
                                I18N.String("expired") :
                                usr.GetSubLeft().ToString() :
                            I18N.String("inactive")
                    });
                    UpdateRowBack(usr, UserList.Rows.Count - 1);
                }
                UserList.Sort(UserList.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                Util.ThrowError(ex);
                Util.ShowError("unknown-error");
            }
        }

        /// <summary>
        /// Loads data about a user into the edit form.
        /// </summary>
        /// <param name="u">The user to load into the forms</param>
        /// <param name="newUser">If the user is new</param>
        private void LoadUser(User u, bool newUser)
        {
            CurrentUser = u;
            try
            {
                foreach(DataControl d in Data)
                {
                    d.UpdateControl(ref u);
                }
                UpdateSubscriptionStatus();
                SetNew(!newUser);

                lbOrders.Items.Clear();
                Orders = Database.GetOrdersByUser(u);
                foreach (Order item in Orders)
                {
                    string product = Database.GetProductById(item.Product).Name;
                    string date = item.Date.ToShortDateString();
                    lbOrders.Items.Add(product + " " + date);
                }
                
                labelSubscriptionStatus.BackColor = u.IsRed() ?
                    Color.Red :
                    u.IsYellow() ?
                        Color.Yellow :
                        Color.FromKnownColor(KnownColor.Control);
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }

        }

        /// <summary>
        /// Loads a new user into the edit form.
        /// </summary>
        private void LoadUser()
        {
            LoadUser(new User(), true);
        }

        /// <summary>
        /// Loads a non-new user into the edit form.
        /// </summary>
        /// <param name="user">The user to load</param>
        private void LoadUser(User user)
        {
            LoadUser(user, false);
        }

        /// <summary>
        /// Updates the user's subscription status after loading and extending.
        /// </summary>
        private void UpdateSubscriptionStatus()
        {
            if(CurrentUser.Expired())
            {
                labelSubscriptionExpiry.Text = "";
                labelSubscriptionStatus.Text = I18N.String("expired");
            }
            else
            {
                labelSubscriptionExpiry.Text = CurrentUser.SubscriptionExpiry.ToString();
                labelSubscriptionStatus.Text = CurrentUser.GetSubLeft().ToString();
            }
        }

        /// <summary>
        /// Updates notifications
        /// </summary>
        private void UpdateNotification()
        {
            int count = Util.GetNotif().Count;
            string i18n = I18N.String("notifications");
            if (count > 0)
            {
                btnNotif.Text = $"{i18n} ({count})";
                btnNotif.BackColor = Color.Red;
            }
            else
            {
                btnNotif.Text = i18n;
                btnNotif.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        /// <summary>
        /// Refreshes the form when the user table updates.
        /// </summary>
        /// <param name="q">Query used to get the userlist</param>
        private void RefreshUser(string q)
        {
            Users = q == null ? Database.GetUsers() : Database.GetUsers(q);
            Fill();
            LoadUser();
            UpdateNotification();
        }

        /// <summary>
        /// Refreshes the form when the user table updates.
        /// </summary>
        private void RefreshUser()
        {
            RefreshUser(null);
        }

        /// <summary>
        /// Populates the user object with values from controls
        /// </summary>
        /// <returns>Populated <see cref="User"/> object</returns>
        private void PopulateUser()
        {
            foreach (DataControl d in Data)
            {
                d.UpdateUser(ref CurrentUser);
            }
        }

        /// <summary>
        /// Validates the input from controls
        /// </summary>
        /// <returns>If the input is valid</returns>
        private bool ValidateUser()
        {
            // TODO: Implement
            return true;
        }

        /// <summary>
        /// Sets the columns in the filter table up.
        /// </summary>
        private void SetColumns()
        {
            UserList.Columns.Add("ID", I18N.String("id"));
            UserList.Columns.Add("Uid", I18N.String("id"));
            UserList.Columns.Add("Name", I18N.String("name"));
            UserList.Columns.Add("Surname", I18N.String("surname"));
            UserList.Columns.Add("BirthDate", I18N.String("birthdate"));
            UserList.Columns.Add("Email", I18N.String("email"));
            UserList.Columns.Add("SubscriptionLeft", I18N.String("subscription-left"));
            UserList.Columns[0].Visible = false;

            Filter.Columns.Add("user_id", I18N.String("id"));
            Filter.Columns.Add("name", I18N.String("name"));
            Filter.Columns.Add("surname", I18N.String("surname"));
            Filter.Columns.Add("email", I18N.String("email"));
        }

        /// <summary>
        /// Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            SetColumns();
            RefreshUser();
        }

        /// <summary>
        /// Handles the CellClick event of the Users control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(AddState || EditState)
                {
                    AddState = EditState = false;
                    btnAddUser.Text = I18N.String("add");
                    btnEditUser.Text = I18N.String("edit");
                }
                if(e.RowIndex != -1)
                {
                    int id = Convert.ToInt32(UserList.Rows[e.RowIndex].Cells[0].Value);
                    LoadUser(Users.Find(i => i.ID == id));
                    SetEn(true, null);
                }
            }
            catch (Exception ex)
            {
                Util.ThrowError(ex);
                Util.ShowError("unknown-error");
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the lbOrders control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void lbOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Order o = Orders[lbOrders.SelectedIndex];
                Product p = Database.GetProductById(o.Product);
                MessageBox.Show(
                    I18N.String(
                        "form-message-order",
                        CurrentUser.Name,
                        p.Name,
                        p.Description,
                        o.Date.ToShortDateString()
                    )
                );
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnNotif control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNotif_Click(object sender, EventArgs e)
        {
            new Notifications().ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnProducts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnPreferences control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            new PreferencesF().ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnAddOrder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            new AddOrder(CurrentUser.ID).ShowDialog();
            LoadUser(CurrentUser);
        }

        /// <summary>
        /// Handles the Click event of the btnRemoveOrder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Database.RemoveOrder(Orders[lbOrders.SelectedIndex]);
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
            LoadUser(CurrentUser);
        }

        /// <summary>
        /// Handles the Click event of the btnExtend control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnExtend_Click(object sender, EventArgs e)
        {
            new ExtendSub(CurrentUser.ID).ShowDialog();
            Users = Database.GetUsers();
            foreach (DataGridViewRow r in UserList.Rows)
            {
                User u = Database.GetUserById(int.Parse((string)r.Cells[0].Value));
                UpdateRowBack(u, r.Index);
                r.Cells[6].Value = u.Active ? u.Expired() ? I18N.String("expired") : u.GetSubLeft().ToString() : I18N.String("inactive");
            }
            CurrentUser = Users.Find(u => u.ID == CurrentUser.ID);
            UpdateSubscriptionStatus();
            UpdateNotification();
        }

        /// <summary>
        /// Handles the Click event of the bntAddUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bntAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateUser();
                if(!ValidateUser())
                {
                    Util.ShowError("field-required");
                    return;
                }
                SetEn(AddState, btnAddUser);
                if (AddState)
                {
                    btnAddUser.Text = I18N.String("add");
                    Database.AddUser(CurrentUser);
                    RefreshUser();
                }
                else
                {
                    LoadUser();
                }
                AddState = !AddState;
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEditUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateUser();
                if (!ValidateUser())
                {
                    Util.ShowError("field-required");
                    return;
                }
                SetEn(EditState, btnEditUser);
                if (EditState)
                {
                    btnEditUser.Text = I18N.String("edit");
                    Database.UpdateUser(CurrentUser);
                    RefreshUser();
                }
                EditState = !EditState;
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRemoveUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CurrentUser.ID);
            if (Util.Question("user-delete-confirm", CurrentUser.GetFullName()))
            {
                Database.DeepRemoveUser(CurrentUser);
                RefreshUser();
            }

        }

        /// <summary>
        /// Handles the SortCompare event of the Users control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewSortCompareEventArgs"/> instance containing the event data.</param>
        private void Users_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true; // pass by the default sorting
            }
        }

        /// <summary>
        /// Handles the Click event of the btnFilter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bool and = false;
                string Q = "SELECT * FROM `users` WHERE ";
                foreach (DataGridViewRow item in Filter.Rows)
                {
                    if (item.Index != Filter.RowCount - 1)
                    {
                        if (item.Index != 0)
                        {
                            Q += " OR ";
                        }
                        Q += "(";
                        and = false;
                        foreach (DataGridViewCell cell in item.Cells)
                        {
                            if (!string.IsNullOrWhiteSpace((string)cell.Value))
                            {
                                if (!and)
                                {
                                    and = true;
                                }
                                else
                                {
                                    Q += " AND ";
                                }
                                string op = cell.ColumnIndex == 0 ? "=" : "LIKE";
                                Q += $"`{Filter.Columns[cell.ColumnIndex].Name}` {op} '{(string)cell.Value}'";
                            }

                        }
                        Q += ")";
                    }
                }
                RefreshUser(Q);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska: Filter nije u tacnom obliku");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClearFilter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            Filter.Rows.Clear();
            RefreshUser();
        }

        /// <summary>
        /// Handles the ValueChanged event of the dtpDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            tbAge.Text = (DateTime.Now.Year - ((DateTimePicker)sender).Value.Year).ToString();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the cbActive control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            btnExtend.Enabled = ((CheckBox)sender).Checked;
        }
    }
}