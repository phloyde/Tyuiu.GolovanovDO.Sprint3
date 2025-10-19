using Tyuiu.GolovanovDO.Sprint3.Task0.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = 1;
        int stopValue = 7;
        DataService ds = new DataService();
        Console.Write(ds.GetMultiplySeries(startValue, stopValue));
    }
}