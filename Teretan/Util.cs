using System;
using System.Collections.Generic;

namespace Teretan
{
    public static class Util
    {
        public static List<User> GetNotif()
        {
            List<User> users = Database.GetUsers(),
                       ret = new List<User>();
            foreach(User u in users)
            {
                if (u.IsRed())
                {
                    ret.Add(u);
                }
            }
            return ret;
        }
    }
}
