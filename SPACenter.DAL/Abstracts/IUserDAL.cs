using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface IUserDAL
    {
        User Add(User c);
        User Update(User c);
        User Delete(int id);
        User Get(int id);
        List<User> GetAll(bool? deleted = false);

    }
}
