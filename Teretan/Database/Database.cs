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

        const string QUERY_SELECT_ORDER_USER = "SELECT * FROM `orders` WHERE `user`='{0}'";
        const string QUERY_SELECT_ORDER_PRODUCT = "SELECT * FROM `orders` WHERE `product`='{0}'";
        const string QUERY_SELECT_USER_ID = "SELECT * FROM `users` WHERE `id`='{0}' LIMIT 1";
        const string QUERY_SELECT_PRODUCT_ID = "SELECT * from `products` WHERE `id`='{0}' LIMIT 1";

        /**
         * Insert queries
         */
       const string QUERY_INSERT_USER = @"INSERT INTO `users` (`user_id`,`name`,`surname`,`birthdate`,`circumference_neck`,`circumference_chest`,`circumference_waist`,`circumference_hips`,`circumference_biceps_left`,`circumference_biceps_right`,`circumference_thigh_left`,`circumference_thigh_right`,`circumference_calv_left`,`circumference_calv_right`,`body_fat`,`height`,`weight`,`tel`,`email`,`subscription_expiry`,`active`,`notes`)
           VALUES('{0}', '{1}','{2}', '{3:yyyy'-'MM'-'dd' 'HH':'mm':'ss}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}', '{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19:yyyy'-'MM'-'dd' 'HH':'mm':'ss}','{20}','{21}')";
       const string QUERY_INSERT_PRODUCT = "INSERT INTO `products` (`name`, `description`) VALUES('{0}', '{1}')";
       const string QUERY_INSERT_ORDER = "INSERT INTO `orders` (`user`, `product`, `date`) VALUES('{0}', '{1}','{2:yyyy'-'MM'-'dd' 'HH':'mm':'ss}')";

       /**
        * Delete queries
        */
        const string QUERY_DELETE_USER = "DELETE FROM `users` WHERE `id`='{0}'";
        const string QUERY_DELETE_PRODUCT = "DELETE FROM `products` WHERE `id`='{0}'";
        const string QUERY_DELETE_ORDER = "DELETE FROM `orders` WHERE `id`='{0}'";

        /**
         * Update queries
         */
        const string QUERY_UPDATE_USER = "UPDATE `users` SET `user_id`='{0}',`name`='{1}',`surname`='{2}',`birthdate`='{3:yyyy'-'MM'-'dd' 'HH':'mm':'ss}',`circumference_neck`='{4}',`circumference_chest`='{5}',`circumference_waist`='{6}',`circumference_hips`='{7}',`circumference_biceps_left`='{8}',`circumference_biceps_right`='{9}',`circumference_thigh_left`='{10}',`circumference_thigh_right`='{11}',`circumference_calv_left`='{12}',`circumference_calv_right`='{13}',`body_fat`='{14}',`height`='{15}',`weight`='{16}',`tel`='{17}',`email`='{18}',`subscription_expiry`='{19:yyyy'-'MM'-'dd' 'HH':'mm':'ss}',`active`='{20}',`notes`='{21}' WHERE `id`='{22}'";
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
            `tel`	                        TEXT,
	        `email`	                        TEXT,
	        `subscription_expiry`	        TEXT,
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
            // Console.WriteLine(q);
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
                    reader.GetInt32(0),     // ID
                    reader.GetInt32(1),     // UID
                    reader.GetString(2),    // Name
                    reader.GetString(3),    // Surname
                    reader.GetDateTime(4),  // BirthDate
                    reader.GetDouble(5),    // CircumferenceNeck
                    reader.GetDouble(6),    // CircumferenceChest
                    reader.GetDouble(7),    // CircumferenceWaist
                    reader.GetDouble(8),    // CircumferenceHips
                    reader.GetDouble(9),    // CircumferenceBicepsLeft
                    reader.GetDouble(10),   // CircumferenceBicepsRight
                    reader.GetDouble(11),   // CircumferenceThighLeft
                    reader.GetDouble(12),   // CircumferenceThighRight
                    reader.GetDouble(13),   // CircumferenceCalvLeft
                    reader.GetDouble(14),   // CircumferenceCalvRight
                    reader.GetDouble(15),   // BodyFat
                    reader.GetDouble(16),   // Height
                    reader.GetDouble(17),   // Weight
                    reader.GetString(18),   // Telephone
                    reader.GetString(19),   // Email
                    reader.GetDateTime(20), // SubscriptionExpiry
                    reader.GetString(22),   // Notes
                    reader.GetBoolean(21)   // Active
                ));
            }
            return ret;
        }

        public static User GetUserById(int id)
        {
            return GetUsers(QUERY_SELECT_USER_ID, id)[0];
        }

        public static List<Product> GetProducts()
        {
            return GetProducts(QUERY_SELECT_PRODUCTS);
        }

        private static List<Product> GetProducts(string query, params object[] args)
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

        public static Product GetProductById(int id)
        {
            return GetProducts(QUERY_SELECT_PRODUCT_ID, id)[0];
        }

        public static List<Order> GetOrders()
        {
            return GetOrders(QUERY_SELECT_ORDERS);
        }

        private static List<Order> GetOrders(string query, params object[] args)
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

        public static List<Order> GetOrdersByUser(User user)
        {
            return GetOrders(QUERY_SELECT_ORDER_USER, user.ID);
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
            ExecuteNoQuery(QUERY_INSERT_USER, User.UID, User.Name, User.Surname, User.BirthDate,
                User.CircumferenceNeck, User.CircumferenceChest, User.CircumferenceWaist,
                User.CircumferenceHips, User.CircumferenceBicepsLeft, User.CircumferenceBicepsRight,
                User.CircumferenceThighLeft, User.CircumferenceThighRight, User.CircumferenceCalvLeft,
                User.CircumferenceCalvRight, User.BodyFat, User.Height, User.Weight, User.Telephone,
                User.Email, User.SubscriptionExpiry, User.Active ? 1 : 0, User.Notes);
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
            Console.WriteLine(User.ID);
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
            List<Order> dep = GetOrdersByUser(user);
            foreach (Order item in dep)
            {
                RemoveOrder(item);
            }
        }

        public static void UpdateUser(User User)
        {
            ExecuteNoQuery(QUERY_UPDATE_USER, User.UID, User.Name, User.Surname, User.BirthDate,
                User.CircumferenceNeck, User.CircumferenceChest, User.CircumferenceWaist,
                User.CircumferenceHips, User.CircumferenceBicepsLeft, User.CircumferenceBicepsRight,
                User.CircumferenceThighLeft, User.CircumferenceThighRight, User.CircumferenceCalvLeft,
                User.CircumferenceCalvRight, User.BodyFat, User.Height, User.Weight, User.Telephone,
                User.Email, User.SubscriptionExpiry, User.Active ? 1 : 0,
                User.Notes, User.ID);
        }

        public static void UpdateProduct(Product Product)
        {
            ExecuteNoQuery(QUERY_UPDATE_PRODUCT, Product.Name, Product.Description, Product.ID);
        }
    }
}
