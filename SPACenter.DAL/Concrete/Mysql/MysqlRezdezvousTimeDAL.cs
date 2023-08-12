using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Concrete.Mysql
{
    public class MysqlRezdezvousTimeDAL : IRendezvousTimeDAL
    {
        public RendezvousTime Add(RendezvousTime c)
        {
            throw new NotImplementedException();
        }

        public RendezvousTime Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RendezvousTime Get(int id)
        {
            throw new NotImplementedException();
        }

       
        public List<RendezvousTime> GetAll(bool? active = false)
        {
            throw new NotImplementedException();
        }

        public RendezvousTime Update(RendezvousTime c)
        {
            throw new NotImplementedException();
        }
    }
}
