using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//PeenkLion (Some parts may be taken from Stack Overflow, but most of this is me)
//Discord.io/PLCoding

namespace OpenCore_AutoInstaller
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
        }

        bool mouseDown;
        private Point offset;
        bool agreed = false;

        private void FirstTime_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void FirstTime_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FirstTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FirstTime_Load(object sender, EventArgs e)
        {
            one1.Hide();
            two1.Hide();
            three1.Hide();
            d.Hide();
            hello.Text = "Hello, " + Environment.UserName + ". Welcome to OpenCore Auto Installer, or \nOCAI for short. Complete the following questions\nto continue:";
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Provider == "Dell" || Properties.Settings.Default.Provider == "HP" || Properties.Settings.Default.Provider == "Other")
            {
                if (agreed == true)
                {
                    Properties.Settings.Default.FirstTime = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("First Time User Set up done! You can edit these settings later, but your good to get started now!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Agree to the terms provided to continue");
                }
            }
            else
            {
                MessageBox.Show("Finish inputting your settings to continue");
                
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (agreed == true)
            {
                hello.Text = "Select your device:";
                button1.ForeColor = Color.Green;
                two1.Hide();
                three1.Hide();
                one1.Show();
            }
            else
            {
                MessageBox.Show("Agree to the terms provided to continue");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PCType == "Desktop" || Properties.Settings.Default.PCType == "Laptop")
            {
                hello.Text = "Select your method of internet access:";
                button2.ForeColor = Color.Green;
                two1.Show();
                three1.Hide();
                one1.Hide();
                
            }
            else
            {
                MessageBox.Show("Enter in your settings for the previous step to continue to this step");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MethodOfIA == "Ethernet" || Properties.Settings.Default.MethodOfIA == "WiFi")
            {
                hello.Text = "Select your PC Provider:";
                button3.ForeColor = Color.Green;
                two1.Hide();
                three1.Show();
                one1.Hide();
                d.Show();
                
            }
            else
            {
                MessageBox.Show("Enter in your settings for the previous step to continue to this step");
            }
        }

        private void iAgree_Click(object sender, EventArgs e)
        {
            agreed = true;
            iAgree.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void three1_Load(object sender, EventArgs e)
        {

        }
    }
}
