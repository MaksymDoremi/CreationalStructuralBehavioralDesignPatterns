using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Factory
{
    public class GooglePayPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Google pay payment, amount: {amount}");
        }
    }
}
