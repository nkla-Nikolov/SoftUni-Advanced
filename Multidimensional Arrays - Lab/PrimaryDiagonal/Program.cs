using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum = 0;

            for (int rows = 0; rows < n; rows++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < columnElements.Length; cols++)
                {
                    matrix[rows, cols] = columnElements[cols];
                }
            }

            for (int rows = 0; rows < n; rows++)
            {
                
                for (int cols = rows; cols < n; cols++)
                {
                    sum += matrix[rows, cols];
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
