using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index(IsUnique = true )]  //Aynı isimde birden fazla kayıt olusturulamaz.
        [DisplayName("Bölüm Adı")]
        public string Name { get; set; }

        //[Range(1, Int32.MaxValue, ErrorMessage = "Seansa ait kontenjanı boş bırakamazsınız.")]
        [DisplayName("Seansa Ait Kontenjan")]
        public int QuotaPerSeance { get; set; }

        //[Range(1, Int32.MaxValue, ErrorMessage = "Seansa ait ücreti boş bırakamazsınız.")]
        [DisplayName("Seans Ücreti")]
        public double PaymentPerSeance { get; set; }

       // [Range(1, Int32.MaxValue, ErrorMessage = "Seans süresini boş bırakamazsınız.")]
        [DisplayName("Seans Uzunluğu")]
        public int SessionLength { get; set; }
        public bool DelFlag { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Payment> Payments { get; set; }
        public List<RendezvousTime> RendezvousTimes { get; set; }

    }
}
