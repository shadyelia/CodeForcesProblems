using System;

namespace A._George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort n = Convert.ToUInt16(Console.ReadLine()), numberOfRooms = 0;
            for (ushort i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                if (Convert.ToInt16(data[1]) - Convert.ToInt16(data[0]) >= 2) numberOfRooms++;
            }

            Console.WriteLine(numberOfRooms);
        }
    }
}
