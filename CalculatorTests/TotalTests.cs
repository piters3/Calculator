using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTests
{
    [TestClass]    
    public class TotalTests
    {
        Total total = new Total();

        [TestMethod]
        public void addTestTotal()
        {
            int a = 1, b = 2;
            int wynik = total.Add(a, b);
            Assert.AreEqual(wynik, 3);
        }

        [TestMethod]
        public void SubtractTestTotal()
        {
            int a = 5, b = 9;
            int wynik = total.Subtract(a, b);
            Assert.AreEqual(wynik, -4);
        }

        [TestMethod]
        public void MultiplyTestTotal()
        {
            int a = 4, b = 7;
            int wynik = total.Multiply(a, b);
            Assert.AreEqual(wynik, 28);
        }

        [TestMethod]
        public void DivideTestTotal()
        {
            int a = 6, b = 2;
            int wynik = total.Divide(a, b);
            Assert.AreEqual(wynik, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTotalThrowExceptionWhenDividingByZero()
        {
            int a = 5, b = 0;
            int wynik = total.Divide(a, b);
        }

        [TestMethod]
        public void FactorialReturnOneForOne()
        {
            int wynik = total.Factorial(1);
            Assert.AreEqual(wynik, 1);
        }

        [TestMethod]
        public void FactorialTestTotal()
        {
            int wynik = total.Factorial(5);
            Assert.AreEqual(wynik, 120);
        }
    }
}
