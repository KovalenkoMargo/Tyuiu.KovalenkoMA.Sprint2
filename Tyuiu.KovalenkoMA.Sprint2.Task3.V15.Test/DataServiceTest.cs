using Tyuiu.KovalenkoMA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var y = ds.Calculate(x);
            Assert.AreEqual(11, y);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            var y = ds.Calculate(x);
            Assert.AreEqual(0.75, y);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;
            var  y = ds.Calculate(x);
            Assert.AreEqual(256, y);

        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -20;  
            var y = ds.Calculate(x);
            Assert.AreEqual(-219.95, y);
        }
    }
}
