using System;
using System.Collections.Generic;
using System.Linq;

namespace B._Taxi
{
    class Program
    {
        static void Main2()
        {
            Console.ReadLine();
            List<uint> numbers = Console.ReadLine().Split(' ').Select(uint.Parse).ToList();
            uint counter = 0;

            numbers = numbers.OrderByDescending(i => i).ToList();

            while(numbers.Count>0)   
            {
                int length = numbers.Count;

                if (length > 0 && numbers.First() == 4)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;
                }

                if (length > 0 && numbers.First() == 3)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;
                    if (length > 0 && numbers.Last() == 1)
                    {
                        numbers.RemoveAt(numbers.Count - 1);
                        length--;
                    }
                }

                if (length > 0 && numbers.First() == 2)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;
                    if (length > 0 && numbers.First() == 2)
                    {
                        numbers.RemoveAt(0);
                        length--;
                    }
                    else
                    {          
                        if (length > 0 && numbers.Last() == 1)
                        {
                            numbers.RemoveAt(numbers.Count - 1);
                            length--;
                        }
                        if (length > 0 && numbers.Last() == 1)
                        {
                            numbers.RemoveAt(numbers.Count - 1);
                            length--;
                        }
                    }
                }

                if (length > 0 && numbers.First() == 1)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;

                    if (length > 0 && numbers.Last()==1)
                    {
                        numbers.RemoveAt(numbers.Count - 1);
                        length--;
                    }
                    if (length > 0 && numbers.Last() == 1)
                    {
                        numbers.RemoveAt(numbers.Count - 1);
                        length--;
                    }
                    if (length > 0 && numbers.Last() == 1)
                    {
                        numbers.RemoveAt(numbers.Count - 1);
                        length--;
                    }

                }               
               
            }

            Console.WriteLine(counter);
        }

    }
}