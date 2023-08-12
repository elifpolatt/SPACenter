using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPACenter.Entities.Database;

namespace SPACenter.DAL.Abstracts
{
    public interface IRendezvousTimeDAL
    {
        RendezvousTime Add(RendezvousTime c);
        RendezvousTime Update(RendezvousTime c);
        RendezvousTime Delete(int id);
        List<RendezvousTime> GetAll(bool? active = false);
        RendezvousTime Get(int id);
    }
}
