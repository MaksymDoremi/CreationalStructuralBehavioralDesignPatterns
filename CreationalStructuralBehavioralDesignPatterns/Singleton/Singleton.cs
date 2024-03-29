using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Singleton
{
    public class Singleton
    {
        private Singleton() { }
        private static readonly object _lock = new object();
        private static string _value = null;

        public static string Instance()
        {
            if (_value == null)
            {
                lock (_lock)
                {
                    if (_value == null)
                    {
                        _value = "connection string for example";
                    }
                }
            }

            return _value;
        }
    }
}
