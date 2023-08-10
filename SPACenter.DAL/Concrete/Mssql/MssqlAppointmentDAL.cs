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

        private string ConnectionString { get;  }

        public MssqlAppointmentDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public Appointment Add(Appointment c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(ConnectionString))
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
            throw new NotImplementedException();
        }

        public Appointment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(ConnectionString))
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
