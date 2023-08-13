using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SPACenter.Entities.Database
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adı boş geçemezsiniz")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı 50 karakterden fazla olamaz.")]
        [DisplayName("Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadını boş geçemezsiniz.")]
        [StringLength(100, ErrorMessage = " Kullanıcı soyadı 100 karakterden fazla olamaz")]
        [DisplayName("Soyadı")]
        public string Surname { get; set; }

        [Required]
        public string Password { get; set; }

        [NotMapped]
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre boş geçilemez.")]
        public string PasswordTemp { get; set; }
        
        public bool DelFlag { get; set; }

        [DisplayName("Yönetici")]
        public bool SystemAdmin { get; set; }

        [NotMapped]
        [DisplayName("Hesap Türü")]
        public string AccountType => SystemAdmin ? "Yönetici" : "Çalışan"; 
        //System admin true ise yönetici, false ise çalışan

        //byte olarak tutma nedenimiz veri tabanına direkt olarak fotografların image seklinde kaydedilmemesi icindir.

        public byte[] ImageBytes { get; set; }
        //Burada MemoryStream kullanılarak byte tutucagız ve byte dizesini Photoya atacagız. 
        ////Bu yapı sayesinde, veritabanında Photo adlı bir sütuna doğrudan fotoğrafın byte dizisi depolanmaz. Bunun yerine, Image özelliği aracılığıyla fotoğrafı doğrudan alabilir ve işleyebiliriz. Bu, Image türündeki fotoğrafı daha kolay kullanılabilir ve işlenebilir hale getirir ve Photo adlı byte dizisi özelliğinin doğrudan kullanılmasından kaçınır.

        [NotMapped]
        public Image Image { get; set; } //MemoryStream uygulanacak

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }

}

