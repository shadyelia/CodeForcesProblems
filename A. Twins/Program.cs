using System;
using System.Collections.Generic;


namespace A._Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int totalSum = 0;
            string[] data = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var number = Convert.ToInt32(data[i]);
                numbers.Add(number);
                totalSum += number;
            }

            numbers.Sort();

            int sum = 0, counter = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (sum > totalSum)
                    break;

                sum += numbers[i];
                totalSum -= numbers[i];
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
