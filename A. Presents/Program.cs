using System;
using System.Linq;

namespace A._Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string[] line = Console.ReadLine().Split(' ');
            var numbers = line.Select(int.Parse).ToList();

            for (int i = 1; i <= numbers.Count; i++)
            {
                Console.Write(numbers.FindIndex(number => number == i) + 1);
                if (i != numbers.Count) Console.Write(" ");
            }
        }
    }
}
