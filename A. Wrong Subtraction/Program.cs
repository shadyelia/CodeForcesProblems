using System;

namespace A._Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');

            long n = Convert.ToInt64(data[0]);
            int k = Convert.ToInt32(data[1]);

            while (k > 0)
            {
                if (n % 10 == 0) n /= 10;
                else n--;

                k--;
            }

            Console.WriteLine(n);
        }
    }
}
