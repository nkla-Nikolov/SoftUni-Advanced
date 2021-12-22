using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadFromConsole();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int[,] smallMatrix = new int[2, 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = ReadFromConsole();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int result = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (result > maxSum)
                    {
                        maxSum = result;
                        smallMatrix[0, 0] = matrix[i, j];
                        smallMatrix[0, 1] = matrix[i, j + 1];
                        smallMatrix[1, 0] = matrix[i + 1, j];
                        smallMatrix[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{smallMatrix[i, j]}" + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }

        public static int[] ReadFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
