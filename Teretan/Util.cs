using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public static class Util
    {
        public static int GetSubLeft(User User){
            DateTime dt = User.Subscription_Date;
            dt = dt.Add(User.Subscription_Lenght);
            TimeSpan left = dt.Subtract(DateTime.Now);
            return left.Days;

        }

        public static int GetAge(User User){
            DateTime today = DateTime.Today;
            // Calculate the age.
            int age = today.Year - User.BirthDate.Year;
            // Do stuff with it.
            if (User.BirthDate > today.AddYears(-age)) age--;
            return age;
        }

        public static List<User> GetNotif()
        {
            List<User> Lu = DB_Handler.GetUser("SELECT * FROM Users");
            List<User> ret = new List<User>();
            for (int i = 0; i < Lu.Count; i++)
            {
                if (Util.GetSubLeft(Lu[i]) <= Convert.ToInt32(Preferences.get("Red")))
                {
                    ret.Add(Lu[i]);
                }
            }
            return ret;
        }
    }
}
