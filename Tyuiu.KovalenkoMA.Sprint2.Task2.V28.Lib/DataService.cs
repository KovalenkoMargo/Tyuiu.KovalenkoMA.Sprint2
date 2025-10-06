using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovalenkoMA.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (y == 3 && ((x >= 3 && x <= 5) || (x >= 10 && x <= 13))) return true;
            if (y == 2 && (x >= 10 && x <= 13)) return true;
            if (y == 4 && ((x >= 2 && x <= 5) || (x >= 10 && x <= 12))) return true;
            if (y == 5 && (x >= 2 && x <= 12)) return true;
            if (y == 6 && (x >= 3 && x <= 8)) return true;
            if (y == 7 && (x >= 3 && x <= 8)) return true;
            if (y == 8 && (x >= 6 && x <= 8)) return true;
            if (y == 9 && ((x >= 6 && x <= 8) || (x == 13))) return true;
            if (y == 10 && ((x >= 6 && x <= 8) || (x == 13))) return true;
            if (y == 11 && (x >= 3 && x <= 13)) return true;
            if (y == 12 && ((x >= 7 && x <= 9) || (x == 13))) return true;
            if (y == 13 && (x == 13)) return true;
            else
            {
                res = false;
            }
            return res;
        }
    }
}
