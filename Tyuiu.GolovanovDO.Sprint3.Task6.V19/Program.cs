using Tyuiu.GolovanovDO.Sprint3.Task6.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = 10;
        int stopValue = 15;
        DataService ds = new DataService(); 
        Console.Write("Количество делителей меньших восьми = " + ds.GetSumTheDivisors(startValue, stopValue));
    }
}