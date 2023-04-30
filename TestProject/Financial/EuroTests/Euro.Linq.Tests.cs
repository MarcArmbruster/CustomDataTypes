namespace TestProject.EuroTests
{
    [TestClass]
    public class EuroLinqTests
    {
        [TestMethod]
        public void MinTest()
        {
            Euro one = new(1.231m);
            Euro two = new(1.232m);
            Euro three = new(1.233m);

            var list = new List<Euro> { one, two, three };

            Assert.AreEqual(1.231m, list.Min().ValueExact);
        }

        [TestMethod]
        public void MaxTest()
        {
            Euro one = new(1.231m);
            Euro two = new(1.232m);
            Euro three = new(1.233m);

            var list = new List<Euro> { one, two, three };

            Assert.AreEqual(1.233m, list.Max().ValueExact);
        }

        [TestMethod]
        public void ContainsTest()
        {
            Euro one = new(2m);
            Euro two = new(4m);
            Euro three = new(12m);

            var list = new List<Euro> { one, two, three };

            Assert.IsTrue(list.Contains(two));
        }
    }
}