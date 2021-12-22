using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char[] separator = new char[2] {' ', ','};

            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(separator));

            while (queue.Count != 0)
            {
                int row = int.Parse(queue.Dequeue());
                int col = int.Parse(queue.Dequeue());

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[row, col] == matrix[i, j])
                        {
                            if (row - 1 >= 0)
                            {
                                matrix[i - 1, j] -= matrix[i, j];
                            } 
                            if (row + 1 < matrix.GetLength(0))
                            {
                                matrix[i + 1, j] -= matrix[i, j];
                            }
                            if (col - 1 >= 0)
                            {
                                matrix[i, j - 1] -= matrix[i, j];
                            }
                            if (col + 1 < matrix.GetLength(1))
                            {
                                matrix[i, j + 1] -= matrix[i, j];
                            }
                            if (row - 1 >= 0 && col - 1 >= 0)
                            {
                                matrix[i - 1, j - 1] -= matrix[i, j];
                            }
                            if (row - 1 >= 0 && row)
                            {
                                
                            }

                            matrix[i, j] = 0;
                        }
                        
                    }
                }
                
            }
        }

    }
}
