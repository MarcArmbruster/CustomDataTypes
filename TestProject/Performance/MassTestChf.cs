namespace TestProject.Performance
{
    using System.Diagnostics;

    [TestClass]
    public class MassTestChf
    {
        [TestMethod]
        public void MassTest()
        {
            Stopwatch sw = Stopwatch.StartNew();
            foreach (var value in Enumerable.Range(0, 1_000_000))
            {
                BuildAndDestroy(value);
            }
            sw.Stop();

            Trace.WriteLine($"-> Duration: {sw.ElapsedMilliseconds} ms");

            Assert.IsTrue(sw.ElapsedMilliseconds > 0);
        }

        private static void BuildAndDestroy(decimal value)
        {
            CHF chf = value;
            chf += 1m;
        }
    }
}