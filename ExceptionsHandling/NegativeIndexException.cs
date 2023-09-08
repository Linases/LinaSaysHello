using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqaLabHomeworkFilesStorage.Task8
{
    internal class NegativeIndexException :Exception
    {
        public NegativeIndexException(string message) : base(message)
        {
        }
    }
}
