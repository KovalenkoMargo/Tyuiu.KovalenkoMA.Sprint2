using Newtonsoft.Json.Linq;
using Tyuiu.KovalenkoMA.Sprint2.Task6.V5.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res1 = ds.FindCardValue(6);
            var res2 = ds.FindCardValue(14);
            Assert.AreEqual("шестерка", res1);
            Assert.AreEqual("туз", res2);
        }
    }
}
