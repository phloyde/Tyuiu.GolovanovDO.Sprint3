using Tyuiu.GolovanovDO.Sprint3.Task4.V9.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(1.708, res);
        }
    }
}
