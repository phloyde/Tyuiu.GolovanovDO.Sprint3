using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            int cnt = 0;
            double[] valueArray;
            valueArray = new double[len];
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2, 2);
                valueArray[cnt] = y;
                cnt++;
            }
            return valueArray;  
        }
    }
}
