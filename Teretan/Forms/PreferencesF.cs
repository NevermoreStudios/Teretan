using System;
using System.Windows.Forms;

namespace Teretan
{
    public partial class PreferencesF : Form
    {
        public PreferencesF()
        {
            InitializeComponent();
            I18N.TranslateControls(this);
        }

        private void PreferencesF_Load(object sender, EventArgs e)
        {
            try
            {
                yellowVal.Value = int.Parse(Preferences.Get("yellow"));
                redVal.Value = int.Parse(Preferences.Get("red"));
            }
            catch (Exception ex)
            {
                 Util.DBError(ex);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                Preferences.Set("yellow", yellowVal.Value.ToString());
                Preferences.Set("red", redVal.Value.ToString());
            }
            catch (Exception ex)
            {
                Util.DBError(ex);
            }
            Close();
        }
    }
}
