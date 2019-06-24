using Calculator.Application;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private ICalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator.Application.Calculator();
        }

        [Test]
        public void Add_Given5And6_ShouldReturn11()
        {
            //Act
            int result = _calculator.Add(5, 6);
            //Assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void Mul_Given5And6_ShouldReturn30()
        {
            //Act
            int result = _calculator.Add(5, 6);
            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        [Ignore("This test is depricated.")]
        public void ShouldNotMulTwoNumbers()
        {
            int expectedResult = _calculator.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}