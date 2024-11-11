

using Tyuiu.IvanovPG.Sprint4.Task5.V20.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 2, 2, 5, 5, 9 },
                                         { 7, 3, 8, 8, 9 },
                                         { 6, 7, 9, 3, 5 },
                                         { 7, 5, 7, 7, 8 },
                                         { 2, 2, 4, 7, 9 } };

            int res = ds.Calculate(mas2);
            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}