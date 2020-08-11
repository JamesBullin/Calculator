using NUnit.Framework;
using OperationsLibrary;

namespace OperationsTests
{
    public class Tests
    {
        // Passing Test Cases in

        [TestCase (0.1, 0.2, 0.3)]
        [TestCase(55, -103, -48)]
        [TestCase(-1000, -1500, -2500)]
        public void AdditionTest(decimal x, decimal y, decimal expected)
        {
            decimal result = OperationsLibrary.Operations.Addition(x, y);
            Assert.AreEqual(result, expected);
        }

        // Hardcoding values in the method

        public void SubtractionTest()
        {
            decimal result = OperationsLibrary.Operations.Addition(63, 50);
            Assert.AreEqual(result, 13);
        }

        // Using a Setup method

        private decimal _result;
        [SetUp]
        public void Setup()
        {
            _result = OperationsLibrary.Operations.Multiplication(5, 6);
        }

        [Test]
        public void MultiplicationTest()
        {
            Assert.AreEqual(30, _result);
        }

        // The other tests using TestCases

        [TestCase(0.1, 0.2, 0.5)]
        [TestCase(55, -5, -11)]
        [TestCase(-9, -6, 1.5)]
        public void DivisionTest(decimal x, decimal y, decimal expected)
        {
            decimal result = OperationsLibrary.Operations.Division(x, y);
            Assert.AreEqual(result, expected);
        }

        [TestCase(5, 2, 1)]
        [TestCase(55, 7, 6)]
        [TestCase(-10, 6, -4)]
        public void ModulusTest(decimal x, decimal y, decimal expected)
        {
            decimal result = OperationsLibrary.Operations.Modulus(x, y);
            Assert.AreEqual(result, expected);
        }
    }
}