using System;

namespace A._Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();
            Console.WriteLine(string.Compare(first, second));
        }
    }
}
