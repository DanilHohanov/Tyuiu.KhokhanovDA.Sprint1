using Tyuiu.KhokhanovDA.Sprint1.Task7.V20.Lib;

namespace Tyuiu.KhokhanovDA.Sprint1Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хоханов Д.А. | НТм-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #1                                                               #");
            Console.WriteLine("# Тема: Добавление к решению итоговых проектов по спринту                 #");
            Console.WriteLine("# Задание #7                                                              #");
            Console.WriteLine("# Вариант #20                                                             #");
            Console.WriteLine("# Выполнил Хоханов Данил Анатольевич | НТм-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу, которая вычисляет математическое выражение по       #");
            Console.WriteLine("# исходным значениям данных, вводимых пользователем                       #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            double x, y;
            Console.WriteLine("Введите x и y");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
