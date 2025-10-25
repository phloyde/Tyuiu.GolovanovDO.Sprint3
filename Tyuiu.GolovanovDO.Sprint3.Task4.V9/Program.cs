using Tyuiu.GolovanovDO.Sprint3.Task4.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;
        DataService ds = new DataService();
        double res = ds.Calculate(startValue, stopValue);

        Console.Write(res);
        
    }
}