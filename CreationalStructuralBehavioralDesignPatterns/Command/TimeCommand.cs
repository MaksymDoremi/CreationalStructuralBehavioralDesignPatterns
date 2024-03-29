using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalStructuralBehavioralDesignPatterns.Command
{
    internal class TimeCommand : ICommand
    {
        public string Execute()
        {
            return DateTime.Now.ToString();
        }
    }
}
