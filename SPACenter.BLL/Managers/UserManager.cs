using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class UserManager
    {
        private IUserDAL _IUserDal;

        public UserManager(ConnectInfo connectInfo)
        {
            _IUserDal = new NinjectModules(connectInfo).StandardKernel.Get<IUserDAL>();

        }

        public Tuple<bool, List<string>, User> Add(User c)
        {
            Tuple<bool, List<string>, User> validate = Validations.ObjectValidator.Validate(c);

            if (!validate.Item1)
            {
                return validate;
            }

            User newUser = _IUserDal.Add(c);
            bool isSuccess = newUser != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);

            return Tuple.Create(isSuccess, resultMessages, newUser);
        }

        public Tuple<bool, List<string>, User> Update(User c)
        {
            Tuple<bool, List<string>, User> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)
            {
                return validate;

            }
            User newUser = _IUserDal.Update(c);
            bool isSuccess = newUser != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess, resultMessages, newUser);

        }

        public Tuple<bool, List<string>, User> Delete(int id)
        {
            User newUser = _IUserDal.Delete(id);
            bool isSuccess = newUser != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess, resultMessages, newUser);
        }

        public User Get(int id)
        {
            return _IUserDal.Get(id);
        }

        public List<User> GetAll(bool? deleted = false)
        {
            return _IUserDal.GetAll(deleted);
        }
    }
}
