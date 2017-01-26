using MTR_APP;
using System;
using System.Windows.Forms;
using Bunifu;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace MTR_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MTR_APP.MainForm());
            //SplashForm.ShowSplashScreen();
            //MainForm mainForm = new MainForm(); //this takes ages
            //System.Threading.Thread.Sleep(5000);
            //SplashForm.CloseForm();
            //Application.Run(mainForm);

        }
    }
}