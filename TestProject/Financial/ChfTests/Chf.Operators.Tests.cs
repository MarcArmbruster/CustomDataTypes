namespace TestProject.CHFTests
{
    [TestClass]
    public class ChfOperatorsTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            CHF one = 12.3456m;
            CHF two = 34.5678m;

            var three = one + two;

            Assert.AreEqual(46.91m, three.Value);
            Assert.AreEqual(46.9134m, three.ValueExact);
        }

        [TestMethod]
        public void SmartAdditionTest()
        {
            CHF one = new(12.3456m);
            CHF two = new(34.5678m);
                
            one += two;

            Assert.AreEqual(46.91m, one.Value);
            Assert.AreEqual(46.9134m, one.ValueExact);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            CHF one = new(12.3456m);
            CHF two = new(34.5678m);

            var three = one - two;

            Assert.AreEqual(-22.22m, three.Value);
            Assert.AreEqual(-22.2222m, three.ValueExact);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            CHF one = new(12.3456m);
            CHF two = new(34.5678m);

            var three = one * two;

            Assert.AreEqual(426.760m, three.Value);
            Assert.AreEqual(426.76023168m, three.ValueExact);
        }

        [TestMethod]
        public void DivisionTest()
        {
            CHF one = new(20.20m);
            CHF two = new(10.000m);

            var three = one / two;

            Assert.AreEqual(2.020m, three.Value);
            Assert.AreEqual(2.020m, three.ValueExact);
        }

        [TestMethod]
        public void GreaterTest()
        {
            CHF one = new(20.20m);
            CHF two = new(10.000m);

            Assert.IsTrue(one > two);
        }

        [TestMethod]
        public void GreaterOrEqualTest()
        {
            CHF one = new(20.20m);
            CHF two = new(20.20m);
            CHF three = new(10.000m);

            Assert.IsTrue(one >= two);
            Assert.IsTrue(one >= three);
        }

        [TestMethod]
        public void LowerTest()
        {
            CHF one = new(20.20m);
            CHF two = new(10.000m);

            Assert.IsTrue(two < one);
        }

        [TestMethod]
        public void LowerOrEqualTest()
        {
            CHF one = new(20.20m);
            CHF two = new(20.20m);
            CHF three = new(10.000m);

            Assert.IsTrue(two <= one);
            Assert.IsTrue(three <= two);
        }

        [TestMethod]
        public void EqualTest()
        {
            CHF one = new(20.20m);
            CHF two = new(20.20m);
            CHF three = new(20.21m);

            Assert.IsTrue(one == two);
            Assert.IsFalse(one == three);
            Assert.IsFalse(two == three);
        }

        [TestMethod]
        public void NotEqualTest()
        {
            CHF one = new(20.20m);
            CHF two = new(20.20m);
            CHF three = new(20.22m);

            Assert.IsFalse(one != two);
            Assert.IsTrue(one != three);
            Assert.IsTrue(two != three);
        }
    }
}