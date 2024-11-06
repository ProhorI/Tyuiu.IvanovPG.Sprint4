namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 6,3,4,7,8,1};
        int m = int.MaxValue;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] % 2 == 0 && array[i] < m)
                m = array[i];
        }
        Console.WriteLine(m);
    }
}
