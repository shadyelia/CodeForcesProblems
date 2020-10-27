using System;
using System.Collections.Generic;
using System.Linq;

namespace B._A_and_B_and_Compilation_Errors_Solution2
{
    class Program
    {
        static void Main()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            long sum1 = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse)).Sum();
            long sum2 = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse)).Sum();
            Console.WriteLine(sum1 - sum2);
            sum1 = new List<long>(Console.ReadLine().Split(' ').Select(long.Parse)).Sum();
            Console.WriteLine(sum2 - sum1);
        }
    }
}
