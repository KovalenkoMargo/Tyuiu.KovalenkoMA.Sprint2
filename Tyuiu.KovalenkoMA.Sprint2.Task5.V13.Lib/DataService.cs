using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KovalenkoMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
                int next_g = g;
                int next_m = m;
                int next_n = n + 1;
                int daysInCurrentMonth;

                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        daysInCurrentMonth = 31;
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        daysInCurrentMonth = 30;
                        break;

                    case 2:
                        daysInCurrentMonth = 29;
                        break;

                    default:

                        return "Ошибка: Некорректный месяц";
                }


                if (n == daysInCurrentMonth)
                {
                    next_n = 1;
                    if (m == 12)
                    {
                        next_m = 1;
                        next_g = g + 1;
                    }
                    else
                    {
                        next_m = m + 1;
                    }
                }
                string day = next_n.ToString().PadLeft(2, '0');
                string month = next_m.ToString().PadLeft(2, '0');
                string year = next_g.ToString();

                return $"{day}.{month}.{year}";
        }
    }
}

