using System;

namespace _4A___Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0 && n != 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
