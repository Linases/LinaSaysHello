using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture]
    internal class AssertionsTest0 
    {
        [TestCase (0,1,2)]
        public void FailTest(int num1, int num2, int expextedResult)
        {
            Assert.Fail("failure",num1 / num2 ==expextedResult);
        }

    }
}
