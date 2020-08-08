using System;

namespace A._Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort year = (ushort)(Convert.ToUInt16(Console.ReadLine()) + 1);
            ushort a, b, c, d;

            while (true)
            {
                a = (ushort)(year % 10);
                b = (ushort)((year / 10) % 10);
                c = (ushort)((year / 100) % 10);
                d = (ushort)((year / 1000) % 10);

                if (a != b && a != c && a != d && b != c && b != d && c != d) break;
                else year++;
            }

            Console.WriteLine(year);
        }
    }
}
