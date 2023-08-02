using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //Index
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class Department
    {
        //public Department()
        //{
        //    Appointments = new List<Appointment>();
        //}
        public int Id { get; set; }
        [Required(ErrorMessage = "Bölüm adını boş geçemezsiniz.")]
        [StringLength(100, ErrorMessage = "Bölüm adı 100 karakterden fazla olamaz.")]
        //[DisplayName("Bölüm Adı")]
        [Index(IsUnique = true)]  //Aynı isimde birden fazla kayıt olusturulamaz.
        public string Name { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Seansa ait kontenjanı boş bırakamazsınız.")]
        public int QuotaPerSeance { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Seans ait ücreti boş bırakamazsınız.")]
        public double PaymentPerSeance { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Seans süresini boş bırakamazsınız.")]
        public int SessionLength { get; set; }
        public bool DelFlag { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Payment> Payments { get; set; }
        public List<RendezvousTime> RendezvousTimes { get; set; }

    }
}
