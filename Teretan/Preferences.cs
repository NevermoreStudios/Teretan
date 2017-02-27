using System.Collections.Generic;

namespace Teretan
{
    public static class Preferences
    {
        private static Dictionary<string, string> preferences;

        public static void Init()
        {
            preferences = Database.GetPreferences();
        }

        public static void Set(string key, string value)
        {
            preferences[key] = value;
            Database.SetPreference(key, value);
        }

        public static string Get(string key)
        {
            return preferences[key];
        }
    }
}
