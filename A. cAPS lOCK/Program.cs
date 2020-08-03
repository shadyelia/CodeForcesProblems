using System;

namespace A._cAPS_lOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();


            if (line.Length == 0) Console.WriteLine(line.ToUpper());
            else if ((int)line[0] >= 97 && isAllUpper(line.Substring(1)))
            {
                Console.Write((char)(line[0] - 32));
                foreach (char c in line.Substring(1))
                {
                    Console.Write((char)(c + 32));
                }
            }
            else if (isAllUpper(line))
            {
                foreach (char c in line)
                {
                    Console.Write((char)(c + 32));
                }
            }
            else
            {
                Console.WriteLine(line);
            }
        }

        static bool isAllUpper(string line)
        {
            foreach (int c in line)
            {
                if (c >= 97) return false;
            }
            return true;
        }
    }
}
