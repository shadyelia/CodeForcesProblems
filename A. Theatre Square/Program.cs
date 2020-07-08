using System;

namespace A._Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            long n = Convert.ToInt64(data[0]);
            long m = Convert.ToInt64(data[1]);
            long a = Convert.ToInt64(data[2]);

            Console.WriteLine(Math.Ceiling((decimal)n / a) * Math.Ceiling((decimal)m / a));
        }
    }
}
