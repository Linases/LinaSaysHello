using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    public abstract class DeviceWithCamera: ElectricalDevice
    {
        protected double NumberOfPixelsInCamera { get; set; }
        public DeviceWithCamera(double numberOfPixelsInCamera, string? modelName, decimal price):base (modelName, price) 
        {
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public abstract void TakePhoto();
        
        
    }
}
