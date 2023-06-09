﻿namespace TestProject.MoneyTests
{
    [TestClass]
    public class MoneyOperatorsTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            Money one = new(12.3456m, "EUR", 2);
            Money two = new(34.5678m, "EUR", 3);

            var three = one + two;

            Assert.AreEqual("EUR", three.CurrencyCode);
            Assert.AreEqual(3, three.Precision);
            Assert.AreEqual(46.913m, three.Value);
            Assert.AreEqual(46.9134m, three.ValueExact);
        }

        [TestMethod]
        public void SmartAdditionTest()
        {
            Money one = new(12.3456m, "EUR", 2);
            Money two = new(34.5678m, "EUR", 3);

            one += two;

            Assert.AreEqual("EUR", one.CurrencyCode);
            Assert.AreEqual(3, one.Precision);
            Assert.AreEqual(46.913m, one.Value);
            Assert.AreEqual(46.9134m, one.ValueExact);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Money one = new(12.3456m, "EUR", 2);
            Money two = new(34.5678m, "EUR", 3);

            var three = one - two;

            Assert.AreEqual("EUR", three.CurrencyCode);
            Assert.AreEqual(3, three.Precision);
            Assert.AreEqual(-22.222m, three.Value);
            Assert.AreEqual(-22.2222m, three.ValueExact);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Money one = new(12.3456m, "EUR", 2);
            Money two = new(34.5678m, "EUR", 3);

            var three = one * two;

            Assert.AreEqual("EUR", three.CurrencyCode);
            Assert.AreEqual(3, three.Precision);
            Assert.AreEqual(426.760m, three.Value);
            Assert.AreEqual(426.76023168m, three.ValueExact);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(10.000m, "EUR", 3);

            var three = one / two;

            Assert.AreEqual("EUR", three.CurrencyCode);
            Assert.AreEqual(3, three.Precision);
            Assert.AreEqual(2.020m, three.Value);
            Assert.AreEqual(2.020m, three.ValueExact);
        }

        [TestMethod]
        public void GreaterTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(10.000m, "EUR", 3);

            Assert.IsTrue(one > two);
        }

        [TestMethod]
        public void GreaterOrEqualTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(20.20m, "EUR", 2);
            Money three = new(10.000m, "EUR", 3);

            Assert.IsTrue(one >= two);
            Assert.IsTrue(one >= three);
        }

        [TestMethod]
        public void LowerTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(10.000m, "EUR", 3);

            Assert.IsTrue(two < one);
        }

        [TestMethod]
        public void LowerOrEqualTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(20.20m, "EUR", 2);
            Money three = new(10.000m, "EUR", 3);

            Assert.IsTrue(two <= one);
            Assert.IsTrue(three <= two);
        }

        [TestMethod]
        public void EqualTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(20.20m, "EUR", 2);
            Money three = new(20.20m, "EUR", 3);

            Assert.IsTrue(one == two);
            Assert.IsFalse(one == three);
            Assert.IsFalse(two == three);
        }

        [TestMethod]
        public void NotEqualTest()
        {
            Money one = new(20.20m, "EUR", 2);
            Money two = new(20.20m, "EUR", 2);
            Money three = new(20.20m, "EUR", 3);

            Assert.IsFalse(one != two);
            Assert.IsTrue(one != three);
            Assert.IsTrue(two != three);
        }
    }
}