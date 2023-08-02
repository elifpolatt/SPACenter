using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class Appointment
    {
        public int Id { get; set; }
        //En az bir değer alması gerekiyor. sonsuz deger alabilir demektir.

        [Range(1, Int32.MaxValue, ErrorMessage = "Müşteri seçiniz.")]
        public int CustomerId { get; set; }
        //[DisplayName("Müşteri")]
        public Customer Customer { get; set; }

        //[DisplayName("Tarih")]
        public DateTime RendevousDate { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Randevu saati seçiniz.")]
        public int RendezvousTimeId { get; set; }
        //[DisplayName("Randevu Saatleri")]

        public RendezvousTime RendevousTime { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Bölüm seçiniz.")]
        public int DepartmentId { get; set; }
        //[DisplayName("Bölüm")]
        public Department Department { get; set; }

    }
}
