using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadArrayFromConsole();

            int[,] matrix = new int[size[0], size[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] columnElements = ReadArrayFromConsole();

                for (int cols = 0; cols < columnElements.Length; cols++)
                {
                    matrix[rows, cols] = columnElements[cols];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, col];
                }

                Console.WriteLine(sum);
            }
        }

        public static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
