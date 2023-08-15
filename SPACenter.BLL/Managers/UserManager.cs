using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SPACenter.BLL.Ninject;
using SPACenter.BLL.Security;
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

            c.Password = new Cryptography().TextCoding(c.PasswordTemp);
            //şifremiz 123 olsun. bu şifreyi alıp passwordtempe atıyoruz. Cryptography ile şifreleyerek de passworde atıyoruz(asıl veri tabanında bu tutuluyor cunku). Bununla birlikte de şifreler veri tabanında açık sekılde kalmamıs oluyor

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
            c.Password = new Cryptography().TextCoding(c.PasswordTemp);
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

            User User = _IUserDal.Get(id);
            Cryptography cryptography = new Cryptography();
            User.PasswordTemp = cryptography.TextEnCoding(User.Password); //şifrelenmiş şifreler passwordtempe atanır.
            return User;
        }

        public List<User> GetAll(bool? deleted = false)
        {
            Cryptography cryptography = new Cryptography();
            List<User> users = _IUserDal.GetAll(deleted);
            users.ForEach(u =>
            {
                u.PasswordTemp = cryptography.TextEnCoding(u.Password);
            });
            return users;  //şifrelenmıs kullanıcı lıstesı döndürlür
        }



        public User LoginUser(int id)
        {
            User user = Get(id);
            Cryptography cryptography = new Cryptography();

            if (user != null && user.PasswordTemp == cryptography.TextEnCoding(user.Password))
            {
                return user;
            }


            else
            {
                return null;
            }

        }


    }
}
