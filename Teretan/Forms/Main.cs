using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Teretan
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            uid = 1;
        }
        private static List<User> lu;
        private static List<Order> lo;
        int uid;
        bool addstate = false;
        bool editstate = false;
        private void SetVis(bool v)
        {
            foreach (Control item in Controls[Controls.IndexOfKey("groupBox")].Controls)
            {
                if (item.Tag != null)
                {
                    if ((string)item.Tag == "TextBox")
                    {
                        item.Visible = v;
                    }
                }
            }
        }

        private void Fill(List<User> lu)
        {
            Users.Rows.Clear();
            Users.Columns.Clear();
            Users.Columns.Add("ID", "ID");
            Users.Columns.Add("Name", "Name");
            Users.Columns.Add("Surname", "Surname");
            Users.Columns.Add("BirthDate", "BirthDate");
            Users.Columns.Add("Email", "Email");
            Users.Columns.Add("SubscriptionLeft", "SubscriptionLeft");
            Users.Columns[0].Visible = false;
            foreach (User usr in lu)
            {
                Users.Rows.Add(new string[] { usr.ID.ToString(), usr.Name, usr.Surname, usr.BirthDate.ToShortDateString(), usr.Email, Math.Max(0, usr.GetSubLeft()).ToString() });
                if (usr.IsRed()) { Users.Rows[Users.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red; }
                else if (usr.IsYellow()) { Users.Rows[Users.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow; }
            }
            Users.Sort(Users.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void LoadUser(User u)
        {
            btnAddOrder.Enabled = true;
            btnRemoveOrder.Enabled = true;
            btnExtend.Enabled = true;
            btnRemoveUser.Enabled = true;
            btnEditUser.Enabled = true;
            uid = u.ID;
            labelName.Text = u.Name;
            labelSurname.Text = u.Surname;
            labelBithdate.Text = u.BirthDate.ToShortDateString();
            labelAge.Text = u.GetAge().ToString();
            labelHeight.Text = u.Height.ToString();
            labelWaistWidth.Text = u.WaistWidth.ToString();
            labelShoulderWidth.Text = u.ShoulderWidth.ToString();
            labelArmsLenght.Text = u.ArmsLenght.ToString();
            labelLegsLenght.Text = u.LegsLenght.ToString();
            labelWeight.Text = u.Weight.ToString();
            listBox1.Items.Clear();
            lo = Database.GetOrders("SELECT * FROM `orders` WHERE user='{0}'", u.ID.ToString());
            foreach (Order item in lo)
            {
                string product = Database.GetProducts("SELECT * FROM `products` WHERE ID='{0}'", item.Product.ToString())[0].Name;
                string date = item.Date.ToShortDateString();
                listBox1.Items.Add(product + " " + date);
            }
            labelSubscriptionDate.Text = u.SubscriptionDate.ToShortDateString();
            labelSubscriptionLenght.Text = u.SubscriptionLength.Days.ToString();
            labelSubscriptionLeft.Text = u.GetSubLeft() <= 0 ? "ISTEKLO" : u.GetSubLeft().ToString();
            if (u.IsRed()) { labelSubscriptionLeft.BackColor = Color.Red; }
            else if (u.IsYellow()) { labelSubscriptionLeft.BackColor = Color.Yellow; }
            else labelSubscriptionLeft.BackColor = Color.FromKnownColor(KnownColor.Control);
            labelEmail.Text = u.Email;
            textBox1.Text = u.Notes;

        }
        private void LoadUser()
        {
            uid = 0;
            labelName.Text = "";
            labelSurname.Text ="";
            labelBithdate.Text = "";
            labelAge.Text = "";
            labelHeight.Text = "";
            labelWaistWidth.Text = "";
            labelShoulderWidth.Text = "";
            labelArmsLenght.Text = "";
            labelLegsLenght.Text = "";
            labelWeight.Text = "";
            listBox1.Items.Clear();
            
            labelSubscriptionDate.Text = "";
            labelSubscriptionLenght.Text = "";
            labelSubscriptionLeft.Text = "";
            labelEmail.Text = "";
            textBox1.Text = "";
            btnAddOrder.Enabled = false;
            btnRemoveOrder.Enabled = false;
            btnExtend.Enabled = false;
            btnRemoveUser.Enabled = false;
            btnEditUser.Enabled = false;
        }

        private void putNotif()
        {
            int count = Util.GetNotif().Count;
            if (count > 0)
            {
                button2.Text = "Notifications (" + count.ToString() + ")";
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.Text = "Notifications";
                button2.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetVis(false);
            lu = Database.GetUsers();
            Fill(lu);
            LoadUser();
            putNotif();
            Setfilter();
        }

        private void Setfilter()
        {
            Filter.Columns.Add("name", "name");
            Filter.Columns.Add("surname", "surname");
            Filter.Columns.Add("height", "height");
            Filter.Columns.Add("waist_width", "waist_width");
            Filter.Columns.Add("shoulder_width", "shoulder_width");
            Filter.Columns.Add("arms_length", "arms_lenght");
            Filter.Columns.Add("legs_length", "legs_lenght");
            Filter.Columns.Add("weight", "weight");
            Filter.Columns.Add("email", "email");
            Filter.Columns.Add("notes", "notes");
        }

        private void Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Users.Rows[e.RowIndex].Cells[0].Value);
                LoadUser(lu.Find(i => i.ID == id));
            }
            catch (Exception) { }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string nameuser = labelName.Text;
                Product p = Database.GetProducts("SELECT * FROM `products` WHERE ID='{0}'", lo[listBox1.SelectedIndex].Product.ToString())[0];
                string date = lo[listBox1.SelectedIndex].Date.ToShortDateString();
                string f = "Name: " + nameuser + "\r\nProduct: " + p.Name + "\r\nDescription: " + p.Description + "\r\nDate: " + date;
                MessageBox.Show(f);
            }
            catch (Exception)
            {
            }
        }

        private void Users_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 5)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Notifications().ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            new PreferencesF().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lu = Database.GetUsers();
            Fill(lu);
            LoadUser();
            putNotif();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            new AddOrder(uid).ShowDialog();
            LoadUser(lu.Find(i => i.ID == uid));

        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Database.RemoveOrder(lo[listBox1.SelectedIndex]);
            }
            catch (Exception)
            {
            }

            LoadUser(lu.Find(i => i.ID == uid));
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            new ExtendSub(uid).ShowDialog();
            lu = Database.GetUsers();
            foreach (DataGridViewRow r in Users.Rows)
            {
                User u = Database.GetUsers("SELECT * FROM `users` WHERE ID='{0}'", r.Cells[0].Value)[0];
                if (u.IsRed()) { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.Red; }
                else if (u.IsYellow()) { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.Yellow; }
                else { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.White; }
                r.Cells[5].Value = u.GetSubLeft();
            }
            LoadUser(lu.Find(i => i.ID == uid));
            putNotif();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addstate)
            {
                addstate = !addstate;
                button1.Text = "Add";
                SetVis(false);
                btnAddOrder.Enabled = true;
                btnRemoveOrder.Enabled = true;
                btnExtend.Enabled = true;
                textBox1.ReadOnly = true;
                Database.AddUser(new User(0, textBoxName.Text, textBoxSurname.Text, dateTimePicker1.Value, Convert.ToSingle(textBoxh.Text), Convert.ToSingle(textBoxww.Text), Convert.ToSingle(textBoxsw.Text), Convert.ToSingle(textBoxal.Text), Convert.ToSingle(textBoxll.Text),Convert.ToSingle(textBoxW.Text), textBoxemail.Text, DateTime.Now, new TimeSpan(0), textBox1.Text));
                lu = Database.GetUsers();
                Fill(lu);
                LoadUser();
                putNotif();
            }
            else
            {
                addstate = !addstate;
                button1.Text = "Done";
                SetVis(true);
                foreach (Control item in Controls[Controls.IndexOfKey("groupBox")].Controls)
                {
                    if (item.Tag != null)
                    {
                        if ((string)item.Tag == "TextBox")
                        {
                            item.Text = "";
                        }
                    }
                }
                textBox1.Text = "";
                listBox1.Items.Clear();
                labelSubscriptionDate.Text = "NONE";
                labelSubscriptionLeft.Text = "NONE";
                labelSubscriptionLenght.Text = "NONE";
                labelAge.Text = "";
                btnAddOrder.Enabled = false;
                btnRemoveOrder.Enabled = false;
                btnExtend.Enabled = false;
                textBox1.ReadOnly = false;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User u = lu.Find(i => i.ID == uid);
            if (editstate)
            {
                editstate = !editstate;
                btnEditUser.Text = "Edit";
                SetVis(false);
                btnAddOrder.Enabled = true;
                btnRemoveOrder.Enabled = true;
                btnExtend.Enabled = true;
                textBox1.ReadOnly = true;
                Database.UpdateUser(new User(u.ID, textBoxName.Text, textBoxSurname.Text, dateTimePicker1.Value, Convert.ToSingle(textBoxh.Text), Convert.ToSingle(textBoxww.Text), Convert.ToSingle(textBoxsw.Text), Convert.ToSingle(textBoxal.Text), Convert.ToSingle(textBoxll.Text), Convert.ToSingle(textBoxW.Text), textBoxemail.Text, u.SubscriptionDate, u.SubscriptionLength, textBox1.Text));
                lu = Database.GetUsers();
                Fill(lu);
                LoadUser();
                putNotif();
            }
            else
            {
                editstate = !editstate;
                btnEditUser.Text = "Done";
                SetVis(true);
                labelAge.Text = "";

                textBoxName.Text = u.Name;
                textBoxSurname.Text = u.Surname;
                dateTimePicker1.Value = u.BirthDate;
                textBoxh.Text = u.Height.ToString();
                textBoxww.Text = u.WaistWidth.ToString();
                textBoxsw.Text = u.ShoulderWidth.ToString();
                textBoxal.Text = u.ArmsLenght.ToString();
                textBoxll.Text = u.LegsLenght.ToString();
                textBoxemail.Text = u.Email;

                btnAddOrder.Enabled = false;
                btnRemoveOrder.Enabled = false;
                btnExtend.Enabled = false;
                textBox1.ReadOnly = false;
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

            User u = lu.Find(i => i.ID == uid);
            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete:" + u.Name, "Da li ste sigurni?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Database.DeepRemoveUser(u);
                lu = Database.GetUsers();
                Fill(lu);
                LoadUser();
                putNotif();
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool and = false;
            String Q = "SELECT * FROM `users` WHERE ";
            foreach (DataGridViewRow item in Filter.Rows)
            {
                if (item.Index != Filter.RowCount - 1)
                {
                    if (item.Index != 0) { Q += " OR "; }
                    Q += "(";
                    and = false;
                    foreach (DataGridViewCell cell in item.Cells)
                    {
                        if (!string.IsNullOrWhiteSpace((string)cell.Value))
                        {
                            if (cell.ColumnIndex == 2 || cell.ColumnIndex == 3 || cell.ColumnIndex == 4 || cell.ColumnIndex == 5 || cell.ColumnIndex == 6 || cell.ColumnIndex == 7)
                            {
                                if (!and) { and = true; }
                                else { Q += " AND "; }
                                Q += "`";
                                Q += Filter.Columns[cell.ColumnIndex].Name;
                                Q += "`";
                                Q += (string)cell.Value;
                            }
                            else
                            {
                                if (!and) { and = true; }
                                else { Q += " AND "; }
                                Q += "`";
                                Q += Filter.Columns[cell.ColumnIndex].Name;
                                Q += "` LIKE '";
                                Q += (string)cell.Value;
                                Q += "'";
                            }
                        }

                    }
                    Q += ")";
                }

            }
            lu = Database.GetUsers(Q);
            Fill(lu);
            LoadUser();
            putNotif();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            Filter.Rows.Clear();
            lu = Database.GetUsers();
            Fill(lu);
            LoadUser();
            putNotif();
        }
    }
}