using Tyuiu.KhokhanovDA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KhokhanovDA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 123.647;
            var res = ds.Calculate(x);
            Assert.AreEqual(6, res);
        }
    }
}
