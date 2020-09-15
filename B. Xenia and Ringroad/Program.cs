using System;
using System.Linq;

namespace B._Xenia_and_Ringroad
{
    class Program
    {
        static void Main()
        {
            long n = Convert.ToInt32(Console.ReadLine().Split(' ')[0]);
            long steps = 0, lastNumber = 1;

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            foreach (long currentNumber in numbers)
            {
                if (currentNumber == lastNumber) steps += 0;
                else if (currentNumber > lastNumber) steps += (currentNumber - lastNumber);
                else steps += ((n + currentNumber) - lastNumber);
                lastNumber = currentNumber;
            }
            Console.WriteLine(steps);
        }
    }
}
