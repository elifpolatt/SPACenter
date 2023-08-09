using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Messages;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class CustomerManager

    
    {
        //Fields
        public ICustomerDAL _CustomerDal;


        //Constructor
        public CustomerManager(ConnectInfo connectInfo)
        {
            // dependency enjeksiyonu kullanarak ICustomerDAL nesnesi oluşturduk
            // NinjectModules sınıfından bağımlılıkla alınıyo

            _CustomerDal = new NinjectModules(connectInfo).StandardKernel.Get<ICustomerDAL>();
        }

        //Methods
        //Müşteri ekleme metodu
        public Tuple<bool, List<string>, Customer> Add(Customer c)
        {
            // Validasyon işlemi. Validations sınıfındaki ObjectValidator.Validate metodu kullanılıyor
            Tuple<bool, List<string>, Customer> validate = Validations.ObjectValidator.Validate(c);

            if (!validate.Item1) //validaasyon sonucları false ise hata mesajları dönecek
            {
                return validate;
            }

            //müşteri ekle
            Customer newCustomer = _CustomerDal.Add(c);

            // Müşteri eklenme sonucu ve mesajları Tuple olarak döndürülüyor.
            //return new Tuple<bool, List<string>, Customer>(newCustomer != null,
            //    StaticMessages.GetResultMessage(newCustomer != null), customerNew);
            bool isSuccess = newCustomer != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);

            return Tuple.Create(isSuccess, resultMessages, newCustomer);//Tuple.Create, Tuple nesnesini hızlı bir şekilde oluşturulamsına yardımcı olur. Create yöntemi, Tuple sınıfının oluşturulmasını kolaylaştırır ve kodun daha okunabilir olmasını sağlar.


        }
        //Müşteri güncelleme metodu
        public Tuple<bool, List<string>, Customer> Update(Customer c)
        {
            // Validasyon işlemi. Validations sınıfındaki ObjectValidator.Validate metodu kullanılıyor
            Tuple<bool, List<string>, Customer> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)//validaasyon sonucları false ise hata mesajları dönecek
            {
                return validate; 
            }
            Customer newCustomer = _CustomerDal.Update(c);
            bool isSuccess = newCustomer != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess); //issuccesin durumuna baglı olarak staticmessagedaki getresultmessagedan basarılı veya basarısız sonucu donduurlecek
            return Tuple.Create(isSuccess, resultMessages, newCustomer);
        }

        //müşterileri listeleme
        public List<Customer> GetAll(bool? deleted = false)
        {
            return _CustomerDal.GetAll(deleted);
        }

        //belirli bir müşteriyi idye gore getiriyor
        public Customer Get(int id)
        {
            return _CustomerDal.Get(id);
        }


        //Müşteri silme metodu
        public Tuple<bool, List<string>, Customer> Delete(int id)
        {
            Customer newCustomer = _CustomerDal.Delete(id);
            bool isSuccess = newCustomer != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSuccess);
            return Tuple.Create(isSuccess, resultMessages, newCustomer);

        }
    }


}



