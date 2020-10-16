using System;
using System.Collections.Generic;
using System.Linq;

namespace A._Puzzles
{
    class Program
    {
        static void Main()
        {
            List<int> result = new List<int>();

            string[] data = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(data[0]);
            int m = Convert.ToInt32(data[1]);

            data = Console.ReadLine().Split(' ');
            List<int> numbers = data.Select(int.Parse).ToList();
            numbers.Sort();
            int minDiff = numbers[n-1] - numbers[0];

            for(int i = 1; i < (m - (n-1)); i++)
            {
                if (minDiff >= numbers[n - 1 + i] - numbers[i])
                    minDiff = numbers[n - 1 + i] - numbers[i];
            }


            Console.WriteLine(minDiff);
            
        }
    }
}
