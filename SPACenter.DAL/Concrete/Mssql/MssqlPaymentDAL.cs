using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlPaymentDAL : IPaymentDAL
    {
        public string DbConnectionString { get; set; }

        public MssqlPaymentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Payment Add(Payment c)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Payment payment = context.Payments.Add(c);
                if (context.SaveChanges())
                {
                    return payment;
                }
                else
                {
                    return null;
                }
            }
        }
        //Soft Delete vs. Hard Delete:

        //İlk örnekte DelFlag adlı bir alan kullanılarak silme işlemi gerçekleştiriliyor gibi görünüyor.Bu yaklaşım, veritabanında silme işlemi yerine bir tür "yumuşak silme" yapmayı amaçlar. Yani, kaydı fiziksel olarak silmezsiniz, sadece bir bayrak veya alan kullanarak bu kaydın artık kullanılmadığını belirtirsiniz.Bu tür yaklaşımlar genellikle verinin geri dönüşüme açık olmasını ve geçmiş izlemeyi sağlamak için kullanılır.
        //    İkinci örnekte ise Remove metodu kullanılarak kayıt fiziksel olarak veritabanından siliniyor gibi görünüyor.Bu, veritabanında tamamen kaydın silinmesini ifade eder ve geri dönüşüm veya geçmiş izleme gibi konuları dikkate almayabilir.
        public Payment Delete(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
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
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Payment payment = context.Payments.Include(p => p.Customer).Include(p => p.Department).FirstOrDefault(x => x.Id == id);
                return payment;
            }
        }

        public List<Payment> GetAll()
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<Payment> Payments = context.Payments.Include(x=>x.Customer).Include(x=>x.Department).ToList();
                //Paymentın ilişkili oldugu tabloları bu sekılde include ile cekıyoruz. Müşterileri ve bölümleri getirmek ıcın bunu kullanıyoruz.
                return Payments;
            }
        }

        public Payment Update(Payment c)
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
