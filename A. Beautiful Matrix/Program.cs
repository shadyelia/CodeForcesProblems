using System;
using System.Linq;

namespace A._Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rows = 5, columns = 5;
            int[,] matrix = new int[rows, columns];
            int xIndex = 0, yIndex = 0;
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int[] numbers = line.Select(int.Parse).ToArray();


                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = numbers[j];
                    if (numbers[j] == 1)
                    {
                        xIndex = i;
                        yIndex = j;
                    }
                }


            }

            int numberOfMoves = Math.Abs(2 - xIndex) + Math.Abs(2 - yIndex);

            Console.WriteLine(numberOfMoves);


        }
    }
}
