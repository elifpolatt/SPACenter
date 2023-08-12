using SPACenter.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Database
{
    public class Payment
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }

        //int?
        [DisplayName("Müşteri Adı")]
        public Customer Customer { get; set; }
        public int? DepartmentId { get; set; } //zorunlu değil


        [DisplayName("Bölüm")]
        public Department Department { get; set; }


        [DisplayName("Tarih")]
        public DateTime DateTime { get; set; }


        [DisplayName("Ödenecek Tutar")]
        public double Amount
        {
            get;
            set;
        }
        public PaymentType PaymentType { get; set; }

        [NotMapped]
        [DisplayName("Toplam Kazanç")]
        public double TotalAmount
        {
            get { return Amount; }
        }

        [DisplayName("Ödeme Türü")]

        public string SelectPaymentType
        {
            get
            {
                switch (PaymentType)
                {
                    case PaymentType.Cash:
                        return "Nakit";
                    case PaymentType.CreditCard:
                        return "Kredi Kartı";
                    default:
                        return null;
                }
                {

                }
            }
        }

    }
}
