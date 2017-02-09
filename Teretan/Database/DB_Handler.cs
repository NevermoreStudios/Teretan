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
                Console.WriteLine(reader["Dates"]);
                ReturnList.Add(new Order(Convert.ToInt32(reader["IDProducts"]),
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
    }
}
