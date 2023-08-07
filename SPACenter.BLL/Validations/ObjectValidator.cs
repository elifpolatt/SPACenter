using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.BLL.Validations
{
    public class ObjectValidator //nesne doğrulama
    //doğrulama işlemini bu sınıf yapıyor kullanıcıya bunu bildirme islemini de messageboxes sınıfı yapıyor.
    {
        public static Tuple<bool, List<string>, T> Validate<T>(T c)
        {
            List<string> errorMessages = new List<string>();

            //ValidationResult dataannotations ile kullanılıyor.

            ICollection<ValidationResult> validationResults = new List<ValidationResult>();

            bool valObject = Validator.TryValidateObject(c, new ValidationContext(c) , validationResults , true);
            //TryValidateObject kullanılarak nesne dogrulama islemi gerceklestiriliyor
            //validationcontext null alamaz. yanı bır nesne almalı burda da c ile tum interface sınıflarından nesne alıyoruz.
            //validationresults tüm doğrulama sonucları tutuluyor.
            //true ile tüm nesneleri dogrulama islemine tabi tutuyoruz.

            if (valObject)
            {
                //nesne doğrulandıysa doğrulama sonucu true döner.
                return new Tuple<bool, List<string>, T>(true, null, c);
            }

            foreach (ValidationResult validationResult in validationResults)
            { //doğrulama hataları ıcın her bır sonuc uzerınde dongu baslatılıyor.
                errorMessages.Add(validationResult.ErrorMessage); 
                //her hata mesajı errorMessages listesine ekleniyor.
            }

            return new Tuple<bool, List<string>, T>(false, errorMessages, c);
            //doğrularken hata olustuysa doğrulama sonucunu false döndür
        }
    }
}
