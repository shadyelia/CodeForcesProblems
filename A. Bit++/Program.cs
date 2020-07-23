using System;

namespace A._Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                if (line == "++X" || line == "X++")
                {
                    result++;
                }
                else
                {
                    result--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
