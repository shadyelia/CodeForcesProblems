using System;
using System.Linq;

namespace B._Drinks
{
    class Program
    {
        static void Main()
        {
            short n = Convert.ToInt16(Console.ReadLine());
            double result = Console.ReadLine().Split(' ').Select(double.Parse).Sum() / n;
            Console.WriteLine(result);
        }
    }
}
