using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlRendezvousTimeDAL : IRendezvousTimeDAL
    {
        private string DbConnectionString { get; set; }
        public MysqlRendezvousTimeDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public RendezvousTime Add(RendezvousTime c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext())
            {
                RendezvousTime RendezvousTime = context.RendezvousTime.Add(c);

                if (context.SaveChanges())
                {
                    return RendezvousTime;
                }
                else
                {
                    return null;
                }
            }
        }

        public RendezvousTime Delete(int id)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                RendezvousTime RendezvousTime = context.RendezvousTime.FirstOrDefault(x => x.Id == id);

                RendezvousTime.Active = false;
                if (RendezvousTime == null)
                {
                    return null;
                }

                if (context.SaveChanges())
                {
                    return RendezvousTime;
                }
                else
                {
                    return null;
                }
            }
        }

        public RendezvousTime Get(int id)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                RendezvousTime RendezvousTime = context.RendezvousTime.FirstOrDefault(x => x.Id == id);
                return RendezvousTime;
            }
        }

       
        public List<RendezvousTime> GetAll(bool? active = false)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                // List<RendezvousTime> RendezvousTimes = context.RendezvousTime.ToList();


                List<RendezvousTime> RendezvousTimes = context.RendezvousTime.Include(x => x.Department).Where(x => active == null || x.Active == active).OrderBy(x => x.Department.Name).ToList();
                return RendezvousTimes;
            }
        }

        public RendezvousTime Update(RendezvousTime c)
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
    }
}
