using ElectronicsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqaLabHomeworkFilesStorage.Task7
{
    public class Printer : ISwitch
    {
        private int paperWidth;
        private int paperHeight;
        private string? modelName;
        private decimal price;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight)
        {
            this.modelName = modelName;
            this.price = price;
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}";
            }
        }

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
