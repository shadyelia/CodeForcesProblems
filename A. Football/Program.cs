using System;

namespace A._Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int counter = 1;

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] == line[i - 1])
                    counter++;
                else
                    counter = 1;

                if (counter == 7)
                {
                    Console.WriteLine("YES");
                    break;
                }
            }
            if (counter < 7)
                Console.WriteLine("NO");
        }
    }
}
