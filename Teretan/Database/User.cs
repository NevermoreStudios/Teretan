using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public class User
    {
        public User(int ID,string Name,string Surname,DateTime BirthDate,float Height,float Other1,float Other2,float Other3,float Other4,float Other5,float Other6,string e_mail,DateTime Subscription_Date,TimeSpan Subscription_Lenght,string Notes)
        {
            this.ID = ID;
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            this.Height = Height;
            this.Other1 = Other1;
            this.Other2 = Other2;
            this.Other3 = Other3;
            this.Other4 = Other4;
            this.Other5 = Other5;
            this.Other6 = Other6;
            this.e_mail = e_mail;
            this.Subscription_Date = Subscription_Date;
            this.Subscription_Lenght = Subscription_Lenght;
            this.Notes = Notes;
        }
        public int ID;
        public string Name;
        public string Surname;
        public DateTime BirthDate;
        public float Height;
        public float Other1;
        public float Other2;
        public float Other3;
        public float Other4;
        public float Other5;
        public float Other6;
        public string e_mail;
        public DateTime Subscription_Date;
        public TimeSpan Subscription_Lenght;
        public string Notes;
    }
}
