using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            ToastNotificationManagerCompat.History.Clear();
            Application.Exit();
        }
    }
}
