using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretan
{
    public class User
    {
        public User(int ID,string Name,string Surname,DateTime BirthDate,float Height,float WaistWidth,float ShoulderWidth,float ArmsLenght,float LegsLenght,string e_mail,DateTime Subscription_Date,TimeSpan Subscription_Lenght,string Notes)
        {
            this.ID = ID;
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            this.Height = Height;
            this.WaistWidth = WaistWidth;
            this.ShoulderWidth = ShoulderWidth;
            this.ArmsLenght = ArmsLenght;
            this.LegsLenght = LegsLenght;
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
        public float WaistWidth;
        public float ShoulderWidth;
        public float ArmsLenght;
        public float LegsLenght;
        public string e_mail;
        public DateTime Subscription_Date;
        public TimeSpan Subscription_Lenght;
        public string Notes;
    }
}
