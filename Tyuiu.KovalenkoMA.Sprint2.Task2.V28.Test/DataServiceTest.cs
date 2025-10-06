using Tyuiu.KovalenkoMA.Sprint2.Task2.V28.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 7;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
