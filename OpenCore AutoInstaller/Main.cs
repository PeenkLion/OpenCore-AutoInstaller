using AnimateDemo;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams.Effects;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCore_AutoInstaller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;
        string cdir { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {
            
            cdir = Environment.CurrentDirectory;
            if (Properties.Settings.Default.vfx == false)
            {
                
                Directory.CreateDirectory(cdir + @"\Cache");
                WebClient wc = new WebClient();
                wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975450785334853682/OpencoreAI.png", cdir + @"\Cache\title.png");
                wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975450968122609724/x1.png", cdir + @"\Cache\exit.png");
                wc.DownloadFile("https://cdn.discordapp.com/attachments/805578987731943424/975450968445550592/dash.png", cdir + @"\Cache\mini.png");
                gif.Image = Image.FromFile(cdir + @"\Cache\title.png");
                min.Image = Image.FromFile(cdir + @"\Cache\mini.png");
                exit.Image = Image.FromFile(cdir + @"\Cache\exit.png");
            }
            else
            {
                if (Directory.Exists(cdir + @"\Cache"))
                {
                    if (File.Exists(cdir + @"\Cache\exit.png") || File.Exists(cdir + @"\Cache\mini.png") || File.Exists(cdir + @"\Cache\title.png") || File.Exists(cdir + @"\Cache\7z2107-x64.exe"))
                    {
                        File.Delete(cdir + @"\Cache\exit.png");
                        File.Delete(cdir + @"\Cache\mini.png");
                        File.Delete(cdir + @"\Cache\title.png");
                        File.Delete(cdir + @"\Cache\7z2107-x64.exe");
                        File.Delete(cdir + @"\Cache\7z2107-x64.exe");
                    }
                    Directory.Delete(cdir + @"\Cache");
                }
            }
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_POSITIVE);
            this.Shown += new System.EventHandler(this.Form_Shown);

        }
        private void Form_Shown(object sender, EventArgs e)
        {
            gif.Visible = true;
            if (Properties.Settings.Default.PCType == "Desktop")
            {
                desktop.BackColor = Color.DodgerBlue;
                
                if (Properties.Settings.Default.MethodOfIA == "Ethernet")
                {
                    lD.Visible = true;
                    ethD.BackColor = Color.DodgerBlue;
                    
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        eTd.Visible = true;
                        dDell.BackColor = Color.DodgerBlue;
                        
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        eTh.Visible = true;
                        dH.BackColor = Color.DodgerBlue;
                        
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        eTo.Visible = true;
                        dOther.BackColor = Color.DodgerBlue;
                        
                    }
                }
                else if (Properties.Settings.Default.MethodOfIA == "WiFi")
                {
                    rD.Visible = true;
                    wifiD.BackColor = Color.DodgerBlue;
                    
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        wTd.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        wTh.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        wTo.Visible = true;
                    }
                }
            }

            else if (Properties.Settings.Default.PCType == "Laptop")
            {
                laptop.BackColor = Color.DodgerBlue;
                
                if (Properties.Settings.Default.MethodOfIA == "Ethernet")
                {
                    lR.Visible = true;
                    ethL.BackColor = Color.DodgerBlue;
                    
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        lapD.BackColor = Color.DodgerBlue;
                        LeTd.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        lapH.BackColor = Color.DodgerBlue;
                        LeTH.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        lapO.BackColor = Color.DodgerBlue;
                        LeTo.Visible = true;
                    }
                }
                else if (Properties.Settings.Default.MethodOfIA == "WiFi")
                {
                    lL.Visible = true;
                    wifiL.BackColor = Color.DodgerBlue;
                    
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        lapD.BackColor = Color.DodgerBlue;
                        LwTd.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        lapH.BackColor = Color.DodgerBlue;
                        LwTh.Visible = true;
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        lapO.BackColor = Color.DodgerBlue;
                        LwTo.Visible = true;
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FirstTime = true;
            Properties.Settings.Default.PCType = "";
            Properties.Settings.Default.MethodOfIA = "";
            Properties.Settings.Default.Provider = "";
            Properties.Settings.Default.music = true;
            Properties.Settings.Default.vfx = true;
            Properties.Settings.Default.path = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings Reset!\n\nRestart Application to continue...");
            Application.Restart();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void waveformPainter1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.music = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Background Music Muted! Restart to continue...");
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Properties.Settings.Default.path = dialog.FileName;
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("This may take a while");
            WebClient wc = new WebClient();
            if (File.Exists(@"C:\Program Files\7-Zip\7zG.exe") || File.Exists(@"D:\Program Files\7-Zip\7zG.exe") || File.Exists(@"E:\Program Files\7-Zip\7zG.exe") || File.Exists(@"F:\Program Files\7-Zip\7zG.exe") || File.Exists(@"G:\Program Files\7-Zip\7zG.exe") || File.Exists(@"H:\Program Files\7-Zip\7zG.exe") || File.Exists(@"I:\Program Files\7-Zip\7zG.exe") || File.Exists(@"J:\Program Files\7-Zip\7zG.exe") || File.Exists(@"K:\Program Files\7-Zip\7zG.exe") || File.Exists(@"L:\Program Files\7-Zip\7zG.exe") || File.Exists(@"M:\Program Files\7-Zip\7zG.exe") || File.Exists(@"N:\Program Files\7-Zip\7zG.exe") || File.Exists(@"A:\Program Files\7-Zip\7zG.exe") ||
                File.Exists(@"O:\Program Files\7-Zip\7zG.exe") || File.Exists(@"P:\Program Files\7-Zip\7zG.exe") || File.Exists(@"Q:\Program Files\7-Zip\7zG.exe") || File.Exists(@"R:\Program Files\7-Zip\7zG.exe") || File.Exists(@"S:\Program Files\7-Zip\7zG.exe") || File.Exists(@"T:\Program Files\7-Zip\7zG.exe") || File.Exists(@"U:\Program Files\7-Zip\7zG.exe") || File.Exists(@"V:\Program Files\7-Zip\7zG.exe") || File.Exists(@"W:\Program Files\7-Zip\7zG.exe") || File.Exists(@"X:\Program Files\7-Zip\7zG.exe") || File.Exists(@"Y:\Program Files\7-Zip\7zG.exe") || File.Exists(@"Z:\Program Files\7-Zip\7zG.exe") || File.Exists(@"B:\Program Files\7-Zip\7zG.exe"))
            {

            }
            else
            {
                if (!Directory.Exists(cdir + @"\Cache"))
                {
                    Directory.CreateDirectory(cdir + @"\Cache");
                    wc.DownloadFile("https://www.7-zip.org/a/7z2107-x64.exe", cdir + @"\Cache\7z2107-x64.exe");
                }
                else
                {
                    wc.DownloadFile("https://www.7-zip.org/a/7z2107-x64.exe", cdir + @"\Cache\7z2107-x64.exe");
                }
                try
                {
                    Process.Start(cdir + @"\Cache\7z2107-x64.exe");
                    Thread.Sleep(1000);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(2500);
                    SendKeys.Send("{ENTER}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to install. Try elevating this application to administrator and trying again. \n\nFull exception log: " + ex.ToString());
                }
                
            }
            if (Properties.Settings.Default.PCType == "Desktop")
            {
                if (Properties.Settings.Default.MethodOfIA == "Ethernet")
                {
                    if (Properties.Settings.Default.Provider == "Dell")
                    {

                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1_YgLRNy1PkiAUehP-twKFYbMdnnP9s8D"), Properties.Settings.Default.path + @"\EFI.7z");
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1_huZU6SHpJkYsa7y4Z0nX3NF68Q_mPdj"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1L5pQ0ek1xH_Osvha6ZlI7vbHArr0EFQd"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
                else if (Properties.Settings.Default.MethodOfIA == "WiFi")
                {
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1LB4MUhwVhwyl-Q7QtHJ4u8RkZyxoX4lv"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1IKrOgwNdds39dmwO3pQXdGISLicsS-GS"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=18SsE3MEnNnpP6TehBIOvdJSrHToE9PkH"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }

            else if (Properties.Settings.Default.PCType == "Laptop")
            {
                if (Properties.Settings.Default.MethodOfIA == "Ethernet")
                {
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1VO7Q0Z93dD8g-9-KeO495IbHP_DXgO9z"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1ecIRiaY2Jxrof07LFzA-Dk9sBi5acYuS"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1uL65N3qzBOdArVF0BP4R8uindcqY8sRE"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
                else if (Properties.Settings.Default.MethodOfIA == "WiFi")
                {
                    if (Properties.Settings.Default.Provider == "Dell")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1VNGU-nIPglQobxLw-pIBd2xWIRqS-Es4"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "HP")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=19bvR8utuuHn71AnlBLzPVWPpGZH3yR1z"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                    else if (Properties.Settings.Default.Provider == "Other")
                    {
                        try
                        {
                            wc.DownloadFileCompleted += DownloadCompleted;
                            wc.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1CjWUowRPZuzQ9YcayXp10010kDURDTg7g"), Properties.Settings.Default.path + @"\EFI.7z");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }

            }
        }
        public static void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Finished!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.vfx = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("VFX Turned Off! Restart to continue...");
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Support().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new InstallsAndScripts().Show();
        }
    }
}
