using System;
using System.Collections.Generic;

namespace A._Anton_and_Letters
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            HashSet<char> uniqueChar = new HashSet<char>();
            for(int i = 1; i < line.Length - 1; i++)
            {
                if(line[i] != ' ' && line[i]!= ',')
                {
                    uniqueChar.Add(line[i]);
                }
            }
            Console.WriteLine(uniqueChar.Count);
        }
    }
}
