using CreationalStructuralBehavioralDesignPatterns.Command;
using CreationalStructuralBehavioralDesignPatterns.Facade;
using CreationalStructuralBehavioralDesignPatterns.Factory;
using CreationalStructuralBehavioralDesignPatterns.Iterator;
using CreationalStructuralBehavioralDesignPatterns.Proxy;
using CreationalStructuralBehavioralDesignPatterns.Singleton;

namespace Maturita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance());

            IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);

            payment.Pay(1000);

            Subsystem1 sub1 = new Subsystem1();
            Subsystem2 sub2 = new Subsystem2();
            Facade facade = new Facade(sub1, sub2);

            Console.WriteLine(facade.PerformOperation(1));
            Console.WriteLine(facade.PerformOperation(2));

            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Dictionary<string, ICommand> myCommands = new Dictionary<string, ICommand>
            {
                { "help", new HelpCommand() },
                { "time", new TimeCommand()}

            };

            Console.WriteLine(myCommands["help"].Execute());
            Console.WriteLine(myCommands["time"].Execute());

            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Alphabetical traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse Alphabetical traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

        }
    }
}