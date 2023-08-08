using SPACenter.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public int? DepartmentId { get; set; }
        //int?
        [DisplayName("Bölüm")]
        public Department Department { get; set; }
        [DisplayName("Tarih")]
        public DateTime DateTime { get; set; }
        [DisplayName("Ödenecek Tutar")]
        public double Amount { get; set; }
        [DisplayName("Ödeme Türü")]
        public PaymentType PaymentType { get; set; }

    }
}
