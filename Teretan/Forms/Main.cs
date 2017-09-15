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
                    if ((string)item.Tag == "Tog")
                    {
                        item.Enabled = v;
                    }
                }
            }
        }

        private void SetEn(bool v)
        {
            foreach (Control item in Controls)
            {
                if (item.Tag != null)
                {
                    if ((string)item.Tag == "bt")
                    {
                        item.Enabled = v;
                    }
                }
            }
        }

        private void Fill(List<User> lu)
        {
            try
            {
                Users.Rows.Clear();
                Users.Columns.Clear();
                Users.Columns.Add("ID", "ID");
                Users.Columns.Add("Uid", "ID");
                Users.Columns.Add("Name", "Ime");
                Users.Columns.Add("Surname", "Prezime");
                Users.Columns.Add("BirthDate", "Datum rođenja");
                Users.Columns.Add("Email", "E-mail");
                Users.Columns.Add("SubscriptionLeft", "Preostala pretplata");
                Users.Columns[0].Visible = false;
                foreach (User usr in lu)
                {
                    Users.Rows.Add(new string[] { usr.ID.ToString(), usr.UID.ToString(), usr.Name, usr.Surname, usr.BirthDate.ToShortDateString(), usr.Email, usr.Active ? usr.GetSubLeft() <= 0 ? "ISTEKLO" : usr.GetSubLeft().ToString() : "NE AKTIVAN" });
                    if (!usr.Active) { Users.Rows[Users.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    else if (usr.IsRed()) { Users.Rows[Users.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red; }
                    else if (usr.IsYellow()) { Users.Rows[Users.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow; }
                }
                Users.Sort(Users.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška sa bazom, pozovite korisničku podršku");
            }

        }

        private void LoadUser(User u)
        {
            try
            {
                uid = u.ID;
                tbID.Text = u.UID.ToString();
                tbName.Text = u.Name.ToString();
                tbSurname.Text = u.Surname.ToString();
                dtpDate.Value = u.BirthDate;
                tbAge.Text = u.GetAge().ToString();

                tbNeck.Text = Math.Round(u.circumference_neck, 2).ToString();
                tbChest.Text = Math.Round(u.circumference_chest,2).ToString();
                tbWaist.Text = Math.Round(u.circumference_waist,2).ToString();
                tbHips.Text = Math.Round(u.circumference_hips,2).ToString();
                tbBicepsL.Text = Math.Round(u.circumference_biceps_left,2).ToString();
                tbBicepsR.Text = Math.Round(u.circumference_biceps_right,2).ToString();
                tbTighL.Text = Math.Round(u.circumference_thigh_left,2).ToString();
                tbTighR.Text = Math.Round(u.circumference_thigh_right,2).ToString();
                tbCalvL.Text = Math.Round(u.circumference_calv_left,2).ToString();
                tbCalvR.Text = Math.Round(u.circumference_calv_right,2).ToString();
                tbFat.Text = Math.Round(u.body_fat,2).ToString();
                tbHeight.Text = Math.Round(u.Height,2).ToString();
                tbWeight.Text = Math.Round(u.Weight,2).ToString();

                tbTel.Text = u.Tel;
                tbEmail.Text = u.Email;
                cbActive.Checked = u.Active;

                lbOrders.Items.Clear();
                labelSubscriptionDate.Text = "";
                labelSubscriptionLenght.Text = "";
                labelSubscriptionLeft.Text = "";
                tbNotes.Text = u.Notes;
                btnAddOrder.Enabled = true;
                btnRemoveOrder.Enabled = true;
                btnExtend.Enabled = true;
                btnRemoveUser.Enabled = true;
                btnEditUser.Enabled = true;

                lo = Database.GetOrders("SELECT * FROM `orders` WHERE user='{0}'", u.ID.ToString());
                foreach (Order item in lo)
                {
                    string product = Database.GetProducts("SELECT * FROM `products` WHERE ID='{0}'", item.Product.ToString())[0].Name;
                    string date = item.Date.ToShortDateString();
                    lbOrders.Items.Add(product + " " + date);
                }
                labelSubscriptionDate.Text = u.SubscriptionDate.ToShortDateString();
                labelSubscriptionLenght.Text = u.SubscriptionLength.Days.ToString();
                labelSubscriptionLeft.Text = u.GetSubLeft() <= 0 ? "ISTEKLO" : u.GetSubLeft().ToString();
                if (u.IsRed()) { labelSubscriptionLeft.BackColor = Color.Red; }
                else if (u.IsYellow()) { labelSubscriptionLeft.BackColor = Color.Yellow; }
                else labelSubscriptionLeft.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška sa bazom");
            }

        }
        private void LoadUser()
        {
            uid = 0;
            tbID.Text = "0";
            tbName.Text = "";
            tbSurname.Text = "";
            dtpDate.Value = DateTime.Now;
            tbAge.Text = "";

            tbNeck.Text = "";
            tbChest.Text = "";
            tbWaist.Text = "";
            tbHips.Text = "";
            tbBicepsL.Text = "";
            tbBicepsR.Text = "";
            tbTighL.Text = "";
            tbTighR.Text = "";
            tbCalvL.Text = "";
            tbCalvR.Text = "";
            tbFat.Text = "";
            tbHeight.Text = "";
            tbWeight.Text = "";

            tbTel.Text = "";
            tbEmail.Text = "";
            cbActive.Checked = false;

            lbOrders.Items.Clear();
            labelSubscriptionDate.Text = "";
            labelSubscriptionLenght.Text = "";
            labelSubscriptionLeft.Text = "";
            tbNotes.Text = "";
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
                btnNotif.Text = "Obaveštenja (" + count.ToString() + ")";
                btnNotif.BackColor = Color.Red;
            }
            else
            {
                btnNotif.Text = "Obaveštenja";
                btnNotif.BackColor = Color.FromKnownColor(KnownColor.Control);
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



        private void Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Users.Rows[e.RowIndex].Cells[0].Value);
                LoadUser(lu.Find(i => i.ID == id));
            }
            catch (Exception) { }
        }

        private void lbOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string nameuser = tbName.Text;
                Product p = Database.GetProducts("SELECT * FROM `products` WHERE ID='{0}'", lo[lbOrders.SelectedIndex].Product.ToString())[0];
                string date = lo[lbOrders.SelectedIndex].Date.ToShortDateString();
                string f = "Ime: " + nameuser + "\r\nProizvod: " + p.Name + "\r\nOpis: " + p.Description + "\r\nDatum: " + date;
                MessageBox.Show(f);
            }
            catch (Exception)
            {
            }
        }



        private void btnNotif_Click(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
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
                Database.RemoveOrder(lo[lbOrders.SelectedIndex]);
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
                if (!u.Active) { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.Gray; }
                else if (u.IsRed()) { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.Red; }
                else if (u.IsYellow()) { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.Yellow; }
                else { Users.Rows[r.Index].DefaultCellStyle.BackColor = Color.White; }
                r.Cells[6].Value = u.Active ? u.GetSubLeft() <= 0 ? "ISTEKLO" : u.GetSubLeft().ToString() : "NE AKTIVAN";
            }
            LoadUser(lu.Find(i => i.ID == uid));
            putNotif();
        }

        private void bntAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (addstate)
                {
                    addstate = !addstate;
                    btnAddUser.Text = "Dodaj";
                    SetVis(false);
                    SetEn(true);
                    Database.AddUser(new User(0,Convert.ToInt32(tbID.Text), tbName.Text, tbSurname.Text, dtpDate.Value, Convert.ToSingle(tbNeck.Text), Convert.ToSingle(tbChest.Text), Convert.ToSingle(tbWaist.Text), Convert.ToSingle(tbHips.Text), Convert.ToSingle(tbBicepsL.Text), Convert.ToSingle(tbBicepsR.Text), Convert.ToSingle(tbTighL.Text), Convert.ToSingle(tbTighR.Text), Convert.ToSingle(tbCalvL.Text), Convert.ToSingle(tbCalvR.Text), Convert.ToSingle(tbFat.Text), Convert.ToSingle(tbHeight.Text), Convert.ToSingle(tbWeight.Text), tbTel.Text,tbEmail.Text, DateTime.Now, new TimeSpan(0), tbNotes.Text,cbActive.Checked));
                    lu = Database.GetUsers();
                    Fill(lu);
                    LoadUser();
                    putNotif();
                }
                else
                {
                    addstate = !addstate;
                    btnAddUser.Text = "Gotovo";
                    SetVis(true);
                    SetEn(false);
                    btnAddUser.Enabled = true;
                    LoadUser();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška: Obavezno polje nije popunjeno ili nije u potrebnom formatu");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                User u = lu.Find(i => i.ID == uid);
                if (editstate)
                {
                    editstate = !editstate;
                    btnEditUser.Text = "Izmeni";
                    SetVis(false);
                    SetEn(true);
                    Database.UpdateUser(new User(u.ID, Convert.ToInt32(tbID.Text), tbName.Text, tbSurname.Text, dtpDate.Value, Convert.ToSingle(tbNeck.Text), Convert.ToSingle(tbChest.Text), Convert.ToSingle(tbWaist.Text), Convert.ToSingle(tbHips.Text), Convert.ToSingle(tbBicepsL.Text), Convert.ToSingle(tbBicepsR.Text), Convert.ToSingle(tbTighL.Text), Convert.ToSingle(tbTighR.Text), Convert.ToSingle(tbCalvL.Text), Convert.ToSingle(tbCalvR.Text), Convert.ToSingle(tbFat.Text), Convert.ToSingle(tbHeight.Text), Convert.ToSingle(tbWeight.Text), tbTel.Text, tbEmail.Text, u.SubscriptionDate,u.SubscriptionLength, tbNotes.Text, cbActive.Checked));
                    lu = Database.GetUsers();
                    Fill(lu);
                    LoadUser();
                    putNotif();
                }
                else
                {
                    editstate = !editstate;
                    btnEditUser.Text = "Gotovo";
                    SetVis(true);
                    SetEn(false);
                    btnEditUser.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška: Obavezno polje nije popunjeno ili nije u potrebnom formatu");
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

            User u = lu.Find(i => i.ID == uid);
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete:" + u.Name, "Da li ste sigurni?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Database.DeepRemoveUser(u);
                lu = Database.GetUsers();
                Fill(lu);
                LoadUser();
                putNotif();
            }

        }

        private void Setfilter()
        {
            Filter.Columns.Add("user_id", "ID");
            Filter.Columns.Add("name", "Ime");
            Filter.Columns.Add("surname", "Prezime");
            Filter.Columns.Add("email", "E-mail");
        }

        private void Users_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
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
                                if (cell.ColumnIndex == 0)
                                {
                                    if (!and) { and = true; }
                                    else { Q += " AND "; }
                                    Q += "`";
                                    Q += Filter.Columns[cell.ColumnIndex].Name;
                                    Q += "` ='";
                                    Q += (string)cell.Value;
                                    Q += "'";
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
            catch (Exception)
            {
                MessageBox.Show("Greška: Filter nije u tačnom obliku");
            }
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