
using Tyuiu.IvanovPG.Sprint4.Task7.V25.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "348561792486";

            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colums; j++) 
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, colums, str);
            Console.WriteLine("сумма = " + res);
            Console.ReadKey();
        }
    }
}
