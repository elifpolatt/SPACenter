using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public Customer Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id)
        {
            throw new NotImplementedException();
        }


        public List<Customer> GetAll(bool? deleted)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                List<Customer> Customers = context.Customers.Where(x => deleted == null || x.DelFlag == deleted).ToList();
                return Customers;
            }
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
