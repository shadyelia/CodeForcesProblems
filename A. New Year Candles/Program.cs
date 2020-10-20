using System;

namespace A._New_Year_Candles
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(data[0]);
            int b = Convert.ToInt32(data[1]);

            int counter = a;

            while (a / b > 0)
            {
                counter += a / b;
                a = (a / b) + (a % b);
            }

            Console.WriteLine(counter);
        }
    }
}
