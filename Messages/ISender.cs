using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    interface ISender
    {
        string SenderName { get; set; }

        void UpdateSenderName(string neWSenderName);
      

    }
}
