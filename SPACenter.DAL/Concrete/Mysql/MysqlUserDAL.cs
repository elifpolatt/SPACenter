using SPACenter.Entities.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlUserDAL : IUserDAL
    {
        private string DbConnectionString;

        public MysqlUserDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public User Add(User c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                User user = context.Users.FirstOrDefault(x => x.Id == id);
                return user;
            }
        }

        public List<User> GetAll(bool? deleted = false)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                List<User> users = context.Users.Where(x => deleted == null || x.DelFlag == deleted).ToList();
                //List<User> users = context.Users.ToList(); // Tüm kullanıcıları çek
                //users = users.Where(x => deleted == null || x.DelFlag == deleted).ToList(); // Filtreleme
                return users;
            }
        }

       
    }
}
