using Tyuiu.KhokhanovDA.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KhokhanovDA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "сегодня хороший день";
            string b = ds.MoveLetterToEnd(a);
            Assert.AreEqual("егодняс орошийх еньд", b);
        }
    }
}
