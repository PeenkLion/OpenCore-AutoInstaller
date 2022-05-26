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
    public partial class two : UserControl
    {
        public two()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MethodOfIA = "Ethernet";
            Properties.Settings.Default.Save();
            MessageBox.Show("Ethernet Selected!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MethodOfIA = "WiFi";
            Properties.Settings.Default.Save();
            MessageBox.Show("WiFi Selected!");
        }
    }
}
