using System;
using System.Collections.Generic;
using System.Linq;

namespace B._A_and_B_and_Compilation_Errors
{
    class Program
    {
        static void Main()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            List<long> firstCompl = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(number => number));
            List<long> SecondCompl = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(number => number));
            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    Console.WriteLine(firstCompl.ElementAt(length - 1));
                    break;
                }
                if (firstCompl.ElementAt(i) != SecondCompl.ElementAt(i))
                {
                    Console.WriteLine(firstCompl.ElementAt(i));
                    break;
                }
            }
            firstCompl = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(number => number));
            for (int i = 0; i < length; i++)
            {
                if (i == length - 2)
                {
                    Console.WriteLine(SecondCompl.ElementAt(length - 2));
                    break;
                }
                if (SecondCompl.ElementAt(i) != firstCompl.ElementAt(i))
                {
                    Console.WriteLine(SecondCompl.ElementAt(i));
                    break;
                }

            }
        }
    }
}
