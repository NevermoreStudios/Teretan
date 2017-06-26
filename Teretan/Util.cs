using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
                if (u.IsRed() && u.Active)
                {
                    ret.Add(u);
                }
            }
            return ret;
        }

        public static void ShowError(string key, params string[] parameters)
        {
            MessageBox.Show(I18N.String(key, parameters), I18N.String("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ThrowError(Exception e)
        {
            StreamWriter sw = new StreamWriter("errors.txt", true);
            try
            {
                sw.Write($"===============\nDate: {DateTime.Now.ToString()}\nError: {e.GetType()}\nMessage: {e.Message}\nStack trace:\n{e.StackTrace}\n");
            }
            finally
            {
                sw.Close();
            }
        }

        public static void DBError(Exception e)
        {
            ThrowError(e);
            ShowError("db-error");
        }

        public static bool Question(string key, params string[] parameters)
        {
            return MessageBox.Show(I18N.String(key, parameters), I18N.String("confirm"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

    }
}
