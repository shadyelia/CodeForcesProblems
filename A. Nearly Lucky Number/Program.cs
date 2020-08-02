using System;

namespace A._Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            if (number.Contains("4") || number.Contains("7"))
            {
                long counter = 0;
                foreach (char num in number)
                {
                    if (num == '4' || num == '7') counter++;
                }
                if (counter == 4 || counter == 7)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
