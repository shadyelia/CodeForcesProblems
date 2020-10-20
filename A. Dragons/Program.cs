using System;
using System.Collections.Generic;
using System.Linq;

namespace A._Dragons
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Split(' ');
            long myPower = Convert.ToInt64(data[0]);
            long n = Convert.ToInt64(data[1]);
            List<Dragon> dargons = new List<Dragon>();
            long maxPower = 0, totalBounes = myPower;

            while (n-- > 0)
            {
                data = Console.ReadLine().Split(' ');
                long dargonPower = Convert.ToInt64(data[0]);
                dargons.Add(new Dragon { DargonPower = dargonPower, DargonBouns = Convert.ToInt64(data[1]) });
                if (maxPower < dargonPower) maxPower = dargonPower;
                totalBounes += Convert.ToInt64(data[1]);
            }

            if (totalBounes < maxPower)
            {
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            dargons = dargons.OrderBy(dargon => dargon.DargonPower)
                        .ThenBy(dargon => dargon.DargonBouns).ToList();

            for (int i = 0; i < dargons.Count; i++)
            {
                if (myPower <= dargons[i].DargonPower)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else myPower += dargons[i].DargonBouns;
            }
            Console.WriteLine("YES");
        }
    }

    class Dragon
    {
        public long DargonPower { get; set; }
        public long DargonBouns { get; set; }
    }
}
