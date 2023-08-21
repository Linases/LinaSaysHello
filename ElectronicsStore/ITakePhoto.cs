using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{

    internal interface ITakePhoto
    {
        public double NumberOfPixelsInCamera { get; set; }
        void TakePhoto();
      
    }
}
