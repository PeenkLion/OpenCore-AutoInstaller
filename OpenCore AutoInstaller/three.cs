using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCore_AutoInstaller
{
    public partial class three : UserControl
    {
        public three()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Provider = "Dell";
            Properties.Settings.Default.Save();
            MessageBox.Show("Dell/VIAO Selected!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Provider = "HP";
            Properties.Settings.Default.Save();
            MessageBox.Show("HP Selected!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Provider = "Other";
            Properties.Settings.Default.Save();
            MessageBox.Show("Other Selected!");
        }
    }
}
