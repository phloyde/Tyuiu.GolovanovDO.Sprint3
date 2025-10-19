using Tyuiu.GolovanovDO.Sprint3.Task1.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        DataService ds = new DataService();
        double value = 0.75;
        int startValue = 1;
        int stopValue = 5;
        Console.Write(ds.GetMultiplySeries(value, startValue, stopValue));
    }
}