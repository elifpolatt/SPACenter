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
        Customer Add(Customer customer);
        Customer Delete(int Id);
        Customer Update(Customer customer);
        Customer Get(int Id);
        List<Customer> GetAllCustomer();

    }
}
