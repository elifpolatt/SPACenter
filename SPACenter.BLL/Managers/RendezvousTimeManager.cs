using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Messages;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class RendezvousTimeManager
    {
        private IRendezvousTimeDAL _IRendezvousTimeDal;
        private IDepartmentDAL _DepartmentDal;

        public RendezvousTimeManager(ConnectInfo connectInfo)
        {
            _IRendezvousTimeDal = new NinjectModules(connectInfo).StandardKernel.Get<IRendezvousTimeDAL>();
            _DepartmentDal = new NinjectModules(connectInfo).StandardKernel.Get<IDepartmentDAL>();
        }
        public Tuple<bool, List<string>, RendezvousTime> Add(RendezvousTime c)
        {
            c.Active = true;
            Tuple<bool, List<string>, RendezvousTime> validate = Validations.ObjectValidator.Validate(c);  
            if (!validate.Item1)
            {
                return validate;
            }

            RendezvousTime newRendezvousTime = _IRendezvousTimeDal.Add(c);  

            bool isSucces = newRendezvousTime != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newRendezvousTime);
        }

        public Tuple<bool, List<string>, RendezvousTime> Update(RendezvousTime c) 
        {
            Tuple<bool, List<string>, RendezvousTime> validate = Validations.ObjectValidator.Validate(c);  
            if (!validate.Item1)
            {
                return validate;
            }

            RendezvousTime newRendezvousTime = _IRendezvousTimeDal.Update(c);  

            bool isSucces = newRendezvousTime != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newRendezvousTime);
        }
        public Tuple<bool, List<string>, RendezvousTime> Delete(int id)
        {
            RendezvousTime newRendezvousTime = _IRendezvousTimeDal.Delete(id);
            bool isSucces = newRendezvousTime != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newRendezvousTime);
        }

        public List<RendezvousTime> GetAll(bool? active = true)
        {
            return _IRendezvousTimeDal.GetAll(active);
        }

        public RendezvousTime Get(int id)
        {
            return _IRendezvousTimeDal.Get(id);
        }

    }
}
