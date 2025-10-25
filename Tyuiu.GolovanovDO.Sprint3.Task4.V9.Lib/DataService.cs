using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    res = res * (i / (Math.Cos(i) - i));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
