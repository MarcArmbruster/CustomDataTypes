namespace TestProject.MoneyTests
{
    using System.Globalization;

    [TestClass]
    public class MoneyConvertibleTests
    {
        [TestMethod]
        public void CastMoneyToDecimalTest()
        {
            Money one = new(1.10m, "CHF");

            decimal result = (decimal)one;
            Assert.AreEqual(1.10m, result);
        }

        [TestMethod]
        public void CastDecimalStringToMoneyTest()
        {
            decimal exactValue = 1.111m;

            Money result = (Money)(exactValue, "EUR");

            Assert.AreEqual(1.11m, result.Value);
            Assert.AreEqual(1.111m, result.ValueExact);
            Assert.AreEqual("EUR", result.CurrencyCode);
        }

        [TestMethod]
        public void ConvertToDecimalTest()
        {
            Money one = new(1.10m, "EUR", 2);

            var result = one.ToDecimal(CultureInfo.CurrentCulture);
            Assert.AreEqual(1.10m, result);
        }

        [TestMethod]
        public void ConvertToDoubleTest()
        {
            Money one = new(1.10m, "EUR", 2);

            var result = one.ToDouble(CultureInfo.CurrentCulture);
            Assert.AreEqual((double)1.10m, result);
        }

        [TestMethod]
        public void ConvertToShortTest()
        {
            Money one = new(1.10m, "EUR", 2);

            var result = one.ToInt16(CultureInfo.CurrentCulture);
            Assert.AreEqual((short)1, result);
        }

        [TestMethod]
        public void ConvertToIntTest()
        {
            Money one = new(1.10m, "EUR", 2);

            var result = one.ToInt32(CultureInfo.CurrentCulture);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ConvertToLongTest()
        {
            Money one = new(1.10m, "EUR", 2);

            var result = one.ToInt64(CultureInfo.CurrentCulture);
            Assert.AreEqual(1L, result);
        }

        [TestMethod]
        public void ConvertToBoolTrueTest()
        {
            Money one = new(1.10m, "EUR", 2);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ConvertToBoolFalseTest()
        {
            Money one = new(0m, "EUR", 2);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(false, result);
        }
    }
}
