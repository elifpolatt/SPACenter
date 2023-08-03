using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Enums;

namespace SPACenter.Entities.Models
{
    public class ConnectInfo
    {
        public string ConnectionString { get; set; } //baglantı stringi tutulacak 
        public DatabaseType DatabaseType { get; set; } // veri tabanı tipi tutulacak
        public ConnectInfo(string connectionString, DatabaseType databaseType)
        {
            ConnectionString = connectionString;
            DatabaseType = databaseType;
        }
    }
}
