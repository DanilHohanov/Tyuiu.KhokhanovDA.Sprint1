
using Tyuiu.KhokhanovDA.Sprint1.Task5.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        {
            ArgumentNullException.ThrowIfNull(args);
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine("Введите значение Х:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine("=== PROGRAMME EXTRACTION CHIFFRE FRACTIONNAIRE ===");

            
            Console.Write("Entrez un nombre réel positif x : ");


           
            if (x < 0)
            {
                Console.WriteLine("Erreur : Le nombre doit être positif !");
                return;
            }


           
            int premierChiffre = Convert.ToInt32(x);

           
            Console.WriteLine($"Pour x = {x}, le premier chiffre de la partie fractionnaire est : {premierChiffre}");

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}