using System;

namespace A._HQ9_
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            if (line.Contains("H") ||
                line.Contains("Q") ||
                line.Contains("9") ||
                line.Contains("+"))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
