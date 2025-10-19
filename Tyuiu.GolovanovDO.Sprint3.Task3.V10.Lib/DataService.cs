using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GolovanovDO.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10

    {
        public string DeleteCharInString(string value, char item)
        {
            string res = "";
            foreach (char chr in value)
            {
                
                if (chr != item)
                {
                    res = res + chr;
                }
            }
            return res;
        }
    }
}