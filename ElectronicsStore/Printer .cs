using ElectronicsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqaLabHomeworkFilesStorage.Task7
{
    public class Printer : ElectricalDevice, IPrintOnPaper
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight) : base(modelName, price)
        {

            PaperWidth = paperWidth;
            PaperHeight = paperHeight;
        }

        public override string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

    }
}
