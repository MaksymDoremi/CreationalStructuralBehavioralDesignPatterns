using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Factory
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Credit card payment, amount: {amount}");
        }
    }
}
