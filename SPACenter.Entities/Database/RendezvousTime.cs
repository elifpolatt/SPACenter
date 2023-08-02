using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class RendezvousTime
    {
        //public RendezvousTime()
        //{
        //    Appointments = new List<Appointment>();
        //}




        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public bool Active { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
