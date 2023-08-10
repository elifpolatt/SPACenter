using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlAppointmentDAL : IAppointmentDAL
    {
        private string DbConnectionString { get; set; }

        public MysqlAppointmentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Appointment Add(Appointment c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                Appointment Appointment = context.Appointments.FirstOrDefault(x => x.Id == id);
                return Appointment;

            }
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();


        }

        public Appointment Update(Appointment c)
        {
            throw new NotImplementedException();
        }
    }
}
