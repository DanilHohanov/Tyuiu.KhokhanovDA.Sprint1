
using Tyuiu.KhokhanovDA.Sprint1.Task6.V8.Lib;


namespace Tyuiu.KhokhanovDA.Sprint1.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите текст:");
            DataService ds = new DataService();
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine((word + word[0]).Remove(0, 1));
            }

            Console.ReadKey();

        }
    }
}
