using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            
            double result = 0;
            do
            {
                result = result + (Math.Pow(2 / (Math.Sin(startValue) + 2 * Math.Pow(value, startValue)), startValue));
                startValue++;
            } while (startValue<= stopValue);
            return Math.Round(result, 3);
        }
    }
}
