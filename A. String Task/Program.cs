using System;
using System.Linq;

namespace A._String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine().ToLower();
            string result = "";

            char[] vowels = { 'a', 'o', 'y', 'e', 'u', 'i' };
            foreach (char chara in data)
            {
                if (!vowels.Contains(chara))
                {
                    result += '.' + chara.ToString();
                }
            }

            Console.WriteLine(result);
        }
    }
}
