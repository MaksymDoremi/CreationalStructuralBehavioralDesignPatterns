using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Factory
{
    public class PaymentFactory
    {
        public static IPayment Create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard: return new CreditCardPayment();
                case PaymentMethod.PayPal: return new PayPalPayment();
                case PaymentMethod.GooglePay: return new GooglePayPayment();
                default: throw new NotSupportedException($"{paymentMethod} not currently supported as method");
            }
        }
    }
}
