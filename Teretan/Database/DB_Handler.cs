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
            SQLiteCommand command = new SQLiteCommand(query, DBConnection);
            command.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecuteRead(string query)
        {
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
                    DateTime.ParseExact(Convert.ToString(reader["BirthDate"]), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Convert.ToSingle(reader["Height"]),
                    Convert.ToSingle(reader["Other1"]),
                    Convert.ToSingle(reader["Other2"]),
                    Convert.ToSingle(reader["Other3"]),
                    Convert.ToSingle(reader["Other4"]),
                    Convert.ToSingle(reader["Other5"]),
                    Convert.ToSingle(reader["Other6"]),
                    Convert.ToString(reader["e-mail"]),
                    DateTime.ParseExact(Convert.ToString(reader["SubscriptionDate"]), "dd/MM/yyyy", CultureInfo.InvariantCulture),
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
                    DateTime.ParseExact(Convert.ToString(reader["Dates"]),"dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            return ReturnList;
        }
    }
}
