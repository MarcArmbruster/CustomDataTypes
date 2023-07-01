namespace TestProject.CHFTests
{
    [TestClass]
    public class ChfLinqTests
    {
        [TestMethod]
        public void MinTest()
        {
            CHF one = 1.231m;
            CHF two = 1.232m;
            CHF three = 1.233m;

            var list = new List<CHF> { one, two, three };
            var min = list.Min().ValueExact;
            Assert.AreEqual(1.231m, min);
        }

        [TestMethod]
        public void MaxTest()
        {
            CHF one = new(1.231m);
            CHF two = new(1.232m);
            CHF three = new(1.233m);

            var list = new List<CHF> { one, two, three };

            Assert.AreEqual(1.233m, list.Max().ValueExact);
        }

        [TestMethod]
        public void ContainsTest()
        {
            CHF one = new(2m);
            CHF two = new(4m);
            CHF three = new(12m);

            var list = new List<CHF> { one, two, three };

            Assert.IsTrue(list.Contains(two));
        }
    }
}