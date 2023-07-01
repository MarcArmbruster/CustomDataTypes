namespace TestProject.CHFTests
{
    using System.Globalization;

    [TestClass]
    public class ChfConvertibleTests
    {
        [TestMethod]
        public void CastCHFToDecimalTest()
        {
            CHF one = new(1.10m);

            decimal result = (decimal)one;
            Assert.AreEqual(1.10m, result);
        }
        
        [TestMethod]
        public void CastDecimalToCHFTest()
        {
            decimal exactValue = 1.111m;

            CHF result = (CHF)exactValue;

            Assert.AreEqual(1.11m, result.Value);
            Assert.AreEqual(1.111m, result.ValueExact);
        }

        [TestMethod]
        public void ConvertToDecimalTest()
        {
            CHF one = new(1.10m);

            var result = one.ToDecimal(CultureInfo.CurrentCulture);
            Assert.AreEqual(1.10m, result);
        }

        [TestMethod]
        public void ConvertToDoubleTest()
        {
            CHF one = new(1.10m);

            var result = one.ToDouble(CultureInfo.CurrentCulture);
            Assert.AreEqual((double)1.10m, result);
        }

        [TestMethod]
        public void ConvertToShortTest()
        {
            CHF one = new(1.10m);

            var result = one.ToInt16(CultureInfo.CurrentCulture);
            Assert.AreEqual((short)1, result);
        }

        [TestMethod]
        public void ConvertToIntTest()
        {
            CHF one = new(1.10m);

            var result = one.ToInt32(CultureInfo.CurrentCulture);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ConvertToLongTest()
        {
            CHF one = new(1.10m);

            var result = one.ToInt64(CultureInfo.CurrentCulture);
            Assert.AreEqual(1L, result);
        }

        [TestMethod]
        public void ConvertToBoolTrueTest()
        {
            CHF one = new(1.10m);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ConvertToBoolFalseTest()
        {
            CHF one = new(0m);
            var result = one.ToBoolean(CultureInfo.CurrentCulture);
            Assert.AreEqual(false, result);
        }
    }
}