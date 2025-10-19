using Tyuiu.GolovanovDO.Sprint3.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string value = "gdfppf vfppt p";
        char item = 'p';

        string result = ds.DeleteCharInString(value, item);

        Console.Write(result);
    }
}