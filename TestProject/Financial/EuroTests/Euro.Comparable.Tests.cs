namespace TestProject.EuroTests
{
    [TestClass]
    public class EuroCompareableTests
    {

        [TestMethod]
        public void CopareValueEqualTest()
        {
            Euro one = new(1.99m);
            Euro two = new(1.99m);

            var result = one.CompareTo(two);
            var valueCompare = 1.99m.CompareTo(1.99m);
            Assert.AreEqual(valueCompare, result);
        }

        [TestMethod]
        public void CopareValueNotEqualTest()
        {
            Euro one = new(1.00m);
            Euro two = new(1.99m);

            var result = one.CompareTo(two);
            var valueCompare = 1.00m.CompareTo(1.99m);
            Assert.AreEqual(valueCompare, result);
        }
    }
}
