namespace TestProject.Performance
{
    using System.Diagnostics;

    [TestClass]
    public class MassTestEuro
    {
        [TestMethod]
        public void MassTest()
        {
            Stopwatch sw = Stopwatch.StartNew();
            foreach (var value in Enumerable.Range(0, 1_000_000))
            {
                Create(value);
            }
            sw.Stop();
            
            Trace.WriteLine($"-> Duration: {sw.ElapsedMilliseconds} ms");

            Assert.IsTrue(sw.ElapsedMilliseconds > 0);
        }

        private static void Create(decimal value)
        {
            Euro euro = value;
        }
    }
}