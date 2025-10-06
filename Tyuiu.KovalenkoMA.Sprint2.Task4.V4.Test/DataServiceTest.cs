using Tyuiu.KovalenkoMA.Sprint2.Task4.V4.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1 ;
            double y = 0;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(1, z);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 4;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(8, z);
        }
    }
}
