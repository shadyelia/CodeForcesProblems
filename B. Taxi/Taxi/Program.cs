using System;
using System.Collections.Generic;
using System.Linq;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int numberOfTaxi = 0;

            List<string> line = Console.ReadLine().Split(' ').ToList();
            List<int> numbers = line.Select(int.Parse).ToList();

            while (numbers.Count() > 0)
            {
                int num = numbers[0];
                numbers.RemoveAt(0);
                int remainder = 4 - num;
                int i = 0;

                while (remainder > 0 && i < numbers.Count())
                {
                    int index = numbers.FindIndex(numb => numb == remainder);
                    if (index != -1)
                    {
                        numbers.RemoveAt(index);
                        break;
                    }
                    else
                    {
                        int num2 = numbers[i];
                        if (num2 < remainder)
                        {
                            remainder -= num2;
                            numbers.RemoveAt(i);
                        }
                        else
                            i++;
                    }

                }
                numberOfTaxi++;

            }

            Console.WriteLine(numberOfTaxi);
        }
    }
}
