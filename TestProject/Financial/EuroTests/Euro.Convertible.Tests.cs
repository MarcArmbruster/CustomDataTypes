namespace TestProject.EuroTests
{
    using System.Globalization;

    [TestClass]
    public class EuroConvertibleTests
    {
        [TestMethod]
        public void CastEuroToDecimalTest()
        {
            Euro one = new(1.10m);

            decimal result = (decimal)one;
            Assert.AreEqual(1.10m, result);
        }
        
        [TestMethod]
        public void CastDecimalToEuroTest()
        {
            decimal exactValue = 1.111m;

            Euro result = (Euro)exactValue;

            Assert.AreEqual(1.11m, result.Value);
            Assert.AreEqual(1.111m, result.ValueExact);
        }

        [TestMethod]
        public void ConvertToDecimalTest()
        {
            Euro one = new(1.10m);

            var result = one.ToDecimal(CultureInfo.CurrentCulture);
            Assert.AreEqual(1.10m, result);
        }

        [TestMethod]
        public void ConvertToDoubleTest()
        {
            Euro one = new(1.10m);

            var result = one.ToDouble(CultureInfo.CurrentCulture);
            Assert.AreEqual((double)1.10m, result);
        }

        [TestMethod]
        public void ConvertToShortTest()
        {
            Euro one = new(1.10m);

            var result = one.ToInt16(CultureInfo.CurrentCulture);
            Assert.AreEqual((short)1, result);
        }

        [TestMethod]
        public void ConvertToIntTest()
        {
            Euro one = new(1.10m);

            var result = one.ToInt32(CultureInfo.CurrentCulture);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ConvertToLongTest()
        {
            Euro one = new(1.10m);

            var result = one.ToInt64(CultureInfo.CurrentCulture);
            Assert.AreEqual(1L, result);
        }

        [TestMethod]
        public void ConvertToBoolTrueTest()
        {
            Euro one = new(1.10m);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ConvertToBoolFalseTest()
        {
            Euro one = new(0m);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(false, result);
        }
    }
}