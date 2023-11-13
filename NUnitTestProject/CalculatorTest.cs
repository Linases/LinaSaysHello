using NUnit.Framework;

namespace NUnitTestProject
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [Ignore("Ignore a test")]
        public void ConstructorTest()
        {
            Calculator calculator = new Calculator(0, 1);
            Assert.That(calculator, Is.InstanceOf<Calculator>());
        }

        [Order(1)]
        [TestCase(3, 5, 8)]
        [TestCase(-9, 0, -9)]
        [TestCase(-18, 18, 0)]
        public void AddMethodTest(int num1, int num2, int expectedResult)
        {
            Assert.That(num1 + num2, Is.EqualTo(expectedResult));
        }

        [Order(2)]
        [TestCase(40, 5, 35)]
        [TestCase(-9, 3, -12)]
        [TestCase(-18, 18, 36)]

        public void MinusMethodTest(int num1, int num2, int expectedResult)
        {
            Assert.That(num1 - num2, Is.EqualTo(expectedResult));
        }
    }
}