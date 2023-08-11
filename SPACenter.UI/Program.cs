using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Org.BouncyCastle.Asn1.X509.Qualified;
using SPACenter.UI.Wait_Forms;
using DevExpress.XtraWaitForm;

namespace SPACenter.UI
{
    internal static class Program
    {
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new FormMain());
           

            //form main acılırken loading ekranı
            SplashScreenManager.ShowForm(typeof(SplashScreenForm));

            System.Threading.Thread.Sleep(2000); // 2000 ms = 2 saniye bekleyecek main acılırken

            FormMain mainForm = new FormMain();

            Application.Run(mainForm);

            SplashScreenManager.CloseForm(false);
        }

     
    }
}
