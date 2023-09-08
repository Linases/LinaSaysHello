﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    public abstract class ElectricalDevice 
    {

        protected string? ModelName;
        protected decimal Price;

        public ElectricalDevice (string? modelName, decimal price)
        {
            ModelName = modelName;
            Price = price;
        }

        public abstract string Description { get; }

        public abstract void TurnOn();

  
        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
        public void Print()
        {
            Console.WriteLine("Printing.....");
        }
    }
}
