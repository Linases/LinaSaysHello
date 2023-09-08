using ElectronicsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqaLabHomeworkFilesStorage.Task7
{
    public class Polaroid : PhotoCamera,  IPrintOnPaper
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }


        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price): base (numberOfPixelsInCamera, modelName, price)
        {
            PaperWidth = paperWidth;
            PaperHeight = paperHeight;
        }

        public override string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}, number of pixels in camera: {NumberOfPixelsInCamera}";
            }
        }
        public override void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }
    }

}
