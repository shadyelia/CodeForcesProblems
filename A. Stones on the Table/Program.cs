using System;

namespace A._Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string data = Console.ReadLine();

            int numberOfChatToRemove = 0;

            if (data.Length > 0)
            {
                char prevChar = data[0];
                for (int i = 1; i < n; i++)
                {
                    if (prevChar == data[i])
                    {
                        numberOfChatToRemove++;
                    }
                    else
                    {
                        prevChar = data[i];
                    }
                }
            }

            Console.WriteLine(numberOfChatToRemove);
        }
    }
}
