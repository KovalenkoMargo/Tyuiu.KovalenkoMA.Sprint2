using Tyuiu.KovalenkoMA.Sprint2.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #13                                                             *"); 
        Console.WriteLine("* Выполнила:  Коваленко Маргарита Александровна | ПИНб-25-1               *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
        Console.WriteLine("* требуемое значение и возвращает результат (дату следующего дня).        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите год (g, високосный): ");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите порядковый номер месяца (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string result = ds.FindDateOfNextDay(g, m, n);
        Console.WriteLine($"Дата следующего дня (дд.мм.гггг): {result}");
        Console.ReadKey();
    }
}
