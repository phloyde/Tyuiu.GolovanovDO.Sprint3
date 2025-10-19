using Tyuiu.GolovanovDO.Sprint3.Task3.V10.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "gdfppf vfppt p";
            char item = 'p';

            string res = ds.DeleteCharInString(value, item);
            Assert.AreEqual("gdff vft ", res);
        }
    }
}
