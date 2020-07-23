using System;

namespace A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');

            string result = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length > 1)
                    result += char.ToUpper(data[i][0]) + data[i].Substring(1);
                else
                    result += char.ToUpper(data[i][0]);

                if (i != data.Length - 1)
                    result += " ";
            }

            Console.WriteLine(result);
        }
    }
}
