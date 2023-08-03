using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlCustomerDAL : ICustomerDAL
    {
        //veri tabanı baglantısı ıcın 
        private string DbConnectionString { get; set; }
        public MssqlCustomerDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public Customer Add(Customer customer)
        {
            using (var context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return customer;
            }
        }

        public Customer Delete(int Id)
        {
            using (var context = new MssqlSaunaContext(DbConnectionString))
            {
                var customer = context.Customers.Find(Id);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
                return customer;
            }

        }

        public Customer Update(Customer customer)
        {
            using (var context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
                return customer;
            }
        }

        public Customer Get(int Id)
        {
            using (var context = new MssqlSaunaContext(DbConnectionString))
            {
                return context.Customers.FirstOrDefault(x => x.Id == Id);
            }
            
        }

        public List<Customer> GetAll()
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<Customer> Customers = context.Customers.ToList();
                return Customers;
            }
        }
    }
}
