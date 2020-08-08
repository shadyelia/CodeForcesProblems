using System;

namespace A._Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string line = Console.ReadLine();
            long numberOFA = 0, numberOFB = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'A') numberOFA++;
                else numberOFB++;
            }
            if (numberOFA > numberOFB) Console.WriteLine("Anton");
            else if (numberOFA < numberOFB) Console.WriteLine("Danik");
            else Console.WriteLine("Friendship");
        }
    }
}
