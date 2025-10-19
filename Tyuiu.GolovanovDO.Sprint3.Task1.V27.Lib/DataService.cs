using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            value = 0.75;
            startValue = 1;
            stopValue = 5;
            int i;
            double result = 1;
            for (i = startValue; i <= stopValue; i++)
            {
                result = result * (Math.Pow(2 / Math.Pow(value, i), 3));
            }
            return Math.Round(result, 3);
        }
    }
}
