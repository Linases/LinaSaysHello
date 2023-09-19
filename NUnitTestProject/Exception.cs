using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public static class CustomException:Exception 
    {
        private static void NullMethod(string message): base (message) => throw new NullReferenceException();
    }
}
