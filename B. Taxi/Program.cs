using System;
using System.Collections.Generic;
using System.Linq;

namespace B._Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<string> data = Console.ReadLine().Split(' ').ToList();
            List<int> numbers = data.Select(int.Parse).ToList();
            long counter = 0;

            numbers = numbers.OrderByDescending(i => i).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 3)
                {
                    if (numbers[numbers.Count-1] == 1)
                    {
                        numbers.RemoveAt(numbers.Count-1);
                    }
                }

                else if (numbers[i] == 2)
                {
                    int index = -1;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == 2 && j != i)
                        {
                            index = j; break;
                        }
                    }
                    if (index != -1)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        int index1 = -1;
                        int index2 = -1;
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (numbers[j] == 1 && index1 == -1)
                            {
                                index1 = j;
                            }
                            else if (numbers[j] == 1 && index2 == -1)
                            {
                                index2 = j;
                                break;
                            }
                        }

                        if (index1 != -1)
                        {
                            numbers.RemoveAt(index1);
                        }
                        if (index2 != -1)
                        {
                            numbers.RemoveAt(index2 - 1);
                        }
                    }
                }

                else if (numbers[i] == 1)
                {
                    int index1 = -1;
                    int index2 = -1;
                    int index3 = -1;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == 1 && index1 == -1 && j != i)
                        {
                            index1 = j;
                        }
                        else if (numbers[j] == 1 && index2 == -1 && j != i)
                        {
                            index2 = j;
                        }
                        else if (numbers[j] == 1 && index3 == -1 && j != i)
                        {
                            index3 = j;
                            break;
                        }
                    }
                    if (index1 != -1)
                    {
                        numbers.RemoveAt(index1);
                    }
                    if (index2 != -1)
                    {
                        numbers.RemoveAt(index2 - 1);
                    }
                    if (index3 != -1)
                    {
                        numbers.RemoveAt(index3 - 2);
                    }

                }

                numbers.RemoveAt(i);
                counter++;
                i--;
            }

            Console.WriteLine(counter);
        }

    }
}
