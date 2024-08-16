using NUnit.Framework;
using System;

namespace CalculatorApp.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {

        // ADDITION
        [TestCase(20, 30, 50)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void PerformOperation_Addition_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "add");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(20, 30, 60)]
        [TestCase(-5, 5, 10)]
        [TestCase(0, 0, 1)]
        public void PerformOperation_Addition_ReturnsIncorrectResult(double num1, double num2, double incorrect)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "add");
            Assert.That(actual, Is.Not.EqualTo(incorrect)); 
        }


        // SUBTRACTION
        [TestCase(10, 4, 6)]
        [TestCase(5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void PerformOperation_Subtraction_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "subtract");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, 4, 5)]
        [TestCase(5, 5, 1)]
        [TestCase(0, 0, 1)]
        public void PerformOperation_Subtraction_ReturnsIncorrectResult(double num1, double num2, double incorrect)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "subtract");
            Assert.That(actual, Is.Not.EqualTo(incorrect));
        }


        // MULTIPLICATION
        [TestCase(3, 8, 24)]
        [TestCase(0, 5, 0)]
        [TestCase(-3, 3, -9)]
        public void PerformOperation_Multiplication_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "multiply");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(3, 8, 25)]
        [TestCase(0, 5, 1)]
        [TestCase(-3, 3, 9)]
        public void PerformOperation_Multiplication_ReturnsIncorrectResult(double num1, double num2, double incorrect)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "multiply");
            Assert.That(actual, Is.Not.EqualTo(incorrect));
        }


        // DIVISION
        [TestCase(16, 4, 4)]
        [TestCase(9, 3, 3)]
        [TestCase(-12, 3, -4)]
        public void PerformOperation_Division_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "divide");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(16, 4, 5)]
        [TestCase(9, 3, 4)]
        [TestCase(-12, 3, -5)]
        
        public void PerformOperation_Division_ReturnsIncorrectResult(double num1, double num2, double incorrect)
        {
            var calculator = new Calculator();
            double actual = calculator.PerformOperation(num1, num2, "divide");
            Assert.That(actual, Is.Not.EqualTo(incorrect));
        }


        // DIVIDE BY ZERO EXCEPTION
        [Test]
        public void PerformOperation_DivisionByZero_ThrowsDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.PerformOperation(6, 0, "divide"));
        }


        // UNSUPPORTED OPERATION EXCEPTION
        [Test]
        public void PerformOperation_UnsupportedOperation_ThrowsUnsupportedOperationException()
        {
            var calculator = new Calculator();
            Assert.Throws<UnsupportedOperationException>(() => calculator.PerformOperation(9, 55, "equals"));
        }
    }
}