using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToLower();
            int counter = 0;
            string result = "NO";

            foreach (char chara in line)
            {
                if ((counter == 0 && chara == 'h')
                    || (counter == 1 && chara == 'e')
                    || ((counter == 2 || counter == 3) && chara == 'l'))
                {
                    counter++;
                }
                else if (counter == 4 && chara == 'o')
                {

                    result = "YES";
                    break;
                }
                
            }

            Console.WriteLine(result);
        }
    }
}
