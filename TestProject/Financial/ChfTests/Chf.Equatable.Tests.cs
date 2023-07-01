namespace TestProject.CHFTests
{
    [TestClass]
    public class ChfEquatableTests
    {
        [TestMethod]
        public void EqualTest()
        {
            CHF one = new(1.23m);
            CHF two = new(1.23m);

            Assert.IsTrue(one.Equals(two));
        }

        [TestMethod]
        public void NotEqualDueToValueTest()
        {
            CHF one = new(1.234m);
            CHF two = new(1.23m);

            Assert.IsFalse(one.Equals(two));
        }
    }
}