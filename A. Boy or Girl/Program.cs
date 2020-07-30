using System;
using System.Linq;

namespace A._Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int numberOfUniqueChar = line.Distinct().Count();

            if (numberOfUniqueChar % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
