using ElectronicsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqaLabHomeworkFilesStorage.Task7
{
    public class MobilePhone : ElectricalDevice, ITakePhoto
    {
        public double NumberOfPixelsInCamera { get; set; }

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}, number of pixels in camera: {NumberOfPixelsInCamera}";
            }
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

    }
}
