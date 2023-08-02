using SPACenter.Entities.Enums;
using System;
using System.Collections.Generic;
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
        public Customer Customer { get; set; }
        public int? DepartmentId { get; set; }
        //int?
        public Department Department { get; set; }
        public DateTime DateTime { get; set; }
        public double Amount { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
