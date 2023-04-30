namespace TestProject.MoneyTests
{
    [TestClass]
    public class MoneyCompareableTests
    {

        [TestMethod]
        public void CopareValueTest()
        {
            Money one = new(1.00m, "EUR", 2);
            Money two = new(1.99m, "EUR", 2);

            var result = one.CompareTo(two);
            var valueCompare = 1.00m.CompareTo(1.99m);
            Assert.AreEqual(valueCompare, result);
        }

        [TestMethod]
        public void CopareCurrencyTest()
        {
            Money one = new(1.23m, "EUR", 2);
            Money two = new(1.23m, "CHF", 2);

            var result = one.CompareTo(two);
            var stringCompare = "EUR".CompareTo("CHF");
            Assert.AreEqual(stringCompare, result);
        }
    }
}
