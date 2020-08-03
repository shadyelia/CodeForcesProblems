using System;

namespace A._Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = Convert.ToInt16(Console.ReadLine());
            short b = Convert.ToInt16(Console.ReadLine());
            short c = Convert.ToInt16(Console.ReadLine());

            short max = 0;

            if ((a + b + c) > max) max = (short)(a + b + c);
            if (((a + b) + c) > max) max = (short)(a + b + c);
            if ((a + b * c) > max) max = (short)(a + b * c);
            if ((a * (b + c)) > max) max = (short)(a * (b + c));
            if ((a * b * c) > max) max = (short)(a * b * c);
            if (((a + b) * c) > max) max = (short)((a + b) * c);

            Console.WriteLine(max);

        }
    }
}
