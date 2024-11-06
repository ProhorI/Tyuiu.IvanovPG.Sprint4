
using Tyuiu.IvanovPG.Sprint4.Task0.V3.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Иванов  П.Г. | ИСТНБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
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

            DataService ds = new DataService();


            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Исходный массив:");
            foreach (int i in numsArray)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultOddArrEl(numsArray));
            Console.ReadKey();

        }
    }
}
