using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCore_AutoInstaller
{
    public partial class InstallsAndScripts : Form
    {
        public InstallsAndScripts()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;

        private void InstallsAndScripts_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void InstallsAndScripts_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        string cdir { get; set; }
        private void InstallsAndScripts_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void InstallsAndScripts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            WebClient wc = new WebClient();
            if (!Directory.Exists(cdir + @"\Downloads"))
            {
                Directory.CreateDirectory(cdir + @"\Downloads");
            }
            wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975546424546721852/SSDTTime.7z", cdir + @"\Downloads\SSDTTime.7z");
            MessageBox.Show("Done!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            WebClient wc = new WebClient();
            if (!Directory.Exists(cdir + @"\Downloads"))
            {
                Directory.CreateDirectory(cdir + @"\Downloads");
            }
            wc.DownloadFile("https://github.com/pbatard/rufus/releases/download/v3.18/rufus-3.18.exe", cdir + @"\Downloads\rufus-3.18.exe");
            Process.Start(cdir + @"\Downloads\rufus-3.18.exe");
            MessageBox.Show("Done!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            WebClient wc = new WebClient();
            if (!Directory.Exists(cdir + @"\Downloads"))
            {
                Directory.CreateDirectory(cdir + @"\Downloads");
            }
            wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975546668114141195/GenSMBIOS.7z", cdir + @"\Downloads\GenSMBIOS.7z");
            MessageBox.Show("Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            WebClient wc = new WebClient();
            if (!Directory.Exists(cdir + @"\Downloads"))
            {
                Directory.CreateDirectory(cdir + @"\Downloads");
            }
            wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975546424546721852/SSDTTime.7z", cdir + @"\Downloads\SSDTTime.7z");
            MessageBox.Show("Done!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            WebClient wc = new WebClient();
            if (!Directory.Exists(cdir + @"\Downloads"))
            {
                Directory.CreateDirectory(cdir + @"\Downloads");
            }
            wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975546529114894367/macrecovery.7z", cdir + @"\Downloads\macrecovery.7z");
            MessageBox.Show("Done!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cdir = Environment.CurrentDirectory;
            if (Directory.Exists(cdir + @"\Downloads"))
            {
                Process.Start("explorer.exe", cdir + @"\Downloads");
            }
            else
            {
                MessageBox.Show("No files downloaded");
            }
        }
    }
}
