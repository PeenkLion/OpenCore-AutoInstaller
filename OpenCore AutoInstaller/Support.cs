using AnimateDemo;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCore_AutoInstaller
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        bool mouseDown;
        private Point offset;

        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
        {
                {
                    "username",
                        username
                },
                {
                    "content",
                        msg
                }
            });
        }

        private void Support_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 3000, WinAPI.BLEND);
        }
        string MyIP { get; set; }
        string environment { get; set; }
        string set { get; set; }
        string hardware { get; set; }
        bool sent = false;

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            if (sent == false)
            {
                string message = textBox1.Text;
                string name = Environment.UserName;
                string URL = "https://discord.com/api/webhooks/886123988835794974/kTNP0GtanmDYPiVhg4vBFSGXEhYY_UL-04DMREvY3QHrzeCVFZ2VbXmMDRVLU2aKaMJ9";
                if (ipv4.Checked == true)
                {
                    WebClient wc = new WebClient();
                    MyIP = wc.DownloadString("http://myexternalip.com/raw");
                }
                else
                {
                    MyIP = "none";
                }
                if (settings.Checked == true)
                {
                    set = "\nType: " + Properties.Settings.Default.PCType + "\nMethod Of Internet Access: " + Properties.Settings.Default.MethodOfIA + "\nProvider: " + Properties.Settings.Default.Provider + "\nPath: " + Properties.Settings.Default.path + "\nFirst Time: " + Properties.Settings.Default.FirstTime;
                }
                else
                {
                    set = "none";
                }
                if (env.Checked == true)
                {
                    environment = "\nCurrent Directory: " + Environment.CurrentDirectory + "\nIs 64Bit OS: " + Environment.Is64BitOperatingSystem + "\nMachine Name: " + Environment.MachineName + "\nOS Version: " + Environment.OSVersion + "\nProcessor Count: " + Environment.ProcessorCount + "\nProcess Id: " + Environment.ProcessId;
                }
                else
                {
                    environment = "none";
                }
                if (hwd.Checked == true)
                {
                    WebClient wc = new WebClient();
                    DateTime dt1 = DateTime.Now;
                    byte[] data = wc.DownloadData("http://google.com");
                    DateTime dt2 = DateTime.Now;
                    string speed = Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2).ToString();
                    String firstMacAddress = NetworkInterface
        .GetAllNetworkInterfaces()
        .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
        .Select(nic => nic.GetPhysicalAddress().ToString())
        .FirstOrDefault();
                    var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
                    ManagementObjectCollection mbsList = mbs.Get();
                    string id = "";
                    foreach (ManagementObject mo in mbsList)
                    {
                        id = mo["ProcessorId"].ToString();
                        break;
                    }
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.Start();

                    cmd.StandardInput.WriteLine(@"cd C:\Users\" + Environment.UserName);
                    cmd.StandardInput.WriteLine("wmic bios get serialnumber");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    hardware = "Internet Speed: " + speed + " | " + "MAC Address: " + firstMacAddress + " | " + "HWID: " + id + " | " + "SerialNumber: " + cmd.StandardOutput.ReadToEnd();
                }
                else
                {
                    hardware = "none";
                }
                sendWebHook(URL, "@everyone ```Message: [" + message + "]```" + "     ```Internet Protocol Version 4: " + MyIP + "```     ```Environment Variables: " + environment + "```     ```Settings: " + set + "```" + "     ```Hardware Data: " + hardware + "```", Environment.UserName);
                sent = true;
            }
            else
            {
                MessageBox.Show("You've already sent a request. Contact PeenkLion for support.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Support_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Support_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Support_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
    }
}
