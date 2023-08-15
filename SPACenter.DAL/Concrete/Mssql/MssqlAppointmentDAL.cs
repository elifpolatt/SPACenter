using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlAppointmentDAL : IAppointmentDAL
    {

        private string DbConnectionString { get;  }

        public MssqlAppointmentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Appointment Add(Appointment c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Appointment Appointment = context.Appointments.Add(c);
                if (context.SaveChanges())
                {
                    return Appointment;
                }
                else
                {
                    return null;
                }
            }
        }

       
        public Appointment Delete(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Appointment Appointment = context.Appointments.FirstOrDefault(x => x.Id == id);
                if (Appointment == null)
                {
                    return null;
                }

                context.Appointments.Remove(Appointment);
                if (context.SaveChanges())
                {
                    return Appointment;
                }
                else
                {
                    return null;
                }
            }
        }

        public Appointment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<Appointment> appointments = context.Appointments.Include(x=>x.Customer).Include(x=>x.Department).Include(x=>x.RendevousTime).ToList();
                return appointments;
            }
        }

        public Appointment Update(Appointment c)
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
