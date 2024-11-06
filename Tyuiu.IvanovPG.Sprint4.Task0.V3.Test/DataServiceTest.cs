
using Tyuiu.IvanovPG.Sprint4.Task0.V3.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            int numsWaitArray = 945;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}


//int[] numsArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int[] res = ds.Calculate(numsArray);
//int[] numsWaitArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
//CollectionAssert.AreEqual(res, numsWaitArray)