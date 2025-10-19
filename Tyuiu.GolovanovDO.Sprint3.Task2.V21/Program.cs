using Tyuiu.GolovanovDO.Sprint3.Task2.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 1;
        int stopValue = 10;
        double value = 1.5;

        Console.Write(ds.GetSumSeries(value, startValue, stopValue));
    }
}