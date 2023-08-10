using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlCustomerDAL : ICustomerDAL
    {
        private string DbConnectionString { get; set; }
        public MysqlCustomerDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Customer Add(Customer c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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

        public Customer Delete(int id)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                Customer Customer = context.Customers.FirstOrDefault(x => x.Id == id);
                if (Customer == null)
                {
                    return null;
                }

                Customer.DelFlag = true;
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
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                List<Customer> Customers = context.Customers.Where(x => deleted == null || x.DelFlag == deleted).ToList();
                return Customers;
            }
        }

        public Customer Update(Customer c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                context.Entry(c).State = EntityState.Modified;
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
    }
}
