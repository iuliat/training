using System;
using Q1Exchange;
using Q1ExchangeTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Q1ExchangeTests
{
    [TestClass]
    public class ExchangeTests
    {
        [TestMethod]
        public void MakeChangePositiveAmount()
        {
            Exchange exhange = new Exchange();
            int actualResult = exhange.MakeChange(135);
            int expectedResult = 4;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Amount inserted must be > 0.")]
        public void MakeChangeNegativeAmount()
        {
            Exchange exhange = new Exchange();
            int actualResult = exhange.MakeChange(-10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Amount inserted must be > 0.")]
        public void MakeChangeZeroAmount()
        {
            Exchange exhange = new Exchange();
            int actualResult = exhange.MakeChange(0);
        }
    }
}
