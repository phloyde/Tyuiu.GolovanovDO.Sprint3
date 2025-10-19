using Tyuiu.GolovanovDO.Sprint3.Task0.V4.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double wait = 6480.619;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
