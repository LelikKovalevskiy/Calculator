using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            double a = 10.5, b = 15, result, expectedResult = 25.5;
            char operation = '+';

            result = Calculator.Calculate(operation, a, b);

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void SubtractionTest()
        {
            double a = 20.3, b = 4, result, expectedResult = 16.3;
            char operation = '-';

            result = Calculator.Calculate(operation, a, b);

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void MultiplicationTest()
        {
            double a = 10.5, b = 15, result, expectedResult = 157.5;
            char operation = '*';

            result = Calculator.Calculate(operation, a, b);

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void DivisionTest()
        {
            double a = 20, b = 43, result, expectedResult = 20 / 43.0;
            char operation = '/';

            result = Calculator.Calculate(operation, a, b);

            Assert.AreEqual(expectedResult, result);

        }
        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void DivideByZeroTest()
        {
            double a = Double.MaxValue, b = 0;
            char operation = '/';

            Calculator.Calculate(operation, a, b);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void InvalidOperationTest()
        {
            double a = 15, b = 18;
            char operation = '|';

            Calculator.Calculate(operation, a, b);
        }
    }
}
