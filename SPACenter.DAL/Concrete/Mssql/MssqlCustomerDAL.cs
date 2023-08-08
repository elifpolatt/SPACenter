using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
               // return context.SaveChanges() ? Customer : null;

                if (context.SaveChanges())
                {
                    return Customer;
                }
                else
                {
                    return null;
                }
            }
        }

        public Customer Update(Customer c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Entry(c).State = EntityState.Modified;
                //return context.SaveChanges() ? c : null;
                if (context.SaveChanges())
                {
                    return c;
                }
                else
                {
                    return null;
                }

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

        public List<Customer> GetAll(bool? deleted)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<Customer> Customers = context.Customers.Where(x=>deleted == null || x.DelFlag == deleted).ToList();
                return Customers;
            }
        }

        public Customer Delete(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Customer Customer = context.Customers.FirstOrDefault(x => x.Id == id);


                if (Customer == null)
                {
                    return null;
                }

                Customer.DelFlag = true;
                //  return context.SaveChanges() ? Customer : null;
                if (context.SaveChanges())
                {
                    return Customer;
                }
                else
                {
                    return null;
                }
            }
        }

    
    }
}
