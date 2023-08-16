using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.DAL.Concrete.Mysql;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlRendezvousTimeDAL : IRendezvousTimeDAL
    {
        private string DbConnectionString { get; set; }
        public MssqlRendezvousTimeDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public RendezvousTime Add(RendezvousTime c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
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
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
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
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                RendezvousTime RendezvousTime = context.RendezvousTime.FirstOrDefault(x => x.Id == id);
                return RendezvousTime;
            }
        }

        public List<RendezvousTime> GetAll(bool? active = false)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
               // List<RendezvousTime> RendezvousTimes = context.RendezvousTime.ToList();
                

                List<RendezvousTime> RendezvousTimes = context.RendezvousTime.Include(x => x.Department).Where(x => active == null || x.Active == active).OrderBy(x=> x.Department.Name).ToList();
                return RendezvousTimes;
            }
        }

        public RendezvousTime Update(RendezvousTime c)
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

       
    }
}
