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
        [TestCase(0, 1, 2)]
        public void FailTest(int num1, int num2, int expextedResult)
        {
            Assert.Fail("failure", num1 / num2 == expextedResult);
        }
        [Test]
        public void EmptyTest ()
        {
            string a = string.Empty;
            Assert.That(a, Is.Empty);
        }
        [Test]
        public void CollectionTest()
        { 
            List <int> intList = new List<int> () {1,2,3,4};
            int variable = 1;
            Assert.Contains(variable,intList);
            Assert.That(intList, Is.All.Positive);
            Assert.That(intList.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public void ExceptionTest()
        {
            Exception ex = new Exception();
        }
    }
}
