using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    public abstract class PhotoCamera
    {
        protected string? ModelName;
        protected decimal Price;
        protected double NumberOfPixelsInCamera { get; set; }
        public PhotoCamera(double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
            ModelName = modelName;
            Price = price;
        }

        public abstract string Description { get; }

        public abstract void TurnOn();

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
        public abstract void TakePhoto();
    }
}
