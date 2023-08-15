using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class RendezvousTime
    {
        public RendezvousTime()
        {
            Appointments = new List<Appointment>();
        }

        public int Id { get; set; }

        [DisplayName("Başlama Saati")]
        public TimeSpan StartTime { get; set; }
        [DisplayName("Bitiş Saati")]

        public TimeSpan EndTime { get; set; }
        public int DepartmentId { get; set; }
        [DisplayName("Bölüm")]
        public Department Department { get; set; }
        public bool Active { get; set; }
        public List<Appointment> Appointments { get; set; }


        //reandevu saatlerini RandezvousId ile aldıgımız ıcın id olan yapıları tostring ile gosterecegız.
        
        public override string ToString()
        {
            return $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
        }

        [NotMapped]
        public DateTime StartTimeTemp
        {
            get
            {
                return new DateTime(1, 1, 1, StartTime.Hours, StartTime.Minutes, StartTime.Seconds);
            } set
            {
                StartTime = value.TimeOfDay;
            }
        }
        [NotMapped]
        public DateTime EndTimeTemp
        {
            get
            {
                return new DateTime(1, 1, 1, EndTime.Hours, EndTime.Minutes, EndTime.Seconds);
            }
            set
            {
                EndTime = value.TimeOfDay;
            }
        }


        [NotMapped]
        [DisplayName("Randevu Saatleri")] public string ToDisplay => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";   //format 00:00:00 olmasın 00:00 seklinde olsun dıye bu sekılde saat ve dakikayı alacagımızı belırtıyoruz

    }
}
