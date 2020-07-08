using System;

namespace A._Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                string[] answers = Console.ReadLine().Split(' ');
                if (answers.Length == 3)
                {
                    if ((answers[0] == "1" && answers[1] == "1")
                    || (answers[0] == "1" && answers[2] == "1")
                    || (answers[1] == "1" && answers[2] == "1"))
                        result++;
                }
            }

            Console.WriteLine(result);

        }
    }
}
