using System.Resources;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.KhokhanovDA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] a = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > 1)
                {
                    a[i] = a[i].Substring(1) + a[i][0];
                }
            }

            return string.Join(" ", a);
        }
    }
}
