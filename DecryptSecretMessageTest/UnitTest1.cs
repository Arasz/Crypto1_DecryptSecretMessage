using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crypto1_DecryptSecretMessage;
using System.Diagnostics;

namespace DecryptSecretMessageTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FactorialPositiveInputTest()
        {
            long[] factorials = new long[]
            {
                1,
                1,
                2,
                6,
                24,
                120,
                720,
                5040,
                40320,
                362880,
                3628800,
                39916800,
                479001600,
                1932053504,
            };

            int n = 0;
            foreach (int fac in factorials)
            {
                long factorial = DecryptMessage.Factorial(n++);
                Assert.AreEqual(fac, factorial,"{n}");
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void FactorialNegativeInputTest()
        {
            int n = -1;

            DecryptMessage.Factorial(n);
        }
    }
}
