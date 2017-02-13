using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public static class Preferences
    {

        public static void Set(string key,string value)
        {
            string q = String.Format("UPDATE Preferences SET Key='{0}',Value='{1}' WHERE Key='{0}';", key, value);
            DB_Handler.ExecuteNoQuery(q);
        }

        public static string get(string key)
        {
            string s="";
            string q = String.Format("SELECT * FROM Preferences WHERE Key='{0}';", key);
            SQLiteDataReader reader = DB_Handler.ExecuteRead(q);
            while (reader.Read())
            {
                s = Convert.ToString(reader["Value"]);
            }
            return s;
        }
    }
}
