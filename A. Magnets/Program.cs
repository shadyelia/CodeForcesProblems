using System;

namespace A._Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string data = "", lastOne = "";
            while (n-- > 0)
            {
                data = Console.ReadLine();
                if (data != lastOne) result++;
                lastOne = data;
            }

            Console.WriteLine(result);

        }
    }
}
