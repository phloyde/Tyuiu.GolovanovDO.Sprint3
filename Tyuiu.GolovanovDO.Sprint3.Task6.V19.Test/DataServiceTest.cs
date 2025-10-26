using Tyuiu.GolovanovDO.Sprint3.Task6.V19.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(16, res);
        }
    }
}
