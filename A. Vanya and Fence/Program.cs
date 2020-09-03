using System;

namespace A._Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            short result = 0;

            string[] data = Console.ReadLine().Split(' ');
            short l = Convert.ToInt16(data[1]);

            string[] numbers = Console.ReadLine().Split(' ');

            foreach (var number in numbers)
            {
                if (l < Convert.ToInt16(number)) result += 2;
                else result++;
            }

            Console.WriteLine(result);
        }
    }
}
