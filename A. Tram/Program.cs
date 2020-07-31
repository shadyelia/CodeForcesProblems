using System;

namespace A._Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumberOfPassengers = 0, maxNumberOfPassengers = 0;

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                totalNumberOfPassengers -= Convert.ToInt32(data[0]);
                totalNumberOfPassengers += Convert.ToInt32(data[1]);

                if (totalNumberOfPassengers > maxNumberOfPassengers)
                    maxNumberOfPassengers = totalNumberOfPassengers;
            }

            Console.WriteLine(maxNumberOfPassengers);
        }
    }
}
