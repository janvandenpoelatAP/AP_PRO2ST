using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            var a = 2;
            var b = 3;
            var expected = 5;
            var result = calculator.Sum(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}