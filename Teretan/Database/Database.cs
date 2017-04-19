using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

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
        const string QUERY_INSERT_USER = @"INSERT INTO `users` (`user_id`,`name`,`surname`,`birthdate`,`circumference_neck`,`circumference_chest`,`circumference_waist`,`circumference_hips`,`circumference_biceps_left`,`circumference_biceps_right`,`circumference_thigh_left`,`circumference_thigh_right`,`circumference_calv_left`,`circumference_calv_right`,`body_fat`,`height`,`weight`,`tel`,`email`,`subscription_date`,`subscription_length`,`active`,`notes`)
            VALUES('{0}', '{1}','{2}', '{3:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}', '{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19:yyyy'-'MM'-'dd' 'HH':'mm':'ss}','{20}','{21}','{22}')";
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
        const string QUERY_UPDATE_USER = "UPDATE `users` SET `user_id`={0},`name`={1},`surname`={2},`birthdate`={3},`circumference_neck`={4},`circumference_chest`={5},`circumference_waist`={6},`circumference_hips`={7},`circumference_biceps_left`={8},`circumference_biceps_right`={9},`circumference_thigh_left`={10},`circumference_thigh_right`={11},`circumference_calv_left`={12},`circumference_calv_right`={13},`body_fat`={14},`height`={15},`weight`={16},`tel`={17},`email`={18},`subscription_date`={19},`subscription_length`={20},`active`={21},`notes`={22} WHERE `id`={23}";
        const string QUERY_UPDATE_PRODUCT = "UPDATE `products` SET `name`='{0}', `description`='{1}' WHERE `id`='{2}'";
        const string QUERY_UPDATE_PREFERENCE = "UPDATE `preferences` SET `key`='{0}', `value`='{1}' WHERE `key`='{0}'";

        /**
         * Table creation query
         */
        const string QUERY_CREATE = @"
        CREATE TABLE IF NOT EXISTS `users` (
	        `id`	                        INTEGER PRIMARY KEY AUTOINCREMENT,
            `user_id`                       INTEGER,
	        `name`	                        TEXT,
	        `surname`	                    TEXT,
	        `birthdate`	                    TEXT,
            `circumference_neck`	        REAL,
            `circumference_chest`	        REAL,
            `circumference_waist`	        REAL,
            `circumference_hips`	        REAL,
            `circumference_biceps_left`     REAL,
            `circumference_biceps_right`    REAL,
            `circumference_thigh_left`      REAL,
            `circumference_thigh_right`	    REAL,
            `circumference_calv_left`       REAL,
            `circumference_calv_right`      REAL,
            `body_fat`	                    REAL,
            `height`	                    REAL,
            `weight`	                    REAL,
            `tel`	                    TEXT,
	        `email`	                        TEXT,
	        `subscription_date`	            TEXT,
	        `subscription_length`	        INTEGER,
            `active`                        INTEGER,
	        `notes`	                        TEXT
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
            try
            {
                Query(query, args).ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Generic database no query eror");
            }

        }

        private static SQLiteDataReader ExecuteRead(string query, params object[] args)
        {
            try
            {
                return Query(query, args).ExecuteReader();
            }
            catch (Exception)
            {
                Console.WriteLine("Generic database read eror");
            }
            return null;
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
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    reader.GetDouble(5),
                    reader.GetDouble(6),
                    reader.GetDouble(7),
                    reader.GetDouble(8),
                    reader.GetDouble(9),
                    reader.GetDouble(10),
                    reader.GetDouble(11),
                    reader.GetDouble(12),
                    reader.GetDouble(13),
                    reader.GetDouble(14),
                    reader.GetDouble(15),
                    reader.GetDouble(16),
                    reader.GetDouble(17),
                    reader.GetString(18),
                    reader.GetString(19),
                    reader.GetDateTime(20),
                    new TimeSpan(reader.GetInt32(21), 0, 0, 0),
                    reader.GetString(23),
                    reader.GetBoolean(22)
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
            ExecuteNoQuery(QUERY_INSERT_USER, User.ID, User.UID, User.Name, User.Surname, User.BirthDate, User.circumference_neck, User.circumference_chest, User.circumference_waist, User.circumference_hips, User.circumference_biceps_left, User.circumference_biceps_right, User.circumference_thigh_left, User.circumference_thigh_right, User.circumference_calv_left, User.circumference_calv_right, User.body_fat, User.Height, User.Weight, User.Tel, User.Email, User.SubscriptionDate, User.SubscriptionLength, User.Active, User.Notes);
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
            ExecuteNoQuery(QUERY_UPDATE_USER, User.ID, User.UID, User.Name, User.Surname, User.BirthDate, User.circumference_neck, User.circumference_chest, User.circumference_waist, User.circumference_hips, User.circumference_biceps_left, User.circumference_biceps_right, User.circumference_thigh_left, User.circumference_thigh_right, User.circumference_calv_left, User.circumference_calv_right, User.body_fat, User.Height, User.Weight, User.Tel, User.Email, User.SubscriptionDate, User.SubscriptionLength, User.Active, User.Notes);
        }

        public static void UpdateProduct(Product Product)
        {
            ExecuteNoQuery(QUERY_UPDATE_PRODUCT, Product.Name, Product.Description, Product.ID);
        }
    }
}
