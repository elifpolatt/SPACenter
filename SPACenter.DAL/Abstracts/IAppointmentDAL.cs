using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface IAppointmentDAL
    {
        Appointment Add(Appointment c);
        Appointment Update(Appointment c);
        Appointment Delete(int id);
        Appointment Get(int id);
        List<Appointment> GetAll();
    }
}
