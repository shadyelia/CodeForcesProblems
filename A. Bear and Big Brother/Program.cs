using System;

namespace A._Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(data[0]);
            int b = Convert.ToInt32(data[1]);
            int counter = 0;

            while (a <= b)
            {
                a *= 3;
                b *= 2;
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
