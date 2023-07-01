namespace TestProject.Financial.CHFTests
{
    [TestClass]
    public class ChfBaseTests
    {
        [TestMethod]
        public void NettoTest()
        {
            CHF brutto = new(100.00m);

            var netto = brutto.Netto(0.15m);
            Assert.AreEqual(85m, netto);
        }

        [TestMethod]
        public void NettoVatTest()
        {
            CHF brutto = new(100.00m);
            Vat vat = 15m;

            var netto = brutto.Netto(vat);
            Assert.AreEqual(85m, netto);
        }

        [TestMethod]
        public void TaraVatest()
        {
            CHF brutto = new(100.00m);
            Vat vat = 15m;

            var tara = brutto.Tara(vat);
            Assert.AreEqual(15m, tara);
        }
    }
}
