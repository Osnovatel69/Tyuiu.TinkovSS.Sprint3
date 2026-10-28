using System;
using Tyuiu.TinkovSS.Sprint3.Task5.V6.Lib;

namespace Tyuiu.TinkovSS.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Тиньков С. С.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение суммы ряда по формуле:                               *");
            Console.WriteLine("* y = sum(i=1..3) sum(k=1..10) (1 / cos(k) + 2)                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага первой суммы (i) = " + startValue1);
            Console.WriteLine("Конец шага первой суммы (i) = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы (k) = " + startValue2);
            Console.WriteLine("Конец шага второй суммы (k) = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}