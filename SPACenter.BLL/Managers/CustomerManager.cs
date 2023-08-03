using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class CustomerManager
    {
        public ICustomerDAL _CustomerDal;


        public CustomerManager(ConnectInfo connectInfo)
        {
            _CustomerDal = new NinjectModules(connectInfo).StandardKernel.Get<ICustomerDAL>();
        }


        //Müşteri ekleme
        public (bool success, List<string> Errors, Customer customer) Add(Customer customer)
        {
            //List<string> Errors = new List<string>();

            ////fluent validation eklenecek
            ////ValueTuple ile yapıldı 

            //if (string.IsNullOrEmpty(customer.Name))
            //{
            //    Errors.Add("Müşteri adı boş olamaz.");
            //}

            //if (string.IsNullOrEmpty(customer.Surname))
            //{
            //    Errors.Add("Müşteri soyadı boş olamaz.");
            //}

            //if (Errors.Any())
            //{
            //    return (false, Errors, null);
            //}

            //Customer newCustomer = _CustomerDal.Add(customer);

            //return (true, null, newCustomer);
            return (true, null, null);

        }

        public List<Customer> GetAllCustomers()
        {
            return _CustomerDal.GetAll();
        }


        //tuple ile 
        //public Tuple<bool, List<string>, Customer> Add(Customer customer)
        //{
        //    // Basit bir doğrulama mekanizması ekleme
        //    List<string> validationErrors = new List<string>();

        //    if (string.IsNullOrEmpty(customer.Name))
        //    {
        //        validationErrors.Add("Müşteri adı boş olamaz.");
        //    }

        //    if (string.IsNullOrEmpty(customer.Surname))
        //    {
        //        validationErrors.Add("Müşteri soyadı boş olamaz.");
        //    }

        //    // Burada gerekli diğer doğrulamaları ekleyebilirsiniz

        //    if (validationErrors.Any())
        //    {
        //        return new Tuple<bool, List<string>, Customer>(false, validationErrors, null);
        //    }

        //    // Tüm doğrulamalar başarılı ise müşteriyi ekle
        //    Customer newCustomer = _CustomerDal.Add(customer);

        //    return new Tuple<bool, List<string>, Customer>(true, null, newCustomer);
        //}
    }
    }



