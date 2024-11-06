﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanovPG.Sprint4.Task2.V4.Lib
{
    public class DataService : ISprint4Task2V4
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
