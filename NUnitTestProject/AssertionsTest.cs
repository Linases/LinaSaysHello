using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture]
    internal class AssertionsTest
    {
        [Test]
        public void FailTest()
        {
            Assert.Fail();
        }
        [Test]
        public void EmptyTest()
        {
            string a = string.Empty;
            Assert.That(a, Is.Empty);
        }
        [Test]
        public void CollectionTest()
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            int variable = 1;
            Assert.Contains(variable, intList);
            Assert.That(intList, Is.All.Positive);
            Assert.That(intList.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public void ExceptionTest()
        {
            AssertionsTest assertionsTest = new AssertionsTest();
            Assert.Throws<NullReferenceException>(() => assertionsTest.NullMethod());
        }

        private void NullMethod()
        {
            string nullString = null;
            int length = nullString.Length;
        }
        [Test]
        public void CollectionTest2()
        {
            List<string> list = new List<string>() { "a", "b", "c" };
            List<string> listNew = new List<string>() { "c", "b", "a" };
            Assert.That(list, Is.EquivalentTo(listNew));
        }
        [Test]
        public void TrueFalseTest ()
        {
            int number = 0;
            Assert.True(number.GetType() == typeof(Int32));
        }
        [Test]
        public void StringsTest () 
        {
        string word1 = "abc";
        string word2  = "abc";

            Assert.That(word1, Is.SameAs(word2));
        }
    }
}
