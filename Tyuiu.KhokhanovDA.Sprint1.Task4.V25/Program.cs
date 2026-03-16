using Tyuiu.KhokhanovDA.Sprint1.Task4.V25.Lib;

DataService ds = new DataService();

Console.WriteLine("Введите градусы для подсчета по формуле");
double alpha = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ds.Calculate(alpha));
Console.ReadKey();


