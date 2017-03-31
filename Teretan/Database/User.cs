using System;

namespace Teretan
{
    public class User
    {
        public int ID { get; }
        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public float Height { get; }
        public float WaistWidth { get; }
        public float ShoulderWidth { get; }
        public float ArmsLenght { get; }
        public float LegsLenght { get; }
        public float Weight { get; }
        public string Email { get; }
        public DateTime SubscriptionDate { get; set; }
        public TimeSpan SubscriptionLength { get; set; }
        public string Notes { get; }

        public User(int ID, string Name, string Surname, DateTime BirthDate, float Height, float WaistWidth, float ShoulderWidth, float ArmsLenght, float LegsLenght,float Weight, string Email, DateTime SubscriptionDate, TimeSpan SubscriptionLength, string Notes)
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
            this.Email = Email;
            this.SubscriptionDate = SubscriptionDate;
            this.SubscriptionLength = SubscriptionLength;
            this.Notes = Notes;
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
            return GetSubLeft() <= int.Parse(Preferences.Get("red"));
        }

        public bool IsYellow()
        {
            return GetSubLeft() <= int.Parse(Preferences.Get("yellow"));
        }
    }
}
