using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> pData = Console.ReadLine().Split(' ').ToList();
            int p = Convert.ToInt32(pData[0]);
            pData.RemoveAt(0);
            int[] pArr = pData.Select(int.Parse).ToArray();

            List<string> qData = Console.ReadLine().Split(' ').ToList();
            int q = Convert.ToInt32(qData[0]);
            qData.RemoveAt(0);
            int[] qArr = qData.Select(int.Parse).ToArray();

            string result = "Oh, my keyboard!";

            if (n == p || n == q) result = "I become the guy.";
            else
            {
                HashSet<int> numbers = new HashSet<int>();
                for (int j = 1; j <= n; j++)
                {
                    numbers.Add(j);
                }
                int i = 0;
                while (numbers.Count() > 0)
                {
                    if (i >= p && i >= q) break;

                    if (i < p)
                    {
                        if (numbers.Contains(pArr[i]))
                        {
                            numbers.Remove(pArr[i]);
                        }
                    }

                    if (i < q)
                    {
                        if (numbers.Contains(qArr[i]))
                        {
                            numbers.Remove(qArr[i]);
                        }
                    }

                    i++;
                }
                if (numbers.Count() == 0) result = "I become the guy.";

            }

            Console.WriteLine(result);

        }
    }
}
