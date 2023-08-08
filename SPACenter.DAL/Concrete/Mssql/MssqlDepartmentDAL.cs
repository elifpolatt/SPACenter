using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mssql
{
    public class MssqlDepartmentDAL : IDepartmentDAL
    {
        private string DbConnectionString { get; set; }

        public MssqlDepartmentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Department Add(Department c)
        {

            using (MssqlSaunaContext context= new MssqlSaunaContext(DbConnectionString))
            {
                Department Department = context.Departments.Add(c);
                if (context.SaveChanges())
                {
                    return Department;
                }
                else
                {
                    return null;
                }

            }
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext())
            {
                Department Department = context.Departments.FirstOrDefault(x => x.Id == id);
                return Department;
            }
        }

        public List<Department> GetAll()
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext())
            {
                return context.Departments.ToList();

                
            }
        }

        public Department Update(Department c)
        {
            throw new NotImplementedException();
        }
    }
}
