using System;
using System.Data;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primarySum += matrix[row, row];
                secondarySum += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
