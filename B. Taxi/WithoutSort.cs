using System;
using System.Collections.Generic;
using System.Linq;

namespace B._Taxi
{
    class WithoutSort
    {
        static void Main()
        {
            Console.ReadLine();
            List<uint> numbers = Console.ReadLine().Split(' ').Select(uint.Parse).ToList();
            uint counter = 0;

            if (numbers.All(n => n == 3 || n == 4)) counter = (uint)numbers.Count;
            else
             while (numbers.Count > 0)
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

                    bool isOneFound = true;
                    if (length > 0 && isOneFound)
                    {
                        int index = -1;
                        for (int j = 0; j < length; j++)
                        {
                            if (numbers[j] == 1)
                            {
                                index = j;
                                break;
                            }
                        }
                        if (index != -1)
                        {
                            numbers.RemoveAt(index);
                            length--;
                        }
                        else
                        {
                            isOneFound = false;
                        }

                    }
                }

                if (length > 0 && numbers.First() == 2)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;
                    if (length > 0)
                    {
                        int index = -1;
                        for (int j = 0; j < length; j++)
                        {
                            if (numbers[j] == 2)
                            {
                                index = j;
                                break;
                            }
                        }
                        if (index != -1)
                        {
                            numbers.RemoveAt(index);
                            length--;
                        }
                        else
                        {
                            int index1 = -1;
                            int index2 = -1;
                            for (int j = 0; j < length; j++)
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
                                length--;
                            }
                            if (index2 != -1)
                            {
                                numbers.RemoveAt(index2 - 1);
                                length--;
                            }
                        }

                    }

                }

                if (length > 0 && numbers.First() == 1)
                {
                    numbers.RemoveAt(0);
                    counter++;
                    length--;

                    if (length > 0)
                    {
                        int indexNumber3 = -1;
                        int indexNumber2 = -1;

                        int indexFirstOne = -1;
                        int indexSecondOne = -1;
                        int indexThridOne = -1;
                        for (int j = 0; j < length; j++)
                        {
                            if (numbers[j] == 3)
                            {
                                indexNumber3 = j;
                                break;
                            }
                            if (numbers[j] == 2)
                            {
                                indexNumber2 = j;
                            }

                            if (numbers[j] == 1 && indexFirstOne == -1)
                            {
                                indexFirstOne = j;
                            }
                            else if (numbers[j] == 1 && indexSecondOne == -1)
                            {
                                indexSecondOne = j;
                            }
                            else if (numbers[j] == 1 && indexThridOne == -1)
                            {
                                indexThridOne = j;
                                break;
                            }

                            if (indexNumber2 != -1 && indexFirstOne != -1) break;

                        }

                        //1 + 3
                        if (indexNumber3 != -1)
                        {
                            numbers.RemoveAt(indexNumber3);
                            length--;
                            continue;
                        }

                        //1 + 2 + 1
                        if (indexNumber2 != -1 && indexFirstOne != -1)
                        {
                            if (indexNumber2 > indexFirstOne)
                            {
                                numbers.RemoveAt(indexNumber2);
                                numbers.RemoveAt(indexFirstOne);
                            }
                            else
                            {
                                numbers.RemoveAt(indexFirstOne);
                                numbers.RemoveAt(indexNumber2);
                            }

                            length -= 2;

                            continue;
                        }

                        // 1 + 1 + 1 + 1
                        if (indexFirstOne != -1 && indexSecondOne != -1 && indexThridOne != -1)
                        {
                            numbers.RemoveAt(indexFirstOne);
                            numbers.RemoveAt(indexSecondOne - 1);
                            numbers.RemoveAt(indexThridOne - 2);

                            length -= 3;
                            continue;
                        }

                        // 1 + 1 + 1
                        if (indexFirstOne != -1 && indexSecondOne != -1)
                        {
                            numbers.RemoveAt(indexFirstOne);
                            numbers.RemoveAt(indexSecondOne - 1);

                            length -= 2;
                            continue;
                        }

                        // 1 + 2
                        if (indexNumber2 != -1)
                        {
                            numbers.RemoveAt(indexNumber2);
                            length--;
                            continue;
                        }

                        // 1 + 1
                        if (indexFirstOne != -1)
                        {
                            numbers.RemoveAt(indexFirstOne);
                            length--;
                            continue;
                        }
                    }
                }

            }

            Console.WriteLine(counter);
        }
    }
}
