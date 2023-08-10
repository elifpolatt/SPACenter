using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SPACenter.BLL.Ninject;
using SPACenter.DAL.Abstracts;
using SPACenter.Entities.Database;
using SPACenter.Entities.Messages;
using SPACenter.Entities.Models;

namespace SPACenter.BLL.Managers
{
    public class PaymentManager
    {
        public IPaymentDAL _IPaymentDal;

        public PaymentManager(ConnectInfo connectInfo)
        {
            _IPaymentDal = new NinjectModules(connectInfo).StandardKernel.Get<IPaymentDAL>();
        }

        //Ödeme nesnesini ekler ve doğrulama kontrolleri gerceklestırir
        public Tuple<bool, List<string>, Payment> Add(Payment c)  //burada musterı ve bolum null geliyor??
        {
            Tuple<bool, List<string>, Payment> validate = Validations.ObjectValidator.Validate(c);  //müşteri nesnesini alabiliyor muyuz diye kontrol saglıyoruz
            if (!validate.Item1)
            {
                return validate;
            }

            Payment newPayment = _IPaymentDal.Add(c);  //Müşteriyi eklemek icin dal kullanıyoruz
            
            bool isSucces = newPayment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newPayment);
        }

        //Ödeme nesnesini günceller ve doğrulama kontrolleri gerceklestırir
        public Tuple<bool, List<string>, Payment> Update(Payment c)
        {
            Tuple<bool, List<string>, Payment> validate = Validations.ObjectValidator.Validate(c);
            if (!validate.Item1)
            {
                return validate;

            }
            Payment newPayment = _IPaymentDal.Update(c);

            bool isSucces = newPayment != null;  //newPayment nesnesi null degilse issucces degeri true olacak
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces); //issuccese baglı olarak degerı alacak true ise staticmessagesdan true olan kısmı getırecek
            return Tuple.Create(isSucces, resultMessages, newPayment); //alınan degerlere gore tuple döner
        }

        //ödeme nesnelerini çekip listelemek icin ipaymentdaldaki getalli kullanıyoruz.
        public List<Payment> GetAll()
        {
            return _IPaymentDal.GetAll();
        }

        //belirli bir ödemenin veri tabanından cekılmesı ıcın ipaymentdaldaki geti kullanıyoruz.
        public Payment Get(int id)
        {
            return _IPaymentDal.Get(id);
        }

        //Ödeme nesnesini siler ve doğrulama kontrolleri gerceklestırir

        public Tuple<bool, List<string> , Payment> Delete(int id)
        {
            Payment newPayment = _IPaymentDal.Delete(id);
            bool isSucces = newPayment != null;
            List<string> resultMessages = StaticMessages.GetResultMessage(isSucces);
            return Tuple.Create(isSucces, resultMessages, newPayment);
        }
    }
}
