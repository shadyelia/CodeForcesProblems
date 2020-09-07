using System;

namespace A._Calculating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt64(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number / 2);
            else
                Console.WriteLine(-(number + 1) / 2);

        }
    }
}
