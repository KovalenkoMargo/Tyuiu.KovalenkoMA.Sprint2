using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovalenkoMA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res1 = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
            bool res2 = (Math.Pow(x, 2) + Math.Pow(y, 2) < 0.3) && ((x < 0.3) && (x > 0)) && ((y < 0.3) && (y > 0));
            return res1 && (!res2);
        }
    }
}
