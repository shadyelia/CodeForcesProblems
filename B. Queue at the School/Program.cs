using System;

namespace B._Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            short Length = Convert.ToInt16(line[0]);
            short seconds = Convert.ToInt16(line[1]);
            string data = Console.ReadLine();
            string result = data;

            while (seconds != 0)
            {
                data = result;
                result = "";

                for (int i = 0; i < Length - 1; i++)
                {
                    if (data[i] == 'B' && data[i + 1] == 'G')
                    {
                        result += "GB";
                        i++;
                    }
                    else result += data[i];
                }
                if (result.Length < Length) result += data[Length-1];

                if (result == data) break;

                seconds--;
            }

            Console.WriteLine(result);
        }
    }
}
