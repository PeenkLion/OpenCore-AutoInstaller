using AnimateDemo;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCore_AutoInstaller
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
        IntPtr wParam, IntPtr lParam);
        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            
            WebClient wc = new WebClient();
            string data = wc.DownloadString("https://pastebin.com/raw/KtLPvw8C");
            if (data.Contains("active: false"))
            {
                Application.Exit();
            }
            else
            {
                if (data.Contains("update: false"))
                {
                    WinAPI.AnimateWindow(this.Handle, 750, WinAPI.CENTER);
                    Thread.Sleep(1000);
                    timer1.Start();
                }
                else
                {
                    this.Hide();
                    new Update().Show();
                }
                
            }
            this.Shown += new System.EventHandler(this.Form_Shown);
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            
            string cdir = Environment.CurrentDirectory;
            if (!File.Exists(cdir + @"\Music\msb.mp3"))
            {
                WebClient wc = new WebClient();
                Directory.CreateDirectory(cdir + @"\Music");
                wc.DownloadFile("https://download1335.mediafire.com/95rxy6nyyvsg/qpz5khee3reix41/Money+So+Big.mp3", cdir + @"\Music\msb.mp3");
            }

            if (Properties.Settings.Default.music == true)
            {
                for (int i = 0; i < 51; i++)
                {
                    VolDown();
                    Thread.Sleep(1);
                }
                for (int i = 0; i < 13; i++)
                {
                    VolUp();
                    Thread.Sleep(1);
                }
                IWavePlayer waveOutDevice = new WaveOut();
                AudioFileReader audioFileReader = new AudioFileReader(cdir + @"\Music\msb.mp3");

                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discord.io/PLCoding");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                timer1.Stop();
                if (Properties.Settings.Default.FirstTime == true)
                {
                    new FirstTime().Show();
                    this.Visible = false;
                }
                else
                {
                    new Main().Show();
                    this.Visible = false;
                }
            }
            else
            {
                Opacity = Opacity - .01;
            }
        }
    }
}
