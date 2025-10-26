using Tyuiu.GolovanovDO.Sprint3.Task7.V1.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task7.V1.Test
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
            int len = stopValue - startValue + 1;
            double[] valueWait;
            valueWait = new double[len];

            valueWait[0] = -12.18;
            valueWait[1] = 16.03;
            valueWait[2] = 18.87;
            valueWait[3] = 4.96;
            valueWait[4] = -9.99;
            valueWait[5] = -2;
            valueWait[6] = 2.16;
            valueWait[7] = -7.54;
            valueWait[8] = -22.76;
            valueWait[9] = -20.45;
            valueWait[10] = 7.77;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWait, res);
            
        }
    }
}
