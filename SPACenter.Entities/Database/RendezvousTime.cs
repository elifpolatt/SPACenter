using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Başlama Zamanı")]
        public TimeSpan StartTime { get; set; }
        [DisplayName("Bitiş Zamanı")]

        public TimeSpan EndTime { get; set; }
        public int DepartmentId { get; set; }
        [DisplayName("Bölüm")]
        public Department Department { get; set; }
        public bool Active { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
