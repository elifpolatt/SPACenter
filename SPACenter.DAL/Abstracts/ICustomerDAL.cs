using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface ICustomerDAL
    {
        Customer Add(Customer c); //Customer türünden nesne alacak ve ekleme işlemi gerçekleştirilecek
        Customer Delete(int id); //idye göre müşteri silme işlemi gerçekleşecek.
        Customer Update(Customer c); //zaten var olan bir müşteri güncellenecek
        Customer Get(int id); //idye sahip müşteriyi çekmek için kullanılacak.
        List<Customer> GetAll(bool? deleted = false); //veri tabanındaki tüm müşterileri listeleyecek. silinen silinmeyen hepsini getir anlamında bool? kullandık 

    }
}
