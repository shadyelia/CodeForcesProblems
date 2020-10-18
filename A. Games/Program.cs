using System;
using System.Collections.Generic;
using System.Linq;

namespace A._Games
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> homeColors = new List<int>();
            List<int> awayColors = new List<int>();
            int result = 0;
            while (n-- > 0)
            {
                string[] data = Console.ReadLine().Split(' ');
                int homeColor = Convert.ToInt32(data[0]);
                int awayColor = Convert.ToInt32(data[1]);
                result += awayColors.FindAll(color => color == homeColor).Count();
                result += homeColors.FindAll(color => color == awayColor).Count();

                homeColors.Add(homeColor);
                awayColors.Add(awayColor);
            }

            Console.WriteLine(result);
        }
    }
}
