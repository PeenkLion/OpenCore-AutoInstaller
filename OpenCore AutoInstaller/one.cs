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
    public partial class one : UserControl
    {
        public one()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCType = "Desktop";
            Properties.Settings.Default.Save();
            MessageBox.Show("Desktop Selected!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCType = "Laptop";
            Properties.Settings.Default.Save();
            MessageBox.Show("Laptop Selected!");
        }
    }
}
