using System;

namespace A._Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split('+');
            int[] numbers = Array.ConvertAll(data, s => int.Parse(s));

            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i != numbers.Length - 1) Console.Write('+');
            }
        }
    }
}
