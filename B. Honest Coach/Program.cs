using System;
using System.Linq;

namespace B._Honest_Coach
{
    class Program
    {
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                Console.ReadLine();
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                numbers.Sort();
                int min = numbers[1] - numbers[0];
                for(int i = 1; i < numbers.Count() - 1; i++)
                {
                    if ((numbers[i + 1] - numbers[i]) < min) min = numbers[i + 1] - numbers[i];
                }
                Console.WriteLine(min);
            }
        }
    }
}
