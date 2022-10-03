using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Wallpaper : Form
    {
        public Wallpaper()
        {
            InitializeComponent();
        }

        private void Wallpaper_Load(object sender, EventArgs e)
        {

        }

        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam,
        string pvParam, uint fWinIni);

        public static void changeWallpaper(string imgURL)
        {
            string downloadedFileName = Path.GetTempPath() + "img.png";
            string url = imgURL;
            using (WebClient webC = new WebClient())
            {
                webC.DownloadFile(new Uri(url), downloadedFileName);

            }
            SystemParametersInfo(0x0014, 0, downloadedFileName, 0x0001);

        }
        public static void startUp()
        {
            string currentPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string startUpFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string path = Path.Combine(startUpFolder, "wallpaper.exe");
            if (!File.Exists(path))
            {
                try
                {
                    File.Copy(currentPath, path);
                }
                catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startUpFile = Environment.SpecialFolder.Startup + "wallpaper.exe";
            while (true)
            {
                if (!File.Exists(startUpFile))
                {
                    startUp();
                }

                changeWallpaper(textBox1.Text);
                Thread.Sleep(1800000);
            }
        }

        private const string registryKey =
            @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string appsUseLightThemeValue =
            "AppsUseLightTheme";
        private const string systemUsesLightTheme =
            "SystemUsesLightTheme";

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            this.Hide();
        }
        private void ToggleTheme()
        {
            var systemUsesLightThemeValue = (int)Registry
                .GetValue(registryKey, systemUsesLightTheme, 1) != 0;

            Registry.SetValue(registryKey, appsUseLightThemeValue, Convert.ToInt32(!systemUsesLightThemeValue));
            Registry.SetValue(registryKey, systemUsesLightTheme, Convert.ToInt32(!systemUsesLightThemeValue));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sURL = textBox1.Text;
            WebRequest req = WebRequest.Create(sURL);
            WebResponse res = req.GetResponse();
            Stream imgStream = res.GetResponseStream();
            Image img1 = Image.FromStream(imgStream);
            imgStream.Close();
            pictureBox1.Image = img1;
        }
    }
}
