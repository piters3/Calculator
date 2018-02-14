using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class RealTests
    {
        Real real = new Real();

        [TestMethod]
        public void AddTestReal()
        {
            double a = 1.2, b = 2.3;
            double wynik = real.Add(a, b);
            Assert.AreEqual(wynik, 3.5);
        }

        [TestMethod]
        public void SubtractTestReal()
        {
            double a = 9.2, b = 3.1;
            double wynik = real.Subtract(a, b);
            Assert.AreEqual(wynik, 6.1);
        }

        [TestMethod]
        public void MultiplyTestReal()
        {
            double a = 4.7, b = 7.1;
            double wynik = real.Multiply(a, b);
            Assert.AreEqual(wynik, 33.37);
        }

        [TestMethod]
        public void DivideTestReal()
        {
            double a = 6.6, b = 2;
            double wynik = real.Divide(a, b);
            Assert.AreEqual(wynik, 3.3);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideRealThrowExceptionWhenDividingByZero()
        {
            double a = 5.4, b = 0;
            double wynik = real.Divide(a, b);
        }

        [TestMethod]
        public void PowerTestReal()
        {
            double a = 2.1;
            int b = 2;
            double wynik = real.Power(a, b);
            Assert.AreEqual(wynik, 4.41);
        }

        [TestMethod]
        public void RootTestReal()
        {
            double a = 4.84;
            double wynik = real.Root(a);
            Assert.AreEqual(wynik, 2.2);
        }
    }
}
