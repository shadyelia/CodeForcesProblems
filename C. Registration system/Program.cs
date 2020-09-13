using System;
using System.Collections;

namespace C._Registration_system
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Hashtable users = new Hashtable();

            while (n-- > 0)
            {
                string name = Console.ReadLine();
                if (users.Contains(name))
                {
                    int number = Convert.ToInt32(users[name]) + 1;
                    users[name] = number;
                    Console.WriteLine(name + number.ToString());
                }
                else
                {
                    users.Add(name, 0);
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
