using Tyuiu.KhokhanovDA.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KhokhanovDA.Sprint1.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите предложение: ");
            string x;
            x = Console.ReadLine();
            string es = ds.MoveLetterToEnd(x);
            Console.WriteLine(es);
            Console.ReadKey();
        }
    }
}