namespace TestProject.CHFTests
{
    [TestClass]
    public class ChfCompareableTests
    {

        [TestMethod]
        public void CopareValueEqualTest()
        {
            CHF one = new(1.99m);
            CHF two = new(1.99m);

            var result = one.CompareTo(two);
            var valueCompare = 1.99m.CompareTo(1.99m);
            Assert.AreEqual(valueCompare, result);
        }

        [TestMethod]
        public void CopareValueNotEqualTest()
        {
            CHF one = new(1.00m);
            CHF two = new(1.99m);

            var result = one.CompareTo(two);
            var valueCompare = 1.00m.CompareTo(1.99m);
            Assert.AreEqual(valueCompare, result);
        }
    }
}
