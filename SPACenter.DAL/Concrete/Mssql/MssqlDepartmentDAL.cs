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
    public class MssqlDepartmentDAL : IDepartmentDAL
    {
        private string DbConnectionString { get; set; }

        public MssqlDepartmentDAL(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }
        public Department Add(Department c)
        {

            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Department department= context.Departments.Add(c);
                if (context.SaveChanges())
                {
                    return department;
                }
                else
                {
                    return null;
                }

            }
        }

        public Department Delete(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Department department = context.Departments.FirstOrDefault(x => x.Id == id);
                if (department == null)
                {
                    return null;
                }

                department.DelFlag = true;
                if (context.SaveChanges())
                {
                    return department;
                }
                else
                {
                    return null;
                }
            }
        }

        public Department Get(int id)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                Department department = context.Departments.FirstOrDefault(x => x.Id == id);
                return department;
            }
        }

        public List<Department> GetAll(bool? deleted)
        {
            using (MssqlSaunaContext context = new MssqlSaunaContext(DbConnectionString))
            {
                List<Department> Departmens = context.Departments.Where(x=>deleted == null || x.DelFlag == deleted).ToList();
                return Departmens;

            }
        }

        public Department Update(Department c)
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
