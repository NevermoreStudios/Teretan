using System;

namespace Teretan
{
    /// <summary>
    /// Model class containing all properties of a user.
    /// </summary>
    public class User
    {
        // Jesus Christ
        public int ID { get; set; }
        public int UID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public double CircumferenceNeck { get; set; }
        public double CircumferenceChest { get; set; }
        public double CircumferenceWaist { get; set; }
        public double CircumferenceHips { get; set; }
        public double CircumferenceBicepsLeft { get; set; }
        public double CircumferenceBicepsRight { get; set; }
        public double CircumferenceThighLeft { get; set; }
        public double CircumferenceThighRight { get; set; }
        public double CircumferenceCalvLeft { get; set; }
        public double CircumferenceCalvRight { get; set; }
        public double BodyFat { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime SubscriptionExpiry { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="ID">User's database ID</param>
        /// <param name="UID">User's custom ID</param>
        /// <param name="Name">User's name</param>
        /// <param name="Surname">User's surname</param>
        /// <param name="BirthDate">User's birth date</param>
        /// <param name="CircumferenceNeck">Circumference of the user's right neck</param>
        /// <param name="CircumferenceChest">Circumference of the user's right chest</param>
        /// <param name="CircumferenceWaist">Circumference of the user's waist</param>
        /// <param name="CircumferenceHips">Circumference of the user's hips</param>
        /// <param name="CircumferenceBicepsLeft">Circumference of the user's left biceps</param>
        /// <param name="CircumferenceBicepsRight">Circumference of the user's right biceps</param>
        /// <param name="CircumferenceThighLeft">Circumference of the user's left thigh</param>
        /// <param name="CircumferenceThighRight">Circumference of the user's right thigh</param>
        /// <param name="CircumferenceCalvLeft">Circumference of the user's left calv</param>
        /// <param name="CircumferenceCalvRight">Circumference of the user's right calv</param>
        /// <param name="BodyFat">User's body fat</param>
        /// <param name="Height">User's height</param>
        /// <param name="Weight">User's weight</param>
        /// <param name="Telephone">User's phone number</param>
        /// <param name="Email">User's email</param>
        /// <param name="SubscriptionExpiry">Subscription expiry date</param>
        /// <param name="Notes">Notes about the user</param>
        /// <param name="Active">If the user is active</param>
        public User(int ID, int UID, string Name, string Surname, DateTime BirthDate, double CircumferenceNeck,
            double CircumferenceChest, double CircumferenceWaist, double CircumferenceHips,
            double CircumferenceBicepsLeft, double CircumferenceBicepsRight, double CircumferenceThighLeft,
            double CircumferenceThighRight, double CircumferenceCalvLeft, double CircumferenceCalvRight,
            double BodyFat, double Height, double Weight, string Telephone, string Email,
            DateTime SubscriptionExpiry, string Notes, bool Active)
        {
            this.ID = ID;
            this.UID = UID;
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            this.CircumferenceNeck = CircumferenceNeck;
            this.CircumferenceChest = CircumferenceChest;
            this.CircumferenceWaist = CircumferenceWaist;
            this.CircumferenceHips = CircumferenceHips;
            this.CircumferenceBicepsLeft = CircumferenceBicepsLeft;
            this.CircumferenceBicepsRight = CircumferenceBicepsRight;
            this.CircumferenceThighLeft = CircumferenceThighLeft;
            this.CircumferenceThighRight = CircumferenceThighRight;
            this.CircumferenceCalvLeft = CircumferenceCalvLeft;
            this.CircumferenceCalvRight = CircumferenceCalvRight;
            this.BodyFat = BodyFat;
            this.Height = Height;
            this.Telephone = Telephone;
            this.Email = Email;
            this.SubscriptionExpiry = SubscriptionExpiry;
            this.Notes = Notes;
            this.Active = Active;
            this.Weight = Weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            ID = UID = 0;
            Name = Surname = Telephone = Email = Notes = "";
            CircumferenceNeck = CircumferenceChest = CircumferenceWaist = CircumferenceHips =
                CircumferenceBicepsLeft = CircumferenceBicepsRight = CircumferenceThighLeft =
                CircumferenceThighRight = CircumferenceCalvLeft = CircumferenceCalvRight =
                BodyFat = Height = Weight = 0;
            BirthDate = SubscriptionExpiry = new DateTime(1973, 1, 1);
            Active = false;
        }

        /// <summary>
        /// Gets the amount of days left until the subscription expires.
        /// </summary>
        /// <returns>The amount of days left until the subscription expires</returns>
        public int GetSubLeft()
        {
            return SubscriptionExpiry < DateTime.Now ?
                0 :
                1 + SubscriptionExpiry
                    .Subtract(DateTime.Now)
                    .Days;
        }

        /// <summary>
        /// Gets the user's age
        /// </summary>
        /// <returns>User's age</returns>
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

        /// <summary>
        /// Gets the user's full name (name + surname)
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }


        /// <summary>
        /// Determines whether the user is marked red on the user list
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the user should be marked red on the user list; otherwise, <c>false</c>
        /// </returns>
        public bool IsRed()
        {
            return GetSubLeft() <= int.Parse(Preferences.Get("red")) && Active;
        }

        /// <summary>
        /// Determines whether the user is marked yellow on the user list
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the user should be marked yellow on the user list; otherwise, <c>false</c>
        /// </returns>
        public bool IsYellow()
        {
            return GetSubLeft() <= int.Parse(Preferences.Get("yellow")) && Active;
        }

        /// <summary>
        /// If the user's subscription has expired
        /// </summary>
        /// <returns>If the user's subscription has expired</returns>
        public bool Expired()
        {
            return GetSubLeft() == 0;
        }
    }
}
