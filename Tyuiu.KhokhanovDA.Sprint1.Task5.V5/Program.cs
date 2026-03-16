using Tyuiu.KhokhanovDA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KhokhanovDA.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите X: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            int d = ds.Calculate(x);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}