using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Proxy
{
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
