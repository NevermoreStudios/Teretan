using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Globalization;

namespace Teretan
{
    public static class DB_Handler
    {
        private static SQLiteConnection DBConnection;
        public static void Init()
        {
            DBConnection = new SQLiteConnection("Data Source=Teretan.db;Version=3;");
            DBConnection.Open();
        }

        public static void Dispose()
        {
            DBConnection.Close();
        }

        public static void ExecuteNoQuery(string query)
        {
            Console.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, DBConnection);
            command.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecuteRead(string query)
        {
            Console.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, DBConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int Count(SQLiteDataReader Read)
        {
            int i = 0;
            while (Read.Read()) { i++; }
            return i;
        }

        public static List<User> GetUser(string query)
        {
            List<User> ReturnList = new List<User>();
            SQLiteDataReader reader = ExecuteRead(query);
            while (reader.Read())
            {
                ReturnList.Add(new User(Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Name"]),
                    Convert.ToString(reader["Surname"]),
                    DateTime.ParseExact(Convert.ToString(reader["BirthDate"]), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    Convert.ToSingle(reader["Height"]),
                    Convert.ToSingle(reader["WaistWidth"]),
                    Convert.ToSingle(reader["ShoulderWidth"]),
                    Convert.ToSingle(reader["ArmsLength"]),
                    Convert.ToSingle(reader["LegsLength"]),
                    Convert.ToString(reader["email"]),
                    DateTime.ParseExact(Convert.ToString(reader["SubscriptionDate"]), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    new TimeSpan(Convert.ToInt32(reader["SubscriptionLength"]), 0, 0, 0),
                    Convert.ToString(reader["Notes"])));
            }
            return ReturnList;
        }

        public static List<Product> GetProduct(string query)
        {
            List<Product> ReturnList = new List<Product>();
            SQLiteDataReader reader = ExecuteRead(query);
            while (reader.Read())
            {
                ReturnList.Add(new Product(Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Name"]),
                    Convert.ToString(reader["Description"])));
            }
            return ReturnList;
        }

        public static List<Order> GetOrder(string query)
        {
            List<Order> ReturnList = new List<Order>();
            SQLiteDataReader reader = ExecuteRead(query);
            while (reader.Read())
            {
                ReturnList.Add(new Order(Convert.ToInt32(reader["ID"]), 
                    Convert.ToInt32(reader["IDProducts"]),
                    Convert.ToInt32(reader["IDUsers"]),
                    DateTime.ParseExact(Convert.ToString(reader["Dates"]),"dd-MM-yyyy", CultureInfo.InvariantCulture)));
            }
            return ReturnList;
        }

        public static void AddUser(User User)
        {
            string q = String.Format("INSERT INTO Users (Name, Surname, BirthDate, Height, WaistWidth, ShoulderWidth, ArmsLength, LegsLength, email, SubscriptionDate, SubscriptionLength, Notes) VALUES('{0}', '{1}', '{2:dd/MM/yyyy}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9:dd/MM/yyyy}', '{10}', '{11}');",
                User.Name,User.Surname,User.BirthDate,User.Height,User.WaistWidth,User.ShoulderWidth,User.ArmsLenght,User.LegsLenght,User.e_mail,User.Subscription_Date,User.Subscription_Lenght.Days,User.Notes);
            ExecuteNoQuery(q);
        }

        public static void AddProduct(Product Product)
        {
            string q = String.Format("INSERT INTO Products (Name, Description) VALUES('{0}', '{1}');",
                Product.Name,Product.Description);
            ExecuteNoQuery(q);
        }

        public static void AddOrder(Order Order)
        {
            string q = String.Format("INSERT INTO Orders (IDUsers, IDProducts, Dates) VALUES('{0}', '{1}','{2:dd/MM/yyyy}');",
                Order.IDUser,Order.IDProduct,Order.Date);
            ExecuteNoQuery(q);
        }

        public static void RemoveUser(User User)
        {
            string q = String.Format("DELETE FROM Users WHERE ID={0};",User.ID);
            ExecuteNoQuery(q);
        }

        public static void RemoveProduct(Product Product)
        {
            string q = String.Format("DELETE FROM Products WHERE ID={0};", Product.ID);
            ExecuteNoQuery(q);
        }

        public static void RemoveOrder(Order Order)
        {
            string q = String.Format("DELETE FROM Orders WHERE ID={0};", Order.ID);
            ExecuteNoQuery(q);
        }

        public static bool CheckProduct(Product Product)
        {
            string q = String.Format("SELECT * FROM ORDERS WHERE IDProducts={0};", Product.ID);
            SQLiteDataReader read= ExecuteRead(q);
            return Count(read)==0;
        }

        public static void DeepRemoveUser(User User)
        {
            List<Order> dep=GetOrder("SELECT * FROM Orders WHERe IDUsers=" + User.ID.ToString());
            RemoveUser(User);
            foreach (Order item in dep)
            {
                RemoveOrder(item);
            }
        }

        public static void UpdateUser(User User)
        {
            string q = String.Format("UPDATE Users SET Name='{0}', Surname='{1}', BirthDate='{2:dd/MM/yyyy}', Height='{3}', WaistWidth='{4}', ShoulderWidth='{5}', ArmsLength='{6}', LegsLength='{7}', email='{8}', SubscriptionDate='{9:dd/MM/yyyy}', SubscriptionLength='{10}', Notes='{11}' WHERE ID={12};",
                User.Name, User.Surname, User.BirthDate, User.Height, User.WaistWidth, User.ShoulderWidth, User.ArmsLenght, User.LegsLenght, User.e_mail, User.Subscription_Date, User.Subscription_Lenght.Days, User.Notes,User.ID);
            ExecuteNoQuery(q);
        }

        public static void UpdateProduct(Product Product)
        {
            string q = String.Format("UPDATE Products SET Name='{0}', Description='{1}' WHERE ID='{2}';",
                Product.Name, Product.Description,Product.ID);
            ExecuteNoQuery(q);
        }
    }
}
