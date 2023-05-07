namespace TestProject.Financial.EuroTests
{
    [TestClass]
    public class EuroBaseTests
    {
        [TestMethod]
        public void NettoTest()
        {
            Euro brutto = new(100.00m);

            var netto = brutto.Netto(0.15m);
            Assert.AreEqual(85m, netto);
        }

        [TestMethod]
        public void NettoVatTest()
        {
            Euro brutto = new(100.00m);
            Vat vat = 15m;

            var netto = brutto.Netto(vat);
            Assert.AreEqual(85m, netto);
        }

        [TestMethod]
        public void TaraVatest()
        {
            Euro brutto = new(100.00m);
            Vat vat = 15m;

            var tara = brutto.Tara(vat);
            Assert.AreEqual(15m, tara);
        }
    }
}
