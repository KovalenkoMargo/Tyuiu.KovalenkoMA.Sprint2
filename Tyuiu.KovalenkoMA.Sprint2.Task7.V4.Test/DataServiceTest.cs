using Tyuiu.KovalenkoMA.Sprint2.Task7.V4.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.5;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
