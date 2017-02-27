using System;
using System.Resources;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Teretan
{
    class I18N
    {
        static Dictionary<string, Dictionary<string, string>> data;
        
        public static void Init()
        {
            string json = "";
            byte[] bytes = (byte[])Properties.Resources.ResourceManager.GetObject("i18n");
            foreach(byte b in bytes)
            {
                json += Convert.ToChar(b);
            }
            data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
        }

        public static void InitLanguage()
        {
            // TODO
        }

        public static string String(string key, params string[] parameters)
        {
            return string.Format(data[Preferences.Get("lang")][key], parameters);
        }
    }
}
