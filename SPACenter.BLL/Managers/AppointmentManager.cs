using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SPACenter.BLL.Ninject;
using SPACenter.BLL.Validations;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Messages;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class AppointmentManager 
    {
        public IAppointmentDAL _IAppointmentDal;

        public AppointmentManager(ConnectInfo connectInfo)
        {
            _IAppointmentDal = new NinjectModules(connectInfo).StandardKernel.Get<IAppointmentDAL>();
        }

        public Tuple<bool, List<string>, Appointment> Add(Appointment c)
        {
            Tuple<bool, List<string>, Appointment> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)
            {
                return validate;

            }
            Appointment newAppointment = _IAppointmentDal.Add(c);
            bool isSuccess = newAppointment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess, resultMessages, newAppointment);
        }

        public Tuple<bool,List<string>, Appointment> Update(Appointment c)
        {
            Tuple<bool, List<string>, Appointment> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)
            {
                return validate;
            }

            Appointment newAppointment = _IAppointmentDal.Update(c);

            bool isSuccess = newAppointment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess, resultMessages, newAppointment);
        }
        public Tuple<bool,List<string> , Appointment> Delete(int id)
        {
            Appointment newAppointment = _IAppointmentDal.Delete(id);
            bool isSuccess = newAppointment != null;
            List<String> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess , resultMessages , newAppointment);
        }

        public Appointment Get(int id)
        {
            return _IAppointmentDal.Get(id);
        }

        public List<Appointment> GetAll()
        {
            return _IAppointmentDal.GetAll();
        }

     
    }
}
