using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            //Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [10, 15]
            //количество всех делителей меньше 8

            int cnt = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0 && d < 8)
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
