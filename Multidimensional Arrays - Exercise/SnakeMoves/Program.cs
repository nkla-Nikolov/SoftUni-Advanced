using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sizes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        
        Queue<char> queue = new Queue<char>(Console.ReadLine().ToCharArray());
        char[,] matrix = new char[sizes[0], sizes[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char element = queue.Peek();
                    matrix[row, col] = element;
                    queue.Enqueue(queue.Dequeue());
                }
            }
            else
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    char element = queue.Peek();
                    matrix[row, col] = element;
                    queue.Enqueue(queue.Dequeue());
                }
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }

    }
}