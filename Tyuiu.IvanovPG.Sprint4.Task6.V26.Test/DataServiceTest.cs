
using Tyuiu.IvanovPG.Sprint4.Task6.V26.Lib;

namespace Tyuiu.IvanovPG.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var array = new string[] { "������", "������", "�����", "����", "���" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "������", "������" };

            Assert.AreEqual(wait, res);
        }
    }
}