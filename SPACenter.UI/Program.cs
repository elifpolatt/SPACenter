using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Org.BouncyCastle.Asn1.X509.Qualified;
using SPACenter.UI.Wait_Forms;
using DevExpress.XtraWaitForm;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Models;
using SPACenter.UI.Forms;

namespace SPACenter.UI
{
    internal static class Program
    {
        private static bool FormClosed;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           



            SplashScreenManager.ShowForm(typeof(SplashScreenForm));
            if (FormClosed)
            {
                SplashScreenManager.ShowForm(typeof(SplashScreenForm));

            }

        
            XtraFormLogin login = new XtraFormLogin();
            SplashScreenManager.CloseForm(false);
            login.ShowDialog();

            if (GlobalVariables.User != null)
            {
                Application.Run(new FormMain());
            }
        }


    }
}





//  Application.Run(new FormMain());


//form main acılırken loading ekranı

//System.Threading.Thread.Sleep(2000); // 2000 ms = 2 saniye bekleyecek main acılırken

//FormMain mainForm = new FormMain();

//Application.Run(mainForm);

//SplashScreenManager.CloseForm(false);



//bool database = false;
//ConnectInfo connectInfo = GlobalVariables.ConnectInfo;
//if (connectInfo != null)
//{
//    DatabaseManager databaseManager = new DatabaseManager(connectInfo);
//    database = databaseManager.TestDatabase();
//}

//SplashScreenManager.CloseForm(false);


//if (!database)
//{
//    XtraMessageBox.Show(
//        "Veri tabanı bağlantısı başarısız. Bağlantı sağlandıktan sonra uygulama kullanılabilir.", "Hata",
//        MessageBoxButtons.OK, MessageBoxIcon.Error);
//    XtraFormSetDatabase setDatabase = new XtraFormSetDatabase();
//    setDatabase.ShowDialog();

//    if (!setDatabase.Result)
//    {
//        XtraMessageBox.Show(
//            "Veri tabanı bağlantısı başarısız. Bağlantı sağlandıktan sonra uygulama kullanılabilir.", "Hata",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return;
//    }
//    SplashScreenManager.ShowForm(typeof(SplashScreenManager));
//    DatabaseManager databaseManager = new DatabaseManager(GlobalVariables.ConnectInfo);
//    databaseManager.CreatDatabase(setDatabase.User);

//}