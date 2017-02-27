using System;
using System.Windows.Forms;

namespace Teretan
{
    public partial class PreferencesF : Form
    {
        public PreferencesF()
        {
            InitializeComponent();
        }

        private void PreferencesF_Load(object sender, EventArgs e)
        {
            yellowVal.Value = int.Parse(Preferences.Get("yellow"));
            redVal.Value = int.Parse(Preferences.Get("red"));
        }

        private void Save(object sender, EventArgs e)
        {
            Preferences.Set("yellow", yellowVal.Value.ToString());
            Preferences.Set("red", redVal.Value.ToString());
            Close();
        }
    }
}
