namespace TestProject.MoneyTests
{
    [TestClass]
    public class MoneyEquatableTests
    {
        [TestMethod]
        public void EqualTest()
        {
            Money one = new(1.23m, "EUR", 2);
            Money two = new(1.23m, "EUR", 2);

            Assert.IsTrue(one.Equals(two));
        }

        [TestMethod]
        public void NotEqualDueToPrecisionTest()
        {
            Money one = new(1.23m, "EUR", 2);
            Money two = new(1.23m, "EUR", 3);

            Assert.IsFalse(one.Equals(two));
        }

        [TestMethod]
        public void NotEqualDueToCurrencyTest()
        {
            Money one = new(1.23m, "CHF", 2);
            Money two = new(1.23m, "EUR", 2);

            Assert.IsFalse(one.Equals(two));
        }

        [TestMethod]
        public void NotEqualDueToValueTest()
        {
            Money one = new(1.234m, "EUR", 2);
            Money two = new(1.23m, "EUR", 2);

            Assert.IsFalse(one.Equals(two));
        }
    }
}