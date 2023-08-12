using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SPACenter.Entities.Database
{
    public class Customer
    {
        //public Customer()
        //{
        //    Appointments = new List<Appointment>();
        //}
        public int Id { get; set; }


        //Buradaki uyarıları fluent validation ile yapacagım.
       [Required(ErrorMessage = "Müşteri adını boş geçemezsiniz.")]
        [StringLength(50, ErrorMessage = "Müşteri adı 50 karakterden fazla olamaz.")]
        [DisplayName("Adı")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "Müşteri soyadı 50 karakterden fazla olamaz.")]
        [DisplayName("Soyadı")]
        public string Surname { get; set; }



        [StringLength(20, ErrorMessage = "Telefon numarası 15 karakterden fazla olamaz.")]
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }

        //byte olarak tutma nedenimiz veri tabanına direkt olarak fotografların image seklinde kaydedilmemesi icindir.
        public byte[] Photo { get; set; }

        //Burada MemoryStream kullanılarak byte tutucagız ve byte dizesini Photoya atacagız. 
        ////Bu yapı sayesinde, veritabanında Photo adlı bir sütuna doğrudan fotoğrafın byte dizisi depolanmaz. Bunun yerine, Image özelliği aracılığıyla fotoğrafı doğrudan alabilir ve işleyebiliriz. Bu, Image türündeki fotoğrafı daha kolay kullanılabilir ve işlenebilir hale getirir ve Photo adlı byte dizisi özelliğinin doğrudan kullanılmasından kaçınır.

        [NotMapped] //-> veri tabanında gormek ıstemedıgımız kısımlarda kullanıyoruz. oraya kaydetmeye gerek yok 
        [DisplayName("Fotoğraf")]
        public Image Image{ get; set; }  //MemoryStream uygulanacak.Image için using System.Drawing; ekledik 



        [DisplayName("Mail")]
        [StringLength(200, ErrorMessage = "Müşteri maili 200 karakterden fazla olamaz.")]
        public string Mail { get; set; }
        public bool DelFlag { get; set; }

        public List<Appointment> Appointments { get; set; }
        public List<Payment> Payments { get; set; }


        [NotMapped]
        [DisplayName("Adı Soyadı")]
        public string FullName => $"{Name} {Surname}";

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
