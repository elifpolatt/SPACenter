using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.Collections;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Models;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlUserDAL : IUserDAL

    {
        private string DbConnectionString;

        public MssqlUserDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public User Add(User c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                User User = context.Users.Add(c);
                if (context.SaveChanges())
                {
                    return User;
                }
                else
                {
                    return null;
                }
            }
        }

        public User Update(User c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Entry(c).State = EntityState.Modified;
                if (context.SaveChanges())
                {
                    return c;
                }
                else
                {
                    return null;
                }
            }
        }

        public User Delete(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                User User = context.Users.FirstOrDefault(x => x.Id == id);

                if (User == null)
                {
                    return null;
                }

                User.DelFlag = true;
                if (context.SaveChanges())
                {
                    return User;
                }
                else
                {
                    return null;
                }
            }

        }

        public User Get(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                User User = context.Users.FirstOrDefault(x => x.Id == id);
                return User;
            }
        }

        public List<User> GetAll(bool? deleted)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<User> users = context.Users.Where(x => deleted == null || x.DelFlag == deleted).ToList();
                //List<User> users = context.Users.ToList(); // Tüm kullanıcıları çek
                //users = users.Where(x => deleted == null || x.DelFlag == deleted).ToList(); // Filtreleme
                return users;
            }
        }
    }
}
