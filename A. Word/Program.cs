using System;

namespace A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            ushort upperCount = 0, lowwerCount = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsUpper(line[i])) upperCount++;
                if (char.IsLower(line[i])) lowwerCount++;
            }
            if (upperCount > lowwerCount)
                Console.WriteLine(line.ToUpper());
            else
                Console.WriteLine(line.ToLower());

        }
    }
}
