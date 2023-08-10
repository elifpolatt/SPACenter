using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlPaymentDAL : IPaymentDAL
    {
        private string DbConnectionString { get; set; }

        public MysqlPaymentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

        public Payment Add(Payment c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                Payment Payment = context.Payments.Add(c);

                if (context.SaveChanges())
                {
                    return Payment;
                }
                else
                {
                    return null;
                }
            }
        }

        public Payment Delete(int id)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                Payment Payment = context.Payments.FirstOrDefault(x => x.Id == id);
                if (Payment == null)
                {
                    return null;
                }
                context.Payments.Remove(Payment);
                if (context.SaveChanges())
                {
                    return Payment;
                }
                else
                {
                    return null;
                }
            }
        }

        public Payment Get(int id)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                Payment Payment = context.Payments.FirstOrDefault(x => x.Id == id);
                return Payment;
            }
        }

        public List<Payment> GetAll()
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
            {
                List<Payment> payments = context.Payments.Include(x => x.Customer).Include(x => x.Department).ToList();
                return payments;
            }
        }

        public Payment Update(Payment c)
        {
            using (MysqlSaunaContext context = new MysqlSaunaContext(DbConnectionString))
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
