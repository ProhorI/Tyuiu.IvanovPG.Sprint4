﻿

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanovPG.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;  //строки
            int columns = matrix.Length / rows;  //столбцы

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if (matrix[i, j] > 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
