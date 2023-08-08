using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlDepartmentDAL : IDepartmentDAL
    {
        private string DbConnectionString { get; set; }

        public MysqlDepartmentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Department Add(Department c)
        {
            throw new NotImplementedException();
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department Update(Department c)
        {
            throw new NotImplementedException();
        }
    }
}
