using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.DAL.Abstracts
{
    public interface IDatabaseDAL
    {
        bool CreateDatabase(); //veri tabanı oluşturmak 
        bool BackUpDatabase(); //veri tabanı yedeği almak
        bool Test(); //veri tabanını test etmek
    }
}
