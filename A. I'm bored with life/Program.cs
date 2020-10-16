using System;

namespace A._I_m_bored_with_life
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Split(' ');
            long num1 = Convert.ToInt64(data[0]);
            long num2 = Convert.ToInt64(data[1]);
            if (num1 > num2)
            {
                var temp = num1;
                num1 = num2;
                num2 = temp;
            }
            long min = num1;

            for (long i = num1 - 1; i > 1; i--)
            {
                num1 = num1 * i;
            }
            Console.WriteLine(num1);
        }
    }
}