using Tyuiu.KhokhanovDA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.KhokhanovDA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double alpha = 1.5;
            Assert.AreEqual(0.934, ds.Calculate(alpha));
        }
    }
}
