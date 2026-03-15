using Tyuiu.KhokhanovDA.Sprint1.Task2.V12.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнил: Хоханов Д.А. | НТм-24-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Арифметические операторы в С#.                                    *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #12                                                             *");
    Console.WriteLine("* Выполнил: Хоханов Данил Анатольевич | НТм-24-1                          *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int x;
    Console.WriteLine("Введите значение Х:");
    x = Convert.ToInt32(Console.ReadLine());

    int y;
    Console.WriteLine("Введите значение Y:");
    y = Convert.ToInt32(Console.ReadLine());

    int z;
    Console.WriteLine("Введите значение Z:");
    z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Объём параллелепипеда = " + ds.CalculateParallelepipedVolume(x, y, z));
    Console.ReadLine();



}