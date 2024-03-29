using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Facade
{
    
    public class Facade
    {
        private Subsystem1 sub1;
        private Subsystem2 sub2;

        public Facade(Subsystem1 sub1, Subsystem2 sub2)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
        }

        public string PerformOperation(int input)
        {
            switch (input)
            {
                case 1:
                    return sub1.Operation();
                case 2:
                    return sub2.Operation();
                default:
                    return "Bad input";
            }
        }



    }
}
