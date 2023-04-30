namespace TestProject.MoneyTests
{
    [TestClass]
    public class MoneyLinqTests
    {
        [TestMethod]
        public void MinTest()
        {
            Money one = new(1.231m, "EUR", 2);
            Money two = new(1.232m, "EUR", 2);
            Money three = new(1.233m, "EUR", 2);

            var list = new List<Money> { one, two, three };

            Assert.AreEqual(1.231m, list.Min().ValueExact);
        }

        [TestMethod]
        public void MaxTest()
        {
            Money one = new(1.231m, "EUR", 2);
            Money two = new(1.232m, "EUR", 2);
            Money three = new(1.233m, "EUR", 2);

            var list = new List<Money> { one, two, three };

            Assert.AreEqual(1.233m, list.Max().ValueExact);
        }

        [TestMethod]
        public void ContainsTest()
        {
            Money one = new(2m, "EUR", 2);
            Money two = new(4m, "EUR", 2);
            Money three = new(12m, "EUR", 2);

            var list = new List<Money> { one, two, three };

            Assert.IsTrue(list.Contains(two));
        }
    }
}