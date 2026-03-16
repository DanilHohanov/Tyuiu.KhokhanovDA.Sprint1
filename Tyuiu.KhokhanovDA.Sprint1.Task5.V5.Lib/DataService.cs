using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhokhanovDA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double a = x - Math.Truncate(x);
            int b = (int)((a * 10) % 10);
            return b;
        }
    }
}
