using System;
using System.Linq;

namespace _2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int count = 0;
            bool isValid = false;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (AreEqual(matrix, row, col))
                    {
                        count++;
                        isValid = true;
                    }
                }
            }

            if (isValid == false)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(count);
            }
        }

        private static bool AreEqual(string[,] matrix, int row, int col)
        {
            return matrix[row, col] == matrix[row, col + 1] &&
                                    matrix[row, col] == matrix[row + 1, col] &&
                                    matrix[row, col] == matrix[row + 1, col + 1];
        }
    }
}

