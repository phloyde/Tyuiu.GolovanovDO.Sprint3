using Tyuiu.GolovanovDO.Sprint3.Task1.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startvalue = 1;
        int stopvalue = 5;
        DataService ds = new DataService();
        Console.Write(ds.GetMultiplySeries(startvalue, stopvalue));
    }
}