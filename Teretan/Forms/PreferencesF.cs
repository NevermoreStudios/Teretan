using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretan
{
    public partial class PreferencesF : Form
    {
        public PreferencesF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preferences.Set("Yellow", numericUpDown1.Value.ToString());
            Preferences.Set("Red", numericUpDown2.Value.ToString());
            this.Close();
        }

        private void PreferencesF_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToInt32(Preferences.get("Yellow"));
            numericUpDown2.Value = Convert.ToInt32(Preferences.get("Red"));
        }
    }
}
