
namespace ConsoleApp
{
    internal class Program
    {
        static double rez;

        static void Main(string[] args)
        {
            Add(2, 3);
            Subtract(4, 5);
            Multiply(5, 6);
            Divide(5, 6);
        }
        private static void Add(int x, int y)
        {
            var z = x + y;
            Console.WriteLine(z);
        }

        private static void Subtract(int x, int y)
        {
            var rez = x - y;
            Console.WriteLine(rez);
        }
        private static void Multiply(int x, int y)
        {
            var rez = x * y;
            Console.WriteLine(rez);
        }
        private static void Divide(double x, double y)
        {
            rez = x / y;
            Console.WriteLine(rez);
        }
    }
}