using Tyuiu.KhokhanovDA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.KhokhanovDA.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 4;
            int z = 8;
            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(64, res);
        }
    }
}
