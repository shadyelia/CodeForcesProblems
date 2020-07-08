using System;

namespace A._Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            int highScore = Convert.ToInt32(Console.ReadLine().Split(' ')[1]);

            string[] data = Console.ReadLine().Split(' ');

            int result = 0;
            int counter = 0;
            while (counter < data.Length)
            {
                int num = Convert.ToInt32(data[counter]);
                counter++;
                if (num > 0)
                {
                    result++;
                    if (result == highScore)
                    {
                        while (counter < data.Length)
                        {
                            int num2 = Convert.ToInt32(data[counter]);

                            if (num == num2) { counter++; result++; }
                            else
                            {
                                Console.WriteLine(result);
                                return;
                            }
                        }
                    }
                }

            }
            Console.WriteLine(result);



        }
    }
}
