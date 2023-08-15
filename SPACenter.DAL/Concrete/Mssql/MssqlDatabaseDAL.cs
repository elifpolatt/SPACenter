using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Models;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlDatabaseDAL : IDatabaseDAL
    {
        private string DbConnectionString { get; set; }

        public MssqlDatabaseDAL(
            string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public bool BackUpDatabase()
        {
            return true;

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
            SqlConnection conn = new SqlConnection(DbConnectionString);
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
