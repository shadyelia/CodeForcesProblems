using System;
using System.Linq;
namespace A._Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            // if (new string(Console.ReadLine().Reverse().ToArray()) == Console.ReadLine())
            //     Console.WriteLine("YES");
            // else Console.WriteLine("NO");
            string word = Console.ReadLine();
            string revWord = Console.ReadLine();

            short length = (short)word.Length;
            if (length != revWord.Length)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < length; i++)
            {
                if (word[i] != revWord[length - 1 - i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
