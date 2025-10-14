using Tyuiu.KovalenkoMA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.KovalenkoMA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNumber()
        {
            DataService ds = new DataService ();
            int g = 2024;
            string res1 = ds.FindDateOfNextDay(g, 3, 15);
            Assert.AreEqual("16.03.2024", res1);

            string res2 = ds.FindDateOfNextDay(g, 2, 29);
            Assert.AreEqual("01.03.2024", res2);

            string res3 = ds.FindDateOfNextDay(g, 4, 30);
            Assert.AreEqual("01.05.2024", res3);

            string res4 = ds.FindDateOfNextDay(g, 12, 31);
            Assert.AreEqual("01.01.2025", res4);
        }
    }
}
        
