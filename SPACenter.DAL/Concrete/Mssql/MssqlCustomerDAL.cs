using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.DAL.Concrete.Mysql;
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

        public Customer Add(Customer c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Customer Customer = context.Customers.Add(c);
                return context.SaveChanges() ? Customer : null;

                //if (context.SaveChanges())
                //{
                //    return Customer;
                //}
                //else
                //{
                //    return null;
                //}
            }
        }

        public Customer Update(Customer c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Entry(c).State = EntityState.Modified;
                return context.SaveChanges() ? c : null;

                //if (context.SaveChanges())
                //{
                //    return c;
                //}
                //else
                //{
                //    return null;
                //}
            }
        }

        public Customer Get(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Customer Customer = context.Customers.FirstOrDefault(x => x.Id == id);
                return Customer;
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
        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
