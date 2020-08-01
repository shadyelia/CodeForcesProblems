using System;

namespace A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int counter = n / 5;
            if (n % 5 != 0) counter++;

            Console.WriteLine(counter);
        }
    }
}
