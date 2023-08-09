using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface IPaymentDAL
    {
        Payment Add(Payment c);
        Payment Update(Payment c);
        Payment Delete(int id);
        List<Payment> GetAll();
        Payment Get(int id);
    }
}
