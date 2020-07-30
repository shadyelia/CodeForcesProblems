using System;

namespace A._Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int totalA = 0, totalB = 0, totalC = 0;

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                totalA += Convert.ToInt32(data[0]);
                totalB += Convert.ToInt32(data[1]);
                totalC += Convert.ToInt32(data[2]);

            }
            if (totalA != 0 || totalB != 0 || totalC != 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
