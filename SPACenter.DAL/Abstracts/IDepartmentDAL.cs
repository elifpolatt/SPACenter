using SPACenter.Entities.Database;
using System.Collections.Generic;

namespace SPACenter.DAL.Abstracts
{
    public interface IDepartmentDAL
    {
        Department Add(Department c);

        Department Update(Department c);
        Department Delete(int id);

        Department Get(int id);

        List<Department> GetAll(bool? deleted = false);
    }
}
