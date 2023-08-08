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
        //Bölüm Ekle
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

        //Bölüm Güncelle
        public Tuple<bool, List<string>, Department> Update(Department c)
        {
            Tuple<bool, List<string>, Department> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1) //bool false ise hata mesajları dönsün
            {
                return validate;
            }

            Department newDepartment = _IDepartmentDal.Update(c);

            bool isSucces = newDepartment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newDepartment); //item1 , item2 , item3
        }

        //Bölümleri Getir
        public Department Get(int id)
        {
            return _IDepartmentDal.Get(id);
        }

        //Bölümleri Listele
        public List<Department> GetAll(bool? deleted = false)
        {
            return _IDepartmentDal.GetAll(deleted);
        }

        public Tuple<bool, List<string>, Department> Delete(int id)
        {

            Department newDepartment = _IDepartmentDal.Delete(id);
            bool isSucces = newDepartment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newDepartment);
        }
            }
}
