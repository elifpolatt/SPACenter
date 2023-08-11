using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Enums
{
    public enum PaymentType
    {
        Cash,
        CreditCard
    }

    public static class PaymentTypeSelect
    {
        public static string ToString(this PaymentType type)
        {
            switch (type)
            {
                case PaymentType.Cash:
                    return "Nakit";
                case PaymentType.CreditCard:
                    return "Kredi Kartı";
                default:
                    throw new Exception("hata");
            }
            {
                
            }
        }
    }
}
