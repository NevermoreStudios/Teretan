using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace Teretan
{
    public static class Database
    {
        /**
         * Select queries
         */
        const string QUERY_SELECT_USERS = "SELECT * FROM `users`";
        const string QUERY_SELECT_PRODUCTS = "SELECT * FROM `products`";
        const string QUERY_SELECT_ORDERS = "SELECT * FROM `orders`";
        const string QUERY_SELECT_PREFERENCES = "SELECT * FROM `preferences`";

        const string QUERY_SELECT_ORDER_USER = "SELECT * FROM `orders` WHERE `user`={0}";
        const string QUERY_SELECT_ORDER_PRODUCT = "SELECT * FROM `orders` WHERE `product`={0}";

        /**
         * Insert queries
         */
        const string QUERY_INSERT_USER = "INSERT INTO `users` (`name`, `surname`, `birthdate`, `height`, `waist_width`, " +
            "`shoulder_width`, `arms_length`, `legs_length`,`weight`, `email`, `subscription_date`, `subscription_length`, `notes`)" +
            "VALUES('{0}', '{1}', '{2:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', '{11}', '{12}')";
        const string QUERY_INSERT_PRODUCT = "INSERT INTO `products` (`name`, `description`) VALUES('{0}', '{1}')";
        const string QUERY_INSERT_ORDER = "INSERT INTO `orders` (`user`, `product`, `date`) VALUES('{0}', '{1}','{2:yyyy'-'MM'-'dd' 'HH':'mm':'ss}')";

        /**
         * Delete queries
         */
        const string QUERY_DELETE_USER = "DELETE FROM `users` WHERE `id`={0}";
        const string QUERY_DELETE_PRODUCT = "DELETE FROM `products` WHERE `id`={0}";
        const string QUERY_DELETE_ORDER = "DELETE FROM `orders` WHERE `id`={0};";

        /**
         * Update queries
         */
        const string QUERY_UPDATE_USER = "UPDATE `users` SET `name`='{0}', `surname`='{1}', `birthdate`='{2:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', `height`='{3}', `waist_width`='{4}', `shoulder_width`='{5}', `arms_length`='{6}', `legs_length`='{7}',`weight`='{8}', `email`='{9}', `subscription_date`='{10:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', `subscription_length`='{11}', `notes`='{12}' WHERE `id`={13}";
        const string QUERY_UPDATE_PRODUCT = "UPDATE `products` SET `name`='{0}', `description`='{1}' WHERE `id`='{2}'";
        const string QUERY_UPDATE_PREFERENCE = "UPDATE `preferences` SET `key`='{0}', `value`='{1}' WHERE `key`='{0}'";

        /**
         * Table creation query
         */
        const string QUERY_CREATE = @"
        CREATE TABLE IF NOT EXISTS `users` (
	        `id`	                INTEGER PRIMARY KEY AUTOINCREMENT,
	        `name`	                TEXT,
	        `surname`	            TEXT,
	        `birthdate`	            TEXT,
	        `height`	            REAL,
	        `waist_width`	        REAL,
	        `shoulder_width`	    REAL,
	        `arms_length`	        REAL,
	        `legs_length`	        REAL,
            `weight`	            REAL,
	        `email`	                TEXT,
	        `subscription_date`	    TEXT,
	        `subscription_length`	INTEGER,
	        `notes`	                TEXT
        );
        CREATE TABLE IF NOT EXISTS `products` (
	        `id`	        INTEGER PRIMARY KEY AUTOINCREMENT,
	        `name`	        TEXT,
	        `description`	TEXT
        );
        CREATE TABLE IF NOT EXISTS `orders` (
	        `id`	    INTEGER PRIMARY KEY AUTOINCREMENT,
	        `product`	INTEGER,
	        `user`	    INTEGER,
	        `date`	    TEXT
        );
        CREATE TABLE IF NOT EXISTS `preferences` (
	        `key`	TEXT,
	        `value`	TEXT,
	        PRIMARY KEY(`key`)
        );
        ";
        const string QUERY_CREATE_PREFERENCES = @"
        INSERT INTO `preferences` VALUES('red', '3');
        INSERT INTO `preferences` VALUES('yellow', '10');
        INSERT INTO `preferences` VALUES('lang', 'en');
        ";

        private static SQLiteConnection DBConnection;

        public static void Init()
        {
            DBConnection = new SQLiteConnection("Data Source=Teretan.db;Version=3;");
            DBConnection.Open();
            ExecuteNoQuery(QUERY_CREATE);
            try
            {
                ExecuteNoQuery(QUERY_CREATE_PREFERENCES);
            }
            catch (SQLiteException)
            {
                // rip
            }
        }

        public static void Dispose()
        {
            DBConnection.Close();
        }

        private static SQLiteCommand Query(string query, params object[] args)
        {
            string q = string.Format(query, args);
            Console.WriteLine(q);
            return new SQLiteCommand(q, DBConnection);
        }

        private static void ExecuteNoQuery(string query, params object[] args)
        {
            Query(query, args).ExecuteNonQuery();
        }

        private static SQLiteDataReader ExecuteRead(string query, params object[] args)
        {
            return Query(query, args).ExecuteReader();
        }

        public static int Count(SQLiteDataReader Read)
        {
            int i = 0;
            while (Read.Read())
            {
                i++;
            }
            return i;
        }

        public static List<User> GetUsers()
        {
            return GetUsers(QUERY_SELECT_USERS);
        }

        public static List<User> GetUsers(string query, params object[] args)
        {
            List<User> ret = new List<User>();
            SQLiteDataReader reader = ExecuteRead(query, args);
            while (reader.Read())
            {
                ret.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetFloat(4),
                    reader.GetFloat(5),
                    reader.GetFloat(6),
                    reader.GetFloat(7),
                    reader.GetFloat(8),
                    reader.GetFloat(9),
                    reader.GetString(10),
                    reader.GetDateTime(11),
                    new TimeSpan(reader.GetInt32(12), 0, 0, 0),
                    reader.GetString(13)
                ));
            }
            return ret;
        }

        public static List<Product> GetProducts()
        {
            return GetProducts(QUERY_SELECT_PRODUCTS);
        }

        public static List<Product> GetProducts(string query, params object[] args)
        {
            List<Product> ret = new List<Product>();
            SQLiteDataReader reader = ExecuteRead(query, args);
            while (reader.Read())
            {
                ret.Add(new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                ));
            }
            return ret;
        }

        public static List<Order> GetOrders()
        {
            return GetOrders(QUERY_SELECT_ORDERS);
        }
        
        public static List<Order> GetOrders(string query, params object[] args)
        {
            List<Order> ret = new List<Order>();
            SQLiteDataReader reader = ExecuteRead(query, args);
            while (reader.Read())
            {
                ret.Add(new Order(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3)
                ));
            }
            return ret;
        }

        public static Dictionary<string, string> GetPreferences()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            SQLiteDataReader reader = ExecuteRead(QUERY_SELECT_PREFERENCES);
            while (reader.Read())
            {
                ret.Add(reader.GetString(0), reader.GetString(1));
            }
            return ret;
        }

        public static void SetPreference(string key, string value)
        {
            ExecuteNoQuery(QUERY_UPDATE_PREFERENCE, key, value);
        }

        public static void AddUser(User User)
        {
            ExecuteNoQuery(QUERY_INSERT_USER, User.Name, User.Surname, User.BirthDate, User.Height, User.WaistWidth, User.ShoulderWidth, User.ArmsLenght, User.LegsLenght,User.Weight, User.Email, User.SubscriptionDate, User.SubscriptionLength.Days, User.Notes);
        }

        public static void AddProduct(Product Product)
        {
            ExecuteNoQuery(QUERY_INSERT_PRODUCT, Product.Name, Product.Description);
        }

        public static void AddOrder(Order Order)
        {
            ExecuteNoQuery(QUERY_INSERT_ORDER, Order.User, Order.Product, Order.Date);
        }

        public static void RemoveUser(User User)
        {
            ExecuteNoQuery(QUERY_DELETE_USER, User.ID);
        }

        public static void RemoveProduct(Product Product)
        {
            ExecuteNoQuery(QUERY_DELETE_PRODUCT, Product.ID);
        }

        public static void RemoveOrder(Order Order)
        {
            ExecuteNoQuery(QUERY_DELETE_ORDER, Order.ID);
        }

        public static bool CheckProduct(Product Product)
        {
            return ExecuteRead(QUERY_SELECT_ORDER_PRODUCT, Product.ID).Read();
        }

        public static void DeepRemoveUser(User user)
        {
            RemoveUser(user);
            List<Order> dep = GetOrders(QUERY_SELECT_ORDER_USER, user.ID);
            foreach (Order item in dep)
            {
                RemoveOrder(item);
            }
        }

        public static void UpdateUser(User User)
        {
            ExecuteNoQuery(QUERY_UPDATE_USER, User.Name, User.Surname, User.BirthDate, User.Height, User.WaistWidth, User.ShoulderWidth, User.ArmsLenght, User.LegsLenght,User.Weight, User.Email, User.SubscriptionDate, User.SubscriptionLength.Days, User.Notes, User.ID);
        }

        public static void UpdateProduct(Product Product)
        {
            ExecuteNoQuery(QUERY_UPDATE_PRODUCT, Product.Name, Product.Description, Product.ID);
        }
    }
}
