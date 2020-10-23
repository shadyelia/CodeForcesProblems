using System;
using System.Collections.Generic;
using System.Linq;

namespace A._Police_Recruits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            List<int> operations = data.Select(int.Parse).ToList();
            int numberOfPolicmen = 0;
            int result = 0;
            
            foreach(var oper in operations)
            {
                if (oper > 0) numberOfPolicmen += oper;
                else
                {
                    if (numberOfPolicmen > 0) numberOfPolicmen--;
                    else result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
