using NUnit.Framework;
using System;
using System.IO;

namespace CalculatorApp.UnitTests
{
    [TestFixture]
    public class ProgramTest
    {

        // INVALID INPUT EXCEPTION

        [Test]
        public void ReadDouble_ValidInput_ReturnsDouble()
        {
            using var sw = new StringWriter();
            using var sr = new StringReader("83.87");
            Console.SetOut(sw);
            Console.SetIn(sr);

            double actual = Program.ReadDouble("Enter a number:");
            Assert.That(actual, Is.EqualTo(83.87));
        }

        [Test]
        public void ReadDouble_InvalidInput_ThrowsFormatException()
        {
            using var sw = new StringWriter();
            using var sr = new StringReader("invalid");
            Console.SetOut(sw);
            Console.SetIn(sr);

            Assert.Throws<FormatException>(() => Program.ReadDouble("Enter a number:"));
        }
    }
}