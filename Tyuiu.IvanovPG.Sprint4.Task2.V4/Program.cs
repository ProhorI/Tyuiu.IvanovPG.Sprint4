
using Tyuiu.IvanovPG.Sprint4.Task2.V4.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Иванов  П.Г. | ИСТНБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Иванов  П.Г.    | ИСТНБ - 24 - 1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("* {8, 9, 4, 1, 2, 3, 4, 5, 6 ,7}                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            DataService ds = new DataService();

            int len;
            Console.Write("ВВедите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                numsArry[i] = rnd.Next(2,9);
            }
            Console.WriteLine("Массив");
            for (int i = 0; i < len - 1; i++)
            {
                Console.WriteLine(numsArry[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArry);
            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
