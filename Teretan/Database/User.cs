using System;

namespace Teretan
{
    public class User
    {
        public int ID;
        public int UID;
        public string Name;
        public string Surname;
        public DateTime BirthDate;
        public double circumference_neck;
        public double circumference_chest;
        public double circumference_waist;
        public double circumference_hips;
        public double circumference_biceps_left;
        public double circumference_biceps_right;
        public double circumference_thigh_left;
        public double circumference_thigh_right;
        public double circumference_calv_left;
        public double circumference_calv_right;
        public double body_fat;
        public double Height;
        public double Weight;
        public string Tel;
        public string Email;
        public DateTime SubscriptionDate;
        public TimeSpan SubscriptionLength;
        public string Notes;
        public bool Active;

        public User(int ID, int UID, string Name, string Surname, DateTime BirthDate, double circumference_neck, double circumference_chest, double circumference_waist, double circumference_hips, double circumference_biceps_left, double circumference_biceps_right, double circumference_thigh_left, double circumference_thigh_right, double circumference_calv_left, double circumference_calv_right, double body_fat, double Height, double Weight, string Tel, string Email, DateTime SubscriptionDate, TimeSpan SubscriptionLength, string Notes, bool Active)
        {
            this.ID = ID;
            this.UID = UID;
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            this.circumference_neck = circumference_neck;
            this.circumference_chest = circumference_chest;
            this.circumference_waist = circumference_waist;
            this.circumference_hips = circumference_hips;
            this.circumference_biceps_left = circumference_biceps_left;
            this.circumference_biceps_right = circumference_biceps_right;
            this.circumference_thigh_left = circumference_thigh_left;
            this.circumference_thigh_right = circumference_thigh_right;
            this.circumference_calv_left = circumference_calv_left;
            this.circumference_calv_right = circumference_calv_right;
            this.body_fat = body_fat;
            this.Height = Height;
            this.Tel = Tel;
            this.Email = Email;
            this.SubscriptionDate = SubscriptionDate;
            this.SubscriptionLength = SubscriptionLength;
            this.Notes = Notes;
            this.Active = Active;
            this.Weight = Weight;
        }

        public int GetSubLeft()
        {
            return SubscriptionDate
                .Add(SubscriptionLength)
                .Subtract(DateTime.Now)
                .Days;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            // Calculate the age.
            int age = today.Year - BirthDate.Year;
            // Do stuff with it.
            if (BirthDate > today.AddYears(-age))
            {
                --age;
            }
            return age;
        }

        public bool IsRed()
        {
            return GetSubLeft() <= int.Parse(Preferences.Get("red")) && Active;
        }

        public bool IsYellow()
        {
            return GetSubLeft() <= int.Parse(Preferences.Get("yellow")) && Active;
        }
    }
}
