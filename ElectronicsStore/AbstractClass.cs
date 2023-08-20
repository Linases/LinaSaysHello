using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    public abstract class AbstractClass
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
