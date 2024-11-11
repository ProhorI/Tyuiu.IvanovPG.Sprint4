


using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanovPG.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            int index = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
                     
            }
        

            int count = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; j++) 
                {
                    if (mtrx[i, j] % 2 != 0) 
                    {
                        count += mtrx[i, j];
                    }
                } 
            }
            return count;

        }
    }
}
