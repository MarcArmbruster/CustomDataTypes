namespace TestProject.EuroTests
{
    [TestClass]
    public class EuroEquatableTests
    {
        [TestMethod]
        public void EqualTest()
        {
            Euro one = new(1.23m);
            Euro two = new(1.23m);

            Assert.IsTrue(one.Equals(two));
        }

        [TestMethod]
        public void NotEqualDueToValueTest()
        {
            Euro one = new(1.234m);
            Euro two = new(1.23m);

            Assert.IsFalse(one.Equals(two));
        }
    }
}