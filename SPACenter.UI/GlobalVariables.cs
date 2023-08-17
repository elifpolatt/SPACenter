using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;
using SPACenter.Entities.Enums;
using SPACenter.Entities.Models;
using SPACenter.UI.Properties;

namespace SPACenter.UI
{
    //static sınıf olusturma nedenimiz bu sınıf ıcındeki propertylerı kullanabilmek ıcın her defasında yeni bir nesne olusturmamak. yanı ortak olan tum ozellıkler bu sınıf ıcınde tutulacak.
    public static class GlobalVariables
    { 
        public static User User { get; set; }
        private static ConnectInfo connectInfo { get; set; }
        //burada connectInfodan gıdecegız sınıf dısında da asagıdakı yapıyı kullnacagız.
        public static ConnectInfo ConnectInfo
        {
            get
            {
                if (connectInfo != null)
                {
                    return connectInfo;

                }
                DatabaseType selectdb = Settings.Default.DatabaseType;
                //DatabaseType selectdb = DatabaseType.Mssql; //boyle sadece mssql gelir.
                string connectionString;
                ConnectionStringSettingsCollection connectionStringCol = ConfigurationManager.ConnectionStrings;
                //app.configdeki veri tabanı baglantısına erismek ıcın ConnectionStringSettingsCollection türünde connectionStringCol degiskeni tanımladık

                switch (selectdb)
                {
                    case DatabaseType.Mssql:
                        connectionString = connectionStringCol["MssqlSaunaContext"].ConnectionString;
                        break;
                    case DatabaseType.Mysql:
                        connectionString = connectionStringCol["MysqlSaunaContext"].ConnectionString;
                       break;
                    default:
                       throw new ArgumentOutOfRangeException("unhandled databasetype: " + selectdb.ToString()); // hicbir secenek de olmuyorsa
                    //beklenmeyen durum hatası verecek

                }
                //ConnectInfo(string, DatabaseType)
                //deafult durum belırtılmedıgınde connectionStringde hata verırdi. her durumu goz onune alarak calısıyor cunku su an. hata durumunda ne yapacagını bılmezse o kısımda hata verecektı.
                connectInfo = new ConnectInfo(connectionString, selectdb);
                return connectInfo;
                    
            }

            //Veri tabanı bağlantı ayarlarında kullanılacak
           
    }
        public static string MssqlConnectionString => ConfigurationManager.ConnectionStrings["MssqlSaunaContext"]?.ConnectionString; // ? -> baglantı olmadıysa null 
        public static string MysqlConnectionString => ConfigurationManager.ConnectionStrings["MysqlSaunaContext"]?.ConnectionString;

    }

}

