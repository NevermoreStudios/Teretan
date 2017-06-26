using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Teretan
{
    class I18N
    {
        static Dictionary<string, Dictionary<string, string>> data;
        static Dictionary<string, string> current;

        public static void Init()
        {
            string json = "";
            byte[] bytes = (byte[])Properties.Resources.ResourceManager.GetObject("i18n");
            foreach (byte b in bytes)
            {
                json += Convert.ToChar(b);
            }
            data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            InitLanguage();
        }

        public static void InitLanguage()
        {
            string lang = Preferences.Get("lang");
            if (data.ContainsKey(lang))
            {
                current = data[lang];
            }
            else
            {
                current = data["en"];
            }
        }

        public static string String(string key, params object[] parameters)
        {
            return current.ContainsKey(key) ?
                       string.Format(current[key], parameters) :
                       $"<{key}>";
        }

        public static void TranslateControls(Form form)
        {
            form.Text = String(form.Text);
            TranslateControlsRecursive(form.Controls);
        }

        private static void TranslateControlsRecursive(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                TranslateControlsRecursive(c.Controls);
                if (c.Tag == null)
                {
                    continue;
                }
                string tag = c.Tag.ToString();
                if (!tag.StartsWith("i18n-"))
                {
                    continue;
                }
                string prop;
                int index = tag.IndexOf(',');
                if (index == -1)
                {
                    prop = tag.Substring(5);
                }
                else
                {
                    prop = tag.Substring(5, index - 5);
                }
                switch (prop)
                {
                    case "text":
                        c.Text = String(c.Text);
                        break;
                }
            }
        }

    }
}
