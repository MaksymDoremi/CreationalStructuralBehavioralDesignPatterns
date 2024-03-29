using CreationalStructuralBehavioralDesignPatterns;

namespace Maturita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance());

            IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);

            payment.Pay(1000);
        }
    }
}