using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class ServerSetting
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string TagName { get; set; }

        [Required(ErrorMessage = "Değeri boş bırakamazsınız.")]
        //[DisplayName("Değer")]
        public string Value { get; set; }
        public string Descripton { get; set; }

        //isim değiştirilebilir
        [Required]
        [StringLength(60)]
        public string DisplayName { get; set; }

        //kullanıcıya düzenleyebilir yetkisi vermek
        public bool EditOnList { get; set; }

    }
}
