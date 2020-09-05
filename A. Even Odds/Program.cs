using System;

namespace A._Even_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            long n = Convert.ToInt64(data[0]);
            long k = Convert.ToInt64(data[1]);

            if (k > (n + 1) / 2)
                Console.WriteLine((k - (n + 1) / 2) * 2);
            else
                Console.WriteLine(k * 2 - 1);

        }
    }
}
