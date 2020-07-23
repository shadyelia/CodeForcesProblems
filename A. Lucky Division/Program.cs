using System;

namespace A._Lucky_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 4 == 0 || a % 7 == 0
                || a % 44 == 0 || a % 47 == 0 || a % 74 == 0 || a % 77 == 0
                || a % 444 == 0 || a % 447 == 0 || a % 474 == 0 || a % 477 == 0
                || a % 744 == 0 || a % 747 == 0 || a % 774 == 0 || a % 777 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
