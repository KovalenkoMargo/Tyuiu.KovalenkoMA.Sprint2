using Tyuiu.KovalenkoMA.Sprint2.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила:  Коваленко Маргарита Александровна | ПИНб-25-1               *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет                                   *");
        Console.WriteLine("* требуемое значение и возвращает результат.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true) 
        {
            Console.WriteLine($"Принадлежит: {res}");
        }
        else
        {
            Console.WriteLine($"Не принадлежит: {res}");
        }
            Console.ReadKey();
    }
}