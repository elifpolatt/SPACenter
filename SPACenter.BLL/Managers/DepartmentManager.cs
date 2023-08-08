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
    public class DepartmentManager
    {

        //Fields
        public IDepartmentDAL _IDepartmentDal;


        //Ctors
        public DepartmentManager(ConnectInfo connectInfo)
        {
            _IDepartmentDal = new NinjectModules(connectInfo).StandardKernel.Get<IDepartmentDAL>();
        }

        //Methods
        public Tuple<bool, List<string>, Department> Add(Department c)
        {
            Tuple<bool, List<string>, Department> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)
            {
                return validate;
            }
            Department newDepartment = _IDepartmentDal.Add(c);

            bool isSucces = newDepartment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newDepartment);

        }

            }
}
