using Tyuiu.GolovanovDO.Sprint3.Task5.V15.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            int x = 5;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(548.732, res);
        }
    }
}
