using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using MySql.Data.MySqlClient;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlDatabaseDAL : IDatabaseDAL
    {
        private string DbConnectionString { get; set; }

        public MysqlDatabaseDAL(
            string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public bool BackUpDatabase()
        {
            throw new NotImplementedException();
        }

        public bool CreateDatabase()
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                if (!context.Database.Exists()) //veri tabanı yoksa oluştur
                {
                    try
                    {
                        return context.Database.CreateIfNotExists(); //oluşturulmamışsa oluşturulucak
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool Test()
        {
            MySqlConnection conn = new MySqlConnection(DbConnectionString);
            //veri tabanı stringini conna at 
            try
            {
                conn.Open(); //conn nesnesini acıp veri tabanına baglanmayı dene
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                //işlem tamamlandıgında baglantıyı sonlandır
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
