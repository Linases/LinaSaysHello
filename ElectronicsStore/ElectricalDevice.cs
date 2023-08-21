using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    public abstract class ElectricalDevice : ISwitch
    {

        protected string? ModelName;
        protected decimal Price;

        public ElectricalDevice (string? modelName, decimal price)
        {
            ModelName = modelName;
            Price = price;
        }

        public abstract string Description { get; }
    

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
