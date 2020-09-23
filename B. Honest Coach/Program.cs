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
                var length = Convert.ToInt32(Console.ReadLine());
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                int numbersOfWrongOdds = 0, numbersOfWrongEvens = 0;

                for(int i = 0; i < length; i += 2)
                {
                    if (numbers[i] % 2 != 0) numbersOfWrongEvens++;
                    if (i + 1 < length && numbers[i + 1] % 2 == 0) numbersOfWrongOdds++;
                }

                if (numbersOfWrongEvens == numbersOfWrongOdds) Console.WriteLine(numbersOfWrongEvens);
                else Console.WriteLine(-1);

            }
        }
    }
}
