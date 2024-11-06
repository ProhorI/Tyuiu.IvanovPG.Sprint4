

using Tyuiu.IvanovPG.Sprint4.Task2.V4.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            ds.Calculate(numsArray);
            int res = ds.Calculate(numsArray);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}